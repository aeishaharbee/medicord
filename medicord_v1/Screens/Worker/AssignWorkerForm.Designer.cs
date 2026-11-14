namespace medicord_v1.Screens.Worker
{
    partial class AssignWorkerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblInfo = new SiticoneLabel();
            lblNone = new SiticoneLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnCancel = new SiticoneButton();
            btnConfirm = new SiticoneButton();
            ddWorker = new SiticoneDropdown();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = Color.FromArgb(15, 76, 76);
            lblInfo.Location = new Point(12, 30);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(776, 119);
            lblInfo.TabIndex = 28;
            lblInfo.Text = "Your facility will see you once you finish.";
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNone
            // 
            lblNone.Font = new Font("Segoe UI", 10F);
            lblNone.ForeColor = Color.Gray;
            lblNone.Location = new Point(194, 228);
            lblNone.Name = "lblNone";
            lblNone.Size = new Size(418, 30);
            lblNone.TabIndex = 58;
            lblNone.Text = "Ask your facility admin for the 6-digit code.";
            lblNone.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel2.Controls.Add(btnCancel, 0, 0);
            tableLayoutPanel2.Controls.Add(btnConfirm, 1, 0);
            tableLayoutPanel2.Location = new Point(260, 302);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(284, 58);
            tableLayoutPanel2.TabIndex = 68;
            // 
            // btnCancel
            // 
            btnCancel.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnCancel.AccessibleName = "Cancel";
            btnCancel.BadgeBackColor = Color.Black;
            btnCancel.BadgeBorderColor = Color.Empty;
            btnCancel.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnCancel.BadgeValueForeColor = Color.White;
            btnCancel.BorderColor = Color.FromArgb(15, 76, 76);
            btnCancel.BorderWidth = 2;
            btnCancel.BusyIndicatorColor = Color.Empty;
            btnCancel.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnCancel.CornerRadiusBottomLeft = 24;
            btnCancel.CornerRadiusBottomRight = 24;
            btnCancel.CornerRadiusTopLeft = 24;
            btnCancel.CornerRadiusTopRight = 24;
            btnCancel.CustomCursor = Cursors.Default;
            btnCancel.DisabledBackColor = Color.Empty;
            btnCancel.DisabledBorderColor = Color.Empty;
            btnCancel.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.FocusRingColor = Color.Empty;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.2F);
            btnCancel.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnCancel.GradientColor = Color.FromArgb(0, 227, 64);
            btnCancel.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnCancel.HoverBorderColor = Color.Empty;
            btnCancel.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnCancel.ImageSize = new Size(16, 16);
            btnCancel.IsRadial = true;
            btnCancel.Location = new Point(6, 3);
            btnCancel.Margin = new Padding(6, 3, 3, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.ParticleColor = Color.FromArgb(200, 200, 200);
            btnCancel.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnCancel.PressedBorderColor = Color.Empty;
            btnCancel.PressedTextColor = Color.Empty;
            btnCancel.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnCancel.RippleColor = Color.FromArgb(0, 0, 0);
            btnCancel.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnCancel.ShadowOffset = new Point(0, 2);
            btnCancel.Size = new Size(118, 52);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = Color.FromArgb(0, 0, 0);
            btnCancel.ToggledBackColor = Color.Empty;
            btnCancel.ToggledBorderColor = Color.Empty;
            btnCancel.ToggledTextColor = Color.Empty;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnConfirm.AccessibleName = "Approve";
            btnConfirm.BadgeBackColor = Color.Black;
            btnConfirm.BadgeBorderColor = Color.Empty;
            btnConfirm.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnConfirm.BadgeValueForeColor = Color.White;
            btnConfirm.BorderColor = Color.FromArgb(15, 76, 76);
            btnConfirm.BorderWidth = 2;
            btnConfirm.BusyIndicatorColor = Color.Empty;
            btnConfirm.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnConfirm.CornerRadiusBottomLeft = 24;
            btnConfirm.CornerRadiusBottomRight = 24;
            btnConfirm.CornerRadiusTopLeft = 24;
            btnConfirm.CornerRadiusTopRight = 24;
            btnConfirm.CustomCursor = Cursors.Default;
            btnConfirm.DisabledBackColor = Color.Empty;
            btnConfirm.DisabledBorderColor = Color.Empty;
            btnConfirm.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnConfirm.Dock = DockStyle.Fill;
            btnConfirm.FocusRingColor = Color.Empty;
            btnConfirm.Font = new Font("Segoe UI Semibold", 10.2F);
            btnConfirm.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnConfirm.GradientColor = Color.FromArgb(0, 227, 64);
            btnConfirm.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnConfirm.HoverBorderColor = Color.Empty;
            btnConfirm.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnConfirm.ImageSize = new Size(16, 16);
            btnConfirm.IsRadial = true;
            btnConfirm.Location = new Point(133, 3);
            btnConfirm.Margin = new Padding(6, 3, 3, 3);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.ParticleColor = Color.FromArgb(200, 200, 200);
            btnConfirm.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnConfirm.PressedBorderColor = Color.Empty;
            btnConfirm.PressedTextColor = Color.Empty;
            btnConfirm.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnConfirm.RippleColor = Color.FromArgb(0, 0, 0);
            btnConfirm.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnConfirm.ShadowOffset = new Point(0, 2);
            btnConfirm.Size = new Size(148, 52);
            btnConfirm.TabIndex = 40;
            btnConfirm.Text = "Approve";
            btnConfirm.TextColor = Color.FromArgb(0, 0, 0);
            btnConfirm.ToggledBackColor = Color.Empty;
            btnConfirm.ToggledBorderColor = Color.Empty;
            btnConfirm.ToggledTextColor = Color.Empty;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // ddWorker
            // 
            ddWorker.AllowMultipleSelection = false;
            ddWorker.BackColor = Color.FromArgb(255, 255, 255);
            ddWorker.BorderColor = Color.FromArgb(210, 210, 210);
            ddWorker.BorderSize = 2;
            ddWorker.CanBeep = false;
            ddWorker.CanShake = true;
            ddWorker.CornerRadius = 10;
            ddWorker.DataSource = null;
            ddWorker.DisplayMember = null;
            ddWorker.DropdownBackColor = Color.FromArgb(255, 255, 255);
            ddWorker.DropdownWidth = 0;
            ddWorker.DropShadowEnabled = false;
            ddWorker.Font = new Font("Segoe UI", 10F);
            ddWorker.ForeColor = Color.FromArgb(60, 60, 60);
            ddWorker.HoveredItemBackColor = Color.FromArgb(240, 240, 240);
            ddWorker.HoveredItemTextColor = Color.FromArgb(30, 30, 30);
            ddWorker.IsReadonly = false;
            ddWorker.ItemHeight = 30;
            ddWorker.Location = new Point(185, 164);
            ddWorker.MaxDropDownItems = 8;
            ddWorker.Name = "ddWorker";
            ddWorker.NotFoundBackColor = Color.Transparent;
            ddWorker.NotFoundFont = null;
            ddWorker.NotFoundTextColor = Color.Gray;
            ddWorker.PlaceholderColor = Color.FromArgb(128, 128, 128);
            ddWorker.PlaceholderDisappearsOnFocus = false;
            ddWorker.PlaceholderText = "Assign a doctor";
            ddWorker.SearchTextColor = Color.FromArgb(0, 0, 0);
            ddWorker.SearchTextFont = null;
            ddWorker.SelectedIndex = -1;
            ddWorker.SelectedItem = null;
            ddWorker.SelectedItemBackColor = Color.FromArgb(230, 240, 250);
            ddWorker.SelectedItemTextColor = Color.FromArgb(30, 30, 30);
            ddWorker.SelectedValue = null;
            ddWorker.Size = new Size(427, 61);
            ddWorker.TabIndex = 69;
            ddWorker.UnselectedItemTextColor = Color.FromArgb(60, 60, 60);
            ddWorker.ValueMember = null;
            // 
            // AssignWorkerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 418);
            Controls.Add(ddWorker);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(lblNone);
            Controls.Add(lblInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AssignWorkerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Approve Appointment";
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneLabel lblInfo;
        private SiticoneLabel lblNone;
        private TableLayoutPanel tableLayoutPanel2;
        private SiticoneButton btnCancel;
        private SiticoneButton btnConfirm;
        private SiticoneDropdown ddWorker;
    }
}