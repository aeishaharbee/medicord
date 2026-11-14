using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Patient
{
    public partial class StartScreen : UserControl
    {
        public StartScreen()
        {
            InitializeComponent();
            Theme.Link(btnDesktop, Color.Transparent);
        }
        public event EventHandler? LoginClicked;
        public event EventHandler? CreateAccountClicked;
        public event EventHandler? DesktopClicked;

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            LoginClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnToRegister_Click(object sender, EventArgs e)
        {
            CreateAccountClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnDesktop_Click(object sender, EventArgs e)
        {
            DesktopClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
