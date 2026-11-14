using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Worker
{
    public partial class WorkDaysForm : Form
    {
        public List<int> Days { get; private set; } = new();
        private readonly SiticoneButton[] chips;

        public WorkDaysForm(string workerName, IEnumerable<int> current)
        {
            InitializeComponent();
            BackColor = Theme.Page; Text = "Working days";
            lblName.Text = workerName;
            Theme.PrimaryBtn(btnSave); Theme.Link(btnCancel, Theme.Page);

            chips = new[] { btnMon, btnTue, btnWed, btnThu, btnFri, btnSat, btnSun };
            string[] names = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
            var set = current.ToHashSet();
            for (int i = 0; i < 7; i++)
            {
                chips[i].Text = names[i];
                Theme.Day(chips[i]);
                chips[i].IsToggled = set.Contains(i);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;

        private void btnSave_Click(object sender, EventArgs e)
        {
            var days = Enumerable.Range(0, 7).Where(i => chips[i].IsToggled).ToList();
            if (days.Count == 0) { Msg.Show("Choose at least one working day."); return; }
            Days = days;
            DialogResult = DialogResult.OK;
        }
    }
}
