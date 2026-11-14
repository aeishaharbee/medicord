namespace medicord_v1.Screens.Worker
{
    public partial class AssignWorkerForm : Form
    {
        public int SelectedWorkerId { get; private set; }
        private readonly List<int> ids = new();

        public AssignWorkerForm(string patient, DateTime date, TimeSpan time, int used, int max,
                                int? currentWorkerId = null, string currentDoctor = "")
        {
            InitializeComponent();
            bool reassign = currentWorkerId != null;
            BackColor = Theme.Page;
            Text = reassign ? "Reassign doctor" : "Approve appointment";
            Theme.Drop(ddWorker); Theme.PrimaryBtn(btnConfirm); Theme.Link(btnCancel, Theme.Page);
            if (reassign) btnConfirm.Text = "Reassign";

            lblInfo.Text = reassign
                ? $"{patient}\n{date:dddd, d MMM yyyy} at {time.ToString(@"hh\:mm")}\nCurrent doctor: {currentDoctor}"
                : $"{patient}\n{date:dddd, d MMM yyyy} at {time.ToString(@"hh\:mm")}\nSlots taken at this time: {used} of {max}";

            foreach (DataRow r in PortalService.GetAvailableWorkers(date, time).Rows)
            {
                int id = Convert.ToInt32(r["WorkerID"]);
                if (id == currentWorkerId) continue;                 
                ids.Add(id);
                ddWorker.Items.Add(r["Display"].ToString() ?? "");
            }

            if (ids.Count == 0)
            {
                lblNone.Text = reassign
                    ? "No other health worker is available at this time. Check their working days under Health workers."
                    : "No health worker is available at this time. Check their working days under Health workers.";
                lblNone.Visible = true; ddWorker.Enabled = false; btnConfirm.Enabled = false;
            }
            else ddWorker.PlaceholderText = reassign ? "Choose a new doctor" : "Assign a doctor";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ddWorker.SelectedIndex < 0) { Msg.Show("Choose a doctor to assign."); return; }
            SelectedWorkerId = ids[ddWorker.SelectedIndex];
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
    }
}