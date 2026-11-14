namespace medicord_v1.Screens.Patient
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
            siticoneLabel4 = new SiticoneLabel();
            btnBook = new SiticoneButtonAdvanced();
            lblEmpty = new SiticoneLabel();
            siticonePanel1 = new SiticonePanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnUpcoming = new SiticoneButton();
            btnPast = new SiticoneButton();
            flowList = new FlowLayoutPanel();
            siticonePanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // siticoneLabel4
            // 
            siticoneLabel4.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel4.ForeColor = Color.Black;
            siticoneLabel4.Location = new Point(39, 16);
            siticoneLabel4.Name = "siticoneLabel4";
            siticoneLabel4.Size = new Size(335, 56);
            siticoneLabel4.TabIndex = 21;
            siticoneLabel4.Text = "Appointments";
            siticoneLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.Transparent;
            btnBook.BadgeBackColor = Color.Red;
            btnBook.BadgeForeColor = Color.White;
            btnBook.BadgeRadius = 8;
            btnBook.BadgeRightMargin = 10;
            btnBook.BadgeValue = 0;
            btnBook.BorderColor = Color.FromArgb(15, 76, 76);
            btnBook.BorderColorEnd = Color.Gray;
            btnBook.BorderColorStart = Color.White;
            btnBook.BorderRadiusBottomLeft = 30;
            btnBook.BorderRadiusBottomRight = 30;
            btnBook.BorderRadiusTopLeft = 30;
            btnBook.BorderRadiusTopRight = 30;
            btnBook.BorderThickness = 0;
            btnBook.ButtonColorEnd = Color.FromArgb(15, 76, 76);
            btnBook.ButtonColorStart = Color.FromArgb(15, 76, 76);
            btnBook.ButtonImage = (Image)resources.GetObject("btnBook.ButtonImage");
            btnBook.CanBeep = false;
            btnBook.CanShake = false;
            btnBook.ClickSoundPath = null;
            btnBook.DisabledOverlayOpacity = 0.5F;
            btnBook.EnableBorderGradient = false;
            btnBook.EnableClickSound = false;
            btnBook.EnableFocusBorder = false;
            btnBook.EnableHoverSound = false;
            btnBook.EnablePressScale = false;
            btnBook.EnableTextShadow = false;
            btnBook.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnBook.FocusBorderThickness = 2;
            btnBook.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBook.ForeColor = SystemColors.Control;
            btnBook.HoverColor = Color.FromArgb(78, 127, 122);
            btnBook.HoverSoundPath = null;
            btnBook.HoverTransitionSpeed = 0.08F;
            btnBook.ImageAlign = ContentAlignment.MiddleCenter;
            btnBook.ImageLeftMargin = 0;
            btnBook.ImageRightMargin = 0;
            btnBook.ImageSize = 30;
            btnBook.IsReadOnly = false;
            btnBook.Location = new Point(416, 700);
            btnBook.MakeRadial = true;
            btnBook.Name = "btnBook";
            btnBook.PressAnimationSpeed = 0.2F;
            btnBook.PressDepth = 1;
            btnBook.RippleColor = Color.FromArgb(231, 243, 239);
            btnBook.RippleExpandSpeedFactor = 0.05F;
            btnBook.RippleFadeSpeedFactor = 0.03F;
            btnBook.ShadowBlurFactor = 0.85F;
            btnBook.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnBook.ShadowOffsetX = 3;
            btnBook.ShadowOffsetY = 3;
            btnBook.Size = new Size(76, 75);
            btnBook.TabIndex = 13;
            btnBook.TextAlign = ContentAlignment.MiddleCenter;
            btnBook.TextPaddingBottom = 0;
            btnBook.TextPaddingLeft = 0;
            btnBook.TextPaddingRight = 0;
            btnBook.TextPaddingTop = 0;
            btnBook.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnBook.TextShadowOffsetX = 1;
            btnBook.TextShadowOffsetY = 1;
            btnBook.Click += btnBook_Click;
            // 
            // lblEmpty
            // 
            lblEmpty.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpty.ForeColor = Color.Black;
            lblEmpty.Location = new Point(75, 191);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new Size(352, 44);
            lblEmpty.TabIndex = 33;
            lblEmpty.Text = "No appointments in your record.";
            lblEmpty.TextAlign = ContentAlignment.MiddleCenter;
            lblEmpty.Visible = false;
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
            siticonePanel1.Location = new Point(39, 91);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.PatternColor = Color.FromArgb(30, 0, 0, 0);
            siticonePanel1.PatternStyle = HatchStyle.Max;
            siticonePanel1.RippleAlpha = 50;
            siticonePanel1.RippleAlphaDecrement = 3;
            siticonePanel1.RippleColor = Color.FromArgb(50, 255, 255, 255);
            siticonePanel1.RippleMaxSize = 600F;
            siticonePanel1.RippleSpeed = 15F;
            siticonePanel1.ShowBorder = true;
            siticonePanel1.Size = new Size(427, 62);
            siticonePanel1.TabIndex = 63;
            siticonePanel1.TabStop = true;
            siticonePanel1.UseBorderGradient = false;
            siticonePanel1.UseMultiGradient = false;
            siticonePanel1.UsePatternTexture = false;
            siticonePanel1.UseRadialGradient = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnUpcoming, 0, 0);
            tableLayoutPanel2.Controls.Add(btnPast, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(3);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(422, 58);
            tableLayoutPanel2.TabIndex = 41;
            // 
            // btnUpcoming
            // 
            btnUpcoming.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnUpcoming.AccessibleName = "Upcoming";
            btnUpcoming.BadgeBackColor = Color.Black;
            btnUpcoming.BadgeBorderColor = Color.Empty;
            btnUpcoming.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnUpcoming.BadgeValueForeColor = Color.White;
            btnUpcoming.BorderColor = Color.FromArgb(15, 76, 76);
            btnUpcoming.BorderWidth = 0;
            btnUpcoming.BusyIndicatorColor = Color.Empty;
            btnUpcoming.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnUpcoming.CornerRadiusBottomLeft = 21;
            btnUpcoming.CornerRadiusBottomRight = 21;
            btnUpcoming.CornerRadiusTopLeft = 21;
            btnUpcoming.CornerRadiusTopRight = 21;
            btnUpcoming.CustomCursor = Cursors.Default;
            btnUpcoming.DisabledBackColor = Color.Empty;
            btnUpcoming.DisabledBorderColor = Color.Empty;
            btnUpcoming.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnUpcoming.Dock = DockStyle.Fill;
            btnUpcoming.FocusRingColor = Color.Empty;
            btnUpcoming.Font = new Font("Segoe UI Semibold", 10.2F);
            btnUpcoming.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnUpcoming.GradientColor = Color.FromArgb(0, 227, 64);
            btnUpcoming.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnUpcoming.HoverBorderColor = Color.Empty;
            btnUpcoming.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnUpcoming.ImageSize = new Size(16, 16);
            btnUpcoming.IsRadial = true;
            btnUpcoming.Location = new Point(6, 6);
            btnUpcoming.Margin = new Padding(3, 3, 6, 3);
            btnUpcoming.Name = "btnUpcoming";
            btnUpcoming.ParticleColor = Color.FromArgb(200, 200, 200);
            btnUpcoming.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnUpcoming.PressedBorderColor = Color.Empty;
            btnUpcoming.PressedTextColor = Color.Empty;
            btnUpcoming.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnUpcoming.RippleColor = Color.FromArgb(0, 0, 0);
            btnUpcoming.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnUpcoming.ShadowOffset = new Point(0, 2);
            btnUpcoming.Size = new Size(199, 46);
            btnUpcoming.TabIndex = 41;
            btnUpcoming.Text = "Upcoming";
            btnUpcoming.TextColor = Color.FromArgb(0, 0, 0);
            btnUpcoming.ToggledBackColor = Color.Empty;
            btnUpcoming.ToggledBorderColor = Color.Empty;
            btnUpcoming.ToggledTextColor = Color.Empty;
            // 
            // btnPast
            // 
            btnPast.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnPast.AccessibleName = "Past";
            btnPast.BadgeBackColor = Color.Black;
            btnPast.BadgeBorderColor = Color.Empty;
            btnPast.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnPast.BadgeValueForeColor = Color.White;
            btnPast.BorderColor = Color.FromArgb(15, 76, 76);
            btnPast.BorderWidth = 0;
            btnPast.BusyIndicatorColor = Color.Empty;
            btnPast.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnPast.CornerRadiusBottomLeft = 21;
            btnPast.CornerRadiusBottomRight = 21;
            btnPast.CornerRadiusTopLeft = 21;
            btnPast.CornerRadiusTopRight = 21;
            btnPast.CustomCursor = Cursors.Default;
            btnPast.DisabledBackColor = Color.Empty;
            btnPast.DisabledBorderColor = Color.Empty;
            btnPast.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnPast.Dock = DockStyle.Fill;
            btnPast.FocusRingColor = Color.Empty;
            btnPast.Font = new Font("Segoe UI Semibold", 10.2F);
            btnPast.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnPast.GradientColor = Color.FromArgb(0, 227, 64);
            btnPast.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnPast.HoverBorderColor = Color.Empty;
            btnPast.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnPast.ImageSize = new Size(16, 16);
            btnPast.IsRadial = true;
            btnPast.Location = new Point(217, 6);
            btnPast.Margin = new Padding(6, 3, 3, 3);
            btnPast.Name = "btnPast";
            btnPast.ParticleColor = Color.FromArgb(200, 200, 200);
            btnPast.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnPast.PressedBorderColor = Color.Empty;
            btnPast.PressedTextColor = Color.Empty;
            btnPast.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnPast.RippleColor = Color.FromArgb(0, 0, 0);
            btnPast.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnPast.ShadowOffset = new Point(0, 2);
            btnPast.Size = new Size(199, 46);
            btnPast.TabIndex = 42;
            btnPast.Text = "Past";
            btnPast.TextColor = Color.FromArgb(0, 0, 0);
            btnPast.ToggledBackColor = Color.Empty;
            btnPast.ToggledBorderColor = Color.Empty;
            btnPast.ToggledTextColor = Color.Empty;
            // 
            // flowList
            // 
            flowList.AutoScroll = true;
            flowList.FlowDirection = FlowDirection.TopDown;
            flowList.Location = new Point(47, 176);
            flowList.Name = "flowList";
            flowList.Size = new Size(436, 599);
            flowList.TabIndex = 64;
            flowList.WrapContents = false;
            // 
            // AppointmentsScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBook);
            Controls.Add(lblEmpty);
            Controls.Add(flowList);
            Controls.Add(siticonePanel1);
            Controls.Add(siticoneLabel4);
            Name = "AppointmentsScreen";
            Size = new Size(522, 779);
            siticonePanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SiticoneLabel siticoneLabel4;
        private SiticoneButtonAdvanced btnBook;
        private SiticoneLabel lblEmpty;
        private SiticonePanel siticonePanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private SiticoneButton btnUpcoming;
        private SiticoneButton btnPast;
        private FlowLayoutPanel flowList;
    }
}
