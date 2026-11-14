using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Patient
{
    public partial class RecordsScreen : UserControl
    {
        private DataTable all = new();
        private string? category;
        private SiticoneButton[] chips = null!;

        public RecordsScreen()
        {
            InitializeComponent();
            BackColor = Theme.Page;
            Theme.Field(txtSearch);

            chips = new[] { btnAll, btnVisit, btnLab, btnRx };
            btnAll.Click += (_, _) => SetCategory(null, btnAll);
            btnVisit.Click += (_, _) => SetCategory("Visit", btnVisit);
            btnLab.Click += (_, _) => SetCategory("Lab result", btnLab);
            btnRx.Click += (_, _) => SetCategory("Prescription", btnRx);
            txtSearch.TextChanged += (_, _) => Render();
            flowList.Resize += (_, _) => { int w = CardWidth(); foreach (Control c in flowList.Controls) c.Width = w; };

            try { all = RecordService.GetForPatient(); }
            catch (SqlException ex) { Msg.Show("Could not load your records:\n" + ex.Message); }
            SetCategory(null, btnAll);
        }

        private void SetCategory(string? cat, SiticoneButton active)
        {
            category = cat;
            foreach (var c in chips) Theme.Tab(c, c == active);
            Render();
        }

        private int CardWidth() => Math.Max(200, flowList.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 4);

        private void Render()
        {
            var parts = new List<string>();
            if (category != null) parts.Add($"[Category] = '{category}'");
            string q = txtSearch.Text.Trim();
            if (q != "")
            {
                string e = TableFilter.EscapeLike(q);
                parts.Add($"([Title] LIKE '%{e}%' OR [FacilityName] LIKE '%{e}%' OR [Doctor] LIKE '%{e}%')");
            }
            var view = all.DefaultView;
            view.RowFilter = string.Join(" AND ", parts);

            flowList.SuspendLayout();
            foreach (Control c in flowList.Controls.Cast<Control>().ToList()) { flowList.Controls.Remove(c); c.Dispose(); }
            foreach (DataRowView rv in view) flowList.Controls.Add(MakeCard(rv.Row));
            flowList.ResumeLayout();

            lblEmpty.Text = all.Rows.Count == 0 ? "No records yet"
                          : q != "" ? $"No records match \"{q}\""
                          : category != null ? "No records in this category"
                          : "No records yet";
            lblEmpty.Visible = view.Count == 0;
            if (lblEmpty.Visible) lblEmpty.BringToFront();
        }

        private Control MakeCard(DataRow r)
        {
            int id = Convert.ToInt32(r["RecordID"]);
            string title = r["Title"].ToString() ?? "";
            bool hasFile = Convert.ToInt32(r["HasFile"]) == 1;

            var card = new SiticonePanel { Width = CardWidth(), Height = 92, Margin = new Padding(0, 0, 0, 12) };
            Theme.Card(card);

            Label L(string text, int top, float size, FontStyle style, Color color) => new Label
            {
                Text = text,
                Left = 16,
                Top = top,
                Width = card.Width - 60,
                Height = 22,
                AutoSize = false,
                AutoEllipsis = true,
                Font = new Font("Segoe UI", size, style),
                ForeColor = color,
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            string who = r["Doctor"].ToString() ?? "";
            var l1 = L(title, 12, 11f, FontStyle.Bold, Theme.Ink);
            var l2 = L($"{r["CheckupDate"]} · {r["FacilityName"]}", 38, 9.5f, FontStyle.Regular, Theme.Muted);
            var l3 = L(!hasFile ? "No PDF attached" : (who == "" ? r["Category"].ToString()! : $"{who} · {r["Category"]}"),
                       62, 9.5f, FontStyle.Regular, hasFile ? Theme.Primary : Theme.Muted);

            var chev = new Label
            {
                Text = hasFile ? "\uE76C" : "",
                Font = new Font("Segoe MDL2 Assets", 11f),
                ForeColor = Theme.Muted,
                BackColor = Color.White,
                AutoSize = false,
                Width = 28,
                Height = 28,
                Left = card.Width - 40,
                Top = (card.Height - 28) / 2,
                TextAlign = ContentAlignment.MiddleCenter,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            card.Controls.AddRange(new Control[] { l1, l2, l3, chev });

            if (hasFile)
                foreach (Control c in new Control[] { card, l1, l2, l3, chev })
                { c.Cursor = Cursors.Hand; c.Click += (_, _) => OpenRecord(id, title); }
            return card;
        }

        private void OpenRecord(int id, string title)
        {
            try
            {
                var f = RecordService.GetFileForPatient(id);
                if (f == null) { Msg.Show("There is no PDF attached to this record."); return; }
                PdfHelper.Show(FindForm()!, title, f.Value.Data, f.Value.Name);
            }
            catch (SqlException ex) { Msg.Show("Could not open the record:\n" + ex.Message); }
        }
    }
}
