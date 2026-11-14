using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static medicord_v1.Services.ProfileService;

namespace medicord_v1.Screens.Worker
{
    public partial class WorkerIdentityForm : Form
    {
        public WorkerIdentityForm()
        {
            InitializeComponent();
            BackColor = Theme.Page;
            foreach (var t in new[] { txtFullName, txtEmail, txtIdNumber, txtCurrent }) Theme.Field(t);
            txtCurrent.UseSystemPasswordChar = true; Theme.AddEye(txtCurrent);
            Theme.Drop(ddRole); ddRole.Items.AddRange(Lists.MedicalRoles);
            Theme.Drop(ddNationality); ddNationality.Items.AddRange(Lists.Nationalities); ddNationality.EnableSearch = true;
            Theme.Drop(ddIdType); ddIdType.Items.AddRange(Lists.IdTypes);
            Theme.PrimaryBtn(btnSave); Theme.Link(btnCancel, Theme.Page);

            try
            {
                var r = ProfileService.GetWorkerProfile();
                txtFullName.Text = r["FullName"].ToString();
                txtIdNumber.Text = r["IdNumber"].ToString();
                txtEmail.Text = r["Email"].ToString();
                Select(ddRole, r["MedicalRole"].ToString());
                Select(ddNationality, r["Nationality"].ToString());
                Select(ddIdType, r["IdType"].ToString());
            }
            catch (SqlException ex) { Msg.Show("Could not load your details:\n" + ex.Message); }
        }

        private static void Select(SiticoneDropdown d, string? value)
        {
            int i = d.Items.IndexOf(value ?? "");
            if (i < 0 && !string.IsNullOrEmpty(value)) { d.Items.Add(value); i = d.Items.Count - 1; } 
            if (i >= 0) d.SelectedIndex = i;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text.Trim();
            string idType = ddIdType.SelectedItem ?? "";
            string idNo = txtIdNumber.Text.Trim().Replace("-", "").Replace(" ", "");
            string email = txtEmail.Text.Trim().ToLower();

            if (name == "" || name.Length > 100) { Msg.Show("Enter your full name (up to 100 characters)."); return; }
            if (ddRole.SelectedIndex < 0 || ddNationality.SelectedIndex < 0) { Msg.Show("Choose your role and nationality."); return; }
            if (idType == "" || !Validators.IsIdNumber(idType, idNo))
            {
                Msg.Show(idType == "Passport" ? "Passport number must be 6-15 letters or numbers." : "NRIC or MyKid must be 12 digits.");
                return;
            }
            if (txtCurrent.Text == "") { Msg.Show("Enter your current password to confirm."); return; }
            if (!Validators.IsEmail(email)) { Msg.Show("Enter a valid email address."); return; }

            AccountResult result;
            try
            {
                result = ProfileService.UpdateWorkerIdentity(txtCurrent.Text, name, ddNationality.SelectedItem, idType, idNo, email, ddRole.SelectedItem);
            }
            catch (SqlException ex) { Msg.Show("Could not save:\n" + ex.Message); return; }

            switch (result)
            {
                case AccountResult.WrongPassword: Msg.Show("Your current password is incorrect."); return;
                case AccountResult.IdTaken: Msg.Show("That ID number is already registered to another worker."); return;
                case AccountResult.EmailTaken: Msg.Show("That email address is already registered to another worker."); return;
            }
            Session.FullName = name;
            Msg.Show("Your identity details were updated.");
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
    }
}
