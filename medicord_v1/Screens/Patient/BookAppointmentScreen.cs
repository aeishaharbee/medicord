using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Patient
{
    public partial class BookAppointmentScreen : UserControl
    {
        public event EventHandler? BackClicked;
        public event EventHandler? Booked;
        private TimeSpan? selectedSlot;
        private List<FacilityItem> _facilities = new List<FacilityItem>();

        private FacilityItem? SelectedFacility =>
            cmbFacility.SelectedIndex >= 0 && cmbFacility.SelectedIndex < _facilities.Count
                ? _facilities[cmbFacility.SelectedIndex]
                : null;
        public BookAppointmentScreen()
        {
            InitializeComponent();

            Theme.Field(txtSymptoms); Theme.Drop(cmbFacility); Theme.Drop(cmbPurpose);
            Theme.DateField(dtpDate);

            lblFor.Visible = Session.IsDependentMode; lblFor.Text = "For " + Session.PatientName;

            cmbPurpose.Items.AddRange(new string[] { "Medical Checkup", "Consultation", "Health Screening" });
            cmbPurpose.SelectedIndex = 0;

            dtpDate.DateFormat = DateFormat.ShortDate;
            dtpDate.MinDate = DateTime.Today;
            dtpDate.MaxDate = DateTime.Today.AddMonths(3);

            try
            {
                _facilities = FacilityService.GetFacilitiesForPatient(Session.PatientID) ?? new List<FacilityItem>();
                cmbFacility.Items.AddRange(_facilities.Select(f => f.Name).ToArray());
                if (_facilities.Count > 0) cmbFacility.SelectedIndex = 0;
            }
            catch (SqlException ex)
            {
                Msg.Show("Could not load facilities:\n" + ex.Message);
            }

            dtpDate.CalendarLockedDateBackColor = Color.FromArgb(235, 238, 238);
            dtpDate.CalendarLockedDateForeColor = Color.Gray;
            ApplyLockedDates();

            cmbFacility.SelectedIndexChanged += (_, _) => { ApplyLockedDates(); LoadSlots(); };
            dtpDate.SelectedDateChanged += (_, _) => LoadSlots();
            LoadSlots();
        }

        private void ApplyLockedDates()
        {
            dtpDate.ClearDates();    
            var facility = SelectedFacility;
            if (facility is null) { dtpDate.LockedDates = new List<DateTime>(); return; }
            try
            {
                dtpDate.LockedDates = AppointmentService.GetLockedDates(facility.Id, dtpDate.MinDate, dtpDate.MaxDate);
            }
            catch (SqlException ex) { Msg.Show("Could not load the facility's calendar:\n" + ex.Message); }
        }

        private void ShowMessage(string text)
        {
            lblNoSlots.Text = text;
            lblNoSlots.Visible = true;
            flpSlots.Visible = false;  
        }

        private void LoadSlots()
        {
            foreach (Control c in flpSlots.Controls.Cast<Control>().ToList())
            {
                flpSlots.Controls.Remove(c);
                c.Dispose();
            }
            selectedSlot = null;

            var facility = SelectedFacility;
            if (facility is null) { ShowMessage("No health facilities are registered yet."); return; }

            //date cleared
            if (dtpDate.Date is not DateTime picked) { ShowMessage("Choose a date to see the available times."); return; }

            List<TimeSpan> slots;
            try { slots = AppointmentService.GetAvailableSlots(facility.Id, picked.Date); }
            catch (SqlException ex)
            {
                Msg.Error("Could not load time slots:\n" + ex.Message);
                return;
            }

            if (slots.Count == 0) { ShowMessage("No slots available on this date."); return; }

            lblNoSlots.Visible = false;
            flpSlots.Visible = true;

            int avail = flpSlots.ClientSize.Width - (flpSlots.AutoScroll ? SystemInformation.VerticalScrollBarWidth : 0);
            int chipWidth = Math.Max(72, avail / 3 - 8); 

            flpSlots.SuspendLayout();
            foreach (var t in slots)
            {
                var chip = new SlotChip
                {
                    Text = DateTime.Today.Add(t).ToString("h:mm tt"),
                    Slot = t,
                    Width = chipWidth,
                    Height = 44,
                    Margin = new Padding(4)
                };
                chip.CheckedChanged += (s, _) =>
                {
                    var me = (SlotChip)s!;
                    if (!me.Checked) return;
                    foreach (var other in flpSlots.Controls.OfType<SlotChip>().Where(o => o != me))
                        other.Checked = false;
                    selectedSlot = me.Slot;
                };
                flpSlots.Controls.Add(chip);
            }
            flpSlots.ResumeLayout();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            var facility = SelectedFacility;
            if (facility is null) { Msg.Show("Please choose a health facility."); return; }
            if (dtpDate.Date is not DateTime pickedDate) { Msg.Warn("Please choose a date."); return; }
            if (selectedSlot is null) { Msg.Warn("Please choose a time slot."); return; }

            BookResult result;
            try
            {
                result = AppointmentService.Book(Session.PatientID, facility.Id, cmbPurpose.SelectedItem,
                             txtSymptoms.Text.Trim(), pickedDate, selectedSlot.Value);
            }
            catch (SqlException ex)
            {
                Msg.Show("Could not send your request:\n" + ex.Message);
                return;
            }

            switch (result)
            {
                case BookResult.Success:
                    Booked?.Invoke(this, EventArgs.Empty);
                    break;
                case BookResult.SlotTaken:
                    Msg.Show("Sorry, that slot was just taken. Please pick another.");
                    LoadSlots();
                    break;
                case BookResult.AlreadyBookedThatDay:
                    Msg.Show("You already have a request at this facility on that date.");
                    break;
                case BookResult.FacilityClosed:
                    Msg.Show("The facility is closed on that date. Please choose another date.");
                    LoadSlots();
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
