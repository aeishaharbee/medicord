using medicord_v1.Screens.Facility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Desktop
{
    public partial class FacilitySettingsScreen : UserControl
    {
        public event EventHandler? Saved;
        private SiticoneButton[] openChips = null!;
        private byte[]? newLogo;
        private bool logoChanged;
        private string facilityName = "";

        public FacilitySettingsScreen()
        {
            InitializeComponent();
            BackColor = Theme.Page;

            foreach (var t in new[] { txtName, txtAddress, txtCity, txtPostcode, txtPhone, txtMaxPerSlot }) Theme.Field(t);
            Theme.Drop(ddState); ddState.Items.AddRange(Lists.States);
            Theme.Drop(ddDuration); ddDuration.Items.AddRange(Lists.ApptDurations);
            Theme.TimeField(txtOpen); Theme.TimeField(txtClose); Theme.Outline(btnCopyCode);
            foreach (var p in new[] { txtOpen, txtClose }) { p.Use24HourFormat = true; p.ShowSeconds = false; }
            Theme.Outline(btnSave); Theme.OutlineWarning(btnCancel); Theme.PrimaryBtn(btnSecurity);
            Theme.Outline(btnChangeLogo); Theme.Link(btnRemoveLogo, Color.White);

            openChips = new[] { btnMon, btnTue, btnWed, btnThu, btnFri, btnSat, btnSun };
            for (int i = 0; i < 7; i++) { Theme.Day(openChips[i]); }

            Theme.Grid(dgvClosures); Theme.EmptyState(dgvClosures, "No closed dates");
            Theme.DateField(dpClosed);
            dpClosed.DateFormat = DateFormat.Custom; dpClosed.CustomDateFormat = "dd MMM yyyy";
            dpClosed.MinDate = DateTime.Today;
            Theme.Field(txtReason);
            Theme.Outline(btnAddClosure); Theme.OutlineDanger(btnRemoveClosure);

            LoadFacility();
        }

        private void LoadFacility()
        {
            DataRow r;
            try { r = PortalService.GetFacility(); }
            catch (Exception ex) { Msg.Show("Could not load facility settings:\n" + ex.Message); return; }

            txtName.Text = r["FacilityName"]?.ToString() ?? "";
            txtAddress.Text = r["AddressLine"]?.ToString() ?? "";
            txtCity.Text = r["City"]?.ToString() ?? "";
            txtPostcode.Text = r["Postcode"]?.ToString() ?? "";
            txtPhone.Text = r["Phone"]?.ToString() ?? "";
            txtMaxPerSlot.Text = r["MaxPerSlot"]?.ToString() ?? "";
            lblFacilityCode.Text = r["FacilityCode"].ToString();

            int s = ddState.Items.IndexOf(r["State"].ToString() ?? "");
            if (s >= 0) ddState.SelectedIndex = s;

            facilityName = r["FacilityName"].ToString() ?? "";
            newLogo = null; logoChanged = false;
            ShowLogo(r["Logo"] as byte[]);

            Theme.SetTime(txtOpen, (TimeSpan)r["OpenTime"]);
            Theme.SetTime(txtClose, (TimeSpan)r["CloseTime"]);

            string dur = $"{r["SlotDurationMin"]} minutes";
            int d = ddDuration.Items.IndexOf(dur);
            if (d < 0) { ddDuration.Items.Add(dur); d = ddDuration.Items.Count - 1; }
            ddDuration.SelectedIndex = d;

            bool walk = Convert.ToBoolean(r["WalkInAvailable"]);
            rdoWalkInYes.Checked = walk; rdoWalkInNo.Checked = !walk;

            var open = PortalService.GetOpenDays();
            for (int i = 0; i < 7; i++) openChips[i].IsToggled = open.Contains(i);
            LoadClosures();
        }

        private void ShowLogo(byte[]? data)
        {
            picLogo.Image?.Dispose();
            picLogo.Image = ImageHelper.LogoTile(data, txtName.Text.Trim() == "" ? facilityName : txtName.Text.Trim(), 96);
        }

        private void btnCancel_Click(object sender, EventArgs e) => LoadFacility();

        private void btnSave_Click(object sender, EventArgs e)
        {
            string post = txtPostcode.Text.Trim();
            string phone = txtPhone.Text.Trim().Replace("-", "").Replace(" ", "");
            var open = Theme.ReadTime(txtOpen); var close = Theme.ReadTime(txtClose);

            if (txtName.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtCity.Text.Trim() == "" || ddState.SelectedIndex < 0)
            { Msg.Show("Please fill in all facility details."); return; }
            if (!Validators.IsPostcode(post)) { Msg.Show("Postcode must be 5 digits."); return; }
            if (!Validators.IsPhone(phone)) { Msg.Show("Enter a valid phone number (digits only)."); return; }
            if (close <= open) { Msg.Show("Closing time must be after opening time."); return; }
            if (ddDuration.SelectedIndex < 0) { Msg.Show("Choose the duration of each slot."); return; }
            if (!int.TryParse(txtMaxPerSlot.Text, out int max) || max < 1 || max > 50)
            { Msg.Show("Appointments per slot must be a number from 1 to 50."); return; }

            int minutes = int.Parse(ddDuration.SelectedItem.Split(' ')[0]);
            if (minutes > (close - open).TotalMinutes)
            { Msg.Show("One slot is longer than your opening hours."); return; }

            var openDays = Enumerable.Range(0, 7).Where(i => openChips[i].IsToggled).ToList();
            if (openDays.Count == 0) { Msg.Show("Choose at least one open day."); return; }

            var d = new FacilityRegData
            {
                Name = txtName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                City = txtCity.Text.Trim(),
                Postcode = post,
                State = ddState.SelectedItem,
                Phone = phone,
                OpenTime = open,
                CloseTime = close,
                SlotMinutes = minutes,
                MaxPerSlot = max,
                WalkInAvailable = rdoWalkInYes.Checked,
                OpenDays = openDays,
                Logo = newLogo,
                LogoChanged = logoChanged,
            };

            try { PortalService.UpdateFacility(d); }
            catch (SqlException ex) { Msg.Show("Could not save:\n" + ex.Message); return; }

            logoChanged = false;
            Session.FullName = d.Name;
            Msg.Show("Facility settings saved.");
            Saved?.Invoke(this, EventArgs.Empty);
            AppEvents.RaiseProfileChanged();
        }

        private void btnCopyCode_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblFacilityCode.Text);
            btnCopyCode.Text = "Copied";
            var t = new System.Windows.Forms.Timer { Interval = 1500 };
            t.Tick += (_, _) => { btnCopyCode.Text = "Copy code"; t.Dispose(); };
            t.Start();
        }

        private void LoadClosures()
        {
            try { Theme.Fill(dgvClosures, PortalService.GetClosures(), "ClosureID"); }
            catch (SqlException ex) { Msg.Show("Could not load closed dates:\n" + ex.Message); }
        }

        private void btnAddClosure_Click(object sender, EventArgs e)
        {
            DateTime? a = dpClosed.RangeStartDate ?? dpClosed.Date;    
            DateTime? b = dpClosed.RangeEndDate ?? a;                  
            if (a == null || b == null) { Msg.Show("Pick the closed date, or a start and end date."); return; }

            DateTime start = a.Value.Date, end = b.Value.Date;
            if (end < start) (start, end) = (end, start);
            if ((end - start).TotalDays > 365) { Msg.Show("A closure can be up to one year long."); return; }

            string reason = txtReason.Text.Trim();
            if (reason.Length > 100) { Msg.Show("The reason can be up to 100 characters."); return; }

            try
            {
                int affected = PortalService.CountAffectedAppointments(start, end);
                if (affected > 0 && !Msg.Confirm(
                        $"{affected} pending or approved appointment(s) fall on these dates. They will not be cancelled automatically. Add the closure anyway?")) return;

                PortalService.AddClosure(start, end, reason);
            }
            catch (SqlException ex) { Msg.Show("Could not add the closure:\n" + ex.Message); return; }

            dpClosed.ClearDates();
            txtReason.Text = "";
            LoadClosures();
        }

        private void btnRemoveClosure_Click(object sender, EventArgs e)
        {
            if (dgvClosures.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvClosures.CurrentRow.Cells["ClosureID"].Value);

            string when = dgvClosures.CurrentRow.Cells["Date"].Value?.ToString() ?? "this date";
            if (!Msg.Confirm($"Remove the closure for {when}?\nPatients will be able to book on it again.")) return;

            try { PortalService.RemoveClosure(id); }
            catch (SqlException ex) { Msg.Show("Could not remove the closure:\n" + ex.Message); return; }
            LoadClosures();
        }

        private void btnChangeLogo_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog { Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp", Title = "Choose a logo" };
            if (dlg.ShowDialog(FindForm()) != DialogResult.OK) return;
            if (new FileInfo(dlg.FileName).Length > 8 * 1024 * 1024) { Msg.Show("Please choose an image under 8 MB."); return; }

            try { newLogo = ImageHelper.ToLogoBytes(dlg.FileName); }
            catch (Exception) { Msg.Show("That file is not a valid image."); return; }
            logoChanged = true;
            ShowLogo(newLogo);                    // preview only: saved with "Save changes"
        }

        private void btnRemoveLogo_Click(object sender, EventArgs e)
        {
            newLogo = null; logoChanged = true;
            ShowLogo(null);
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            using var f = new AccountSecurityForm();
            f.ShowDialog(FindForm());
        }
    }
}
