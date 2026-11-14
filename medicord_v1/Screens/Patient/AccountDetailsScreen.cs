using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static medicord_v1.Services.ProfileService;

namespace medicord_v1.Screens.Patient
{
    public partial class AccountDetailsScreen : UserControl
    {
        public event EventHandler? BackClicked, Saved;
        private string origName = "", origNationality = "", origIdType = "", origId = "", origEmail = "";
        public AccountDetailsScreen()
        {
            InitializeComponent();
            BackColor = Theme.Page;
            foreach (var t in new[] { txtFullName, txtIdNumber, txtEmail, txtNewPassword, txtConfirm, txtCurrent }) Theme.Field(t);
            foreach (var t in new[] { txtNewPassword, txtConfirm, txtCurrent }) t.UseSystemPasswordChar = true;
            Theme.Drop(ddIdType); ddIdType.Items.AddRange(Lists.IdTypes);
            Theme.Drop(ddNationality); ddNationality.Items.AddRange(Lists.Nationalities);
            Theme.PrimaryBtn(btnSave);
            Theme.AddEye(txtCurrent);

            try
            {
                var r = ProfileService.GetPatientProfile();
                origName = r["FullName"].ToString() ?? "";
                origNationality = r["Nationality"].ToString() ?? "";
                origIdType = r["IdType"].ToString() ?? "";
                origId = r["IdNumber"].ToString() ?? "";
                origEmail = Convert.ToString(r["Email"]) ?? "";
                txtFullName.Text = origName; txtIdNumber.Text = origId; txtEmail.Text = origEmail;
                int i = ddIdType.Items.IndexOf(origIdType);
                if (i >= 0) ddIdType.SelectedIndex = i;
                int j = ddNationality.Items.IndexOf(origNationality);
                if (j >= 0) ddNationality.SelectedIndex = j;
            }
            catch (SqlException ex) { Msg.Show("Could not load your details:\n" + ex.Message); }

            if (Session.IsDependentMode)
            {
                lblEmail.Visible = txtEmail.Visible = false;
                lblNewPassword.Visible = txtNewPassword.Visible = false;
                lblConfirmPassword.Visible = txtConfirm.Visible = false;

                lblCurrentPassword.Text = "Guardian's password";
                
                lblCurrentPassword.Top -= 276;
                txtCurrent.Top -= 276;
                btnSave.Top -= 276;
                stcSeparator.Top -= 276;
            } else
            {
                Theme.AddEye(txtNewPassword);
                Theme.AddEye(txtConfirm);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name, idType, idNo, email, nat;

            if (Session.IsDependentMode)
            {
                name = txtFullName.Text.Trim();
                nat = ddNationality.SelectedItem ?? "";
                idType = ddIdType.SelectedItem ?? "";
                idNo = txtIdNumber.Text.Trim().Replace("-", "").Replace(" ", "");
                email = txtEmail.Text.Trim().ToLower();

                if (name.Length < 2 || nat == "" || idNo == "") { Msg.Warn("Please fill in all fields."); return; }
                if (!DependentService.VerifyGuardianPassword(txtCurrent.Text)) { Msg.Warn("Incorrect guardian password."); return; }
                try
                {
                    if (DependentService.IdNumberTakenByOther(idNo)) { Msg.Warn("This ID number is already in MediCord."); return; }
                    DependentService.UpdateIdentity(name, nat, idType, idNo);
                }
                catch (SqlException ex) { Msg.Error("Could not save.\n" + ex.Message); return; }

                Session.ActAs(Session.PatientID, name, Session.ActingType);  
                AppEvents.RaiseProfileChanged();
                Msg.Show("Your details were updated.");
                Saved?.Invoke(this, EventArgs.Empty);
                return;
            }

            name = txtFullName.Text.Trim();
            nat = ddNationality.SelectedItem ?? "";
            idType = ddIdType.SelectedItem ?? "";
            idNo = txtIdNumber.Text.Trim().Replace("-", "").Replace(" ", "");
            email = txtEmail.Text.Trim().ToLower();
            string? newPw = txtNewPassword.Text == "" ? null : txtNewPassword.Text;

            if (name == "" || name.Length > 100) { Msg.Show("Enter your full name (up to 100 characters)."); return; }
            if (idType == "" || !Validators.IsIdNumber(idType, idNo))
            {
                Msg.Show(idType == "Passport" ? "Passport number must be 6-15 letters or numbers." : "NRIC or MyKid must be 12 digits.");
                return;
            }
            if (!Validators.IsEmail(email)) { Msg.Show("Enter a valid email address."); return; }
            if (newPw != null)
            {
                if (newPw.Length < 8) { Msg.Show("The new password must be at least 8 characters."); return; }
                if (newPw != txtConfirm.Text) { Msg.Show("The new passwords do not match."); return; }
            }
            if (txtCurrent.Text == "") { Msg.Show("Enter your current password to confirm."); return; }

            bool identityChanged = name != origName || idType != origIdType || idNo != origId;
            if (!identityChanged && email == origEmail && newPw == null) { Msg.Show("Nothing to save."); return; }
            if (identityChanged && !Msg.Confirm(
                    "Your name and ID appear on your medical records and appointments. Save these changes?")) return;

            AccountResult result;
            try { result = ProfileService.UpdatePatientAccount(txtCurrent.Text, name, nat, idType, idNo, email, newPw); }
            catch (SqlException ex) { Msg.Show("Could not save:\n" + ex.Message); return; }

            switch (result)
            {
                case AccountResult.WrongPassword: Msg.Show("Your current password is incorrect."); return;
                case AccountResult.EmailTaken: Msg.Show("That email is already used by another account."); return;
                case AccountResult.IdTaken: Msg.Show("That ID number is already registered to another account."); return;
            }

            Session.FullName = name;     
            Msg.Show("Your details were updated.");
            Saved?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e) => BackClicked?.Invoke(this, EventArgs.Empty);
    }
}
