using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace medicord_v1.Screens.Facility
{
    public partial class FacilityStep1 : UserControl
    {
        private readonly FacilityRegData data;
        public event EventHandler? NextClicked, BackClicked;



        public FacilityStep1(FacilityRegData data)
        {
            InitializeComponent();
            this.data = data;
            Theme.Side(pnlLeft); Theme.Center(pnlForm, pnlRight);
            Theme.Steps(1, lblStep1, lblStep2, lblStep3, lblStep4);

            Theme.Field(txtName);
            Theme.Drop(ddCategory); ddCategory.Items.AddRange(Lists.FacilityCategories);
            Theme.Outline(btnUpload); Theme.PrimaryBtn(btnNext); Theme.Link(btnBack, Color.Transparent);

            txtDescription.TextChanged += (_, _) =>
                lblWords.Text = $"{Validators.WordCount(txtDescription.Text)} / 100 words";

            // refill when coming back from step 2
            txtName.Text = data.Name;
            txtDescription.Text = data.Description;
            int i = ddCategory.Items.IndexOf(data.Category);
            if (i >= 0) ddCategory.SelectedIndex = i;
            if (data.Logo != null) lblLogoName.Text = "Logo selected";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string cat = ddCategory.SelectedItem ?? "";
            string desc = txtDescription.Text.Trim();

            if (name == "" || cat == "") { Msg.Show("Please enter the facility name and choose a category."); return; }
            if (Validators.WordCount(desc) > 100) { Msg.Show("Description must be 100 words or fewer."); return; }

            data.Name = name; data.Category = cat; data.Description = desc;
            NextClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog { Filter = "Images|*.png;*.jpg;*.jpeg" };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            var info = new FileInfo(dlg.FileName);
            if (info.Length > 2 * 1024 * 1024) { Msg.Show("Please choose an image under 2 MB."); return; }
            try { data.Logo = ImageHelper.ToLogoBytes(dlg.FileName); }
            catch (Exception) { Msg.Show("That file is not a valid image."); return; }
            lblLogoName.Text = info.Name;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
