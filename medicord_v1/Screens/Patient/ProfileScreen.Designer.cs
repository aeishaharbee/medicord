namespace medicord_v1.Screens.Patient
{
    partial class ProfileScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileScreen));
            siticoneLabel4 = new SiticoneLabel();
            btnLogout = new SiticoneButtonAdvanced();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblLocation = new SiticoneLabel();
            lblNationality = new SiticoneLabel();
            lblPhone = new SiticoneLabel();
            lblIdNumber = new SiticoneLabel();
            lblIdType = new SiticoneLabel();
            siticoneLabel6 = new SiticoneLabel();
            siticoneLabel5 = new SiticoneLabel();
            siticoneLabel3 = new SiticoneLabel();
            siticoneLabel2 = new SiticoneLabel();
            siticoneLabel1 = new SiticoneLabel();
            siticoneAdvancedPanel1 = new SiticoneAdvancedPanel();
            lblName = new SiticoneLabel();
            lblEmail = new SiticoneLabel();
            btnEditProfile = new SiticoneButtonAdvanced();
            picAvatar = new SiticonePictureBox();
            pnlDependent = new SiticoneAdvancedPanel();
            siticoneLabel8 = new SiticoneLabel();
            siticoneLabel7 = new SiticoneLabel();
            btnDependents = new SiticoneNavForwardButton();
            btnBackToMine = new SiticoneButtonAdvanced();
            siticonePictureBox1 = new SiticonePictureBox();
            tableLayoutPanel1.SuspendLayout();
            siticoneAdvancedPanel1.SuspendLayout();
            pnlDependent.SuspendLayout();
            SuspendLayout();
            // 
            // siticoneLabel4
            // 
            siticoneLabel4.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel4.ForeColor = Color.Black;
            siticoneLabel4.Location = new Point(29, 13);
            siticoneLabel4.Name = "siticoneLabel4";
            siticoneLabel4.Size = new Size(177, 56);
            siticoneLabel4.TabIndex = 20;
            siticoneLabel4.Text = "Profile";
            siticoneLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BadgeBackColor = Color.Red;
            btnLogout.BadgeForeColor = Color.White;
            btnLogout.BadgeRadius = 8;
            btnLogout.BadgeRightMargin = 10;
            btnLogout.BadgeValue = 0;
            btnLogout.BorderColor = Color.DarkRed;
            btnLogout.BorderColorEnd = Color.Gray;
            btnLogout.BorderColorStart = Color.White;
            btnLogout.BorderRadiusBottomLeft = 35;
            btnLogout.BorderRadiusBottomRight = 35;
            btnLogout.BorderRadiusTopLeft = 35;
            btnLogout.BorderRadiusTopRight = 35;
            btnLogout.BorderThickness = 2;
            btnLogout.ButtonColorEnd = Color.White;
            btnLogout.ButtonColorStart = Color.White;
            btnLogout.ButtonImage = null;
            btnLogout.CanBeep = false;
            btnLogout.CanShake = false;
            btnLogout.ClickSoundPath = null;
            btnLogout.DisabledOverlayOpacity = 0.5F;
            btnLogout.EnableBorderGradient = false;
            btnLogout.EnableClickSound = false;
            btnLogout.EnableFocusBorder = false;
            btnLogout.EnableHoverSound = false;
            btnLogout.EnablePressScale = false;
            btnLogout.EnableTextShadow = false;
            btnLogout.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnLogout.FocusBorderThickness = 2;
            btnLogout.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.DarkRed;
            btnLogout.HoverColor = Color.FromArgb(255, 192, 192);
            btnLogout.HoverSoundPath = null;
            btnLogout.HoverTransitionSpeed = 0.08F;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.ImageLeftMargin = 5;
            btnLogout.ImageRightMargin = 8;
            btnLogout.ImageSize = 24;
            btnLogout.IsReadOnly = false;
            btnLogout.Location = new Point(42, 700);
            btnLogout.MakeRadial = false;
            btnLogout.Name = "btnLogout";
            btnLogout.PressAnimationSpeed = 0.2F;
            btnLogout.PressDepth = 1;
            btnLogout.RippleColor = Color.FromArgb(255, 128, 128);
            btnLogout.RippleExpandSpeedFactor = 0.05F;
            btnLogout.RippleFadeSpeedFactor = 0.03F;
            btnLogout.ShadowBlurFactor = 0.85F;
            btnLogout.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnLogout.ShadowOffsetX = 3;
            btnLogout.ShadowOffsetY = 3;
            btnLogout.Size = new Size(430, 62);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Log Out";
            btnLogout.TextAlign = ContentAlignment.MiddleCenter;
            btnLogout.TextPaddingBottom = 0;
            btnLogout.TextPaddingLeft = 0;
            btnLogout.TextPaddingRight = 0;
            btnLogout.TextPaddingTop = 0;
            btnLogout.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnLogout.TextShadowOffsetX = 1;
            btnLogout.TextShadowOffsetY = 1;
            btnLogout.Click += btnLogout_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 292F));
            tableLayoutPanel1.Controls.Add(lblLocation, 1, 4);
            tableLayoutPanel1.Controls.Add(lblNationality, 1, 3);
            tableLayoutPanel1.Controls.Add(lblPhone, 1, 2);
            tableLayoutPanel1.Controls.Add(lblIdNumber, 1, 1);
            tableLayoutPanel1.Controls.Add(lblIdType, 1, 0);
            tableLayoutPanel1.Controls.Add(siticoneLabel6, 0, 4);
            tableLayoutPanel1.Controls.Add(siticoneLabel5, 0, 3);
            tableLayoutPanel1.Controls.Add(siticoneLabel3, 0, 2);
            tableLayoutPanel1.Controls.Add(siticoneLabel2, 0, 1);
            tableLayoutPanel1.Controls.Add(siticoneLabel1, 0, 0);
            tableLayoutPanel1.Location = new Point(18, 7);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(395, 270);
            tableLayoutPanel1.TabIndex = 22;
            // 
            // lblLocation
            // 
            lblLocation.Dock = DockStyle.Right;
            lblLocation.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.ForeColor = Color.Black;
            lblLocation.Location = new Point(106, 216);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(286, 54);
            lblLocation.TabIndex = 34;
            lblLocation.Text = "47301 Ipoh, Perak";
            lblLocation.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblNationality
            // 
            lblNationality.Dock = DockStyle.Right;
            lblNationality.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNationality.ForeColor = Color.Black;
            lblNationality.Location = new Point(106, 162);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(286, 54);
            lblNationality.TabIndex = 33;
            lblNationality.Text = "Malaysia";
            lblNationality.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPhone
            // 
            lblPhone.Dock = DockStyle.Right;
            lblPhone.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.Black;
            lblPhone.Location = new Point(106, 108);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(286, 54);
            lblPhone.TabIndex = 32;
            lblPhone.Text = "01164036032";
            lblPhone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblIdNumber
            // 
            lblIdNumber.Dock = DockStyle.Right;
            lblIdNumber.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdNumber.ForeColor = Color.Black;
            lblIdNumber.Location = new Point(106, 54);
            lblIdNumber.Name = "lblIdNumber";
            lblIdNumber.Size = new Size(286, 54);
            lblIdNumber.TabIndex = 31;
            lblIdNumber.Text = "080415265478";
            lblIdNumber.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblIdType
            // 
            lblIdType.Dock = DockStyle.Right;
            lblIdType.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdType.ForeColor = Color.Black;
            lblIdType.Location = new Point(106, 0);
            lblIdType.Name = "lblIdType";
            lblIdType.Size = new Size(286, 54);
            lblIdType.TabIndex = 30;
            lblIdType.Text = "NRIC";
            lblIdType.TextAlign = ContentAlignment.MiddleRight;
            // 
            // siticoneLabel6
            // 
            siticoneLabel6.Dock = DockStyle.Left;
            siticoneLabel6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            siticoneLabel6.ForeColor = Color.DimGray;
            siticoneLabel6.Location = new Point(3, 216);
            siticoneLabel6.Name = "siticoneLabel6";
            siticoneLabel6.Size = new Size(97, 54);
            siticoneLabel6.TabIndex = 29;
            siticoneLabel6.Text = "City, State";
            siticoneLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // siticoneLabel5
            // 
            siticoneLabel5.Dock = DockStyle.Left;
            siticoneLabel5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            siticoneLabel5.ForeColor = Color.DimGray;
            siticoneLabel5.Location = new Point(3, 162);
            siticoneLabel5.Name = "siticoneLabel5";
            siticoneLabel5.Size = new Size(97, 54);
            siticoneLabel5.TabIndex = 28;
            siticoneLabel5.Text = "Nationality";
            siticoneLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // siticoneLabel3
            // 
            siticoneLabel3.Dock = DockStyle.Left;
            siticoneLabel3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            siticoneLabel3.ForeColor = Color.DimGray;
            siticoneLabel3.Location = new Point(3, 108);
            siticoneLabel3.Name = "siticoneLabel3";
            siticoneLabel3.Size = new Size(97, 54);
            siticoneLabel3.TabIndex = 27;
            siticoneLabel3.Text = "Phone";
            siticoneLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // siticoneLabel2
            // 
            siticoneLabel2.Dock = DockStyle.Left;
            siticoneLabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            siticoneLabel2.ForeColor = Color.DimGray;
            siticoneLabel2.Location = new Point(3, 54);
            siticoneLabel2.Name = "siticoneLabel2";
            siticoneLabel2.Size = new Size(97, 54);
            siticoneLabel2.TabIndex = 26;
            siticoneLabel2.Text = "ID Number";
            siticoneLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // siticoneLabel1
            // 
            siticoneLabel1.Dock = DockStyle.Left;
            siticoneLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            siticoneLabel1.ForeColor = Color.DimGray;
            siticoneLabel1.Location = new Point(3, 0);
            siticoneLabel1.Name = "siticoneLabel1";
            siticoneLabel1.Size = new Size(97, 54);
            siticoneLabel1.TabIndex = 25;
            siticoneLabel1.Text = "ID Type";
            siticoneLabel1.TextAlign = ContentAlignment.MiddleLeft;
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
            siticoneAdvancedPanel1.Controls.Add(tableLayoutPanel1);
            siticoneAdvancedPanel1.CornerPadding = new Padding(5);
            siticoneAdvancedPanel1.DisabledBackColor = Color.Empty;
            siticoneAdvancedPanel1.DisabledBorderColor = Color.Empty;
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
            siticoneAdvancedPanel1.Location = new Point(42, 200);
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
            siticoneAdvancedPanel1.Size = new Size(430, 291);
            siticoneAdvancedPanel1.SlideDirection = new Point(0, -30);
            siticoneAdvancedPanel1.TabIndex = 23;
            siticoneAdvancedPanel1.TopLeftRadius = 20;
            siticoneAdvancedPanel1.TopRightRadius = 20;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(155, 82);
            lblName.Name = "lblName";
            lblName.Size = new Size(314, 69);
            lblName.TabIndex = 25;
            lblName.Text = "Siti Noraeishah binti Abdul Bari Arbee";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(155, 153);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(314, 44);
            lblEmail.TabIndex = 26;
            lblEmail.Text = "aeishahrb@gmail.com";
            // 
            // btnEditProfile
            // 
            btnEditProfile.BackColor = Color.Transparent;
            btnEditProfile.BadgeBackColor = Color.Red;
            btnEditProfile.BadgeForeColor = Color.White;
            btnEditProfile.BadgeRadius = 8;
            btnEditProfile.BadgeRightMargin = 10;
            btnEditProfile.BadgeValue = 0;
            btnEditProfile.BorderColor = Color.FromArgb(15, 76, 76);
            btnEditProfile.BorderColorEnd = Color.Gray;
            btnEditProfile.BorderColorStart = Color.White;
            btnEditProfile.BorderRadiusBottomLeft = 35;
            btnEditProfile.BorderRadiusBottomRight = 35;
            btnEditProfile.BorderRadiusTopLeft = 35;
            btnEditProfile.BorderRadiusTopRight = 35;
            btnEditProfile.BorderThickness = 2;
            btnEditProfile.ButtonColorEnd = Color.White;
            btnEditProfile.ButtonColorStart = Color.White;
            btnEditProfile.ButtonImage = null;
            btnEditProfile.CanBeep = false;
            btnEditProfile.CanShake = false;
            btnEditProfile.ClickSoundPath = null;
            btnEditProfile.DisabledOverlayOpacity = 0.5F;
            btnEditProfile.EnableBorderGradient = false;
            btnEditProfile.EnableClickSound = false;
            btnEditProfile.EnableFocusBorder = false;
            btnEditProfile.EnableHoverSound = false;
            btnEditProfile.EnablePressScale = false;
            btnEditProfile.EnableTextShadow = false;
            btnEditProfile.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnEditProfile.FocusBorderThickness = 2;
            btnEditProfile.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditProfile.ForeColor = Color.FromArgb(15, 76, 76);
            btnEditProfile.HoverColor = Color.FromArgb(231, 243, 239);
            btnEditProfile.HoverSoundPath = null;
            btnEditProfile.HoverTransitionSpeed = 0.08F;
            btnEditProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditProfile.ImageLeftMargin = 5;
            btnEditProfile.ImageRightMargin = 8;
            btnEditProfile.ImageSize = 24;
            btnEditProfile.IsReadOnly = false;
            btnEditProfile.Location = new Point(42, 614);
            btnEditProfile.MakeRadial = false;
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.PressAnimationSpeed = 0.2F;
            btnEditProfile.PressDepth = 1;
            btnEditProfile.RippleColor = Color.FromArgb(78, 127, 122);
            btnEditProfile.RippleExpandSpeedFactor = 0.05F;
            btnEditProfile.RippleFadeSpeedFactor = 0.03F;
            btnEditProfile.ShadowBlurFactor = 0.85F;
            btnEditProfile.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnEditProfile.ShadowOffsetX = 3;
            btnEditProfile.ShadowOffsetY = 3;
            btnEditProfile.Size = new Size(430, 62);
            btnEditProfile.TabIndex = 27;
            btnEditProfile.Text = "Edit Profile";
            btnEditProfile.TextAlign = ContentAlignment.MiddleCenter;
            btnEditProfile.TextPaddingBottom = 0;
            btnEditProfile.TextPaddingLeft = 0;
            btnEditProfile.TextPaddingRight = 0;
            btnEditProfile.TextPaddingTop = 0;
            btnEditProfile.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnEditProfile.TextShadowOffsetX = 1;
            btnEditProfile.TextShadowOffsetY = 1;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.Transparent;
            picAvatar.BorderColor = Color.Transparent;
            picAvatar.BorderWidth = 1;
            picAvatar.Brightness = 1F;
            picAvatar.Contrast = 1F;
            picAvatar.CornerRadius = 0;
            picAvatar.DraggingSpeed = 3.15F;
            picAvatar.EnableAsyncLoading = false;
            picAvatar.EnableCaching = false;
            picAvatar.EnableDragDrop = false;
            picAvatar.EnableExtendedImageSources = false;
            picAvatar.EnableFilters = false;
            picAvatar.EnableFlipping = false;
            picAvatar.EnableGlow = false;
            picAvatar.EnableHighDpiSupport = false;
            picAvatar.EnableMouseInteraction = false;
            picAvatar.EnablePlaceholder = false;
            picAvatar.EnableRotation = false;
            picAvatar.EnableShadow = false;
            picAvatar.EnableSlideshow = false;
            picAvatar.FlipHorizontal = false;
            picAvatar.FlipVertical = false;
            picAvatar.Grayscale = false;
            picAvatar.Image = null;
            picAvatar.ImageOpacity = 1F;
            picAvatar.Images = (List<Image>)resources.GetObject("picAvatar.Images");
            picAvatar.InterpolationMode = InterpolationMode.HighQualityBicubic;
            picAvatar.IsCircular = false;
            picAvatar.Location = new Point(42, 85);
            picAvatar.MaintainAspectRatio = true;
            picAvatar.Name = "picAvatar";
            picAvatar.PlaceholderImage = null;
            picAvatar.RotationAngle = 0F;
            picAvatar.Saturation = 1F;
            picAvatar.ShowBorder = true;
            picAvatar.Size = new Size(96, 96);
            picAvatar.SizeMode = SiticoneNetCoreUI.Helpers.Enum.SiticonePictureBoxSizeMode.Normal;
            picAvatar.TabIndex = 77;
            picAvatar.Text = "siticonePictureBox1";
            // 
            // pnlDependent
            // 
            pnlDependent.ActiveBackColor = Color.Empty;
            pnlDependent.ActiveBorderColor = Color.Empty;
            pnlDependent.AnimationDuration = 500;
            pnlDependent.AnimationType = SiticoneAdvancedPanel.AnimationTypeEx.Fade;
            pnlDependent.BackgroundImageCustom = null;
            pnlDependent.BackgroundImageOpacity = 1F;
            pnlDependent.BackgroundImageSizeMode = SiticoneAdvancedPanel.ImageSizeModeEx.Stretch;
            pnlDependent.BackgroundOverlayColor = Color.FromArgb(0, 0, 0, 0);
            pnlDependent.BorderDashPattern = null;
            pnlDependent.BorderGlowColor = Color.Cyan;
            pnlDependent.BorderGlowSize = 3F;
            pnlDependent.BottomLeftRadius = 20;
            pnlDependent.BottomRightRadius = 20;
            pnlDependent.ContentAlignmentCustom = ContentAlignment.MiddleCenter;
            pnlDependent.Controls.Add(siticonePictureBox1);
            pnlDependent.Controls.Add(siticoneLabel8);
            pnlDependent.Controls.Add(siticoneLabel7);
            pnlDependent.Controls.Add(btnDependents);
            pnlDependent.CornerPadding = new Padding(5);
            pnlDependent.DisabledBackColor = Color.Empty;
            pnlDependent.DisabledBorderColor = Color.Empty;
            pnlDependent.DoubleBorderSpacing = 2F;
            pnlDependent.EasingType = SiticoneAdvancedPanel.EasingTypeEx.Linear;
            pnlDependent.EnableAnimation = false;
            pnlDependent.EnableBackgroundImage = false;
            pnlDependent.EnableBorderGlow = false;
            pnlDependent.EnableDoubleBorder = false;
            pnlDependent.EnableGradient = false;
            pnlDependent.EnableInnerShadow = false;
            pnlDependent.EnableShadow = false;
            pnlDependent.EnableSmartPadding = true;
            pnlDependent.EnableStateStyles = false;
            pnlDependent.FlowDirectionCustom = FlowDirection.LeftToRight;
            pnlDependent.GradientAngle = 90F;
            pnlDependent.GradientEndColor = Color.LightGray;
            pnlDependent.GradientStartColor = Color.White;
            pnlDependent.GradientType = SiticoneAdvancedPanel.GradientTypeEx.Linear;
            pnlDependent.HoverBackColor = Color.Empty;
            pnlDependent.HoverBorderColor = Color.Empty;
            pnlDependent.InnerShadowColor = Color.Black;
            pnlDependent.InnerShadowDepth = 3;
            pnlDependent.InnerShadowOpacity = 0.2F;
            pnlDependent.Location = new Point(42, 507);
            pnlDependent.Name = "pnlDependent";
            pnlDependent.Padding = new Padding(25);
            pnlDependent.RadialGradientCenter = (PointF)resources.GetObject("pnlDependent.RadialGradientCenter");
            pnlDependent.RadialGradientRadius = 1F;
            pnlDependent.ScaleRatio = 0.8F;
            pnlDependent.SecondaryBorderColor = Color.DarkGray;
            pnlDependent.ShadowBlur = 10;
            pnlDependent.ShadowColor = Color.Black;
            pnlDependent.ShadowDepth = 5;
            pnlDependent.ShadowOffset = new Point(2, 2);
            pnlDependent.ShadowOpacity = 0.3F;
            pnlDependent.Size = new Size(430, 86);
            pnlDependent.SlideDirection = new Point(0, -30);
            pnlDependent.TabIndex = 24;
            pnlDependent.TopLeftRadius = 20;
            pnlDependent.TopRightRadius = 20;
            // 
            // siticoneLabel8
            // 
            siticoneLabel8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            siticoneLabel8.ForeColor = Color.Black;
            siticoneLabel8.Location = new Point(73, 44);
            siticoneLabel8.Name = "siticoneLabel8";
            siticoneLabel8.Size = new Size(290, 38);
            siticoneLabel8.TabIndex = 79;
            siticoneLabel8.Text = "Children, parents and family you manage.";
            // 
            // siticoneLabel7
            // 
            siticoneLabel7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel7.ForeColor = Color.Black;
            siticoneLabel7.Location = new Point(73, 16);
            siticoneLabel7.Name = "siticoneLabel7";
            siticoneLabel7.Size = new Size(290, 37);
            siticoneLabel7.TabIndex = 78;
            siticoneLabel7.Text = "Dependents";
            // 
            // btnDependents
            // 
            btnDependents.BackColor = Color.Transparent;
            btnDependents.BorderRadius = 8;
            btnDependents.BounceDuration = 500;
            btnDependents.BounceStrength = 0.3F;
            btnDependents.CanBeep = true;
            btnDependents.CanShake = true;
            btnDependents.EnableParticles = true;
            btnDependents.EnablePulseEffect = true;
            btnDependents.EnableRippleEffect = true;
            btnDependents.EnableShadow = true;
            btnDependents.HoverAnimationSpeed = 200;
            btnDependents.HoverColor = Color.FromArgb(240, 240, 240);
            btnDependents.HoverOpacity = 150;
            btnDependents.IconColor = Color.FromArgb(64, 64, 64);
            btnDependents.IconSize = 24F;
            btnDependents.IconStrokeWidth = 2F;
            btnDependents.InteractiveBounce = false;
            btnDependents.IsInteractive = true;
            btnDependents.IsReadOnly = false;
            btnDependents.Location = new Point(375, 18);
            btnDependents.Name = "btnDependents";
            btnDependents.ParticleColor = Color.FromArgb(100, 149, 237);
            btnDependents.ParticleCount = 20;
            btnDependents.ParticleSpeed = 3F;
            btnDependents.PressAnimationSpeed = 100;
            btnDependents.PressColor = Color.FromArgb(240, 240, 240);
            btnDependents.PressDepthOffset = 2;
            btnDependents.PressShadowColor = Color.FromArgb(240, 240, 240);
            btnDependents.ShadowColor = Color.FromArgb(50, 0, 0, 0);
            btnDependents.ShadowDepth = 3;
            btnDependents.Size = new Size(50, 50);
            btnDependents.TabIndex = 0;
            btnDependents.Text = "siticoneNavForwardButton1";
            btnDependents.Click += btnDependents_Click;
            // 
            // btnBackToMine
            // 
            btnBackToMine.BackColor = Color.Transparent;
            btnBackToMine.BadgeBackColor = Color.Red;
            btnBackToMine.BadgeForeColor = Color.White;
            btnBackToMine.BadgeRadius = 8;
            btnBackToMine.BadgeRightMargin = 10;
            btnBackToMine.BadgeValue = 0;
            btnBackToMine.BorderColor = Color.FromArgb(15, 76, 76);
            btnBackToMine.BorderColorEnd = Color.Gray;
            btnBackToMine.BorderColorStart = Color.White;
            btnBackToMine.BorderRadiusBottomLeft = 35;
            btnBackToMine.BorderRadiusBottomRight = 35;
            btnBackToMine.BorderRadiusTopLeft = 35;
            btnBackToMine.BorderRadiusTopRight = 35;
            btnBackToMine.BorderThickness = 2;
            btnBackToMine.ButtonColorEnd = Color.White;
            btnBackToMine.ButtonColorStart = Color.White;
            btnBackToMine.ButtonImage = null;
            btnBackToMine.CanBeep = false;
            btnBackToMine.CanShake = false;
            btnBackToMine.ClickSoundPath = null;
            btnBackToMine.DisabledOverlayOpacity = 0.5F;
            btnBackToMine.EnableBorderGradient = false;
            btnBackToMine.EnableClickSound = false;
            btnBackToMine.EnableFocusBorder = false;
            btnBackToMine.EnableHoverSound = false;
            btnBackToMine.EnablePressScale = false;
            btnBackToMine.EnableTextShadow = false;
            btnBackToMine.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnBackToMine.FocusBorderThickness = 2;
            btnBackToMine.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToMine.ForeColor = Color.FromArgb(15, 76, 76);
            btnBackToMine.HoverColor = Color.FromArgb(231, 243, 239);
            btnBackToMine.HoverSoundPath = null;
            btnBackToMine.HoverTransitionSpeed = 0.08F;
            btnBackToMine.ImageAlign = ContentAlignment.MiddleLeft;
            btnBackToMine.ImageLeftMargin = 5;
            btnBackToMine.ImageRightMargin = 8;
            btnBackToMine.ImageSize = 24;
            btnBackToMine.IsReadOnly = false;
            btnBackToMine.Location = new Point(42, 700);
            btnBackToMine.MakeRadial = false;
            btnBackToMine.Name = "btnBackToMine";
            btnBackToMine.PressAnimationSpeed = 0.2F;
            btnBackToMine.PressDepth = 1;
            btnBackToMine.RippleColor = Color.FromArgb(78, 127, 122);
            btnBackToMine.RippleExpandSpeedFactor = 0.05F;
            btnBackToMine.RippleFadeSpeedFactor = 0.03F;
            btnBackToMine.ShadowBlurFactor = 0.85F;
            btnBackToMine.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnBackToMine.ShadowOffsetX = 3;
            btnBackToMine.ShadowOffsetY = 3;
            btnBackToMine.Size = new Size(430, 62);
            btnBackToMine.TabIndex = 78;
            btnBackToMine.Text = "Back To My Account";
            btnBackToMine.TextAlign = ContentAlignment.MiddleCenter;
            btnBackToMine.TextPaddingBottom = 0;
            btnBackToMine.TextPaddingLeft = 0;
            btnBackToMine.TextPaddingRight = 0;
            btnBackToMine.TextPaddingTop = 0;
            btnBackToMine.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnBackToMine.TextShadowOffsetX = 1;
            btnBackToMine.TextShadowOffsetY = 1;
            btnBackToMine.Visible = false;
            btnBackToMine.Click += btnBackToMine_Click;
            // 
            // siticonePictureBox1
            // 
            siticonePictureBox1.BackColor = Color.Transparent;
            siticonePictureBox1.BorderColor = Color.Transparent;
            siticonePictureBox1.BorderWidth = 1;
            siticonePictureBox1.Brightness = 1F;
            siticonePictureBox1.Contrast = 1F;
            siticonePictureBox1.CornerRadius = 0;
            siticonePictureBox1.DraggingSpeed = 3.15F;
            siticonePictureBox1.EnableAsyncLoading = false;
            siticonePictureBox1.EnableCaching = false;
            siticonePictureBox1.EnableDragDrop = false;
            siticonePictureBox1.EnableExtendedImageSources = false;
            siticonePictureBox1.EnableFilters = false;
            siticonePictureBox1.EnableFlipping = false;
            siticonePictureBox1.EnableGlow = false;
            siticonePictureBox1.EnableHighDpiSupport = false;
            siticonePictureBox1.EnableMouseInteraction = false;
            siticonePictureBox1.EnablePlaceholder = false;
            siticonePictureBox1.EnableRotation = false;
            siticonePictureBox1.EnableShadow = false;
            siticonePictureBox1.EnableSlideshow = false;
            siticonePictureBox1.FlipHorizontal = false;
            siticonePictureBox1.FlipVertical = false;
            siticonePictureBox1.Grayscale = false;
            siticonePictureBox1.Image = (Image)resources.GetObject("siticonePictureBox1.Image");
            siticonePictureBox1.ImageOpacity = 1F;
            siticonePictureBox1.Images = (List<Image>)resources.GetObject("siticonePictureBox1.Images");
            siticonePictureBox1.InterpolationMode = InterpolationMode.HighQualityBicubic;
            siticonePictureBox1.IsCircular = false;
            siticonePictureBox1.Location = new Point(16, 18);
            siticonePictureBox1.MaintainAspectRatio = true;
            siticonePictureBox1.Name = "siticonePictureBox1";
            siticonePictureBox1.PlaceholderImage = null;
            siticonePictureBox1.RotationAngle = 0F;
            siticonePictureBox1.Saturation = 1F;
            siticonePictureBox1.ShowBorder = false;
            siticonePictureBox1.Size = new Size(50, 50);
            siticonePictureBox1.SizeMode = SiticoneNetCoreUI.Helpers.Enum.SiticonePictureBoxSizeMode.Zoom;
            siticonePictureBox1.TabIndex = 79;
            siticonePictureBox1.Text = "siticonePictureBox1";
            // 
            // ProfileScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnBackToMine);
            Controls.Add(pnlDependent);
            Controls.Add(picAvatar);
            Controls.Add(btnEditProfile);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(siticoneAdvancedPanel1);
            Controls.Add(btnLogout);
            Controls.Add(siticoneLabel4);
            Name = "ProfileScreen";
            Size = new Size(522, 828);
            tableLayoutPanel1.ResumeLayout(false);
            siticoneAdvancedPanel1.ResumeLayout(false);
            pnlDependent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneLabel siticoneLabel4;
        private SiticoneButtonAdvanced btnLogout;
        private TableLayoutPanel tableLayoutPanel1;
        private SiticoneAdvancedPanel siticoneAdvancedPanel1;
        private SiticoneLabel siticoneLabel1;
        private SiticoneLabel siticoneLabel6;
        private SiticoneLabel siticoneLabel5;
        private SiticoneLabel siticoneLabel3;
        private SiticoneLabel siticoneLabel2;
        private SiticoneLabel lblIdType;
        private SiticoneLabel lblLocation;
        private SiticoneLabel lblNationality;
        private SiticoneLabel lblPhone;
        private SiticoneLabel lblIdNumber;
        private SiticoneLabel lblName;
        private SiticoneLabel lblEmail;
        private SiticoneButtonAdvanced btnEditProfile;
        private SiticonePictureBox picAvatar;
        private SiticoneAdvancedPanel pnlDependent;
        private SiticoneNavForwardButton btnDependents;
        private SiticoneLabel siticoneLabel7;
        private SiticoneLabel siticoneLabel8;
        private SiticoneButtonAdvanced btnBackToMine;
        private SiticonePictureBox siticonePictureBox1;
    }
}
