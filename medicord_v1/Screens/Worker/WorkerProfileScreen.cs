using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Worker
{
    public partial class WorkerProfileScreen : UserControl
    {
        private byte[]? _pendingPhoto; 
        private bool _photoChanged;

        public WorkerProfileScreen()
        {
            InitializeComponent();
            BackColor = Theme.Page;
            Theme.Card(pnlDetails); Theme.Card(pnlPassword);
            foreach (var t in new[] { txtPhone, txtCurrent, txtNew, txtConfirm }) Theme.Field(t);
            foreach (var t in new[] { txtCurrent, txtNew, txtConfirm })
            { t.UseSystemPasswordChar = true; Theme.AddEye(t); }
            Theme.Outline(btnSave); Theme.Outline(btnPassword); Theme.PrimaryBtn(btnIdentity);
            Theme.OutlineWarning(btnCancel); Theme.Outline(btnChangeLogo); Theme.Link(btnRemoveLogo, Color.Transparent);
            LoadProfile();
        }

        private void LoadProfile()
        {
            DataRow r;
            try { r = ProfileService.GetWorkerProfile(); }
            catch (Exception ex) { Msg.Show("Could not load your profile:\n" + ex.Message); return; }

            lblName.Text = r["FullName"].ToString();
            lblRoleFacility.Text = $"{r["MedicalRole"]} · {r["FacilityName"]}";
            lblEmail.Text = ProfileService.GetWorkerEmail();
            lblNationality.Text = r["Nationality"].ToString();
            lblId.Text = $"{r["IdType"]} · {r["IdNumber"]}";
            lblDays.Text = r["WorkingDays"].ToString();
            txtPhone.Text = r["Phone"].ToString();

            _pendingPhoto = null;
            _photoChanged = false;
            picAvatar.Image?.Dispose();
            picAvatar.Image = ProfileService.LoadAvatar(110);
        }

        private void btnSave_Click(object s, EventArgs e)
        {
            string phone = txtPhone.Text.Trim().Replace("-", "").Replace(" ", "");
            if (!Validators.IsPhone(phone)) { Msg.Show("Enter a valid phone number (digits only)."); return; }

            try
            {
                if (!ProfileService.UpdateWorkerContact(phone, _photoChanged, _pendingPhoto))
                { Msg.Show("Could not save your changes."); return; }
            }
            catch (SqlException ex) { Msg.Show("Could not save:\n" + ex.Message); return; }

            LoadProfile();
            AppEvents.RaiseProfileChanged();
            Msg.Show("Profile updated.");
        }

        private void btnPassword_Click(object s, EventArgs e)
        {
            if (txtCurrent.Text == "") { Msg.Show("Enter your current password."); return; }
            if (txtNew.Text.Length < 8) { Msg.Show("The new password must be at least 8 characters."); return; }
            if (txtNew.Text != txtConfirm.Text) { Msg.Show("The new passwords do not match."); return; }
            if (txtNew.Text == txtCurrent.Text) { Msg.Show("Choose a password different from the current one."); return; }

            try
            {
                if (!ProfileService.ChangePassword(txtCurrent.Text, txtNew.Text))
                { Msg.Show("Your current password is incorrect."); return; }
            }
            catch (SqlException ex) { Msg.Show("Could not change the password:\n" + ex.Message); return; }

            txtCurrent.Text = txtNew.Text = txtConfirm.Text = "";
            Msg.Show("Password updated.");
        }

        private void btnIdentity_Click(object sender, EventArgs e)
        {
            using var f = new WorkerIdentityForm();
            if (f.ShowDialog(FindForm()) != DialogResult.OK) return;
            LoadProfile();
            AppEvents.RaiseProfileChanged();
        }

        private void btnChangeLogo_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog { Filter = "Images|*.jpg;*.jpeg;*.png" };
            if (dlg.ShowDialog(FindForm()) != DialogResult.OK) return;
            try
            {
                _pendingPhoto = ImageHelper.ToAvatarBytes(dlg.FileName);
                _photoChanged = true;
                picAvatar.Image?.Dispose();
                picAvatar.Image = ImageHelper.CircleFromBytes(_pendingPhoto, 110);
            }
            catch (Exception ex) { Msg.Show("Could not use that image:\n" + ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e) => LoadProfile();

        private void btnRemoveLogo_Click(object sender, EventArgs e)
        {
            _pendingPhoto = null;
            _photoChanged = true;
            picAvatar.Image?.Dispose();
            picAvatar.Image = ImageHelper.Initials(lblName.Text, 110);
            AppEvents.RaiseProfileChanged();

        }
    }
}
