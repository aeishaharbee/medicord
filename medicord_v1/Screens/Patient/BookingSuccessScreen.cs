using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace medicord_v1.Screens.Patient
{
    public partial class BookingSuccessScreen : UserControl
    {
        public event EventHandler? DoneClicked;
        public BookingSuccessScreen()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DoneClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
