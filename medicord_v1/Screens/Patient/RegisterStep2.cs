using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Patient
{
    public partial class RegisterStep2 : UserControl
    {
        private readonly PatientRegData data;
        public event EventHandler? NextClicked;
        public event EventHandler? BackClicked;

        private static readonly string[] States =
            { "Johor", "Kedah", "Kelantan", "Melaka", "Negeri Sembilan", "Pahang", "Perak",
      "Perlis", "Pulau Pinang", "Sabah", "Sarawak", "Selangor", "Terengganu",
      "Kuala Lumpur", "Labuan", "Putrajaya" };

        public RegisterStep2(PatientRegData data)
        {
            InitializeComponent();
            this.data = data;

            Theme.Drop(cmbState);
            Theme.Field(txtCity); Theme.Field(txtPostcode);

            cmbState.Items.AddRange(States);
            cmbState.EnableSearch = true;

            txtCity.Text = data.City;
            int s = cmbState.Items.IndexOf(data.State);
            if (s >= 0) cmbState.SelectedIndex = s;
            txtPostcode.Text = data.Postcode;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text.Trim();
            string post = txtPostcode.Text.Trim();
            string state = cmbState.SelectedItem ?? "";

            if (city == "" || state == "")
            { Msg.Show("Please fill in all fields."); return; }
            if (!Validators.IsPostcode(post))
            { Msg.Show("Postcode must be 5 digits."); return; }

            data.City = city;
            data.State = state;
            data.Postcode = post;
            NextClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
