using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Patient
{
    public partial class EditProfileScreen : UserControl
    {
        public event EventHandler? BackClicked, Saved, AccountClicked;
        private byte[]? newPhoto;
        private bool photoChanged;
        private string fullName = "";

        public EditProfileScreen()
        {
            InitializeComponent();
            BackColor = Theme.Page;
            foreach (var t in new[] { txtPhone, txtCity, txtPostcode }) Theme.Field(t);
            Theme.Drop(ddState); ddState.Items.AddRange(Lists.States);
            Theme.PrimaryBtn(btnSave); Theme.Outline(btnChangePhoto);
            Theme.OutlineDanger(btnRemovePhoto);

            try
            {
                var r = ProfileService.GetPatientProfile();
                fullName = r["FullName"].ToString() ?? "";
                txtPhone.Text = r["Phone"].ToString();
                txtCity.Text = r["City"].ToString();
                txtPostcode.Text = r["Postcode"].ToString();
                int i = ddState.Items.IndexOf(r["State"].ToString() ?? "");
                if (i >= 0) ddState.SelectedIndex = i;
            }
            catch (SqlException ex) { Msg.Show("Could not load your profile:\n" + ex.Message); }

            picAvatar.Image = ProfileService.LoadAvatar(110);
        }

        private void ShowPreview(byte[]? photo)
        {
            picAvatar.Image?.Dispose();
            picAvatar.Image = photo == null ? ImageHelper.Initials(fullName, 110) : ImageHelper.CircleFromBytes(photo, 110);
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog { Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp", Title = "Choose a photo" };
            if (dlg.ShowDialog(FindForm()) != DialogResult.OK) return;
            if (new FileInfo(dlg.FileName).Length > 8 * 1024 * 1024) { Msg.Show("Please choose a photo under 8 MB."); return; }

            try { newPhoto = ImageHelper.ToAvatarBytes(dlg.FileName); }
            catch (Exception) { Msg.Show("That file is not a valid image."); return; }
            photoChanged = true;
            ShowPreview(newPhoto);
        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            newPhoto = null;
            photoChanged = true;
            ShowPreview(null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim().Replace("-", "").Replace(" ", "");
            string city = txtCity.Text.Trim(), post = txtPostcode.Text.Trim();
            string state = ddState.SelectedItem ?? "";

            if (city == "" || state == "") { Msg.Show("Please fill in all fields."); return; }
            if (!Validators.IsPhone(phone)) { Msg.Show("Enter a valid phone number (digits only)."); return; }
            if (!Validators.IsPostcode(post)) { Msg.Show("Postcode must be 5 digits."); return; }

            try { ProfileService.UpdatePatient(phone, city, state, post, photoChanged, newPhoto); }
            catch (SqlException ex) { Msg.Show("Could not save:\n" + ex.Message); return; }

            Saved?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e) => BackClicked?.Invoke(this, EventArgs.Empty);

        private void btnAccount_Click(object sender, EventArgs e) => AccountClicked?.Invoke(this, EventArgs.Empty);
    }
}
