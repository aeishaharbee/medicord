using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Desktop
{
    public partial class PatientDetailsScreen : UserControl
    {
        public event EventHandler? BackClicked;
        private readonly int patientId;

        public PatientDetailsScreen(int patientId)
        {
            InitializeComponent();
            this.patientId = patientId;
            BackColor = Theme.Page;
            Theme.Grid(dgvAppts); Theme.Grid(dgvRecords);
            Theme.AvatarColumn(dgvAppts, "Doctor", "WorkerID"); Theme.AvatarColumn(dgvRecords, "Doctor", "WorkerID");
            Theme.EmptyState(dgvAppts, "No appointments yet"); Theme.EmptyState(dgvRecords, "No records yet");
            Theme.PrimaryBtn(btnOpenRecord);
            dgvRecords.SelectionChanged += (_, _) => UpdateButtons();
            dgvRecords.CellDoubleClick += (_, e) => { if (e.RowIndex >= 0) btnOpenRecord.PerformClick(); };
            Load += (_, _) => LoadAll();
        }

        private void LoadAll()
        {
            try
            {
                var p = PortalService.GetPatientDetails(patientId);
                if (p == null)
                {
                    Msg.Show("This patient is not available to you.");
                    BackClicked?.Invoke(this, EventArgs.Empty);
                    return;
                }

                string name = p["FullName"].ToString() ?? "";
                lblName.Text = name;
                lblSub.Text = $"{p["IdType"]} · {p["IdNumber"]}";
                lblIdType.Text = p["IdType"].ToString();
                lblIdNumber.Text = p["IdNumber"].ToString();
                lblNationality.Text = p["Nationality"].ToString();
                lblPhone.Text = p["Phone"].ToString();
                lblEmail.Text = p["Email"].ToString();
                lblAddress.Text = $"{p["City"]}, {p["State"]} {p["Postcode"]}";
                lblRegistered.Text = p["Registered"].ToString();

                picAvatar.Image?.Dispose();
                picAvatar.Image = ProfileService.LoadAvatar(110, patientId, name);

                Theme.Fill(dgvAppts, PortalService.GetPatientAppointments(patientId));
                Theme.Fill(dgvRecords, RecordService.GetForStaff(patientId),
                        "RecordID", "PatientID", "WorkerID", "UploadedBy", "Patient");
                Theme.Weights(dgvRecords, ("Date", 60), ("Title", 130), ("Category", 80), ("Doctor", 130), ("File", 60));
            }
            catch (SqlException ex) { Msg.Show("Could not load the patient:\n" + ex.Message); }
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            var row = dgvRecords.CurrentRow;
            btnOpenRecord.Enabled = row != null && row.Cells["File"].Value?.ToString() != "No file";
        }

        private void btnOpenRecord_Click(object sender, EventArgs e)
        {
            if (dgvRecords.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvRecords.CurrentRow.Cells["RecordID"].Value);
            string title = dgvRecords.CurrentRow.Cells["Title"].Value?.ToString() ?? "Record";
            try
            {
                var f = RecordService.GetFileForStaff(id);
                if (f == null) { Msg.Show("There is no PDF attached to this record."); return; }
                PdfHelper.Show(FindForm()!, title, f.Value.Data, f.Value.Name);
            }
            catch (SqlException ex) { Msg.Show("Could not open the record:\n" + ex.Message); }
        }

        private void btnBack_Click(object sender, EventArgs e) => BackClicked?.Invoke(this, EventArgs.Empty);
    }
}
