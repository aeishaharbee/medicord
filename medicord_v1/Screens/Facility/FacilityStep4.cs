using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Facility
{
    public partial class FacilityStep4 : UserControl
    {
        private readonly FacilityRegData data;
        public event EventHandler? BackClicked;
        public event EventHandler<string>? RegisterSucceeded;
        public FacilityStep4(FacilityRegData data)
        {
            InitializeComponent();
            this.data = data;
            Theme.Side(pnlLeft); Theme.Center(pnlForm, pnlRight);
            Theme.Steps(4, lblStep1, lblStep2, lblStep3, lblStep4);
            foreach (var t in new[] { txtEmail, txtPassword, txtConfirm }) Theme.Field(t);
            Theme.PrimaryBtn(btnRegister); Theme.Link(btnBack, Color.Transparent); Theme.AddEye(txtPassword);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim().ToLower();
            if (!Validators.IsEmail(email)) { Msg.Show("Enter a valid email address."); return; }
            if (txtPassword.Text.Length < 8) { Msg.Show("Password must be at least 8 characters."); return; }
            if (txtPassword.Text != txtConfirm.Text) { Msg.Show("Passwords do not match."); return; }

            string code;
            try
            {
                if (RegistrationService.EmailExists(email)) { Msg.Show("This email is already registered."); return; }
                data.Email = email; data.Password = txtPassword.Text;
                code = FacilityService.RegisterFacility(data);
                data.Password = "";
            }
            catch (SqlException ex) { Msg.Show("Could not register:\n" + ex.Message); return; }

            RegisterSucceeded?.Invoke(this, code);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
