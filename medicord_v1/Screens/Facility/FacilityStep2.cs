using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Facility
{
    public partial class FacilityStep2 : UserControl
    {
        private readonly FacilityRegData data;
        public event EventHandler? NextClicked, BackClicked;
        public FacilityStep2(FacilityRegData data)
        {
            InitializeComponent();
            this.data = data;
            Theme.Side(pnlLeft); Theme.Center(pnlForm, pnlRight);
            Theme.Steps(2, lblStep1, lblStep2, lblStep3, lblStep4);

            foreach (var t in new[] { txtAddress, txtCity, txtPostcode, txtPhone }) Theme.Field(t);
            Theme.Drop(ddState); ddState.Items.AddRange(Lists.States);
            Theme.PrimaryBtn(btnNext); Theme.Link(btnBack, Color.Transparent);

            txtAddress.Text = data.Address; txtCity.Text = data.City;
            txtPostcode.Text = data.Postcode; txtPhone.Text = data.Phone;
            int i = ddState.Items.IndexOf(data.State);
            if (i >= 0) ddState.SelectedIndex = i;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string addr = txtAddress.Text.Trim(), city = txtCity.Text.Trim(), post = txtPostcode.Text.Trim();
            string phone = txtPhone.Text.Trim().Replace("-", "").Replace(" ", "");
            string state = ddState.SelectedItem ?? "";

            if (addr == "" || city == "" || state == "") { Msg.Show("Please fill in all fields."); return; }
            if (!Validators.IsPostcode(post)) { Msg.Show("Postcode must be 5 digits."); return; }
            if (!Validators.IsPhone(phone)) { Msg.Show("Enter a valid phone number (digits only)."); return; }

            data.Address = addr; data.City = city; data.State = state; data.Postcode = post; data.Phone = phone;
            NextClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
