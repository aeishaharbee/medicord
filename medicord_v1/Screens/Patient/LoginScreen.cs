using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Patient
{
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {
            InitializeComponent();
            Theme.AddEye(txtPassword);
            Theme.Field(txtEmailAddress); Theme.Field(txtPassword); 
        }
        public event EventHandler? BackClicked;
        public event EventHandler? RegisterClicked;
        public event EventHandler? LoginSucceeded;

        private void btnToLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailAddress.Text) || txtPassword.Text == "")
            {
                Msg.Show("Please enter your email and password.");
                return;
            }

            bool ok;
            try { ok = AuthService.LoginPatient(txtEmailAddress.Text, txtPassword.Text); }
            catch (SqlException ex)
            {
                Msg.Show("Cannot reach the database:\n" + ex.Message);
                return;
            }

            if (!ok)
            {
                Msg.Show("Invalid email or password.");
                return;
            }
            LoginSucceeded?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
