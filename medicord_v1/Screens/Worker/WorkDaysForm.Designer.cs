namespace medicord_v1.Screens.Worker
{
    partial class WorkDaysForm
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
            lblName = new SiticoneLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSun = new SiticoneButton();
            btnSat = new SiticoneButton();
            btnFri = new SiticoneButton();
            btnThu = new SiticoneButton();
            btnWed = new SiticoneButton();
            btnTue = new SiticoneButton();
            btnMon = new SiticoneButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnCancel = new SiticoneButton();
            btnSave = new SiticoneButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ActiveCaptionText;
            lblName.Location = new Point(304, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(206, 42);
            lblName.TabIndex = 39;
            lblName.Text = "[Worker Name]";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.29F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.29F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.29F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.29F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28F));
            tableLayoutPanel1.Controls.Add(btnSun, 6, 0);
            tableLayoutPanel1.Controls.Add(btnSat, 5, 0);
            tableLayoutPanel1.Controls.Add(btnFri, 4, 0);
            tableLayoutPanel1.Controls.Add(btnThu, 3, 0);
            tableLayoutPanel1.Controls.Add(btnWed, 2, 0);
            tableLayoutPanel1.Controls.Add(btnTue, 1, 0);
            tableLayoutPanel1.Controls.Add(btnMon, 0, 0);
            tableLayoutPanel1.Location = new Point(49, 109);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(710, 57);
            tableLayoutPanel1.TabIndex = 55;
            // 
            // btnSun
            // 
            btnSun.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnSun.AccessibleName = "Sun";
            btnSun.BadgeBackColor = Color.Black;
            btnSun.BadgeBorderColor = Color.Empty;
            btnSun.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnSun.BadgeValueForeColor = Color.White;
            btnSun.BorderColor = Color.FromArgb(213, 216, 220);
            btnSun.BusyIndicatorColor = Color.Empty;
            btnSun.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnSun.CustomCursor = Cursors.Default;
            btnSun.DisabledBackColor = Color.Empty;
            btnSun.DisabledBorderColor = Color.Empty;
            btnSun.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnSun.Dock = DockStyle.Fill;
            btnSun.FocusRingColor = Color.Empty;
            btnSun.Font = new Font("Segoe UI Semibold", 10.2F);
            btnSun.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnSun.GradientColor = Color.FromArgb(0, 227, 64);
            btnSun.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnSun.HoverBorderColor = Color.Empty;
            btnSun.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnSun.ImageSize = new Size(16, 16);
            btnSun.Location = new Point(609, 3);
            btnSun.Name = "btnSun";
            btnSun.ParticleColor = Color.FromArgb(200, 200, 200);
            btnSun.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnSun.PressedBorderColor = Color.Empty;
            btnSun.PressedTextColor = Color.Empty;
            btnSun.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnSun.RippleColor = Color.FromArgb(0, 0, 0);
            btnSun.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnSun.ShadowOffset = new Point(0, 2);
            btnSun.Size = new Size(98, 51);
            btnSun.TabIndex = 61;
            btnSun.Text = "Sun";
            btnSun.TextColor = Color.FromArgb(0, 0, 0);
            btnSun.ToggledBackColor = Color.FromArgb(15, 76, 76);
            btnSun.ToggledBorderColor = Color.Empty;
            btnSun.ToggledTextColor = Color.Empty;
            // 
            // btnSat
            // 
            btnSat.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnSat.AccessibleName = "Sat";
            btnSat.BadgeBackColor = Color.Black;
            btnSat.BadgeBorderColor = Color.Empty;
            btnSat.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnSat.BadgeValueForeColor = Color.White;
            btnSat.BorderColor = Color.FromArgb(213, 216, 220);
            btnSat.BusyIndicatorColor = Color.Empty;
            btnSat.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnSat.CustomCursor = Cursors.Default;
            btnSat.DisabledBackColor = Color.Empty;
            btnSat.DisabledBorderColor = Color.Empty;
            btnSat.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnSat.Dock = DockStyle.Fill;
            btnSat.FocusRingColor = Color.Empty;
            btnSat.Font = new Font("Segoe UI Semibold", 10.2F);
            btnSat.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnSat.GradientColor = Color.FromArgb(0, 227, 64);
            btnSat.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnSat.HoverBorderColor = Color.Empty;
            btnSat.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnSat.ImageSize = new Size(16, 16);
            btnSat.Location = new Point(508, 3);
            btnSat.Name = "btnSat";
            btnSat.ParticleColor = Color.FromArgb(200, 200, 200);
            btnSat.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnSat.PressedBorderColor = Color.Empty;
            btnSat.PressedTextColor = Color.Empty;
            btnSat.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnSat.RippleColor = Color.FromArgb(0, 0, 0);
            btnSat.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnSat.ShadowOffset = new Point(0, 2);
            btnSat.Size = new Size(95, 51);
            btnSat.TabIndex = 60;
            btnSat.Text = "Sat";
            btnSat.TextColor = Color.FromArgb(0, 0, 0);
            btnSat.ToggledBackColor = Color.FromArgb(15, 76, 76);
            btnSat.ToggledBorderColor = Color.Empty;
            btnSat.ToggledTextColor = Color.Empty;
            // 
            // btnFri
            // 
            btnFri.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnFri.AccessibleName = "Fri";
            btnFri.BadgeBackColor = Color.Black;
            btnFri.BadgeBorderColor = Color.Empty;
            btnFri.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnFri.BadgeValueForeColor = Color.White;
            btnFri.BorderColor = Color.FromArgb(213, 216, 220);
            btnFri.BusyIndicatorColor = Color.Empty;
            btnFri.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnFri.CustomCursor = Cursors.Default;
            btnFri.DisabledBackColor = Color.Empty;
            btnFri.DisabledBorderColor = Color.Empty;
            btnFri.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnFri.Dock = DockStyle.Fill;
            btnFri.FocusRingColor = Color.Empty;
            btnFri.Font = new Font("Segoe UI Semibold", 10.2F);
            btnFri.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnFri.GradientColor = Color.FromArgb(0, 227, 64);
            btnFri.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnFri.HoverBorderColor = Color.Empty;
            btnFri.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnFri.ImageSize = new Size(16, 16);
            btnFri.Location = new Point(407, 3);
            btnFri.Name = "btnFri";
            btnFri.ParticleColor = Color.FromArgb(200, 200, 200);
            btnFri.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnFri.PressedBorderColor = Color.Empty;
            btnFri.PressedTextColor = Color.Empty;
            btnFri.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnFri.RippleColor = Color.FromArgb(0, 0, 0);
            btnFri.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnFri.ShadowOffset = new Point(0, 2);
            btnFri.Size = new Size(95, 51);
            btnFri.TabIndex = 59;
            btnFri.Text = "Fri";
            btnFri.TextColor = Color.FromArgb(0, 0, 0);
            btnFri.ToggledBackColor = Color.FromArgb(15, 76, 76);
            btnFri.ToggledBorderColor = Color.Empty;
            btnFri.ToggledTextColor = Color.Empty;
            // 
            // btnThu
            // 
            btnThu.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnThu.AccessibleName = "Thu";
            btnThu.BadgeBackColor = Color.Black;
            btnThu.BadgeBorderColor = Color.Empty;
            btnThu.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnThu.BadgeValueForeColor = Color.White;
            btnThu.BorderColor = Color.FromArgb(213, 216, 220);
            btnThu.BusyIndicatorColor = Color.Empty;
            btnThu.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnThu.CustomCursor = Cursors.Default;
            btnThu.DisabledBackColor = Color.Empty;
            btnThu.DisabledBorderColor = Color.Empty;
            btnThu.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnThu.Dock = DockStyle.Fill;
            btnThu.FocusRingColor = Color.Empty;
            btnThu.Font = new Font("Segoe UI Semibold", 10.2F);
            btnThu.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnThu.GradientColor = Color.FromArgb(0, 227, 64);
            btnThu.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnThu.HoverBorderColor = Color.Empty;
            btnThu.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnThu.ImageSize = new Size(16, 16);
            btnThu.Location = new Point(306, 3);
            btnThu.Name = "btnThu";
            btnThu.ParticleColor = Color.FromArgb(200, 200, 200);
            btnThu.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnThu.PressedBorderColor = Color.Empty;
            btnThu.PressedTextColor = Color.Empty;
            btnThu.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnThu.RippleColor = Color.FromArgb(0, 0, 0);
            btnThu.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnThu.ShadowOffset = new Point(0, 2);
            btnThu.Size = new Size(95, 51);
            btnThu.TabIndex = 58;
            btnThu.Text = "Thu";
            btnThu.TextColor = Color.FromArgb(0, 0, 0);
            btnThu.ToggledBackColor = Color.FromArgb(15, 76, 76);
            btnThu.ToggledBorderColor = Color.Empty;
            btnThu.ToggledTextColor = Color.Empty;
            // 
            // btnWed
            // 
            btnWed.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnWed.AccessibleName = "Wed";
            btnWed.BadgeBackColor = Color.Black;
            btnWed.BadgeBorderColor = Color.Empty;
            btnWed.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnWed.BadgeValueForeColor = Color.White;
            btnWed.BorderColor = Color.FromArgb(213, 216, 220);
            btnWed.BusyIndicatorColor = Color.Empty;
            btnWed.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnWed.CustomCursor = Cursors.Default;
            btnWed.DisabledBackColor = Color.Empty;
            btnWed.DisabledBorderColor = Color.Empty;
            btnWed.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnWed.Dock = DockStyle.Fill;
            btnWed.FocusRingColor = Color.Empty;
            btnWed.Font = new Font("Segoe UI Semibold", 10.2F);
            btnWed.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnWed.GradientColor = Color.FromArgb(0, 227, 64);
            btnWed.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnWed.HoverBorderColor = Color.Empty;
            btnWed.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnWed.ImageSize = new Size(16, 16);
            btnWed.Location = new Point(205, 3);
            btnWed.Name = "btnWed";
            btnWed.ParticleColor = Color.FromArgb(200, 200, 200);
            btnWed.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnWed.PressedBorderColor = Color.Empty;
            btnWed.PressedTextColor = Color.Empty;
            btnWed.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnWed.RippleColor = Color.FromArgb(0, 0, 0);
            btnWed.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnWed.ShadowOffset = new Point(0, 2);
            btnWed.Size = new Size(95, 51);
            btnWed.TabIndex = 57;
            btnWed.Text = "Wed";
            btnWed.TextColor = Color.FromArgb(0, 0, 0);
            btnWed.ToggledBackColor = Color.FromArgb(15, 76, 76);
            btnWed.ToggledBorderColor = Color.Empty;
            btnWed.ToggledTextColor = Color.Empty;
            // 
            // btnTue
            // 
            btnTue.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnTue.AccessibleName = "Tue";
            btnTue.BadgeBackColor = Color.Black;
            btnTue.BadgeBorderColor = Color.Empty;
            btnTue.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnTue.BadgeValueForeColor = Color.White;
            btnTue.BorderColor = Color.FromArgb(213, 216, 220);
            btnTue.BusyIndicatorColor = Color.Empty;
            btnTue.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnTue.CustomCursor = Cursors.Default;
            btnTue.DisabledBackColor = Color.Empty;
            btnTue.DisabledBorderColor = Color.Empty;
            btnTue.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnTue.Dock = DockStyle.Fill;
            btnTue.FocusRingColor = Color.Empty;
            btnTue.Font = new Font("Segoe UI Semibold", 10.2F);
            btnTue.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnTue.GradientColor = Color.FromArgb(0, 227, 64);
            btnTue.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnTue.HoverBorderColor = Color.Empty;
            btnTue.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnTue.ImageSize = new Size(16, 16);
            btnTue.Location = new Point(104, 3);
            btnTue.Name = "btnTue";
            btnTue.ParticleColor = Color.FromArgb(200, 200, 200);
            btnTue.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnTue.PressedBorderColor = Color.Empty;
            btnTue.PressedTextColor = Color.Empty;
            btnTue.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnTue.RippleColor = Color.FromArgb(0, 0, 0);
            btnTue.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnTue.ShadowOffset = new Point(0, 2);
            btnTue.Size = new Size(95, 51);
            btnTue.TabIndex = 56;
            btnTue.Text = "Tue";
            btnTue.TextColor = Color.FromArgb(0, 0, 0);
            btnTue.ToggledBackColor = Color.FromArgb(15, 76, 76);
            btnTue.ToggledBorderColor = Color.Empty;
            btnTue.ToggledTextColor = Color.Empty;
            // 
            // btnMon
            // 
            btnMon.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnMon.AccessibleName = "Mon";
            btnMon.BadgeBackColor = Color.Black;
            btnMon.BadgeBorderColor = Color.Empty;
            btnMon.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnMon.BadgeValueForeColor = Color.White;
            btnMon.BorderColor = Color.FromArgb(213, 216, 220);
            btnMon.BusyIndicatorColor = Color.Empty;
            btnMon.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnMon.CustomCursor = Cursors.Default;
            btnMon.DisabledBackColor = Color.Empty;
            btnMon.DisabledBorderColor = Color.Empty;
            btnMon.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnMon.Dock = DockStyle.Fill;
            btnMon.FocusRingColor = Color.Empty;
            btnMon.Font = new Font("Segoe UI Semibold", 10.2F);
            btnMon.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnMon.GradientColor = Color.FromArgb(0, 227, 64);
            btnMon.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnMon.HoverBorderColor = Color.Empty;
            btnMon.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnMon.ImageSize = new Size(16, 16);
            btnMon.Location = new Point(3, 3);
            btnMon.Name = "btnMon";
            btnMon.ParticleColor = Color.FromArgb(200, 200, 200);
            btnMon.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnMon.PressedBorderColor = Color.Empty;
            btnMon.PressedTextColor = Color.Empty;
            btnMon.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnMon.RippleColor = Color.FromArgb(0, 0, 0);
            btnMon.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnMon.ShadowOffset = new Point(0, 2);
            btnMon.Size = new Size(95, 51);
            btnMon.TabIndex = 55;
            btnMon.Text = "Mon";
            btnMon.TextColor = Color.FromArgb(0, 0, 0);
            btnMon.ToggledBackColor = Color.FromArgb(15, 76, 76);
            btnMon.ToggledBorderColor = Color.Empty;
            btnMon.ToggledTextColor = Color.Empty;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.Controls.Add(btnCancel, 0, 0);
            tableLayoutPanel2.Controls.Add(btnSave, 1, 0);
            tableLayoutPanel2.Location = new Point(243, 200);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(308, 58);
            tableLayoutPanel2.TabIndex = 67;
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
            btnCancel.Size = new Size(114, 52);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = Color.FromArgb(0, 0, 0);
            btnCancel.ToggledBackColor = Color.Empty;
            btnCancel.ToggledBorderColor = Color.Empty;
            btnCancel.ToggledTextColor = Color.Empty;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnSave.AccessibleName = "Save changes";
            btnSave.BadgeBackColor = Color.Black;
            btnSave.BadgeBorderColor = Color.Empty;
            btnSave.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnSave.BadgeValueForeColor = Color.White;
            btnSave.BorderColor = Color.FromArgb(15, 76, 76);
            btnSave.BorderWidth = 2;
            btnSave.BusyIndicatorColor = Color.Empty;
            btnSave.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnSave.CornerRadiusBottomLeft = 24;
            btnSave.CornerRadiusBottomRight = 24;
            btnSave.CornerRadiusTopLeft = 24;
            btnSave.CornerRadiusTopRight = 24;
            btnSave.CustomCursor = Cursors.Default;
            btnSave.DisabledBackColor = Color.Empty;
            btnSave.DisabledBorderColor = Color.Empty;
            btnSave.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnSave.Dock = DockStyle.Fill;
            btnSave.FocusRingColor = Color.Empty;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F);
            btnSave.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnSave.GradientColor = Color.FromArgb(0, 227, 64);
            btnSave.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnSave.HoverBorderColor = Color.Empty;
            btnSave.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnSave.ImageSize = new Size(16, 16);
            btnSave.IsRadial = true;
            btnSave.Location = new Point(129, 3);
            btnSave.Margin = new Padding(6, 3, 3, 3);
            btnSave.Name = "btnSave";
            btnSave.ParticleColor = Color.FromArgb(200, 200, 200);
            btnSave.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnSave.PressedBorderColor = Color.Empty;
            btnSave.PressedTextColor = Color.Empty;
            btnSave.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnSave.RippleColor = Color.FromArgb(0, 0, 0);
            btnSave.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnSave.ShadowOffset = new Point(0, 2);
            btnSave.Size = new Size(176, 52);
            btnSave.TabIndex = 40;
            btnSave.Text = "Save changes";
            btnSave.TextColor = Color.FromArgb(0, 0, 0);
            btnSave.ToggledBackColor = Color.Empty;
            btnSave.ToggledBorderColor = Color.Empty;
            btnSave.ToggledTextColor = Color.Empty;
            btnSave.Click += btnSave_Click;
            // 
            // WorkDaysForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 289);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WorkDaysForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Worker's Workdays";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneLabel lblName;
        private TableLayoutPanel tableLayoutPanel1;
        private SiticoneButton btnSun;
        private SiticoneButton btnSat;
        private SiticoneButton btnFri;
        private SiticoneButton btnThu;
        private SiticoneButton btnWed;
        private SiticoneButton btnTue;
        private SiticoneButton btnMon;
        private TableLayoutPanel tableLayoutPanel2;
        private SiticoneButton btnCancel;
        private SiticoneButton btnSave;
    }
}