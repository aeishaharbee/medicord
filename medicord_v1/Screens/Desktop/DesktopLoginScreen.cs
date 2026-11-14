using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens
{
    public partial class DesktopLoginScreen : UserControl
    {
        public event EventHandler? LoginSucceeded;
        public event EventHandler? CreateAccountClicked;
        public event EventHandler? MobileClicked;
        private string role = "FacilityAdmin";

        public DesktopLoginScreen()
        {
            InitializeComponent();
            Theme.Side(pnlLeft);
            Theme.Center(pnlForm, pnlRight);
            Theme.Field(txtEmail); Theme.Field(txtPassword); Theme.Link(btnMobile, Color.Transparent);
            txtPassword.UseSystemPasswordChar = true; Theme.AddEye(txtPassword);
            Theme.PrimaryBtn(btnLogin); Theme.Outline(btnCreate);
            SetRole("FacilityAdmin");

            btnTabFacility.Click += (_, _) => SetRole("FacilityAdmin");
            btnTabWorker.Click += (_, _) => SetRole("HealthWorker");
            txtPassword.EnterKeyPressed += (_, _) => btnLogin.PerformClick();
        }

        private void SetRole(string r)
        {
            role = r;
            Theme.Tab(btnTabFacility, r == "FacilityAdmin");
            Theme.Tab(btnTabWorker, r == "HealthWorker");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || txtPassword.Text == "")
            { Msg.Show("Please enter your email and password."); return; }

            bool ok;
            try { ok = AuthService.LoginStaff(txtEmail.Text, txtPassword.Text, role); }
            catch (SqlException ex) { Msg.Show("Cannot reach the database:\n" + ex.Message); return; }

            if (!ok)
            {
                Msg.Show("Invalid email or password for a " +
                    (role == "FacilityAdmin" ? "health facility" : "health worker") + " account.");
                return;
            }
            LoginSucceeded?.Invoke(this, EventArgs.Empty);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateAccountClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnMobile_Click(object sender, EventArgs e)
        {
            MobileClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
