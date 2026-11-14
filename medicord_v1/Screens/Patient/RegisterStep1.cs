using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Patient
{
    public partial class RegisterStep1 : UserControl
    {
        private readonly PatientRegData data;
        public event EventHandler? NextClicked;
        public event EventHandler? BackClicked;


        public RegisterStep1(PatientRegData data)
        {
            InitializeComponent();
            this.data = data;

            Theme.Drop(cmbNationality); Theme.Drop(cmbIdType);
            Theme.Field(txtFullName); Theme.Field(txtIdNumber); Theme.Field(txtPhone);

            cmbNationality.Items.AddRange(Lists.Nationalities);
            cmbNationality.EnableSearch = true;
            cmbIdType.Items.AddRange(Lists.IdTypes);

            // refill if user come back from step 2
            int n = cmbNationality.Items.IndexOf(data.Nationality);
            if (n >= 0) cmbNationality.SelectedIndex = n;
            int t = cmbIdType.Items.IndexOf(data.IdType);
            if (t >= 0) cmbIdType.SelectedIndex = t;

            txtIdNumber.Text = data.IdNumber;
            txtFullName.Text = data.FullName;
            txtPhone.Text = data.Phone;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string nat = cmbNationality.SelectedItem ?? "";
            string idType = cmbIdType.SelectedItem ?? "";
            string idNo = txtIdNumber.Text.Trim().Replace("-", "").Replace(" ", "");
            string name = txtFullName.Text.Trim();
            string phone = txtPhone.Text.Trim().Replace("-", "").Replace(" ", "");

            if (nat == "" || idType == "" || idNo == "" || name == "" || phone == "")
            { Msg.Show("Please fill in all fields."); return; }

            if (!Validators.IsIdNumber(idType, idNo))
            {
                Msg.Show(idType == "Passport"
                    ? "Passport number must be 6-15 letters or numbers."
                    : "NRIC or MyKid must be 12 digits.");
                return;
            }
            if (!Validators.IsPhone(phone))
            { Msg.Show("Enter a valid phone number (digits only)."); return; }

            try
            {
                if (RegistrationService.IdNumberExists(idNo))
                { Msg.Show("This ID number is already registered."); return; }
            }
            catch (SqlException ex)
            { Msg.Show("Cannot reach the database:\n" + ex.Message); return; }

            data.Nationality = nat; data.IdType = idType; data.IdNumber = idNo;
            data.FullName = name; data.Phone = phone;
            NextClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
