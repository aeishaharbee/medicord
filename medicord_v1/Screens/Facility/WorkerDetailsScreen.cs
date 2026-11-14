using medicord_v1.Screens.Worker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Facility
{
    public partial class WorkerDetailsScreen : UserControl
    {
        public event EventHandler? BackClicked;
        private readonly int workerId;
        private string workerName = "";
        private SiticoneButton[] dayChips = null!;
        private static readonly string[] DayNames = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

        public WorkerDetailsScreen(int workerId)
        {
            InitializeComponent();
            this.workerId = workerId;
            BackColor = Theme.Page;
            Theme.Grid(dgvAppts); Theme.EmptyState(dgvAppts, "No appointments yet");
            Theme.AvatarColumn(dgvAppts, "Patient", "PatientID");
            Theme.Outline(btnEditDays);

            dayChips = new[] { btnMon, btnTue, btnWed, btnThu, btnFri, btnSat, btnSun };
            for (int i = 0; i < 7; i++)
            {
                Theme.DayReadOnly(dayChips[i], false);
            }

            Load += (_, _) => LoadAll();
        }

        private void LoadAll()
        {
            try
            {
                var w = PortalService.GetWorkerDetails(workerId);
                if (w == null)
                {
                    Msg.Show("This health worker is not in your facility.");
                    BackClicked?.Invoke(this, EventArgs.Empty);
                    return;
                }

                workerName = w["FullName"].ToString() ?? "";
                lblName.Text = workerName;
                lblRole.Text = w["MedicalRole"].ToString();
                lblIdType.Text = w["IdType"].ToString();
                lblIdNumber.Text = w["IdNumber"].ToString();
                lblNationality.Text = w["Nationality"].ToString();
                lblPhone.Text = w["Phone"].ToString();
                lblEmail.Text = w["Email"].ToString();
                lblJoined.Text = w["Joined"].ToString();

                picAvatar.Image?.Dispose();
                picAvatar.Image = ProfileService.LoadAvatar(110, workerId, workerName);

                var days = PortalService.GetWorkDays(workerId);
                for (int i = 0; i < 7; i++) Theme.DayReadOnly(dayChips[i], days.Contains(i));

                var c = PortalService.WorkerCounts(workerId);
                lblUpcoming.Text = c.Upcoming.ToString();
                lblCompleted.Text = c.Completed.ToString();
                Theme.Fill(dgvAppts, PortalService.GetWorkerAppointments(workerId));
            }
            catch (SqlException ex) { Msg.Show("Could not load the health worker:\n" + ex.Message); }
        }

        private void btnEditDays_Click(object sender, EventArgs e)
        {
            try
            {
                var current = PortalService.GetWorkDays(workerId);
                using var f = new WorkDaysForm(workerName, current);
                if (f.ShowDialog(FindForm()) != DialogResult.OK) return;

                var removed = current.Except(f.Days).OrderBy(d => d).ToList();
                if (removed.Count > 0)
                {
                    int affected = PortalService.CountWorkerAppointmentsOnDays(workerId, removed);
                    if (affected > 0 && !Msg.Confirm(
                            $"{affected} approved appointment(s) with {workerName} fall on {string.Join(", ", removed.Select(d => DayNames[d]))}, " +
                            "which would no longer be working days. They will not be cancelled automatically. Save the new working days anyway?"))
                        return;
                }

                PortalService.SetWorkDays(workerId, f.Days);
            }
            catch (Exception ex) { Msg.Show("Could not update working days:\n" + ex.Message); return; }
            LoadAll();
        }

        private void btnBack_Click(object sender, EventArgs e) => BackClicked?.Invoke(this, EventArgs.Empty);
    }
}
