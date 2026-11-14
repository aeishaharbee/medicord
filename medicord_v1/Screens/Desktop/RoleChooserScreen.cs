using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens
{
    public partial class RoleChooserScreen : UserControl
    {
        public event EventHandler? FacilityChosen, WorkerChosen, BackClicked;

        public RoleChooserScreen()
        {
            InitializeComponent();
            Theme.Center(pnlForm, this);
        }

        private void btnFacility_Click(object sender, EventArgs e)
        {
            FacilityChosen?.Invoke(this, EventArgs.Empty);
        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            WorkerChosen?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
