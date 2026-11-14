using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Patient
{
    public partial class ProfileScreen : UserControl
    {
        public event EventHandler? EditClicked;
        public event EventHandler? LogoutClicked;
        public event EventHandler? DependentsClicked;
        public event EventHandler? BackToMineClicked;

        public ProfileScreen()
        {
            InitializeComponent();

            bool dep = Session.IsDependentMode;
            btnLogout.Visible = !dep;
            btnDependents.Visible = !dep;
            btnBackToMine.Visible = dep;
            pnlDependent.Visible = !dep;
            if (!dep) { int n = 0; try { n = DependentService.Count(); } catch (SqlException) { } btnDependents.Text = n > 0 ? $"Dependents   ({n})" : "Dependents"; }

            LoadProfileData();
        }

        public void LoadProfileData()
        {
            DataRow? r;
            try { r = ProfileService.GetPatientProfile(); }
            catch (SqlException ex)
            {
                Msg.Show("Could not load your profile:\n" + ex.Message);
                return;
            }
            if (r is null) return;

            string id = r["IdNumber"]?.ToString() ?? "";
            string masked = id.Length > 4 ? new string('•', id.Length - 4) + id[^4..] : id;

            lblName.Text = r["FullName"]?.ToString();
            lblEmail.Text = Convert.ToString(r["Email"])?.ToString();
            lblPhone.Text = r["Phone"]?.ToString();
            lblNationality.Text = r["Nationality"]?.ToString();
            lblIdType.Text = r["IdType"]?.ToString();
            lblIdNumber.Text = masked;
            lblLocation.Text = $"{r["City"]}, {r["State"]} {r["Postcode"]}";

            picAvatar.Image?.Dispose();
            picAvatar.Image = ProfileService.LoadAvatar(96);
        }

        private void btnLogout_Click(object sender, EventArgs e) => LogoutClicked?.Invoke(this, EventArgs.Empty);
        private void btnEditProfile_Click(object sender, EventArgs e) => EditClicked?.Invoke(this, EventArgs.Empty);

        private void btnDependents_Click(object sender, EventArgs e) => DependentsClicked?.Invoke(this, EventArgs.Empty);

        private void btnBackToMine_Click(object sender, EventArgs e) => BackToMineClicked?.Invoke(this, EventArgs.Empty);
    }
}
