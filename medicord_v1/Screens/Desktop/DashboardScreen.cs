using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Desktop
{
    public partial class DashboardScreen : UserControl
    {
        public event EventHandler? ViewAllClicked;

        public DashboardScreen()
        {
            InitializeComponent();
            BackColor = Theme.Page;
            Theme.Grid(dgvToday); Theme.EmptyState(dgvToday, "No appointments today");

            Theme.AvatarColumn(dgvToday, "Patient", "PatientID");
            Theme.AvatarColumn(dgvToday, "Doctor", "WorkerID");
            Theme.Outline(btnViewAll);

            static string Greeting() => DateTime.Now.Hour < 12 ? "Good morning"
                          : DateTime.Now.Hour < 18 ? "Good afternoon" : "Good evening";

            lblDate.Text = DateTime.Now.ToString("dddd, d MMMM yyyy");         
            lblGreeting.Text = $"{Greeting()}, {Session.FullName}";

            kpiToday.Glyph = "\uE787"; kpiToday.Caption = "Today's appointments"; kpiToday.Trend = "+1 vs last Fri";
            kpiDone.Glyph = "\uE73E"; kpiDone.Caption = "Completed"; kpiDone.Trend = "1 left"; kpiDone.ChipBack = Color.FromArgb(220, 231, 245); kpiDone.ChipFore = Color.FromArgb(11, 45, 82);
            kpiStaff.Glyph = "\uE95E"; kpiStaff.Caption = "Health workers on duty"; kpiStaff.Trend = "1 on leave";
            kpiPend.Glyph = "\uE823"; kpiPend.Caption = "Pending requests"; kpiPend.Trend = "Needs action"; kpiPend.ChipBack = Theme.AmberBack; kpiPend.ChipFore = Theme.AmberFore;

            kpiStaff.Visible = Session.Role == "FacilityAdmin";
            kpiPend.Visible = Session.Role == "FacilityAdmin";
            RefreshData();
            LoadKpis();
        }

        private void LoadKpis()
        {
            KpiSet k;
            try { k = DashboardService.GetKpis(); }
            catch (Exception ex) { Msg.Error("Could not load the dashboard numbers:\n" + ex.Message); return; }

            kpiToday.Value = k.Today.ToString(); kpiToday.Trend = k.TodayTrend; kpiToday.TrendWarn = k.ClosedToday;
            kpiDone.Value = k.Completed.ToString(); kpiDone.Trend = k.CompletedTrend;
            kpiStaff.Value = k.OnDuty.ToString(); kpiStaff.Trend = k.DutyTrend; kpiStaff.TrendWarn = k.ClosedToday;
            kpiPend.Value = k.Pending.ToString(); kpiPend.Trend = k.PendingTrend; kpiPend.TrendWarn = k.Pending > 0;

        }

        private void RefreshData()
        {
            try
            {
                var c = PortalService.DashboardCounts();
                kpiToday.Value = c.Today.ToString();
                kpiDone.Value = c.Completed.ToString();
                kpiStaff.Value = c.OnDuty.ToString();
                kpiPend.Value = c.Pending.ToString();
                Theme.Fill(dgvToday, PortalService.GetAppointments(DateTime.Today, null), "AppointmentID", "PatientID", "WorkerID");
                Theme.Weights(dgvToday, ("Time", 40), ("Patient", 130), ("Purpose", 100), ("Symptoms", 80), ("Doctor", 130), ("Status", 80));

            }
            catch (SqlException ex) { Msg.Show("Could not load the dashboard:\n" + ex.Message); }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ViewAllClicked?.Invoke(this, EventArgs.Empty);
        }

    }
}
