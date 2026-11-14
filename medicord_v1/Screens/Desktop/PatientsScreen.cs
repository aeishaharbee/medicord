using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Desktop
{
    public partial class PatientsScreen : UserControl
    {
        public event EventHandler<int>? ViewDetailsClicked;
        private DataTable all = new();

        public PatientsScreen()
        {
            InitializeComponent();
            BackColor = Theme.Page; Theme.Grid(dgv); Theme.EmptyState(dgv, "No patients yet");
            Theme.AvatarColumn(dgv, "Name", "PatientID");
            Theme.Field(txtSearch);
            Theme.Outline(btnViewDetails);
            txtSearch.TextChanged += (_, _) => ApplyFilter();
            LoadData();
        }

        private void LoadData()
        {
            try { all = PortalService.GetPatients(""); }
            catch (SqlException ex) { Msg.Show("Could not load patients:\n" + ex.Message); return; }
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string q = txtSearch.Text.Trim();
            var view = all.DefaultView;

            if (q == "") view.RowFilter = "";
            else
            {
                string e = TableFilter.EscapeLike(q);
                string digits = new string(q.Where(char.IsDigit).ToArray());
                string f = $"[Name] LIKE '%{e}%' OR [ID] LIKE '%{e}%' OR [Phone] LIKE '%{e}%'";
                if (digits.Length > 0) f += $" OR [ID] LIKE '%{digits}%' OR [Phone] LIKE '%{digits}%'";
                view.RowFilter = f;
            }

            lblCount.Text = q == "" ? $"{all.Rows.Count} patients" : $"{view.Count} of {all.Rows.Count} patients";
            Theme.SetEmptyText(dgv, q == "" ? "No patients yet" : "No patients match your search");
            Theme.Fill(dgv, view.ToTable(), "PatientID");

        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            ViewDetailsClicked?.Invoke(this, Convert.ToInt32(dgv.CurrentRow.Cells["PatientID"].Value));
        }

        private void btnViewDetails_Click_1(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            ViewDetailsClicked?.Invoke(this, Convert.ToInt32(dgv.CurrentRow.Cells["PatientID"].Value));
        }
    }
}
