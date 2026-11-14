namespace medicord_v1.Screens.Desktop
{
    public partial class DesktopDoneScreen : UserControl
    {
        public event EventHandler? LoginClicked;
        public DesktopDoneScreen(string? facilityCode = null)
        {
            InitializeComponent(); Theme.Center(pnlCard, this);
            Theme.PrimaryBtn(btnLogin);

            if (facilityCode != null)
            {
                lblSub.Text = "Your account has been created. Give this facility code to your health workers so they can register under your facility.";
                lblCode.Text = facilityCode;
                lblCode.Visible = true;
            }
            else
            {
                lblSub.Text = "Your account has been created. Log in to get started.";
                lblCode.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
