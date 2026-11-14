using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static medicord_v1.Services.AppointmentService;

namespace medicord_v1.Screens.Patient
{
    public partial class HomeScreen : UserControl
    {
        public event EventHandler? BookClicked;
        public event EventHandler? RecordsClicked;
        public event EventHandler? FacilitiesClicked;
        public event EventHandler? SwitchProfileClicked;

        public HomeScreen()
        {
            InitializeComponent();
            BuildChip();

            static string Greeting() => DateTime.Now.Hour < 12 ? "Good morning"
                          : DateTime.Now.Hour < 18 ? "Good afternoon" : "Good evening";
            lblGreeting.Text = $"{Greeting()},";
            lblGreetingName.Text = Session.IsDependentMode ? $"{(Session.PatientName.Split(' ')[0])}." : $"{Session.FirstName}.";

            LoadNext();
            LoadRecent();
        }

        private void BuildChip()
        {
            string label = Session.IsDependentMode
                ? (Session.PatientName.Split(' ', StringSplitOptions.RemoveEmptyEntries).FirstOrDefault() ?? "") : "You";
            var chip = new Button
            {
                Text = label + " ▾",
                Width = 130,
                Height = 34,
                Top = 22,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                Font = DepUi.F(9.5f, FontStyle.Bold),
                ForeColor = Theme.Primary,
                BackColor = Color.White,
                
                UseVisualStyleBackColor = false,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            chip.Left = Width - chip.Width - 24;
            chip.FlatAppearance.BorderColor = Color.White;
            DepUi.Round(chip, 17);
            chip.Click += (_, _) => SwitchProfileClicked?.Invoke(this, EventArgs.Empty);
            Controls.Add(chip);
            chip.BringToFront();

            chip.Image = ProfileService.LoadAvatar(24);
            chip.ImageAlign = ContentAlignment.MiddleLeft;
            chip.TextAlign = ContentAlignment.MiddleRight;
            chip.Padding = new Padding(6, 0, 8, 0);
        }

        private static Label MakeLabel(string text, int left, int top, int width, float size, FontStyle style, Color fore, Color back) => new Label
        {
            Text = text,
            Left = left,
            Top = top,
            Width = width,
            Height = (int)(size * 2.1f),
            AutoSize = false,
            AutoEllipsis = true,
            Font = new Font("Segoe UI", size, style),
            ForeColor = fore,
            BackColor = back
        };

        //next appt card
        private void LoadNext()
        {
            foreach (Control c in pnlNext.Controls.Cast<Control>().ToList()) { pnlNext.Controls.Remove(c); c.Dispose(); }
            pnlNext.SetCornerRadius(20);

            NextAppointment? n;
            try { n = AppointmentService.GetNextAppointment(Session.PatientID); }
            catch (SqlException) { ShowEmptyCard("Could not load appointments."); return; }

            if (n is null) { ShowEmptyCard("No upcoming appointments"); return; }

            pnlNext.FillColor = Theme.Primary;
            Color soft = Color.FromArgb(191, 224, 221);
            int w = pnlNext.Width - 40;
            string when = $"{n.Date:ddd, d MMM} · {DateTime.Today.Add(n.Time):h:mm tt}";
            string detail = n.Doctor == "" ? n.Purpose : $"{n.Purpose} · {n.Doctor}";

            pnlNext.Controls.Add(MakeLabel("Next appointment", 20, 14, w - 100, 9.5f, FontStyle.Regular, soft, Theme.Primary));
            pnlNext.Controls.Add(MakeLabel(when, 20, 38, w, 15f, FontStyle.Bold, Color.White, Theme.Primary));
            pnlNext.Controls.Add(MakeLabel(n.Facility, 20, 72, w, 10.5f, FontStyle.Regular, Color.White, Theme.Primary));
            pnlNext.Controls.Add(MakeLabel(detail, 20, 96, w, 9.5f, FontStyle.Regular, soft, Theme.Primary));

            var pill = Pill.ForStatus(n.Status, Theme.Primary);
            pill.Left = pnlNext.Width - 20 - pill.Width;
            pill.Top = 14;
            pnlNext.Controls.Add(pill);
        }

        private void ShowEmptyCard(string message)
        {
            pnlNext.FillColor = Color.White;
            pnlNext.SetCornerRadius(20);
            var l = MakeLabel(message, 0, 0, pnlNext.Width, 11f, FontStyle.Regular, Theme.Muted, Color.Transparent);
            l.Height = pnlNext.Height; l.TextAlign = ContentAlignment.MiddleCenter;
            pnlNext.Controls.Add(l);
        }

        //recent records
        private void LoadRecent()
        {
            foreach (Control c in flowRecords.Controls.Cast<Control>().ToList()) { flowRecords.Controls.Remove(c); c.Dispose(); }

            DataTable all;
            try { all = RecordService.GetForPatient(); }
            catch (SqlException)
            {
                lblNoRecords.Text = "Could not load records."; lblNoRecords.Visible = true;
                return;
            }

            var rows = all.Rows.Cast<DataRow>().Take(3).ToList();
            lblNoRecords.Text = "No records yet";
            lblNoRecords.Visible = rows.Count == 0;
            foreach (var r in rows) flowRecords.Controls.Add(MakeRecordRow(r));
        }

        private Control MakeRecordRow(DataRow r)
        {
            int id = Convert.ToInt32(r["RecordID"]);
            string title = r["Title"].ToString() ?? "";
            bool hasFile = Convert.ToInt32(r["HasFile"]) == 1;

            var row = new SiticonePanel { Width = flowRecords.ClientSize.Width, Height = 84, Margin = new Padding(0, 0, 0, 10) };
            Theme.Card(row);

            string sub = $"{r["CheckupDate"]} · {r["FacilityName"]}" + (hasFile ? "" : " · No PDF");
            var l1 = MakeLabel(title, 16, 16, row.Width - 60, 10.5f, FontStyle.Bold, Theme.Ink, Color.White);
            var l2 = MakeLabel(sub, 16, 44, row.Width - 60, 9f, FontStyle.Regular, Theme.Muted, Color.White);
            var chev = new Label
            {
                Text = hasFile ? "\uE76C" : "",
                Font = new Font("Segoe MDL2 Assets", 11f),
                ForeColor = Theme.Muted,
                BackColor = Color.White,
                AutoSize = false,
                Width = 28,
                Height = 28,
                Left = row.Width - 40,
                Top = (row.Height - 28) / 2,
                TextAlign = ContentAlignment.MiddleCenter
            };
            row.Controls.AddRange(new Control[] { l1, l2, chev });

            if (hasFile)
                foreach (Control c in new Control[] { row, l1, l2, chev })
                { c.Cursor = Cursors.Hand; c.Click += (_, _) => OpenRecord(id, title); }
            return row;
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

        private void btnBook_Click(object sender, EventArgs e) => BookClicked?.Invoke(this, EventArgs.Empty);

        private void btnRecords_Click(object sender, EventArgs e) => RecordsClicked?.Invoke(this, EventArgs.Empty);

        private void btnNearby_Click(object sender, EventArgs e) => FacilitiesClicked?.Invoke(this, EventArgs.Empty);
    }
}
