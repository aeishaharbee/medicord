using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Desktop
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
            Theme.Grid(dgv); Theme.EmptyState(dgv, "No records yet");
            Theme.AvatarColumn(dgv, "Patient", "PatientID");
            Theme.AvatarColumn(dgv, "Doctor", "WorkerID");
            Theme.Field(txtSearch);
            Theme.PrimaryBtn(btnUpload); Theme.Outline(btnOpen);
            Theme.OutlineWarning(btnEdit); Theme.OutlineDanger(btnDelete);

            chips = new[] { btnAll, btnVisit, btnLab, btnRx, btnOther };
            foreach (var c in chips) Theme.Tab(c, c == btnAll);

            btnAll.Click += (_, _) => SetCategory(null, btnAll);
            btnVisit.Click += (_, _) => SetCategory("Visit", btnVisit);
            btnLab.Click += (_, _) => SetCategory("Lab result", btnLab);
            btnRx.Click += (_, _) => SetCategory("Prescription", btnRx);
            btnOther.Click += (_, _) => SetCategory("Other", btnOther);

            txtSearch.TextChanged += (_, _) => ApplyFilter();
            dgv.SelectionChanged += (_, _) => UpdateButtons();
            dgv.CellDoubleClick += (_, e) => { if (e.RowIndex >= 0) btnOpen.PerformClick(); };
            LoadData();
        }

        private void SetCategory(string? cat, SiticoneButton active)
        {
            category = cat;
            foreach (var c in chips) Theme.Tab(c, c == active);
            ApplyFilter();
        }

        private void LoadData()
        {

            try { all = RecordService.GetForStaff(null); }
            catch (SqlException ex) { Msg.Show("Could not load records:\n" + ex.Message); return; }
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (all.Columns.Count == 0) return;  

            var parts = new List<string>();
            if (category != null) parts.Add($"[Category] = '{category}'");
            string q = txtSearch.Text.Trim();
            if (q != "")
            {
                string e = TableFilter.EscapeLike(q);
                parts.Add($"([Patient] LIKE '%{e}%' OR [Title] LIKE '%{e}%' OR [Doctor] LIKE '%{e}%')");
            }

            var view = all.DefaultView;
            view.RowFilter = string.Join(" AND ", parts);

            lblCount.Text = parts.Count == 0 ? $"{all.Rows.Count} medical records"
                                             : $"{view.Count} of {all.Rows.Count} medical records";
            Theme.SetEmptyText(dgv, parts.Count > 0 ? "No records match your search or filter" : "No records yet");
            Theme.Fill(dgv, view.ToTable(), "RecordID", "PatientID", "WorkerID", "UploadedBy");
            Theme.Weights(dgv,
                ("Date", 60), ("Patient", 130), ("Title", 120),
                ("Category", 80), ("Doctor", 130), ("File", 60));
            UpdateButtons();
        }

        private int SelectedId() => Convert.ToInt32(dgv.CurrentRow!.Cells["RecordID"].Value);

        private bool CanModify()
        {
            if (dgv.CurrentRow == null) return false;
            if (Session.Role == "FacilityAdmin") return true;                       //admins: any record of their facility
            var by = dgv.CurrentRow.Cells["UploadedBy"].Value;
            return by != DBNull.Value && Convert.ToInt32(by) == Session.UserID;      //doctors: only their own uploads
        }

        private void UpdateButtons()
        {
            var row = dgv.CurrentRow;
            btnOpen.Enabled = row != null && row.Cells["File"].Value?.ToString() != "No file";
            btnEdit.Enabled = btnDelete.Enabled = CanModify();
        }

        private void SelectRecord(int id)
        {
            foreach (DataGridViewRow r in dgv.Rows)
                if (Convert.ToInt32(r.Cells["RecordID"].Value) == id)
                { dgv.CurrentCell = r.Cells.Cast<DataGridViewCell>().First(c => c.Visible); return; }
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                using var f = new RecordEditForm();
                if (f.ShowDialog(FindForm()) != DialogResult.OK) return;
            }
            catch (SqlException ex) { Msg.Show("Could not open the upload form:\n" + ex.Message); return; }
            LoadData();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            int id = SelectedId();
            string title = dgv.CurrentRow.Cells["Title"].Value?.ToString() ?? "Record";
            try
            {
                var f = RecordService.GetFileForStaff(id);
                if (f == null) { Msg.Show("There is no PDF attached to this record."); return; }
                PdfHelper.Show(FindForm()!, title, f.Value.Data, f.Value.Name);
            }
            catch (SqlException ex) { Msg.Show("Could not open the record:\n" + ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!CanModify()) return;
            int id = SelectedId();
            try
            {
                var row = RecordService.GetOne(id);
                if (row == null) { Msg.Show("This record is no longer available."); LoadData(); return; }
                using var f = new RecordEditForm(row);
                if (f.ShowDialog(FindForm()) != DialogResult.OK) return;
            }
            catch (SqlException ex) { Msg.Show("Could not edit the record:\n" + ex.Message); return; }
            LoadData(); SelectRecord(id);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!CanModify()) return;
            if (!Msg.Confirm("Delete this record? The patient will no longer see it.")) return;
            try
            {
                if (!RecordService.Delete(SelectedId())) Msg.Show("Could not delete: you can only delete records you uploaded.");
            }
            catch (SqlException ex) { Msg.Show("Could not delete the record:\n" + ex.Message); return; }
            LoadData();
        }
    }
}
