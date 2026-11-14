using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Patient
{
    public partial class RegisterSuccess : UserControl
    {
        public RegisterSuccess(string fullName)
        {
            InitializeComponent();
            lblFullName.Text = fullName;
        }
        public event EventHandler? LoginClicked;

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            LoginClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
