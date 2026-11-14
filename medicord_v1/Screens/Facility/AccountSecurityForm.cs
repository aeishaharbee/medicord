using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static medicord_v1.Services.ProfileService;

namespace medicord_v1.Screens.Facility
{
    public partial class AccountSecurityForm : Form
    {
        public AccountSecurityForm()
        {
            InitializeComponent();
            BackColor = Theme.Page;
            foreach (var t in new[] { txtEmail, txtNew, txtConfirm, txtCurrent }) Theme.Field(t);
            foreach (var t in new[] { txtNew, txtConfirm, txtCurrent })
            {
                t.UseSystemPasswordChar = true;
                Theme.AddEye(t);
            }
            Theme.PrimaryBtn(btnSave); Theme.Link(btnCancel, Theme.Page);

            try { txtEmail.Text = ProfileService.GetEmail(); }
            catch (SqlException ex) { Msg.Show("Could not load your account:\n" + ex.Message); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim().ToLower();
            string? newPw = txtNew.Text == "" ? null : txtNew.Text;

            if (!Validators.IsEmail(email)) { Msg.Show("Enter a valid email address."); return; }
            if (newPw != null)
            {
                if (newPw.Length < 8) { Msg.Show("The new password must be at least 8 characters."); return; }
                if (newPw != txtConfirm.Text) { Msg.Show("The new passwords do not match."); return; }
            }
            if (txtCurrent.Text == "") { Msg.Show("Enter your current password to confirm."); return; }

            AccountResult result;
            try { result = ProfileService.UpdateAccount(txtCurrent.Text, email, newPw); }
            catch (SqlException ex) { Msg.Show("Could not save:\n" + ex.Message); return; }

            switch (result)
            {
                case AccountResult.WrongPassword: Msg.Show("Your current password is incorrect."); return;
                case AccountResult.EmailTaken: Msg.Show("That email is already used by another account."); return;
            }
            Msg.Show("Your sign-in details were updated.");
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
    }
}
