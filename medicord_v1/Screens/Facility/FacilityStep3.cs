using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Facility
{
    public partial class FacilityStep3 : UserControl
    {
        private readonly FacilityRegData data;
        public event EventHandler? NextClicked, BackClicked;
        private SiticoneButton[] openChips = null!;
        public FacilityStep3(FacilityRegData data)
        {
            InitializeComponent();
            this.data = data;
            Theme.Side(pnlLeft); Theme.Center(pnlForm, pnlRight);
            Theme.Steps(3, lblStep1, lblStep2, lblStep3, lblStep4);
            Theme.TimeField(txtOpen); Theme.TimeField(txtClose);
            foreach (var p in new[] { txtOpen, txtClose }) { p.Use24HourFormat = true; p.ShowSeconds = false; }
            Theme.Field(txtMaxPerSlot);
            Theme.Drop(ddDuration); ddDuration.Items.AddRange(Lists.ApptDurations);
            Theme.PrimaryBtn(btnNext); Theme.Link(btnBack, Color.Transparent);
            lblApptsPerSlot.ForeColor = Theme.Muted;

            openChips = new[] { btnMon, btnTue, btnWed, btnThu, btnFri, btnSat, btnSun };
            string[] dn = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            for (int i = 0; i < 7; i++)
            {
                openChips[i].Text = dn[i];
                Theme.Day(openChips[i]);
                openChips[i].IsToggled = data.OpenDays.Contains(i);  
            }

            // refill when coming back from step 4
            bool visited = data.CloseTime != TimeSpan.Zero;
            SetPicker(txtOpen, visited ? data.OpenTime : new TimeSpan(9, 0, 0));
            SetPicker(txtClose, visited ? data.CloseTime : new TimeSpan(17, 0, 0));
            if (visited)
            {
                int i = ddDuration.Items.IndexOf($"{data.SlotMinutes} minutes");
                if (i >= 0) ddDuration.SelectedIndex = i;
            }
            txtMaxPerSlot.Text = data.MaxPerSlot.ToString();
            rdoWalkInYes.Checked = data.WalkInAvailable;
            rdoWalkInNo.Checked = !data.WalkInAvailable;

            txtOpen.TimeChanged += (_, _) => UpdatePreview();
            txtClose.TimeChanged += (_, _) => UpdatePreview();
            ddDuration.ItemSelected += (_, _) => UpdatePreview();
            UpdatePreview();
        }

        private static TimeSpan ReadPicker(SiticoneTimePicker p) => new TimeSpan(p.Hour, p.Minute, 0);

        private static void SetPicker(SiticoneTimePicker p, TimeSpan t)
        {
            p.Hour = t.Hours;
            p.Minute = t.Minutes;
            p.Second = 0;
        }

        private void UpdatePreview()
        {
            var o = ReadPicker(txtOpen); var c = ReadPicker(txtClose);
            if (c > o && ddDuration.SelectedIndex >= 0)
            {
                int m = int.Parse(ddDuration.SelectedItem.Split(' ')[0]);
                int n = (int)((c - o).TotalMinutes / m);
                lblSlotPreview.Text = n > 0
                    ? $"Patients will see {n} slots a day, starting at {o.ToString(@"hh\:mm")}."
                    : "One slot is longer than your opening hours.";
            }
            else lblSlotPreview.Text = "Slots are created automatically between opening and closing time.";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var open = ReadPicker(txtOpen); var close = ReadPicker(txtClose);

            if (close <= open) { Msg.Show("Closing time must be after opening time."); return; }
            if (ddDuration.SelectedIndex < 0) { Msg.Show("Choose the duration of each slot."); return; }
            if (!int.TryParse(txtMaxPerSlot.Text, out int max) || max < 1 || max > 50)
            { Msg.Show("Appointments per slot must be a number from 1 to 50."); return; }

            int minutes = int.Parse(ddDuration.SelectedItem.Split(' ')[0]);
            if (minutes > (close - open).TotalMinutes)
            { Msg.Show("One slot is longer than your opening hours."); return; }

            var openDays = Enumerable.Range(0, 7).Where(i => openChips[i].IsToggled).ToList();
            if (openDays.Count == 0) { Msg.Show("Choose at least one open day."); return; }

            data.OpenTime = open; data.CloseTime = close;
            data.SlotMinutes = minutes; data.MaxPerSlot = max;
            data.OpenDays = openDays;
            data.WalkInAvailable = rdoWalkInYes.Checked;
            NextClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
