using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Worker
{
    public partial class WorkerRegisterScreen : UserControl
    {
        public event EventHandler? BackClicked, RegisterSucceeded;
        private SiticoneButton[] dayChips = null!;
        private int failedCodes = 0;
        public WorkerRegisterScreen()
        {
            InitializeComponent();
            Theme.Side(pnlLeft); Theme.Center(pnlForm, pnlRight);
            foreach (var t in new[] { txtName, txtFacilityCode, txtIdNumber, txtPhone, txtEmail, txtPassword, txtConfirm }) Theme.Field(t);

            Theme.Drop(ddRole); ddRole.Items.AddRange(Lists.MedicalRoles);
            Theme.Drop(ddNationality); ddNationality.Items.AddRange(Lists.Nationalities);
            Theme.Drop(ddIdType); ddIdType.Items.AddRange(Lists.IdTypes);
            Theme.PrimaryBtn(btnRegister); Theme.Link(btnBack, Color.Transparent);
            Theme.AddEye(txtPassword); Theme.AddEye(txtConfirm);

            ShowHint("Ask your facility admin for the 6-digit code.", Theme.Muted);
            txtFacilityCode.TextChanged += (_, _) => CheckCode();

            dayChips = new[] { btnMon, btnTue, btnWed, btnThu, btnFri, btnSat, btnSun };
            for (int i = 0; i < 7; i++)
            {
                Theme.Day(dayChips[i]);
                dayChips[i].IsToggled = i <= 4;
            }
        }

        private void ShowHint(string text, Color color) { lblFacilityName.Text = text; lblFacilityName.ForeColor = color; }

        private static bool LooksLikeCode(string c) => c.Length == 6 && c.All(char.IsDigit);

        private void CheckCode()
        {
            string code = txtFacilityCode.Text.Trim();
            if (!LooksLikeCode(code)) { ShowHint("Ask your facility admin for the 6-digit code.", Theme.Muted); return; }

            (int Id, string Name)? fac;
            try { fac = FacilityService.FindByCode(code); }
            catch (SqlException) { ShowHint("Cannot reach the database.", Color.Firebrick); return; }

            if (fac != null) { ShowHint("✓ " + fac.Value.Name, Theme.Primary); return; }

            failedCodes++;
            if (failedCodes >= 5)
            {
                txtFacilityCode.Enabled = false; btnRegister.Enabled = false;
                ShowHint("Too many wrong codes. Go back and try again later.", Color.Firebrick);
            }
            else ShowHint("That code doesn't match any facility.", Color.Firebrick);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim().ToLower();
            string phone = txtPhone.Text.Trim().Replace("-", "").Replace(" ", "");
            string idType = ddIdType.SelectedItem ?? "";
            string idNo = txtIdNumber.Text.Trim().Replace("-", "").Replace(" ", "");
            string code = txtFacilityCode.Text.Trim();
            var days = Enumerable.Range(0, 7).Where(i => dayChips[i].IsToggled).ToList();

            if (txtName.Text.Trim() == "" || ddRole.SelectedIndex < 0 || ddNationality.SelectedIndex < 0 || idType == "" || idNo == "")
            { Msg.Show("Please fill in all details."); return; }
            if (!LooksLikeCode(code)) { Msg.Show("Enter the 6-digit facility code from your facility admin."); return; }
            if (!Validators.IsIdNumber(idType, idNo))
            {
                Msg.Show(idType == "Passport" ? "Passport number must be 6-15 letters or numbers."
                                                  : "NRIC or MyKid must be 12 digits.");
                return;
            }
            if (days.Count == 0) { Msg.Show("Choose at least one working day."); return; }
            if (!Validators.IsPhone(phone)) { Msg.Show("Enter a valid phone number (digits only)."); return; }
            if (!Validators.IsEmail(email)) { Msg.Show("Enter a valid email address."); return; }
            if (txtPassword.Text.Length < 8) { Msg.Show("Password must be at least 8 characters."); return; }
            if (txtPassword.Text != txtConfirm.Text) { Msg.Show("Passwords do not match."); return; }

            try
            {
                var fac = FacilityService.FindByCode(code);
                if (fac == null) { Msg.Show("That facility code doesn't match any facility."); return; }
                if (RegistrationService.EmailExists(email)) { Msg.Show("This email is already registered."); return; }
                if (WorkerService.IdNumberExists(idNo)) { Msg.Show("This ID number is already registered."); return; }

                WorkerService.RegisterWorker(new WorkerRegData
                {
                    FacilityID = fac.Value.Id,
                    Nationality = ddNationality.SelectedItem,
                    IdType = idType,
                    IdNumber = idNo,
                    FullName = txtName.Text.Trim(),
                    MedicalRole = ddRole.SelectedItem,
                    Phone = phone,
                    Days = days,
                    Email = email,
                    Password = txtPassword.Text
                });
            }
            catch (SqlException ex) { Msg.Show("Could not register:\n" + ex.Message); return; }

            RegisterSucceeded?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
