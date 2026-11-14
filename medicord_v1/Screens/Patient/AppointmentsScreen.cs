using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Patient
{
    public partial class AppointmentsScreen : UserControl
    {
        public event EventHandler? BookClicked;
        private DataTable all = new();
        private bool showUpcoming = true;
        public AppointmentsScreen()
        {
            InitializeComponent();
            BackColor = Theme.Page;
            btnUpcoming.Click += (_, _) => SetTab(true);
            btnPast.Click += (_, _) => SetTab(false);
            LoadData();
            SetTab(true);
        }

        private void LoadData()
        {
            try { all = AppointmentService.GetMyAppointments(); }
            catch (SqlException ex) { Msg.Show("Could not load your appointments:\n" + ex.Message); }
        }

        private void SetTab(bool upcoming)
        {
            showUpcoming = upcoming;
            Theme.Tab(btnUpcoming, upcoming); Theme.Tab(btnPast, !upcoming);
            Render();
        }

        private static bool IsUpcoming(DataRow r)
        {
            string st = r["Status"].ToString() ?? "";
            return ((DateTime)r["ApptDate"]).Date >= DateTime.Today && (st == "Pending" || st == "Approved");
        }

        private int CardWidth() => Math.Max(200, flowList.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 4);

        private void Render()
        {
            IEnumerable<DataRow> rows = all.Rows.Cast<DataRow>().Where(r => IsUpcoming(r) == showUpcoming);
            rows = showUpcoming
                ? rows.OrderBy(r => (DateTime)r["ApptDate"]).ThenBy(r => (TimeSpan)r["ApptTime"])
                : rows.OrderByDescending(r => (DateTime)r["ApptDate"]).ThenByDescending(r => (TimeSpan)r["ApptTime"]);
            var list = rows.ToList();

            flowList.SuspendLayout();
            foreach (Control c in flowList.Controls.Cast<Control>().ToList()) { flowList.Controls.Remove(c); c.Dispose(); }
            foreach (var r in list) flowList.Controls.Add(MakeCard(r));
            flowList.ResumeLayout();

            lblEmpty.Text = showUpcoming ? "No upcoming appointments" : "No past appointments";
            lblEmpty.Visible = list.Count == 0;
        }

        private Control MakeCard(DataRow r)
        {
            int id = Convert.ToInt32(r["AppointmentID"]);
            var date = ((DateTime)r["ApptDate"]).Date;
            string timeText = DateTime.Today.Add((TimeSpan)r["ApptTime"]).ToString("h:mm tt");
            string status = r["Status"].ToString() ?? "";
            string doctor = r["Doctor"].ToString() ?? "";
            bool canCancel = date >= DateTime.Today && (status == "Pending" || status == "Approved");

            var card = new SiticonePanel { Width = CardWidth(), Height = 124, Margin = new Padding(0, 0, 0, 12) };
            Theme.Card(card);

            // date block on the left
            var block = new SiticonePanel { Left = 14, Top = 16, Width = 56, Height = 92, FillColor = Theme.Primary, ShowBorder=false };
            block.SetCornerRadius(12);
            Label B(string text, int top, float size, FontStyle st) => new Label
            {
                Text = text,
                Left = 0,
                Top = top,
                Width = 56,
                Height = (int)(size * 2.2f),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Font = new Font("Segoe UI", size, st)
            };
            block.Controls.AddRange(new Control[] { B(date.ToString("ddd"), 10, 9f, FontStyle.Bold),
                                            B(date.Day.ToString(), 28, 18f, FontStyle.Bold),
                                            B(date.ToString("MMM"), 66, 9f, FontStyle.Regular) });
            card.Controls.Add(block);

            int tx = 84, tw = card.Width - tx - 14;
            Label L(string text, int top, float size, FontStyle st, Color color) => new Label
            {
                Text = text,
                Left = tx,
                Top = top,
                Width = tw,
                Height = 22,
                AutoSize = false,
                AutoEllipsis = true,
                Font = new Font("Segoe UI", size, st),
                ForeColor = color,
                BackColor = Color.White
            };
            card.Controls.Add(L(r["FacilityName"].ToString() ?? "", 14, 11f, FontStyle.Bold, Theme.Ink));
            card.Controls.Add(L($"{timeText} · {r["Purpose"]}", 38, 9.5f, FontStyle.Regular, Theme.Muted));
            card.Controls.Add(L(doctor == "" ? "Doctor to be assigned" : doctor, 60, 9.5f, FontStyle.Regular, Theme.Muted));

            var pill = Pill.ForStatus(status, Color.White);
            pill.Left = tx;
            pill.Top = 88;
            card.Controls.Add(pill);

            if (canCancel)
            {
                var cancel = new SiticoneButton { Text = "Cancel", Width = 80, Height = 28, Left = card.Width - 94, Top = 86 };
                Theme.Link(cancel, Color.White);
                cancel.Click += (_, _) => CancelAppointment(id);
                card.Controls.Add(cancel);
            }
            return card;
        }

        private void CancelAppointment(int id)
        {
            if (!Msg.Confirm("Cancel this appointment?")) return;
            try
            {
                if (!AppointmentService.Cancel(id))
                    Msg.Show("This appointment can no longer be cancelled.");
            }
            catch (SqlException ex) { Msg.Show("Could not cancel:\n" + ex.Message); return; }
            LoadData();
            Render();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
