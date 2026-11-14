using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Desktop
{
    public partial class RecordEditForm : Form
    {
        private readonly int? recordId;
        private readonly bool admin = Session.Role == "FacilityAdmin";
        private readonly List<int> patientIds = new();
        private readonly List<int> doctorIds = new();   
        private byte[]? newData;
        private string? newName;

        public RecordEditForm(DataRow? existing = null)
        {
            InitializeComponent();
            recordId = existing == null ? null : Convert.ToInt32(existing["RecordID"]);
            BackColor = Theme.Page;
            Text = recordId == null ? "Upload medical record" : "Edit medical record";
            lblHeading.Text = Text;

            Theme.Drop(ddPatient);
            Theme.Drop(ddCategory); ddCategory.Items.AddRange(Lists.RecordCategories); ddCategory.SelectedIndex = 0;
            Theme.Drop(ddDoctor);
            Theme.Field(txtTitle); 
            Theme.PrimaryBtn(btnSave); Theme.Outline(btnBrowse); Theme.Link(btnCancel, Theme.Page);
            Theme.DateField(dtpDate);

            dtpDate.DateFormat = DateFormat.Custom;
            dtpDate.CustomDateFormat = "dd MMM yyyy";
            dtpDate.MaxDate = DateTime.Today;   
            if (existing == null) dtpDate.Date = DateTime.Today;

            lblDoctor.Visible = ddDoctor.Visible = admin;       //doctors always attending doctor themselves
            lblFile.Text = "No file chosen · PDF only, max 10 MB";

            foreach (DataRow r in RecordService.GetPatientChoices().Rows)
            {
                patientIds.Add(Convert.ToInt32(r["PatientID"]));
                ddPatient.Items.Add(r["Display"].ToString() ?? "");
            }
            if (admin)
            {
                ddDoctor.Items.Add("(none)"); doctorIds.Add(0); ddDoctor.SelectedIndex = 0;
                foreach (DataRow r in RecordService.GetDoctorChoices().Rows)
                {
                    doctorIds.Add(Convert.ToInt32(r["WorkerID"]));
                    ddDoctor.Items.Add(r["FullName"].ToString() ?? "");
                }
            }
            if (existing != null) Fill(existing);
        }

        private void Fill(DataRow r)
        {
            int pid = Convert.ToInt32(r["PatientID"]);
            int i = patientIds.IndexOf(pid);
            if (i < 0) { patientIds.Add(pid); ddPatient.Items.Add(r["PatientName"].ToString() ?? ""); i = patientIds.Count - 1; }
            ddPatient.SelectedIndex = i; ddPatient.Enabled = false;

            txtTitle.Text = r["Title"].ToString();
            int c = ddCategory.Items.IndexOf(r["Category"].ToString() ?? "Other");
            ddCategory.SelectedIndex = c >= 0 ? c : ddCategory.Items.Count - 1;
            var d = Convert.ToDateTime(r["CheckupDate"]);
            dtpDate.Date = d > DateTime.Today ? DateTime.Today : d;
            txtNotes.Text = r["Notes"].ToString();

            if (admin && r["WorkerID"] != DBNull.Value)
            {
                int di = doctorIds.IndexOf(Convert.ToInt32(r["WorkerID"]));
                if (di >= 0) ddDoctor.SelectedIndex = di;
            }
            lblFile.Text = (r["FileName"] == DBNull.Value ? "No PDF attached" : r["FileName"].ToString())
                           + " · choose a new file only to replace it";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var pick = PdfHelper.Pick(this);
            if (pick == null) return;
            newData = pick.Value.Data; newName = pick.Value.Name;
            lblFile.Text = $"{newName} ({(newData.Length + 1023) / 1024} KB)";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim(), notes = txtNotes.Text.Trim();
            if (ddPatient.SelectedIndex < 0) { Msg.Show("Select a patient."); return; }
            if (dtpDate.Date == null) { Msg.Show("Choose the checkup date."); return; }
            if (title == "" || title.Length > 150) { Msg.Show("Enter a title (up to 150 characters)."); return; }
            if (notes.Length > 500) { Msg.Show("Notes can be up to 500 characters."); return; }
            if (recordId == null && newData == null) { Msg.Show("Choose the PDF file to upload."); return; }

            int? worker = admin ? (doctorIds[ddDoctor.SelectedIndex] == 0 ? null : doctorIds[ddDoctor.SelectedIndex])
                                : Session.UserID;
            var input = new RecordInput
            {
                RecordID = recordId,
                PatientID = patientIds[ddPatient.SelectedIndex],
                WorkerID = worker,
                Title = title,
                Category = ddCategory.SelectedItem ?? "Other",
                Notes = notes,
                CheckupDate = dtpDate.Date.Value.Date,
                FileData = newData,
                FileName = newName
            };

            try
            {
                bool ok = recordId == null ? RecordService.Add(input) : RecordService.Update(input);
                if (!ok) { Msg.Show("Could not save. You may not have access to this patient or record."); return; }
            }
            catch (SqlException ex) { Msg.Show("Could not save the record:\n" + ex.Message); return; }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
    }
}
