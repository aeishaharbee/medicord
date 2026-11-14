namespace medicord_v1.Screens.Desktop
{
    partial class AppointmentsScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentsScreen));
            siticoneLabel3 = new SiticoneLabel();
            btnPrev = new SiticoneButton();
            btnNext = new SiticoneButton();
            lblDate = new SiticoneLabel();
            btnComplete = new SiticoneButton();
            btnApprove = new SiticoneButton();
            btnCancel = new SiticoneButton();
            btnDecline = new SiticoneButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnApproved = new SiticoneButton();
            btnAll = new SiticoneButton();
            btnCompleted = new SiticoneButton();
            btnPending = new SiticoneButton();
            siticonePanel1 = new SiticonePanel();
            pnlTable = new SiticonePanel();
            dgv = new DataGridView();
            btnReassign = new SiticoneButton();
            tableLayoutPanel2.SuspendLayout();
            siticonePanel1.SuspendLayout();
            pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // siticoneLabel3
            // 
            siticoneLabel3.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel3.ForeColor = SystemColors.ActiveCaptionText;
            siticoneLabel3.Location = new Point(42, 26);
            siticoneLabel3.Name = "siticoneLabel3";
            siticoneLabel3.Size = new Size(274, 60);
            siticoneLabel3.TabIndex = 22;
            siticoneLabel3.Text = "Appointments";
            // 
            // btnPrev
            // 
            btnPrev.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnPrev.AccessibleName = "";
            btnPrev.BadgeBackColor = Color.Black;
            btnPrev.BadgeBorderColor = Color.Empty;
            btnPrev.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnPrev.BadgeValueForeColor = Color.White;
            btnPrev.BorderColor = Color.FromArgb(213, 216, 220);
            btnPrev.BusyIndicatorColor = Color.Empty;
            btnPrev.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnPrev.ButtonImage = (Image)resources.GetObject("btnPrev.ButtonImage");
            btnPrev.CornerRadiusBottomLeft = 25;
            btnPrev.CornerRadiusBottomRight = 25;
            btnPrev.CornerRadiusTopLeft = 25;
            btnPrev.CornerRadiusTopRight = 25;
            btnPrev.CustomCursor = Cursors.Default;
            btnPrev.DisabledBackColor = Color.Empty;
            btnPrev.DisabledBorderColor = Color.Empty;
            btnPrev.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnPrev.FocusRingColor = Color.Empty;
            btnPrev.Font = new Font("Segoe UI Semibold", 10.2F);
            btnPrev.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnPrev.GradientColor = Color.FromArgb(0, 227, 64);
            btnPrev.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnPrev.HoverBorderColor = Color.Empty;
            btnPrev.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnPrev.ImageSize = new Size(30, 30);
            btnPrev.Location = new Point(43, 129);
            btnPrev.Name = "btnPrev";
            btnPrev.ParticleColor = Color.FromArgb(200, 200, 200);
            btnPrev.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnPrev.PressedBorderColor = Color.Empty;
            btnPrev.PressedTextColor = Color.Empty;
            btnPrev.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnPrev.RippleColor = Color.FromArgb(0, 0, 0);
            btnPrev.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnPrev.ShadowOffset = new Point(0, 2);
            btnPrev.Size = new Size(47, 46);
            btnPrev.TabIndex = 36;
            btnPrev.TextColor = Color.FromArgb(0, 0, 0);
            btnPrev.ToggledBackColor = Color.Empty;
            btnPrev.ToggledBorderColor = Color.Empty;
            btnPrev.ToggledTextColor = Color.Empty;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnNext.AccessibleName = "";
            btnNext.BadgeBackColor = Color.Black;
            btnNext.BadgeBorderColor = Color.Empty;
            btnNext.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnNext.BadgeValueForeColor = Color.White;
            btnNext.BorderColor = Color.FromArgb(213, 216, 220);
            btnNext.BusyIndicatorColor = Color.Empty;
            btnNext.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnNext.ButtonImage = (Image)resources.GetObject("btnNext.ButtonImage");
            btnNext.CornerRadiusBottomLeft = 25;
            btnNext.CornerRadiusBottomRight = 25;
            btnNext.CornerRadiusTopLeft = 25;
            btnNext.CornerRadiusTopRight = 25;
            btnNext.CustomCursor = Cursors.Default;
            btnNext.DisabledBackColor = Color.Empty;
            btnNext.DisabledBorderColor = Color.Empty;
            btnNext.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnNext.FocusRingColor = Color.Empty;
            btnNext.Font = new Font("Segoe UI Semibold", 10.2F);
            btnNext.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnNext.GradientColor = Color.FromArgb(0, 227, 64);
            btnNext.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnNext.HoverBorderColor = Color.Empty;
            btnNext.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnNext.ImageSize = new Size(30, 30);
            btnNext.Location = new Point(334, 129);
            btnNext.Name = "btnNext";
            btnNext.ParticleColor = Color.FromArgb(200, 200, 200);
            btnNext.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnNext.PressedBorderColor = Color.Empty;
            btnNext.PressedTextColor = Color.Empty;
            btnNext.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnNext.RippleColor = Color.FromArgb(0, 0, 0);
            btnNext.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnNext.ShadowOffset = new Point(0, 2);
            btnNext.Size = new Size(47, 46);
            btnNext.TabIndex = 37;
            btnNext.TextColor = Color.FromArgb(0, 0, 0);
            btnNext.ToggledBackColor = Color.Empty;
            btnNext.ToggledBorderColor = Color.Empty;
            btnNext.ToggledTextColor = Color.Empty;
            btnNext.Click += btnNext_Click;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = SystemColors.ActiveCaptionText;
            lblDate.Location = new Point(96, 129);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(232, 42);
            lblDate.TabIndex = 38;
            lblDate.Text = "Tue, 3 Nov 2026";
            lblDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnComplete
            // 
            btnComplete.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnComplete.AccessibleName = "Complete";
            btnComplete.BadgeBackColor = Color.Black;
            btnComplete.BadgeBorderColor = Color.Empty;
            btnComplete.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnComplete.BadgeValueForeColor = Color.White;
            btnComplete.BorderColor = Color.FromArgb(15, 76, 76);
            btnComplete.BorderWidth = 2;
            btnComplete.BusyIndicatorColor = Color.Empty;
            btnComplete.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnComplete.CornerRadiusBottomLeft = 24;
            btnComplete.CornerRadiusBottomRight = 24;
            btnComplete.CornerRadiusTopLeft = 24;
            btnComplete.CornerRadiusTopRight = 24;
            btnComplete.CustomCursor = Cursors.Default;
            btnComplete.DisabledBackColor = Color.Empty;
            btnComplete.DisabledBorderColor = Color.Empty;
            btnComplete.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnComplete.FocusRingColor = Color.Empty;
            btnComplete.Font = new Font("Segoe UI Semibold", 10.2F);
            btnComplete.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnComplete.GradientColor = Color.FromArgb(0, 227, 64);
            btnComplete.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnComplete.HoverBorderColor = Color.Empty;
            btnComplete.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnComplete.ImageSize = new Size(16, 16);
            btnComplete.IsRadial = true;
            btnComplete.Location = new Point(940, 794);
            btnComplete.Margin = new Padding(6, 3, 3, 3);
            btnComplete.Name = "btnComplete";
            btnComplete.ParticleColor = Color.FromArgb(200, 200, 200);
            btnComplete.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnComplete.PressedBorderColor = Color.Empty;
            btnComplete.PressedTextColor = Color.Empty;
            btnComplete.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnComplete.RippleColor = Color.FromArgb(0, 0, 0);
            btnComplete.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnComplete.ShadowOffset = new Point(0, 2);
            btnComplete.Size = new Size(124, 52);
            btnComplete.TabIndex = 43;
            btnComplete.Text = "Complete";
            btnComplete.TextColor = Color.FromArgb(0, 0, 0);
            btnComplete.ToggledBackColor = Color.Empty;
            btnComplete.ToggledBorderColor = Color.Empty;
            btnComplete.ToggledTextColor = Color.Empty;
            btnComplete.Click += btnComplete_Click;
            // 
            // btnApprove
            // 
            btnApprove.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnApprove.AccessibleName = "Approve";
            btnApprove.BadgeBackColor = Color.Black;
            btnApprove.BadgeBorderColor = Color.Empty;
            btnApprove.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnApprove.BadgeValueForeColor = Color.White;
            btnApprove.BorderColor = Color.FromArgb(15, 76, 76);
            btnApprove.BorderWidth = 2;
            btnApprove.BusyIndicatorColor = Color.Empty;
            btnApprove.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnApprove.CornerRadiusBottomLeft = 24;
            btnApprove.CornerRadiusBottomRight = 24;
            btnApprove.CornerRadiusTopLeft = 24;
            btnApprove.CornerRadiusTopRight = 24;
            btnApprove.CustomCursor = Cursors.Default;
            btnApprove.DisabledBackColor = Color.Empty;
            btnApprove.DisabledBorderColor = Color.Empty;
            btnApprove.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnApprove.FocusRingColor = Color.Empty;
            btnApprove.Font = new Font("Segoe UI Semibold", 10.2F);
            btnApprove.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnApprove.GradientColor = Color.FromArgb(0, 227, 64);
            btnApprove.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnApprove.HoverBorderColor = Color.Empty;
            btnApprove.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnApprove.ImageSize = new Size(16, 16);
            btnApprove.IsRadial = true;
            btnApprove.Location = new Point(63, 794);
            btnApprove.Margin = new Padding(3, 3, 6, 3);
            btnApprove.Name = "btnApprove";
            btnApprove.ParticleColor = Color.FromArgb(200, 200, 200);
            btnApprove.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnApprove.PressedBorderColor = Color.Empty;
            btnApprove.PressedTextColor = Color.Empty;
            btnApprove.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnApprove.RippleColor = Color.FromArgb(0, 0, 0);
            btnApprove.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnApprove.ShadowOffset = new Point(0, 2);
            btnApprove.Size = new Size(124, 52);
            btnApprove.TabIndex = 41;
            btnApprove.Text = "Approve";
            btnApprove.TextColor = Color.FromArgb(0, 0, 0);
            btnApprove.ToggledBackColor = Color.Empty;
            btnApprove.ToggledBorderColor = Color.Empty;
            btnApprove.ToggledTextColor = Color.Empty;
            btnApprove.Click += btnApprove_Click;
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
            btnCancel.FocusRingColor = Color.Empty;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.2F);
            btnCancel.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnCancel.GradientColor = Color.FromArgb(0, 227, 64);
            btnCancel.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnCancel.HoverBorderColor = Color.Empty;
            btnCancel.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnCancel.ImageSize = new Size(16, 16);
            btnCancel.IsRadial = true;
            btnCancel.Location = new Point(804, 794);
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
            btnCancel.Size = new Size(127, 52);
            btnCancel.TabIndex = 40;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = Color.FromArgb(0, 0, 0);
            btnCancel.ToggledBackColor = Color.Empty;
            btnCancel.ToggledBorderColor = Color.Empty;
            btnCancel.ToggledTextColor = Color.Empty;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDecline
            // 
            btnDecline.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnDecline.AccessibleName = "Decline";
            btnDecline.BadgeBackColor = Color.Black;
            btnDecline.BadgeBorderColor = Color.Empty;
            btnDecline.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnDecline.BadgeValueForeColor = Color.White;
            btnDecline.BorderColor = Color.FromArgb(15, 76, 76);
            btnDecline.BorderWidth = 2;
            btnDecline.BusyIndicatorColor = Color.Empty;
            btnDecline.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnDecline.CornerRadiusBottomLeft = 24;
            btnDecline.CornerRadiusBottomRight = 24;
            btnDecline.CornerRadiusTopLeft = 24;
            btnDecline.CornerRadiusTopRight = 24;
            btnDecline.CustomCursor = Cursors.Default;
            btnDecline.DisabledBackColor = Color.Empty;
            btnDecline.DisabledBorderColor = Color.Empty;
            btnDecline.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnDecline.FocusRingColor = Color.Empty;
            btnDecline.Font = new Font("Segoe UI Semibold", 10.2F);
            btnDecline.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnDecline.GradientColor = Color.FromArgb(0, 227, 64);
            btnDecline.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnDecline.HoverBorderColor = Color.Empty;
            btnDecline.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnDecline.ImageSize = new Size(16, 16);
            btnDecline.IsRadial = true;
            btnDecline.Location = new Point(196, 794);
            btnDecline.Margin = new Padding(3, 3, 6, 3);
            btnDecline.Name = "btnDecline";
            btnDecline.ParticleColor = Color.FromArgb(200, 200, 200);
            btnDecline.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnDecline.PressedBorderColor = Color.Empty;
            btnDecline.PressedTextColor = Color.Empty;
            btnDecline.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnDecline.RippleColor = Color.FromArgb(0, 0, 0);
            btnDecline.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnDecline.ShadowOffset = new Point(0, 2);
            btnDecline.Size = new Size(124, 52);
            btnDecline.TabIndex = 42;
            btnDecline.Text = "Decline";
            btnDecline.TextColor = Color.FromArgb(0, 0, 0);
            btnDecline.ToggledBackColor = Color.Empty;
            btnDecline.ToggledBorderColor = Color.Empty;
            btnDecline.ToggledTextColor = Color.Empty;
            btnDecline.Click += btnDecline_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(btnApproved, 2, 0);
            tableLayoutPanel2.Controls.Add(btnAll, 0, 0);
            tableLayoutPanel2.Controls.Add(btnCompleted, 3, 0);
            tableLayoutPanel2.Controls.Add(btnPending, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(3);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(523, 64);
            tableLayoutPanel2.TabIndex = 41;
            // 
            // btnApproved
            // 
            btnApproved.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnApproved.AccessibleName = "Approved";
            btnApproved.BadgeBackColor = Color.Black;
            btnApproved.BadgeBorderColor = Color.Empty;
            btnApproved.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnApproved.BadgeValueForeColor = Color.White;
            btnApproved.BorderColor = Color.FromArgb(15, 76, 76);
            btnApproved.BorderWidth = 0;
            btnApproved.BusyIndicatorColor = Color.Empty;
            btnApproved.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnApproved.CornerRadiusBottomLeft = 24;
            btnApproved.CornerRadiusBottomRight = 24;
            btnApproved.CornerRadiusTopLeft = 24;
            btnApproved.CornerRadiusTopRight = 24;
            btnApproved.CustomCursor = Cursors.Default;
            btnApproved.DisabledBackColor = Color.Empty;
            btnApproved.DisabledBorderColor = Color.Empty;
            btnApproved.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnApproved.Dock = DockStyle.Fill;
            btnApproved.FocusRingColor = Color.Empty;
            btnApproved.Font = new Font("Segoe UI Semibold", 10.2F);
            btnApproved.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnApproved.GradientColor = Color.FromArgb(0, 227, 64);
            btnApproved.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnApproved.HoverBorderColor = Color.Empty;
            btnApproved.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnApproved.ImageSize = new Size(16, 16);
            btnApproved.IsRadial = true;
            btnApproved.Location = new Point(246, 6);
            btnApproved.Margin = new Padding(6, 3, 3, 3);
            btnApproved.Name = "btnApproved";
            btnApproved.ParticleColor = Color.FromArgb(200, 200, 200);
            btnApproved.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnApproved.PressedBorderColor = Color.Empty;
            btnApproved.PressedTextColor = Color.Empty;
            btnApproved.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnApproved.RippleColor = Color.FromArgb(0, 0, 0);
            btnApproved.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnApproved.ShadowOffset = new Point(0, 2);
            btnApproved.Size = new Size(115, 52);
            btnApproved.TabIndex = 43;
            btnApproved.Text = "Approved";
            btnApproved.TextColor = Color.FromArgb(0, 0, 0);
            btnApproved.ToggledBackColor = Color.Empty;
            btnApproved.ToggledBorderColor = Color.Empty;
            btnApproved.ToggledTextColor = Color.Empty;
            // 
            // btnAll
            // 
            btnAll.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnAll.AccessibleName = "All";
            btnAll.BadgeBackColor = Color.Black;
            btnAll.BadgeBorderColor = Color.Empty;
            btnAll.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnAll.BadgeValueForeColor = Color.White;
            btnAll.BorderColor = Color.FromArgb(15, 76, 76);
            btnAll.BorderWidth = 0;
            btnAll.BusyIndicatorColor = Color.Empty;
            btnAll.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnAll.CornerRadiusBottomLeft = 24;
            btnAll.CornerRadiusBottomRight = 24;
            btnAll.CornerRadiusTopLeft = 24;
            btnAll.CornerRadiusTopRight = 24;
            btnAll.CustomCursor = Cursors.Default;
            btnAll.DisabledBackColor = Color.Empty;
            btnAll.DisabledBorderColor = Color.Empty;
            btnAll.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnAll.Dock = DockStyle.Fill;
            btnAll.FocusRingColor = Color.Empty;
            btnAll.Font = new Font("Segoe UI Semibold", 10.2F);
            btnAll.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnAll.GradientColor = Color.FromArgb(0, 227, 64);
            btnAll.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnAll.HoverBorderColor = Color.Empty;
            btnAll.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnAll.ImageSize = new Size(16, 16);
            btnAll.IsRadial = true;
            btnAll.Location = new Point(6, 6);
            btnAll.Margin = new Padding(3, 3, 6, 3);
            btnAll.Name = "btnAll";
            btnAll.ParticleColor = Color.FromArgb(200, 200, 200);
            btnAll.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnAll.PressedBorderColor = Color.Empty;
            btnAll.PressedTextColor = Color.Empty;
            btnAll.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnAll.RippleColor = Color.FromArgb(0, 0, 0);
            btnAll.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnAll.ShadowOffset = new Point(0, 2);
            btnAll.Size = new Size(73, 52);
            btnAll.TabIndex = 41;
            btnAll.Text = "All";
            btnAll.TextColor = Color.FromArgb(0, 0, 0);
            btnAll.ToggledBackColor = Color.Empty;
            btnAll.ToggledBorderColor = Color.Empty;
            btnAll.ToggledTextColor = Color.Empty;
            // 
            // btnCompleted
            // 
            btnCompleted.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnCompleted.AccessibleName = "Completed";
            btnCompleted.BadgeBackColor = Color.Black;
            btnCompleted.BadgeBorderColor = Color.Empty;
            btnCompleted.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnCompleted.BadgeValueForeColor = Color.White;
            btnCompleted.BorderColor = Color.FromArgb(15, 76, 76);
            btnCompleted.BorderWidth = 0;
            btnCompleted.BusyIndicatorColor = Color.Empty;
            btnCompleted.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnCompleted.CornerRadiusBottomLeft = 24;
            btnCompleted.CornerRadiusBottomRight = 24;
            btnCompleted.CornerRadiusTopLeft = 24;
            btnCompleted.CornerRadiusTopRight = 24;
            btnCompleted.CustomCursor = Cursors.Default;
            btnCompleted.DisabledBackColor = Color.Empty;
            btnCompleted.DisabledBorderColor = Color.Empty;
            btnCompleted.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnCompleted.Dock = DockStyle.Fill;
            btnCompleted.FocusRingColor = Color.Empty;
            btnCompleted.Font = new Font("Segoe UI Semibold", 10.2F);
            btnCompleted.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnCompleted.GradientColor = Color.FromArgb(0, 227, 64);
            btnCompleted.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnCompleted.HoverBorderColor = Color.Empty;
            btnCompleted.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnCompleted.ImageSize = new Size(16, 16);
            btnCompleted.IsRadial = true;
            btnCompleted.Location = new Point(370, 6);
            btnCompleted.Margin = new Padding(6, 3, 3, 3);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.ParticleColor = Color.FromArgb(200, 200, 200);
            btnCompleted.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnCompleted.PressedBorderColor = Color.Empty;
            btnCompleted.PressedTextColor = Color.Empty;
            btnCompleted.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnCompleted.RippleColor = Color.FromArgb(0, 0, 0);
            btnCompleted.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnCompleted.ShadowOffset = new Point(0, 2);
            btnCompleted.Size = new Size(147, 52);
            btnCompleted.TabIndex = 40;
            btnCompleted.Text = "Completed";
            btnCompleted.TextColor = Color.FromArgb(0, 0, 0);
            btnCompleted.ToggledBackColor = Color.Empty;
            btnCompleted.ToggledBorderColor = Color.Empty;
            btnCompleted.ToggledTextColor = Color.Empty;
            // 
            // btnPending
            // 
            btnPending.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnPending.AccessibleName = "Pending";
            btnPending.BadgeBackColor = Color.Black;
            btnPending.BadgeBorderColor = Color.Empty;
            btnPending.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnPending.BadgeValueForeColor = Color.White;
            btnPending.BorderColor = Color.FromArgb(15, 76, 76);
            btnPending.BorderWidth = 0;
            btnPending.BusyIndicatorColor = Color.Empty;
            btnPending.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnPending.CornerRadiusBottomLeft = 24;
            btnPending.CornerRadiusBottomRight = 24;
            btnPending.CornerRadiusTopLeft = 24;
            btnPending.CornerRadiusTopRight = 24;
            btnPending.CustomCursor = Cursors.Default;
            btnPending.DisabledBackColor = Color.Empty;
            btnPending.DisabledBorderColor = Color.Empty;
            btnPending.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnPending.Dock = DockStyle.Fill;
            btnPending.FocusRingColor = Color.Empty;
            btnPending.Font = new Font("Segoe UI Semibold", 10.2F);
            btnPending.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnPending.GradientColor = Color.FromArgb(0, 227, 64);
            btnPending.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnPending.HoverBorderColor = Color.Empty;
            btnPending.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnPending.ImageSize = new Size(16, 16);
            btnPending.IsRadial = true;
            btnPending.Location = new Point(91, 6);
            btnPending.Margin = new Padding(6, 3, 3, 3);
            btnPending.Name = "btnPending";
            btnPending.ParticleColor = Color.FromArgb(200, 200, 200);
            btnPending.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnPending.PressedBorderColor = Color.Empty;
            btnPending.PressedTextColor = Color.Empty;
            btnPending.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnPending.RippleColor = Color.FromArgb(0, 0, 0);
            btnPending.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnPending.ShadowOffset = new Point(0, 2);
            btnPending.Size = new Size(146, 52);
            btnPending.TabIndex = 42;
            btnPending.Text = "Pending";
            btnPending.TextColor = Color.FromArgb(0, 0, 0);
            btnPending.ToggledBackColor = Color.Empty;
            btnPending.ToggledBorderColor = Color.Empty;
            btnPending.ToggledTextColor = Color.Empty;
            // 
            // siticonePanel1
            // 
            siticonePanel1.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            siticonePanel1.BackColor = Color.Transparent;
            siticonePanel1.BorderAlignment = PenAlignment.Center;
            siticonePanel1.BorderColor = Color.FromArgb(218, 223, 230);
            siticonePanel1.BorderDashPattern = null;
            siticonePanel1.BorderGradientEndColor = Color.Purple;
            siticonePanel1.BorderGradientStartColor = Color.Blue;
            siticonePanel1.BorderThickness = 2F;
            siticonePanel1.Controls.Add(tableLayoutPanel2);
            siticonePanel1.CornerRadiusBottomLeft = 28F;
            siticonePanel1.CornerRadiusBottomRight = 28F;
            siticonePanel1.CornerRadiusTopLeft = 28F;
            siticonePanel1.CornerRadiusTopRight = 28F;
            siticonePanel1.EnableAcrylicEffect = false;
            siticonePanel1.EnableMicaEffect = false;
            siticonePanel1.EnableRippleEffect = false;
            siticonePanel1.FillColor = Color.White;
            siticonePanel1.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            siticonePanel1.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            siticonePanel1.Location = new Point(552, 120);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.PatternColor = Color.FromArgb(30, 0, 0, 0);
            siticonePanel1.PatternStyle = HatchStyle.Max;
            siticonePanel1.RippleAlpha = 50;
            siticonePanel1.RippleAlphaDecrement = 3;
            siticonePanel1.RippleColor = Color.FromArgb(50, 255, 255, 255);
            siticonePanel1.RippleMaxSize = 600F;
            siticonePanel1.RippleSpeed = 15F;
            siticonePanel1.ShowBorder = true;
            siticonePanel1.Size = new Size(528, 68);
            siticonePanel1.TabIndex = 42;
            siticonePanel1.TabStop = true;
            siticonePanel1.UseBorderGradient = false;
            siticonePanel1.UseMultiGradient = false;
            siticonePanel1.UsePatternTexture = false;
            siticonePanel1.UseRadialGradient = false;
            // 
            // pnlTable
            // 
            pnlTable.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            pnlTable.BackColor = Color.Transparent;
            pnlTable.BorderAlignment = PenAlignment.Center;
            pnlTable.BorderColor = Color.FromArgb(210, 210, 210);
            pnlTable.BorderDashPattern = null;
            pnlTable.BorderGradientEndColor = Color.Purple;
            pnlTable.BorderGradientStartColor = Color.Blue;
            pnlTable.BorderThickness = 2F;
            pnlTable.Controls.Add(dgv);
            pnlTable.CornerRadiusBottomLeft = 25F;
            pnlTable.CornerRadiusBottomRight = 25F;
            pnlTable.CornerRadiusTopLeft = 25F;
            pnlTable.CornerRadiusTopRight = 25F;
            pnlTable.EnableAcrylicEffect = false;
            pnlTable.EnableMicaEffect = false;
            pnlTable.EnableRippleEffect = false;
            pnlTable.FillColor = Color.White;
            pnlTable.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            pnlTable.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            pnlTable.Location = new Point(42, 212);
            pnlTable.Name = "pnlTable";
            pnlTable.PatternColor = Color.FromArgb(30, 0, 0, 0);
            pnlTable.PatternStyle = HatchStyle.Max;
            pnlTable.RippleAlpha = 50;
            pnlTable.RippleAlphaDecrement = 3;
            pnlTable.RippleColor = Color.FromArgb(50, 255, 255, 255);
            pnlTable.RippleMaxSize = 600F;
            pnlTable.RippleSpeed = 15F;
            pnlTable.ShowBorder = true;
            pnlTable.Size = new Size(1038, 554);
            pnlTable.TabIndex = 63;
            pnlTable.TabStop = true;
            pnlTable.UseBorderGradient = false;
            pnlTable.UseMultiGradient = false;
            pnlTable.UsePatternTexture = false;
            pnlTable.UseRadialGradient = false;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(21, 14);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1001, 521);
            dgv.TabIndex = 26;
            // 
            // btnReassign
            // 
            btnReassign.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnReassign.AccessibleName = "Reassign";
            btnReassign.BadgeBackColor = Color.Black;
            btnReassign.BadgeBorderColor = Color.Empty;
            btnReassign.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnReassign.BadgeValueForeColor = Color.White;
            btnReassign.BorderColor = Color.FromArgb(15, 76, 76);
            btnReassign.BorderWidth = 2;
            btnReassign.BusyIndicatorColor = Color.Empty;
            btnReassign.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnReassign.CornerRadiusBottomLeft = 24;
            btnReassign.CornerRadiusBottomRight = 24;
            btnReassign.CornerRadiusTopLeft = 24;
            btnReassign.CornerRadiusTopRight = 24;
            btnReassign.CustomCursor = Cursors.Default;
            btnReassign.DisabledBackColor = Color.Empty;
            btnReassign.DisabledBorderColor = Color.Empty;
            btnReassign.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnReassign.FocusRingColor = Color.Empty;
            btnReassign.Font = new Font("Segoe UI Semibold", 10.2F);
            btnReassign.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnReassign.GradientColor = Color.FromArgb(0, 227, 64);
            btnReassign.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnReassign.HoverBorderColor = Color.Empty;
            btnReassign.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnReassign.ImageSize = new Size(16, 16);
            btnReassign.IsRadial = true;
            btnReassign.Location = new Point(668, 794);
            btnReassign.Margin = new Padding(6, 3, 3, 3);
            btnReassign.Name = "btnReassign";
            btnReassign.ParticleColor = Color.FromArgb(200, 200, 200);
            btnReassign.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnReassign.PressedBorderColor = Color.Empty;
            btnReassign.PressedTextColor = Color.Empty;
            btnReassign.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnReassign.RippleColor = Color.FromArgb(0, 0, 0);
            btnReassign.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnReassign.ShadowOffset = new Point(0, 2);
            btnReassign.Size = new Size(127, 52);
            btnReassign.TabIndex = 64;
            btnReassign.Text = "Reassign";
            btnReassign.TextColor = Color.FromArgb(0, 0, 0);
            btnReassign.ToggledBackColor = Color.Empty;
            btnReassign.ToggledBorderColor = Color.Empty;
            btnReassign.ToggledTextColor = Color.Empty;
            btnReassign.Click += btnReassign_Click;
            // 
            // AppointmentsScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReassign);
            Controls.Add(btnCancel);
            Controls.Add(btnComplete);
            Controls.Add(pnlTable);
            Controls.Add(btnApprove);
            Controls.Add(btnDecline);
            Controls.Add(siticonePanel1);
            Controls.Add(lblDate);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(siticoneLabel3);
            Name = "AppointmentsScreen";
            Size = new Size(1136, 899);
            tableLayoutPanel2.ResumeLayout(false);
            siticonePanel1.ResumeLayout(false);
            pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SiticoneLabel siticoneLabel3;
        private SiticoneButton btnPrev;
        private SiticoneButton btnNext;
        private SiticoneLabel lblDate;
        private SiticoneButton btnCancel;
        private SiticoneButton btnDecline;
        private SiticoneButton btnApprove;
        private TableLayoutPanel tableLayoutPanel2;
        private SiticoneButton btnApproved;
        private SiticoneButton btnAll;
        private SiticoneButton btnCompleted;
        private SiticoneButton btnPending;
        private SiticonePanel siticonePanel1;
        private SiticoneButton btnComplete;
        private SiticonePanel pnlTable;
        private DataGridView dgv;
        private SiticoneButton btnReassign;
    }
}
