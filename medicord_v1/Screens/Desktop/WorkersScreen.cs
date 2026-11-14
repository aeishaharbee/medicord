using medicord_v1.Screens.Worker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Desktop
{
    public partial class WorkersScreen : UserControl
    {
        private DataTable all = new();
        public event EventHandler<int>? ViewDetailsClicked;

        public WorkersScreen()
        {
            InitializeComponent();
            BackColor = Theme.Page; Theme.Grid(dgv); Theme.EmptyState(dgv, "No health workers yet");
            Theme.AvatarColumn(dgv, "Name", "WorkerID");
            Theme.Field(txtSearch); Theme.Outline(btnViewDetails);

            dgv.CellDoubleClick += (_, e) => { if (e.RowIndex >= 0) btnViewDetails.PerformClick(); };
            txtSearch.TextChanged += (_, _) => ApplyFilter();
            LoadData();
        }

        private void LoadData()
        {
            try { all = PortalService.GetWorkers(); }
            catch (SqlException ex) { Msg.Show("Could not load health workers:\n" + ex.Message); return; }
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
                view.RowFilter = $"[Name] LIKE '%{e}%' OR [Role] LIKE '%{e}%' OR [Phone] LIKE '%{e}%' OR [Working days] LIKE '%{e}%'";
            }

            lblCount.Text = q == "" ? $"{all.Rows.Count} on staff" : $"{view.Count} of {all.Rows.Count} on staff";
            Theme.SetEmptyText(dgv, q == "" ? "No health workers yet" : "No health workers match your search");
            Theme.Fill(dgv, view.ToTable(), "WorkerID");
        }


        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null) return;
            ViewDetailsClicked?.Invoke(this, Convert.ToInt32(dgv.CurrentRow.Cells["WorkerID"].Value));
        }
    }
}
