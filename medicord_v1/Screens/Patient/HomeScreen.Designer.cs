namespace medicord_v1.Screens.Patient
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            lblGreetingName = new SiticoneLabel();
            lblGreeting = new SiticoneLabel();
            siticoneLabel1 = new SiticoneLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            siticoneAdvancedPanel3 = new SiticoneAdvancedPanel();
            btnNearby = new SiticoneButtonAdvanced();
            siticoneLabel5 = new SiticoneLabel();
            siticoneAdvancedPanel2 = new SiticoneAdvancedPanel();
            btnRecords = new SiticoneButtonAdvanced();
            siticoneLabel4 = new SiticoneLabel();
            siticoneAdvancedPanel1 = new SiticoneAdvancedPanel();
            btnBook = new SiticoneButtonAdvanced();
            siticoneLabel2 = new SiticoneLabel();
            siticoneLabel6 = new SiticoneLabel();
            flowRecords = new FlowLayoutPanel();
            lblNoRecords = new SiticoneLabel();
            pnlNext = new SiticonePanel();
            tableLayoutPanel1.SuspendLayout();
            siticoneAdvancedPanel3.SuspendLayout();
            siticoneAdvancedPanel2.SuspendLayout();
            siticoneAdvancedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblGreetingName
            // 
            lblGreetingName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreetingName.ForeColor = Color.FromArgb(15, 76, 76);
            lblGreetingName.Location = new Point(36, 54);
            lblGreetingName.Name = "lblGreetingName";
            lblGreetingName.Size = new Size(444, 54);
            lblGreetingName.TabIndex = 17;
            lblGreetingName.Text = "user's name";
            lblGreetingName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblGreeting
            // 
            lblGreeting.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreeting.ForeColor = Color.Black;
            lblGreeting.Location = new Point(36, 15);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(352, 44);
            lblGreeting.TabIndex = 18;
            lblGreeting.Text = "Good day,";
            lblGreeting.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // siticoneLabel1
            // 
            siticoneLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel1.ForeColor = Color.Black;
            siticoneLabel1.Location = new Point(36, 104);
            siticoneLabel1.Name = "siticoneLabel1";
            siticoneLabel1.Size = new Size(352, 44);
            siticoneLabel1.TabIndex = 19;
            siticoneLabel1.Text = "How can we help today?";
            siticoneLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(siticoneAdvancedPanel3, 2, 0);
            tableLayoutPanel1.Controls.Add(siticoneAdvancedPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(siticoneAdvancedPanel1, 0, 0);
            tableLayoutPanel1.Location = new Point(36, 318);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(452, 145);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // siticoneAdvancedPanel3
            // 
            siticoneAdvancedPanel3.ActiveBackColor = Color.Empty;
            siticoneAdvancedPanel3.ActiveBorderColor = Color.Empty;
            siticoneAdvancedPanel3.AnimationDuration = 500;
            siticoneAdvancedPanel3.AnimationType = SiticoneAdvancedPanel.AnimationTypeEx.Fade;
            siticoneAdvancedPanel3.BackgroundImageCustom = null;
            siticoneAdvancedPanel3.BackgroundImageOpacity = 1F;
            siticoneAdvancedPanel3.BackgroundImageSizeMode = SiticoneAdvancedPanel.ImageSizeModeEx.Stretch;
            siticoneAdvancedPanel3.BackgroundOverlayColor = Color.FromArgb(0, 0, 0, 0);
            siticoneAdvancedPanel3.BorderDashPattern = null;
            siticoneAdvancedPanel3.BorderGlowColor = Color.Cyan;
            siticoneAdvancedPanel3.BorderGlowSize = 3F;
            siticoneAdvancedPanel3.BottomLeftRadius = 20;
            siticoneAdvancedPanel3.BottomRightRadius = 20;
            siticoneAdvancedPanel3.ContentAlignmentCustom = ContentAlignment.MiddleCenter;
            siticoneAdvancedPanel3.Controls.Add(btnNearby);
            siticoneAdvancedPanel3.Controls.Add(siticoneLabel5);
            siticoneAdvancedPanel3.CornerPadding = new Padding(5);
            siticoneAdvancedPanel3.DisabledBackColor = Color.Empty;
            siticoneAdvancedPanel3.DisabledBorderColor = Color.Empty;
            siticoneAdvancedPanel3.Dock = DockStyle.Fill;
            siticoneAdvancedPanel3.DoubleBorderSpacing = 2F;
            siticoneAdvancedPanel3.EasingType = SiticoneAdvancedPanel.EasingTypeEx.Linear;
            siticoneAdvancedPanel3.EnableAnimation = false;
            siticoneAdvancedPanel3.EnableBackgroundImage = false;
            siticoneAdvancedPanel3.EnableBorderGlow = false;
            siticoneAdvancedPanel3.EnableDoubleBorder = false;
            siticoneAdvancedPanel3.EnableGradient = false;
            siticoneAdvancedPanel3.EnableInnerShadow = false;
            siticoneAdvancedPanel3.EnableShadow = false;
            siticoneAdvancedPanel3.EnableSmartPadding = true;
            siticoneAdvancedPanel3.EnableStateStyles = false;
            siticoneAdvancedPanel3.FlowDirectionCustom = FlowDirection.LeftToRight;
            siticoneAdvancedPanel3.GradientAngle = 90F;
            siticoneAdvancedPanel3.GradientEndColor = Color.LightGray;
            siticoneAdvancedPanel3.GradientStartColor = Color.White;
            siticoneAdvancedPanel3.GradientType = SiticoneAdvancedPanel.GradientTypeEx.Linear;
            siticoneAdvancedPanel3.HoverBackColor = Color.Empty;
            siticoneAdvancedPanel3.HoverBorderColor = Color.Empty;
            siticoneAdvancedPanel3.InnerShadowColor = Color.Black;
            siticoneAdvancedPanel3.InnerShadowDepth = 3;
            siticoneAdvancedPanel3.InnerShadowOpacity = 0.2F;
            siticoneAdvancedPanel3.Location = new Point(306, 6);
            siticoneAdvancedPanel3.Margin = new Padding(6);
            siticoneAdvancedPanel3.Name = "siticoneAdvancedPanel3";
            siticoneAdvancedPanel3.Padding = new Padding(25);
            siticoneAdvancedPanel3.RadialGradientCenter = (PointF)resources.GetObject("siticoneAdvancedPanel3.RadialGradientCenter");
            siticoneAdvancedPanel3.RadialGradientRadius = 1F;
            siticoneAdvancedPanel3.ScaleRatio = 0.8F;
            siticoneAdvancedPanel3.SecondaryBorderColor = Color.DarkGray;
            siticoneAdvancedPanel3.ShadowBlur = 10;
            siticoneAdvancedPanel3.ShadowColor = Color.Black;
            siticoneAdvancedPanel3.ShadowDepth = 5;
            siticoneAdvancedPanel3.ShadowOffset = new Point(2, 2);
            siticoneAdvancedPanel3.ShadowOpacity = 0.3F;
            siticoneAdvancedPanel3.Size = new Size(140, 133);
            siticoneAdvancedPanel3.SlideDirection = new Point(0, -30);
            siticoneAdvancedPanel3.TabIndex = 2;
            siticoneAdvancedPanel3.TopLeftRadius = 20;
            siticoneAdvancedPanel3.TopRightRadius = 20;
            // 
            // btnNearby
            // 
            btnNearby.BackColor = Color.Transparent;
            btnNearby.BadgeBackColor = Color.Red;
            btnNearby.BadgeForeColor = Color.White;
            btnNearby.BadgeRadius = 8;
            btnNearby.BadgeRightMargin = 10;
            btnNearby.BadgeValue = 0;
            btnNearby.BorderColor = Color.FromArgb(15, 76, 76);
            btnNearby.BorderColorEnd = Color.Gray;
            btnNearby.BorderColorStart = Color.White;
            btnNearby.BorderRadiusBottomLeft = 30;
            btnNearby.BorderRadiusBottomRight = 30;
            btnNearby.BorderRadiusTopLeft = 30;
            btnNearby.BorderRadiusTopRight = 30;
            btnNearby.BorderThickness = 0;
            btnNearby.ButtonColorEnd = Color.FromArgb(231, 243, 239);
            btnNearby.ButtonColorStart = Color.FromArgb(231, 243, 239);
            btnNearby.ButtonImage = (Image)resources.GetObject("btnNearby.ButtonImage");
            btnNearby.CanBeep = false;
            btnNearby.CanShake = false;
            btnNearby.ClickSoundPath = null;
            btnNearby.DisabledOverlayOpacity = 0.5F;
            btnNearby.EnableBorderGradient = false;
            btnNearby.EnableClickSound = false;
            btnNearby.EnableFocusBorder = false;
            btnNearby.EnableHoverSound = false;
            btnNearby.EnablePressScale = false;
            btnNearby.EnableTextShadow = false;
            btnNearby.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnNearby.FocusBorderThickness = 2;
            btnNearby.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNearby.ForeColor = Color.FromArgb(15, 76, 76);
            btnNearby.HoverColor = Color.FromArgb(197, 227, 217);
            btnNearby.HoverSoundPath = null;
            btnNearby.HoverTransitionSpeed = 0.08F;
            btnNearby.ImageAlign = ContentAlignment.MiddleCenter;
            btnNearby.ImageLeftMargin = 0;
            btnNearby.ImageRightMargin = 0;
            btnNearby.ImageSize = 30;
            btnNearby.IsReadOnly = false;
            btnNearby.Location = new Point(35, 17);
            btnNearby.MakeRadial = true;
            btnNearby.Name = "btnNearby";
            btnNearby.PressAnimationSpeed = 0.2F;
            btnNearby.PressDepth = 1;
            btnNearby.RippleColor = Color.FromArgb(78, 127, 122);
            btnNearby.RippleExpandSpeedFactor = 0.05F;
            btnNearby.RippleFadeSpeedFactor = 0.03F;
            btnNearby.ShadowBlurFactor = 0.85F;
            btnNearby.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnNearby.ShadowOffsetX = 3;
            btnNearby.ShadowOffsetY = 3;
            btnNearby.Size = new Size(65, 65);
            btnNearby.TabIndex = 12;
            btnNearby.TextAlign = ContentAlignment.MiddleCenter;
            btnNearby.TextPaddingBottom = 0;
            btnNearby.TextPaddingLeft = 0;
            btnNearby.TextPaddingRight = 0;
            btnNearby.TextPaddingTop = 0;
            btnNearby.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnNearby.TextShadowOffsetX = 1;
            btnNearby.TextShadowOffsetY = 1;
            btnNearby.Click += btnNearby_Click;
            // 
            // siticoneLabel5
            // 
            siticoneLabel5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel5.ForeColor = Color.Black;
            siticoneLabel5.Location = new Point(24, 83);
            siticoneLabel5.Name = "siticoneLabel5";
            siticoneLabel5.Size = new Size(92, 32);
            siticoneLabel5.TabIndex = 21;
            siticoneLabel5.Text = "Facilities";
            siticoneLabel5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // siticoneAdvancedPanel2
            // 
            siticoneAdvancedPanel2.ActiveBackColor = Color.Empty;
            siticoneAdvancedPanel2.ActiveBorderColor = Color.Empty;
            siticoneAdvancedPanel2.AnimationDuration = 500;
            siticoneAdvancedPanel2.AnimationType = SiticoneAdvancedPanel.AnimationTypeEx.Fade;
            siticoneAdvancedPanel2.BackgroundImageCustom = null;
            siticoneAdvancedPanel2.BackgroundImageOpacity = 1F;
            siticoneAdvancedPanel2.BackgroundImageSizeMode = SiticoneAdvancedPanel.ImageSizeModeEx.Stretch;
            siticoneAdvancedPanel2.BackgroundOverlayColor = Color.FromArgb(0, 0, 0, 0);
            siticoneAdvancedPanel2.BorderDashPattern = null;
            siticoneAdvancedPanel2.BorderGlowColor = Color.Cyan;
            siticoneAdvancedPanel2.BorderGlowSize = 3F;
            siticoneAdvancedPanel2.BottomLeftRadius = 20;
            siticoneAdvancedPanel2.BottomRightRadius = 20;
            siticoneAdvancedPanel2.ContentAlignmentCustom = ContentAlignment.MiddleCenter;
            siticoneAdvancedPanel2.Controls.Add(btnRecords);
            siticoneAdvancedPanel2.Controls.Add(siticoneLabel4);
            siticoneAdvancedPanel2.CornerPadding = new Padding(5);
            siticoneAdvancedPanel2.DisabledBackColor = Color.Empty;
            siticoneAdvancedPanel2.DisabledBorderColor = Color.Empty;
            siticoneAdvancedPanel2.Dock = DockStyle.Fill;
            siticoneAdvancedPanel2.DoubleBorderSpacing = 2F;
            siticoneAdvancedPanel2.EasingType = SiticoneAdvancedPanel.EasingTypeEx.Linear;
            siticoneAdvancedPanel2.EnableAnimation = false;
            siticoneAdvancedPanel2.EnableBackgroundImage = false;
            siticoneAdvancedPanel2.EnableBorderGlow = false;
            siticoneAdvancedPanel2.EnableDoubleBorder = false;
            siticoneAdvancedPanel2.EnableGradient = false;
            siticoneAdvancedPanel2.EnableInnerShadow = false;
            siticoneAdvancedPanel2.EnableShadow = false;
            siticoneAdvancedPanel2.EnableSmartPadding = true;
            siticoneAdvancedPanel2.EnableStateStyles = false;
            siticoneAdvancedPanel2.FlowDirectionCustom = FlowDirection.LeftToRight;
            siticoneAdvancedPanel2.GradientAngle = 90F;
            siticoneAdvancedPanel2.GradientEndColor = Color.LightGray;
            siticoneAdvancedPanel2.GradientStartColor = Color.White;
            siticoneAdvancedPanel2.GradientType = SiticoneAdvancedPanel.GradientTypeEx.Linear;
            siticoneAdvancedPanel2.HoverBackColor = Color.Empty;
            siticoneAdvancedPanel2.HoverBorderColor = Color.Empty;
            siticoneAdvancedPanel2.InnerShadowColor = Color.Black;
            siticoneAdvancedPanel2.InnerShadowDepth = 3;
            siticoneAdvancedPanel2.InnerShadowOpacity = 0.2F;
            siticoneAdvancedPanel2.Location = new Point(156, 6);
            siticoneAdvancedPanel2.Margin = new Padding(6);
            siticoneAdvancedPanel2.Name = "siticoneAdvancedPanel2";
            siticoneAdvancedPanel2.Padding = new Padding(25);
            siticoneAdvancedPanel2.RadialGradientCenter = (PointF)resources.GetObject("siticoneAdvancedPanel2.RadialGradientCenter");
            siticoneAdvancedPanel2.RadialGradientRadius = 1F;
            siticoneAdvancedPanel2.ScaleRatio = 0.8F;
            siticoneAdvancedPanel2.SecondaryBorderColor = Color.DarkGray;
            siticoneAdvancedPanel2.ShadowBlur = 10;
            siticoneAdvancedPanel2.ShadowColor = Color.Black;
            siticoneAdvancedPanel2.ShadowDepth = 5;
            siticoneAdvancedPanel2.ShadowOffset = new Point(2, 2);
            siticoneAdvancedPanel2.ShadowOpacity = 0.3F;
            siticoneAdvancedPanel2.Size = new Size(138, 133);
            siticoneAdvancedPanel2.SlideDirection = new Point(0, -30);
            siticoneAdvancedPanel2.TabIndex = 1;
            siticoneAdvancedPanel2.TopLeftRadius = 20;
            siticoneAdvancedPanel2.TopRightRadius = 20;
            // 
            // btnRecords
            // 
            btnRecords.BackColor = Color.Transparent;
            btnRecords.BadgeBackColor = Color.Red;
            btnRecords.BadgeForeColor = Color.White;
            btnRecords.BadgeRadius = 8;
            btnRecords.BadgeRightMargin = 10;
            btnRecords.BadgeValue = 0;
            btnRecords.BorderColor = Color.FromArgb(15, 76, 76);
            btnRecords.BorderColorEnd = Color.Gray;
            btnRecords.BorderColorStart = Color.White;
            btnRecords.BorderRadiusBottomLeft = 30;
            btnRecords.BorderRadiusBottomRight = 30;
            btnRecords.BorderRadiusTopLeft = 30;
            btnRecords.BorderRadiusTopRight = 30;
            btnRecords.BorderThickness = 0;
            btnRecords.ButtonColorEnd = Color.FromArgb(231, 243, 239);
            btnRecords.ButtonColorStart = Color.FromArgb(231, 243, 239);
            btnRecords.ButtonImage = (Image)resources.GetObject("btnRecords.ButtonImage");
            btnRecords.CanBeep = false;
            btnRecords.CanShake = false;
            btnRecords.ClickSoundPath = null;
            btnRecords.DisabledOverlayOpacity = 0.5F;
            btnRecords.EnableBorderGradient = false;
            btnRecords.EnableClickSound = false;
            btnRecords.EnableFocusBorder = false;
            btnRecords.EnableHoverSound = false;
            btnRecords.EnablePressScale = false;
            btnRecords.EnableTextShadow = false;
            btnRecords.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnRecords.FocusBorderThickness = 2;
            btnRecords.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecords.ForeColor = Color.FromArgb(15, 76, 76);
            btnRecords.HoverColor = Color.FromArgb(197, 227, 217);
            btnRecords.HoverSoundPath = null;
            btnRecords.HoverTransitionSpeed = 0.08F;
            btnRecords.ImageAlign = ContentAlignment.MiddleCenter;
            btnRecords.ImageLeftMargin = 0;
            btnRecords.ImageRightMargin = 0;
            btnRecords.ImageSize = 30;
            btnRecords.IsReadOnly = false;
            btnRecords.Location = new Point(35, 17);
            btnRecords.MakeRadial = true;
            btnRecords.Name = "btnRecords";
            btnRecords.PressAnimationSpeed = 0.2F;
            btnRecords.PressDepth = 1;
            btnRecords.RippleColor = Color.FromArgb(78, 127, 122);
            btnRecords.RippleExpandSpeedFactor = 0.05F;
            btnRecords.RippleFadeSpeedFactor = 0.03F;
            btnRecords.ShadowBlurFactor = 0.85F;
            btnRecords.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnRecords.ShadowOffsetX = 3;
            btnRecords.ShadowOffsetY = 3;
            btnRecords.Size = new Size(65, 65);
            btnRecords.TabIndex = 12;
            btnRecords.TextAlign = ContentAlignment.MiddleCenter;
            btnRecords.TextPaddingBottom = 0;
            btnRecords.TextPaddingLeft = 0;
            btnRecords.TextPaddingRight = 0;
            btnRecords.TextPaddingTop = 0;
            btnRecords.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnRecords.TextShadowOffsetX = 1;
            btnRecords.TextShadowOffsetY = 1;
            btnRecords.Click += btnRecords_Click;
            // 
            // siticoneLabel4
            // 
            siticoneLabel4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel4.ForeColor = Color.Black;
            siticoneLabel4.Location = new Point(24, 83);
            siticoneLabel4.Name = "siticoneLabel4";
            siticoneLabel4.Size = new Size(92, 32);
            siticoneLabel4.TabIndex = 21;
            siticoneLabel4.Text = "Records";
            siticoneLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // siticoneAdvancedPanel1
            // 
            siticoneAdvancedPanel1.ActiveBackColor = Color.Empty;
            siticoneAdvancedPanel1.ActiveBorderColor = Color.Empty;
            siticoneAdvancedPanel1.AnimationDuration = 500;
            siticoneAdvancedPanel1.AnimationType = SiticoneAdvancedPanel.AnimationTypeEx.Fade;
            siticoneAdvancedPanel1.BackgroundImageCustom = null;
            siticoneAdvancedPanel1.BackgroundImageOpacity = 1F;
            siticoneAdvancedPanel1.BackgroundImageSizeMode = SiticoneAdvancedPanel.ImageSizeModeEx.Stretch;
            siticoneAdvancedPanel1.BackgroundOverlayColor = Color.FromArgb(0, 0, 0, 0);
            siticoneAdvancedPanel1.BorderDashPattern = null;
            siticoneAdvancedPanel1.BorderGlowColor = Color.Cyan;
            siticoneAdvancedPanel1.BorderGlowSize = 3F;
            siticoneAdvancedPanel1.BottomLeftRadius = 20;
            siticoneAdvancedPanel1.BottomRightRadius = 20;
            siticoneAdvancedPanel1.ContentAlignmentCustom = ContentAlignment.MiddleCenter;
            siticoneAdvancedPanel1.Controls.Add(btnBook);
            siticoneAdvancedPanel1.Controls.Add(siticoneLabel2);
            siticoneAdvancedPanel1.CornerPadding = new Padding(5);
            siticoneAdvancedPanel1.DisabledBackColor = Color.Empty;
            siticoneAdvancedPanel1.DisabledBorderColor = Color.Empty;
            siticoneAdvancedPanel1.Dock = DockStyle.Fill;
            siticoneAdvancedPanel1.DoubleBorderSpacing = 2F;
            siticoneAdvancedPanel1.EasingType = SiticoneAdvancedPanel.EasingTypeEx.Linear;
            siticoneAdvancedPanel1.EnableAnimation = false;
            siticoneAdvancedPanel1.EnableBackgroundImage = false;
            siticoneAdvancedPanel1.EnableBorderGlow = false;
            siticoneAdvancedPanel1.EnableDoubleBorder = false;
            siticoneAdvancedPanel1.EnableGradient = false;
            siticoneAdvancedPanel1.EnableInnerShadow = false;
            siticoneAdvancedPanel1.EnableShadow = false;
            siticoneAdvancedPanel1.EnableSmartPadding = true;
            siticoneAdvancedPanel1.EnableStateStyles = false;
            siticoneAdvancedPanel1.FlowDirectionCustom = FlowDirection.LeftToRight;
            siticoneAdvancedPanel1.GradientAngle = 90F;
            siticoneAdvancedPanel1.GradientEndColor = Color.LightGray;
            siticoneAdvancedPanel1.GradientStartColor = Color.White;
            siticoneAdvancedPanel1.GradientType = SiticoneAdvancedPanel.GradientTypeEx.Linear;
            siticoneAdvancedPanel1.HoverBackColor = Color.Empty;
            siticoneAdvancedPanel1.HoverBorderColor = Color.Empty;
            siticoneAdvancedPanel1.InnerShadowColor = Color.Black;
            siticoneAdvancedPanel1.InnerShadowDepth = 3;
            siticoneAdvancedPanel1.InnerShadowOpacity = 0.2F;
            siticoneAdvancedPanel1.Location = new Point(6, 6);
            siticoneAdvancedPanel1.Margin = new Padding(6);
            siticoneAdvancedPanel1.Name = "siticoneAdvancedPanel1";
            siticoneAdvancedPanel1.Padding = new Padding(25);
            siticoneAdvancedPanel1.RadialGradientCenter = (PointF)resources.GetObject("siticoneAdvancedPanel1.RadialGradientCenter");
            siticoneAdvancedPanel1.RadialGradientRadius = 1F;
            siticoneAdvancedPanel1.ScaleRatio = 0.8F;
            siticoneAdvancedPanel1.SecondaryBorderColor = Color.DarkGray;
            siticoneAdvancedPanel1.ShadowBlur = 10;
            siticoneAdvancedPanel1.ShadowColor = Color.Black;
            siticoneAdvancedPanel1.ShadowDepth = 5;
            siticoneAdvancedPanel1.ShadowOffset = new Point(2, 2);
            siticoneAdvancedPanel1.ShadowOpacity = 0.3F;
            siticoneAdvancedPanel1.Size = new Size(138, 133);
            siticoneAdvancedPanel1.SlideDirection = new Point(0, -30);
            siticoneAdvancedPanel1.TabIndex = 0;
            siticoneAdvancedPanel1.TopLeftRadius = 20;
            siticoneAdvancedPanel1.TopRightRadius = 20;
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
            btnBook.ButtonColorEnd = Color.FromArgb(231, 243, 239);
            btnBook.ButtonColorStart = Color.FromArgb(231, 243, 239);
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
            btnBook.ForeColor = Color.FromArgb(15, 76, 76);
            btnBook.HoverColor = Color.FromArgb(197, 227, 217);
            btnBook.HoverSoundPath = null;
            btnBook.HoverTransitionSpeed = 0.08F;
            btnBook.ImageAlign = ContentAlignment.MiddleCenter;
            btnBook.ImageLeftMargin = 0;
            btnBook.ImageRightMargin = 0;
            btnBook.ImageSize = 30;
            btnBook.IsReadOnly = false;
            btnBook.Location = new Point(35, 17);
            btnBook.MakeRadial = true;
            btnBook.Name = "btnBook";
            btnBook.PressAnimationSpeed = 0.2F;
            btnBook.PressDepth = 1;
            btnBook.RippleColor = Color.FromArgb(78, 127, 122);
            btnBook.RippleExpandSpeedFactor = 0.05F;
            btnBook.RippleFadeSpeedFactor = 0.03F;
            btnBook.ShadowBlurFactor = 0.85F;
            btnBook.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnBook.ShadowOffsetX = 3;
            btnBook.ShadowOffsetY = 3;
            btnBook.Size = new Size(65, 65);
            btnBook.TabIndex = 12;
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
            // siticoneLabel2
            // 
            siticoneLabel2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel2.ForeColor = Color.Black;
            siticoneLabel2.Location = new Point(24, 83);
            siticoneLabel2.Name = "siticoneLabel2";
            siticoneLabel2.Size = new Size(92, 32);
            siticoneLabel2.TabIndex = 21;
            siticoneLabel2.Text = "Book";
            siticoneLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // siticoneLabel6
            // 
            siticoneLabel6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel6.ForeColor = Color.Black;
            siticoneLabel6.Location = new Point(36, 476);
            siticoneLabel6.Name = "siticoneLabel6";
            siticoneLabel6.Size = new Size(352, 44);
            siticoneLabel6.TabIndex = 22;
            siticoneLabel6.Text = "Recent records";
            siticoneLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowRecords
            // 
            flowRecords.FlowDirection = FlowDirection.TopDown;
            flowRecords.Location = new Point(42, 533);
            flowRecords.Name = "flowRecords";
            flowRecords.Size = new Size(440, 324);
            flowRecords.TabIndex = 23;
            flowRecords.WrapContents = false;
            // 
            // lblNoRecords
            // 
            lblNoRecords.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoRecords.ForeColor = Color.Black;
            lblNoRecords.Location = new Point(91, 557);
            lblNoRecords.Name = "lblNoRecords";
            lblNoRecords.Size = new Size(352, 44);
            lblNoRecords.TabIndex = 35;
            lblNoRecords.Text = "No records yet";
            lblNoRecords.TextAlign = ContentAlignment.MiddleCenter;
            lblNoRecords.Visible = false;
            // 
            // pnlNext
            // 
            pnlNext.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            pnlNext.BackColor = Color.Transparent;
            pnlNext.BorderAlignment = PenAlignment.Center;
            pnlNext.BorderColor = Color.FromArgb(210, 210, 210);
            pnlNext.BorderDashPattern = null;
            pnlNext.BorderGradientEndColor = Color.Purple;
            pnlNext.BorderGradientStartColor = Color.Blue;
            pnlNext.BorderThickness = 2F;
            pnlNext.CornerRadiusBottomLeft = 25F;
            pnlNext.CornerRadiusBottomRight = 25F;
            pnlNext.CornerRadiusTopLeft = 25F;
            pnlNext.CornerRadiusTopRight = 25F;
            pnlNext.EnableAcrylicEffect = false;
            pnlNext.EnableMicaEffect = false;
            pnlNext.EnableRippleEffect = false;
            pnlNext.FillColor = Color.White;
            pnlNext.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            pnlNext.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            pnlNext.Location = new Point(36, 161);
            pnlNext.Name = "pnlNext";
            pnlNext.PatternColor = Color.FromArgb(30, 0, 0, 0);
            pnlNext.PatternStyle = HatchStyle.Max;
            pnlNext.RippleAlpha = 50;
            pnlNext.RippleAlphaDecrement = 3;
            pnlNext.RippleColor = Color.FromArgb(50, 255, 255, 255);
            pnlNext.RippleMaxSize = 600F;
            pnlNext.RippleSpeed = 15F;
            pnlNext.ShowBorder = true;
            pnlNext.Size = new Size(452, 144);
            pnlNext.TabIndex = 74;
            pnlNext.TabStop = true;
            pnlNext.UseBorderGradient = false;
            pnlNext.UseMultiGradient = false;
            pnlNext.UsePatternTexture = false;
            pnlNext.UseRadialGradient = false;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlNext);
            Controls.Add(lblNoRecords);
            Controls.Add(flowRecords);
            Controls.Add(siticoneLabel6);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(siticoneLabel1);
            Controls.Add(lblGreeting);
            Controls.Add(lblGreetingName);
            Name = "HomeScreen";
            Size = new Size(522, 779);
            tableLayoutPanel1.ResumeLayout(false);
            siticoneAdvancedPanel3.ResumeLayout(false);
            siticoneAdvancedPanel2.ResumeLayout(false);
            siticoneAdvancedPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneNetCoreUI.SiticoneLabel lblGreetingName;
        private SiticoneNetCoreUI.SiticoneLabel lblGreeting;
        private SiticoneLabel siticoneLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private SiticoneAdvancedPanel siticoneAdvancedPanel1;
        private SiticoneButtonAdvanced btnBook;
        private SiticoneLabel siticoneLabel2;
        private SiticoneAdvancedPanel siticoneAdvancedPanel3;
        private SiticoneButtonAdvanced btnNearby;
        private SiticoneLabel siticoneLabel5;
        private SiticoneAdvancedPanel siticoneAdvancedPanel2;
        private SiticoneButtonAdvanced btnRecords;
        private SiticoneLabel siticoneLabel4;
        private SiticoneLabel siticoneLabel6;
        private FlowLayoutPanel flowRecords;
        private SiticoneLabel lblNoRecords;
        private SiticonePanel pnlNext;
    }
}
