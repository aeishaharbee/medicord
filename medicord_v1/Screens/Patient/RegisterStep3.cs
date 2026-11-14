using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Patient
{
    public partial class RegisterStep3 : UserControl
    {
        private readonly PatientRegData data;
        public event EventHandler? BackClicked;
        public event EventHandler? RegisterSucceeded;

        public RegisterStep3(PatientRegData data)
        {
            InitializeComponent();
            Theme.AddEye(txtPassword);
            Theme.AddEye(txtConfirmPassword);
            Theme.Field(txtEmail); Theme.Field(txtPassword); Theme.Field(txtConfirmPassword);
            this.data = data;
        }

        private void btnToRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim().ToLower();

            if (!Validators.IsEmail(email))
            { Msg.Show("Enter a valid email address."); return; }
            if (txtPassword.Text.Length < 8)
            { Msg.Show("Password must be at least 8 characters."); return; }
            if (txtPassword.Text != txtConfirmPassword.Text)
            { Msg.Show("Passwords do not match."); return; }

            try
            {
                if (RegistrationService.EmailExists(email))
                { Msg.Show("This email is already registered."); return; }

                data.Email = email;
                data.Password = txtPassword.Text;
                RegistrationService.RegisterPatient(data);
                data.Password = "";
            }
            catch (SqlException ex)
            {
                Msg.Show("Could not register:\n" + ex.Message);
                return;
            }

            RegisterSucceeded?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
