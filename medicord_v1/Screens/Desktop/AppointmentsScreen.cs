using medicord_v1.Screens.Worker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static medicord_v1.Services.PortalService;

namespace medicord_v1.Screens.Desktop
{
    public partial class AppointmentsScreen : UserControl
    {
        private DateTime day = DateTime.Today;
        private string? filter;
        private SiticoneButton[] chips = null!;

        public AppointmentsScreen()
        {
            InitializeComponent();
            BackColor = Theme.Page;
            Theme.Grid(dgv); Theme.EmptyState(dgv, "No appointments on this day");
            Theme.AvatarColumn(dgv, "Patient", "PatientID");
            Theme.AvatarColumn(dgv, "Doctor", "WorkerID");
            Theme.Outline(btnPrev); Theme.Outline(btnNext);
            Theme.PrimaryBtn(btnApprove); Theme.Outline(btnComplete);
            Theme.OutlineDanger(btnDecline); Theme.OutlineDanger(btnCancel);
            Theme.OutlineWarning(btnReassign);

            if (Session.Role != "FacilityAdmin")
                btnApprove.Visible = btnDecline.Visible = btnCancel.Visible = btnReassign.Visible =false;

            chips = new[] { btnAll, btnPending, btnApproved, btnCompleted };
            btnAll.Click += (_, _) => SetFilter(null, btnAll);
            btnPending.Click += (_, _) => SetFilter("Pending", btnPending);
            btnApproved.Click += (_, _) => SetFilter("Approved", btnApproved);
            btnCompleted.Click += (_, _) => SetFilter("Completed", btnCompleted);
            dgv.SelectionChanged += (_, _) => UpdateButtons();

            SetFilter(null, btnAll);
        }

        private void SetFilter(string? status, SiticoneButton active)
        {
            filter = status;
            foreach (var c in chips) Theme.Tab(c, c == active);
            RefreshData();
        }

        private void RefreshData()
        {
            lblDate.Text = day.ToString("ddd, d MMM yyyy");


            try
            {
                Theme.SetEmptyText(dgv, filter == null ? "No appointments on this day" : $"No {filter.ToLower()} appointments on this day");
                Theme.Fill(dgv, PortalService.GetAppointments(day, filter), "AppointmentID", "PatientID", "WorkerID");
                Theme.Weights(dgv,
                    ("Time", 40), ("Patient", 130), ("Purpose", 100),
                    ("Symptoms", 80), ("Doctor", 130), ("Status", 80));
            }
            catch (SqlException ex) { Msg.Show("Could not load appointments:\n" + ex.Message); }
            UpdateButtons();
            AppEvents.RaiseDataChanged();
        }

        private string SelectedStatus() => dgv.CurrentRow?.Cells["Status"].Value?.ToString() ?? "";

        private void UpdateButtons()
        {
            string st = SelectedStatus();
            btnApprove.Enabled = st == "Pending";
            btnDecline.Enabled = st == "Pending";
            btnCancel.Enabled = st == "Approved";
            btnComplete.Enabled = st == "Approved";
            btnReassign.Enabled = st == "Approved" && day.Date >= DateTime.Today;
        }

        private void Change(string newStatus, params string[] allowedFrom)
        {
            if (dgv.CurrentRow == null) return;
            int id = Convert.ToInt32(dgv.CurrentRow.Cells["AppointmentID"].Value);
            try
            {
                if (!PortalService.SetStatus(id, newStatus, allowedFrom))
                    Msg.Show("This appointment was changed by someone else. The list has been refreshed.");
            }
            catch (SqlException ex) { Msg.Show("Could not update the appointment:\n" + ex.Message); return; }
            RefreshData();

            AppEvents.RaiseDataChanged();
        }

        private void btnPrev_Click(object sender, EventArgs e) { day = day.AddDays(-1); RefreshData(); }
        private void btnNext_Click(object sender, EventArgs e) { day = day.AddDays(1); RefreshData(); }

        private void btnApprove_Click(object s, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            int id = Convert.ToInt32(dgv.CurrentRow.Cells["AppointmentID"].Value);
            string patient = dgv.CurrentRow.Cells["Patient"].Value?.ToString() ?? "";
            var time = TimeSpan.ParseExact(dgv.CurrentRow.Cells["Time"].Value?.ToString() ?? "00:00", @"hh\:mm", null);

            try
            {
                string? closedMsg = PortalService.ClosedReason(day);
                if (closedMsg != null)
                {
                    Msg.Show(closedMsg + " Decline or cancel this request instead.");
                    return;
                }

                var (used, max) = PortalService.SlotUsage(day, time);
                if (used >= max)
                {
                    Msg.Show($"This time is full ({used} of {max} slots taken). " +
                                    "Cancel an approved appointment at this time, or raise the appointments per slot in Facility settings.");
                    return;
                }

                using var f = new AssignWorkerForm(patient, day, time, used, max);
                if (f.ShowDialog(FindForm()) != DialogResult.OK) return;

                switch (PortalService.ApproveAppointment(id, f.SelectedWorkerId))
                {
                    case ApproveResult.SlotFull:
                        Msg.Show("The last slot at this time was just taken. The list has been refreshed."); break;
                    case ApproveResult.DoctorUnavailable:
                        Msg.Show("That doctor is no longer available at this time. Please pick another."); break;
                    case ApproveResult.NotPending:
                        Msg.Show("This request was already handled by someone else."); break;
                    case ApproveResult.FacilityClosed:
                        Msg.Show("The facility is closed on this date."); break;
                }
            }
            catch (SqlException ex) { Msg.Show("Could not approve the appointment:\n" + ex.Message); return; }
            RefreshData();
        }
        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (Msg.Confirm("Mark this appointment as completed?"))
                Change("Completed", "Approved");
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (Msg.Confirm("Decline this appointment request?"))
                Change("Rejected", "Pending");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Msg.Confirm("Cancel this approved appointment?"))
                Change("Cancelled", "Approved");
        }

        private void btnReassign_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            int id = Convert.ToInt32(dgv.CurrentRow.Cells["AppointmentID"].Value);
            string patient = dgv.CurrentRow.Cells["Patient"].Value?.ToString() ?? "";
            string doctor = dgv.CurrentRow.Cells["Doctor"].Value?.ToString() ?? "";
            var wv = dgv.CurrentRow.Cells["WorkerID"].Value;
            int? currentId = wv == null || wv is DBNull ? null : Convert.ToInt32(wv);
            var time = TimeSpan.ParseExact(dgv.CurrentRow.Cells["Time"].Value?.ToString() ?? "00:00", @"hh\:mm", null);

            try
            {
                var (used, max) = PortalService.SlotUsage(day, time);
                using var f = new AssignWorkerForm(patient, day, time, used, max, currentId ?? 0, doctor);
                if (f.ShowDialog(FindForm()) != DialogResult.OK) return;

                switch (PortalService.ReassignWorker(id, f.SelectedWorkerId))
                {
                    case ReassignResult.DoctorUnavailable:
                        Msg.Show("That doctor is no longer available at this time. Please pick another."); break;
                    case ReassignResult.NotEditable:
                        Msg.Show("This appointment can no longer be changed. The list has been refreshed."); break;
                }
            }
            catch (SqlException ex) { Msg.Show("Could not reassign the doctor:\n" + ex.Message); return; }
            RefreshData();
        }
    }
}
