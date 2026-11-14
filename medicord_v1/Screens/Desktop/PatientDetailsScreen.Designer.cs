namespace medicord_v1.Screens.Desktop
{
    partial class PatientDetailsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDetailsScreen));
            pnlInfo = new SiticonePanel();
            lblRegistered = new SiticoneLabel();
            siticoneLabel13 = new SiticoneLabel();
            lblAddress = new SiticoneLabel();
            siticonehSeparator7 = new SiticoneHSeparator();
            siticoneLabel11 = new SiticoneLabel();
            lblEmail = new SiticoneLabel();
            siticonehSeparator6 = new SiticoneHSeparator();
            siticoneLabel9 = new SiticoneLabel();
            lblPhone = new SiticoneLabel();
            siticonehSeparator5 = new SiticoneHSeparator();
            siticoneLabel7 = new SiticoneLabel();
            lblNationality = new SiticoneLabel();
            siticonehSeparator4 = new SiticoneHSeparator();
            siticoneLabel5 = new SiticoneLabel();
            siticoneLabel15 = new SiticoneLabel();
            lblIdNumber = new SiticoneLabel();
            lblIdType = new SiticoneLabel();
            siticonehSeparator3 = new SiticoneHSeparator();
            siticonehSeparator2 = new SiticoneHSeparator();
            siticoneLabel4 = new SiticoneLabel();
            siticoneLabel2 = new SiticoneLabel();
            lblSub = new SiticoneLabel();
            lblName = new SiticoneLabel();
            picAvatar = new SiticonePictureBox();
            siticonePanel1 = new SiticonePanel();
            siticoneLabel25 = new SiticoneLabel();
            dgvAppts = new DataGridView();
            siticonePanel2 = new SiticonePanel();
            btnOpenRecord = new SiticoneButton();
            dgvRecords = new DataGridView();
            siticoneLabel14 = new SiticoneLabel();
            btnBack = new SiticoneNavBackButton();
            siticoneLabel16 = new SiticoneLabel();
            pnlInfo.SuspendLayout();
            siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppts).BeginInit();
            siticonePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            SuspendLayout();
            // 
            // pnlInfo
            // 
            pnlInfo.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            pnlInfo.BackColor = Color.Transparent;
            pnlInfo.BorderAlignment = PenAlignment.Center;
            pnlInfo.BorderColor = Color.FromArgb(210, 210, 210);
            pnlInfo.BorderDashPattern = null;
            pnlInfo.BorderGradientEndColor = Color.Purple;
            pnlInfo.BorderGradientStartColor = Color.Blue;
            pnlInfo.BorderThickness = 2F;
            pnlInfo.Controls.Add(lblRegistered);
            pnlInfo.Controls.Add(siticoneLabel13);
            pnlInfo.Controls.Add(lblAddress);
            pnlInfo.Controls.Add(siticonehSeparator7);
            pnlInfo.Controls.Add(siticoneLabel11);
            pnlInfo.Controls.Add(lblEmail);
            pnlInfo.Controls.Add(siticonehSeparator6);
            pnlInfo.Controls.Add(siticoneLabel9);
            pnlInfo.Controls.Add(lblPhone);
            pnlInfo.Controls.Add(siticonehSeparator5);
            pnlInfo.Controls.Add(siticoneLabel7);
            pnlInfo.Controls.Add(lblNationality);
            pnlInfo.Controls.Add(siticonehSeparator4);
            pnlInfo.Controls.Add(siticoneLabel5);
            pnlInfo.Controls.Add(siticoneLabel15);
            pnlInfo.Controls.Add(lblIdNumber);
            pnlInfo.Controls.Add(lblIdType);
            pnlInfo.Controls.Add(siticonehSeparator3);
            pnlInfo.Controls.Add(siticonehSeparator2);
            pnlInfo.Controls.Add(siticoneLabel4);
            pnlInfo.Controls.Add(siticoneLabel2);
            pnlInfo.CornerRadiusBottomLeft = 25F;
            pnlInfo.CornerRadiusBottomRight = 25F;
            pnlInfo.CornerRadiusTopLeft = 25F;
            pnlInfo.CornerRadiusTopRight = 25F;
            pnlInfo.EnableAcrylicEffect = false;
            pnlInfo.EnableMicaEffect = false;
            pnlInfo.EnableRippleEffect = false;
            pnlInfo.FillColor = Color.White;
            pnlInfo.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            pnlInfo.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            pnlInfo.Location = new Point(29, 251);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.PatternColor = Color.FromArgb(30, 0, 0, 0);
            pnlInfo.PatternStyle = HatchStyle.Max;
            pnlInfo.RippleAlpha = 50;
            pnlInfo.RippleAlphaDecrement = 3;
            pnlInfo.RippleColor = Color.FromArgb(50, 255, 255, 255);
            pnlInfo.RippleMaxSize = 600F;
            pnlInfo.RippleSpeed = 15F;
            pnlInfo.ShowBorder = true;
            pnlInfo.Size = new Size(414, 456);
            pnlInfo.TabIndex = 66;
            pnlInfo.TabStop = true;
            pnlInfo.UseBorderGradient = false;
            pnlInfo.UseMultiGradient = false;
            pnlInfo.UsePatternTexture = false;
            pnlInfo.UseRadialGradient = false;
            // 
            // lblRegistered
            // 
            lblRegistered.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistered.ForeColor = SystemColors.ActiveCaptionText;
            lblRegistered.Location = new Point(146, 395);
            lblRegistered.Name = "lblRegistered";
            lblRegistered.Size = new Size(231, 26);
            lblRegistered.TabIndex = 104;
            lblRegistered.Text = "Nationality";
            lblRegistered.TextAlign = ContentAlignment.TopRight;
            // 
            // siticoneLabel13
            // 
            siticoneLabel13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            siticoneLabel13.ForeColor = Color.FromArgb(90, 107, 106);
            siticoneLabel13.Location = new Point(20, 395);
            siticoneLabel13.Name = "siticoneLabel13";
            siticoneLabel13.Size = new Size(142, 26);
            siticoneLabel13.TabIndex = 102;
            siticoneLabel13.Text = "Registered";
            siticoneLabel13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            lblAddress.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = SystemColors.ActiveCaptionText;
            lblAddress.Location = new Point(146, 341);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(231, 26);
            lblAddress.TabIndex = 101;
            lblAddress.Text = "Nationality";
            lblAddress.TextAlign = ContentAlignment.TopRight;
            // 
            // siticonehSeparator7
            // 
            siticonehSeparator7.BackColor = Color.Transparent;
            siticonehSeparator7.GradientEndColor = Color.Black;
            siticonehSeparator7.GradientMode = SiticoneHSeparator.LinearGradientMode.None;
            siticonehSeparator7.GradientStartColor = Color.White;
            siticonehSeparator7.LineColor = Color.FromArgb(230, 236, 235);
            siticonehSeparator7.LineWidth = 1;
            siticonehSeparator7.Location = new Point(23, 375);
            siticonehSeparator7.Name = "siticonehSeparator7";
            siticonehSeparator7.ParallelLines = 1;
            siticonehSeparator7.ParallelLineSpacing = 4;
            siticonehSeparator7.SegmentNumberColor = Color.Black;
            siticonehSeparator7.SegmentNumberFont = new Font("Arial", 8F);
            siticonehSeparator7.Segments = 1;
            siticonehSeparator7.SegmentSpacing = 10;
            siticonehSeparator7.SeparatorDashStyle = SiticoneHSeparator.CustomDashStyle.Solid;
            siticonehSeparator7.ShowSegmentNumbers = false;
            siticonehSeparator7.Size = new Size(354, 17);
            siticonehSeparator7.TabIndex = 100;
            siticonehSeparator7.Text = "siticonehSeparator7";
            // 
            // siticoneLabel11
            // 
            siticoneLabel11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            siticoneLabel11.ForeColor = Color.FromArgb(90, 107, 106);
            siticoneLabel11.Location = new Point(20, 341);
            siticoneLabel11.Name = "siticoneLabel11";
            siticoneLabel11.Size = new Size(142, 26);
            siticoneLabel11.TabIndex = 99;
            siticoneLabel11.Text = "Address";
            siticoneLabel11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ActiveCaptionText;
            lblEmail.Location = new Point(146, 287);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(231, 26);
            lblEmail.TabIndex = 98;
            lblEmail.Text = "Nationality";
            lblEmail.TextAlign = ContentAlignment.TopRight;
            // 
            // siticonehSeparator6
            // 
            siticonehSeparator6.BackColor = Color.Transparent;
            siticonehSeparator6.GradientEndColor = Color.Black;
            siticonehSeparator6.GradientMode = SiticoneHSeparator.LinearGradientMode.None;
            siticonehSeparator6.GradientStartColor = Color.White;
            siticonehSeparator6.LineColor = Color.FromArgb(230, 236, 235);
            siticonehSeparator6.LineWidth = 1;
            siticonehSeparator6.Location = new Point(23, 321);
            siticonehSeparator6.Name = "siticonehSeparator6";
            siticonehSeparator6.ParallelLines = 1;
            siticonehSeparator6.ParallelLineSpacing = 4;
            siticonehSeparator6.SegmentNumberColor = Color.Black;
            siticonehSeparator6.SegmentNumberFont = new Font("Arial", 8F);
            siticonehSeparator6.Segments = 1;
            siticonehSeparator6.SegmentSpacing = 10;
            siticonehSeparator6.SeparatorDashStyle = SiticoneHSeparator.CustomDashStyle.Solid;
            siticonehSeparator6.ShowSegmentNumbers = false;
            siticonehSeparator6.Size = new Size(354, 17);
            siticonehSeparator6.TabIndex = 97;
            siticonehSeparator6.Text = "siticonehSeparator6";
            // 
            // siticoneLabel9
            // 
            siticoneLabel9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            siticoneLabel9.ForeColor = Color.FromArgb(90, 107, 106);
            siticoneLabel9.Location = new Point(20, 287);
            siticoneLabel9.Name = "siticoneLabel9";
            siticoneLabel9.Size = new Size(142, 26);
            siticoneLabel9.TabIndex = 96;
            siticoneLabel9.Text = "Email";
            siticoneLabel9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPhone
            // 
            lblPhone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = SystemColors.ActiveCaptionText;
            lblPhone.Location = new Point(146, 233);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(231, 26);
            lblPhone.TabIndex = 95;
            lblPhone.Text = "Nationality";
            lblPhone.TextAlign = ContentAlignment.TopRight;
            // 
            // siticonehSeparator5
            // 
            siticonehSeparator5.BackColor = Color.Transparent;
            siticonehSeparator5.GradientEndColor = Color.Black;
            siticonehSeparator5.GradientMode = SiticoneHSeparator.LinearGradientMode.None;
            siticonehSeparator5.GradientStartColor = Color.White;
            siticonehSeparator5.LineColor = Color.FromArgb(230, 236, 235);
            siticonehSeparator5.LineWidth = 1;
            siticonehSeparator5.Location = new Point(23, 267);
            siticonehSeparator5.Name = "siticonehSeparator5";
            siticonehSeparator5.ParallelLines = 1;
            siticonehSeparator5.ParallelLineSpacing = 4;
            siticonehSeparator5.SegmentNumberColor = Color.Black;
            siticonehSeparator5.SegmentNumberFont = new Font("Arial", 8F);
            siticonehSeparator5.Segments = 1;
            siticonehSeparator5.SegmentSpacing = 10;
            siticonehSeparator5.SeparatorDashStyle = SiticoneHSeparator.CustomDashStyle.Solid;
            siticonehSeparator5.ShowSegmentNumbers = false;
            siticonehSeparator5.Size = new Size(354, 17);
            siticonehSeparator5.TabIndex = 94;
            siticonehSeparator5.Text = "siticonehSeparator5";
            // 
            // siticoneLabel7
            // 
            siticoneLabel7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            siticoneLabel7.ForeColor = Color.FromArgb(90, 107, 106);
            siticoneLabel7.Location = new Point(20, 233);
            siticoneLabel7.Name = "siticoneLabel7";
            siticoneLabel7.Size = new Size(142, 26);
            siticoneLabel7.TabIndex = 93;
            siticoneLabel7.Text = "Phone";
            siticoneLabel7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNationality
            // 
            lblNationality.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNationality.ForeColor = SystemColors.ActiveCaptionText;
            lblNationality.Location = new Point(146, 179);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(231, 26);
            lblNationality.TabIndex = 92;
            lblNationality.Text = "Nationality";
            lblNationality.TextAlign = ContentAlignment.TopRight;
            // 
            // siticonehSeparator4
            // 
            siticonehSeparator4.BackColor = Color.Transparent;
            siticonehSeparator4.GradientEndColor = Color.Black;
            siticonehSeparator4.GradientMode = SiticoneHSeparator.LinearGradientMode.None;
            siticonehSeparator4.GradientStartColor = Color.White;
            siticonehSeparator4.LineColor = Color.FromArgb(230, 236, 235);
            siticonehSeparator4.LineWidth = 1;
            siticonehSeparator4.Location = new Point(23, 213);
            siticonehSeparator4.Name = "siticonehSeparator4";
            siticonehSeparator4.ParallelLines = 1;
            siticonehSeparator4.ParallelLineSpacing = 4;
            siticonehSeparator4.SegmentNumberColor = Color.Black;
            siticonehSeparator4.SegmentNumberFont = new Font("Arial", 8F);
            siticonehSeparator4.Segments = 1;
            siticonehSeparator4.SegmentSpacing = 10;
            siticonehSeparator4.SeparatorDashStyle = SiticoneHSeparator.CustomDashStyle.Solid;
            siticonehSeparator4.ShowSegmentNumbers = false;
            siticonehSeparator4.Size = new Size(354, 17);
            siticonehSeparator4.TabIndex = 91;
            siticonehSeparator4.Text = "siticonehSeparator4";
            // 
            // siticoneLabel5
            // 
            siticoneLabel5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            siticoneLabel5.ForeColor = Color.FromArgb(90, 107, 106);
            siticoneLabel5.Location = new Point(20, 179);
            siticoneLabel5.Name = "siticoneLabel5";
            siticoneLabel5.Size = new Size(142, 26);
            siticoneLabel5.TabIndex = 90;
            siticoneLabel5.Text = "Nationality";
            siticoneLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // siticoneLabel15
            // 
            siticoneLabel15.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel15.ForeColor = SystemColors.ActiveCaptionText;
            siticoneLabel15.Location = new Point(17, 23);
            siticoneLabel15.Name = "siticoneLabel15";
            siticoneLabel15.Size = new Size(312, 42);
            siticoneLabel15.TabIndex = 89;
            siticoneLabel15.Text = "Personal Details";
            // 
            // lblIdNumber
            // 
            lblIdNumber.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdNumber.ForeColor = SystemColors.ActiveCaptionText;
            lblIdNumber.Location = new Point(146, 125);
            lblIdNumber.Name = "lblIdNumber";
            lblIdNumber.Size = new Size(231, 26);
            lblIdNumber.TabIndex = 87;
            lblIdNumber.Text = "Nationality";
            lblIdNumber.TextAlign = ContentAlignment.TopRight;
            // 
            // lblIdType
            // 
            lblIdType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdType.ForeColor = SystemColors.ActiveCaptionText;
            lblIdType.Location = new Point(146, 74);
            lblIdType.Name = "lblIdType";
            lblIdType.Size = new Size(231, 26);
            lblIdType.TabIndex = 86;
            lblIdType.Text = "Nationality";
            lblIdType.TextAlign = ContentAlignment.TopRight;
            // 
            // siticonehSeparator3
            // 
            siticonehSeparator3.BackColor = Color.Transparent;
            siticonehSeparator3.GradientEndColor = Color.Black;
            siticonehSeparator3.GradientMode = SiticoneHSeparator.LinearGradientMode.None;
            siticonehSeparator3.GradientStartColor = Color.White;
            siticonehSeparator3.LineColor = Color.FromArgb(230, 236, 235);
            siticonehSeparator3.LineWidth = 1;
            siticonehSeparator3.Location = new Point(23, 159);
            siticonehSeparator3.Name = "siticonehSeparator3";
            siticonehSeparator3.ParallelLines = 1;
            siticonehSeparator3.ParallelLineSpacing = 4;
            siticonehSeparator3.SegmentNumberColor = Color.Black;
            siticonehSeparator3.SegmentNumberFont = new Font("Arial", 8F);
            siticonehSeparator3.Segments = 1;
            siticonehSeparator3.SegmentSpacing = 10;
            siticonehSeparator3.SeparatorDashStyle = SiticoneHSeparator.CustomDashStyle.Solid;
            siticonehSeparator3.ShowSegmentNumbers = false;
            siticonehSeparator3.Size = new Size(354, 17);
            siticonehSeparator3.TabIndex = 84;
            siticonehSeparator3.Text = "siticonehSeparator3";
            // 
            // siticonehSeparator2
            // 
            siticonehSeparator2.BackColor = Color.Transparent;
            siticonehSeparator2.GradientEndColor = Color.Black;
            siticonehSeparator2.GradientMode = SiticoneHSeparator.LinearGradientMode.None;
            siticonehSeparator2.GradientStartColor = Color.White;
            siticonehSeparator2.LineColor = Color.FromArgb(230, 236, 235);
            siticonehSeparator2.LineWidth = 1;
            siticonehSeparator2.Location = new Point(23, 105);
            siticonehSeparator2.Name = "siticonehSeparator2";
            siticonehSeparator2.ParallelLines = 1;
            siticonehSeparator2.ParallelLineSpacing = 4;
            siticonehSeparator2.SegmentNumberColor = Color.Black;
            siticonehSeparator2.SegmentNumberFont = new Font("Arial", 8F);
            siticonehSeparator2.Segments = 1;
            siticonehSeparator2.SegmentSpacing = 10;
            siticonehSeparator2.SeparatorDashStyle = SiticoneHSeparator.CustomDashStyle.Solid;
            siticonehSeparator2.ShowSegmentNumbers = false;
            siticonehSeparator2.Size = new Size(354, 17);
            siticonehSeparator2.TabIndex = 83;
            siticonehSeparator2.Text = "siticonehSeparator2";
            // 
            // siticoneLabel4
            // 
            siticoneLabel4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            siticoneLabel4.ForeColor = Color.FromArgb(90, 107, 106);
            siticoneLabel4.Location = new Point(20, 125);
            siticoneLabel4.Name = "siticoneLabel4";
            siticoneLabel4.Size = new Size(142, 26);
            siticoneLabel4.TabIndex = 81;
            siticoneLabel4.Text = "ID Number";
            siticoneLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // siticoneLabel2
            // 
            siticoneLabel2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            siticoneLabel2.ForeColor = Color.FromArgb(90, 107, 106);
            siticoneLabel2.Location = new Point(20, 74);
            siticoneLabel2.Name = "siticoneLabel2";
            siticoneLabel2.Size = new Size(142, 26);
            siticoneLabel2.TabIndex = 80;
            siticoneLabel2.Text = "ID Type";
            siticoneLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSub
            // 
            lblSub.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSub.ForeColor = Color.FromArgb(15, 76, 76);
            lblSub.Location = new Point(160, 151);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(945, 32);
            lblSub.TabIndex = 77;
            lblSub.Text = "[Medical role] * [Facility name]";
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ActiveCaptionText;
            lblName.Location = new Point(160, 114);
            lblName.Name = "lblName";
            lblName.Size = new Size(945, 37);
            lblName.TabIndex = 76;
            lblName.Text = "Siti Noraeishah binti Abdul Bari Arbee";
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
            picAvatar.Location = new Point(29, 93);
            picAvatar.MaintainAspectRatio = true;
            picAvatar.Name = "picAvatar";
            picAvatar.PlaceholderImage = null;
            picAvatar.RotationAngle = 0F;
            picAvatar.Saturation = 1F;
            picAvatar.ShowBorder = true;
            picAvatar.Size = new Size(110, 110);
            picAvatar.SizeMode = SiticoneNetCoreUI.Helpers.Enum.SiticonePictureBoxSizeMode.Normal;
            picAvatar.TabIndex = 76;
            picAvatar.Text = "siticonePictureBox1";
            // 
            // siticonePanel1
            // 
            siticonePanel1.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            siticonePanel1.BackColor = Color.Transparent;
            siticonePanel1.BorderAlignment = PenAlignment.Center;
            siticonePanel1.BorderColor = Color.FromArgb(210, 210, 210);
            siticonePanel1.BorderDashPattern = null;
            siticonePanel1.BorderGradientEndColor = Color.Purple;
            siticonePanel1.BorderGradientStartColor = Color.Blue;
            siticonePanel1.BorderThickness = 2F;
            siticonePanel1.Controls.Add(siticoneLabel25);
            siticonePanel1.CornerRadiusBottomLeft = 25F;
            siticonePanel1.CornerRadiusBottomRight = 25F;
            siticonePanel1.CornerRadiusTopLeft = 25F;
            siticonePanel1.CornerRadiusTopRight = 25F;
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
            siticonePanel1.Location = new Point(464, 251);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.PatternColor = Color.FromArgb(30, 0, 0, 0);
            siticonePanel1.PatternStyle = HatchStyle.Max;
            siticonePanel1.RippleAlpha = 50;
            siticonePanel1.RippleAlphaDecrement = 3;
            siticonePanel1.RippleColor = Color.FromArgb(50, 255, 255, 255);
            siticonePanel1.RippleMaxSize = 600F;
            siticonePanel1.RippleSpeed = 15F;
            siticonePanel1.ShowBorder = true;
            siticonePanel1.Size = new Size(648, 456);
            siticonePanel1.TabIndex = 105;
            siticonePanel1.TabStop = true;
            siticonePanel1.UseBorderGradient = false;
            siticonePanel1.UseMultiGradient = false;
            siticonePanel1.UsePatternTexture = false;
            siticonePanel1.UseRadialGradient = false;
            // 
            // siticoneLabel25
            // 
            siticoneLabel25.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel25.ForeColor = SystemColors.ActiveCaptionText;
            siticoneLabel25.Location = new Point(18, 19);
            siticoneLabel25.Name = "siticoneLabel25";
            siticoneLabel25.Size = new Size(312, 42);
            siticoneLabel25.TabIndex = 89;
            siticoneLabel25.Text = "Appointment History";
            // 
            // dgvAppts
            // 
            dgvAppts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppts.Location = new Point(482, 319);
            dgvAppts.Name = "dgvAppts";
            dgvAppts.RowHeadersWidth = 51;
            dgvAppts.Size = new Size(615, 371);
            dgvAppts.TabIndex = 106;
            // 
            // siticonePanel2
            // 
            siticonePanel2.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            siticonePanel2.BackColor = Color.Transparent;
            siticonePanel2.BorderAlignment = PenAlignment.Center;
            siticonePanel2.BorderColor = Color.FromArgb(210, 210, 210);
            siticonePanel2.BorderDashPattern = null;
            siticonePanel2.BorderGradientEndColor = Color.Purple;
            siticonePanel2.BorderGradientStartColor = Color.Blue;
            siticonePanel2.BorderThickness = 2F;
            siticonePanel2.Controls.Add(btnOpenRecord);
            siticonePanel2.Controls.Add(dgvRecords);
            siticonePanel2.Controls.Add(siticoneLabel14);
            siticonePanel2.CornerRadiusBottomLeft = 25F;
            siticonePanel2.CornerRadiusBottomRight = 25F;
            siticonePanel2.CornerRadiusTopLeft = 25F;
            siticonePanel2.CornerRadiusTopRight = 25F;
            siticonePanel2.EnableAcrylicEffect = false;
            siticonePanel2.EnableMicaEffect = false;
            siticonePanel2.EnableRippleEffect = false;
            siticonePanel2.FillColor = Color.White;
            siticonePanel2.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            siticonePanel2.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            siticonePanel2.Location = new Point(29, 734);
            siticonePanel2.Name = "siticonePanel2";
            siticonePanel2.PatternColor = Color.FromArgb(30, 0, 0, 0);
            siticonePanel2.PatternStyle = HatchStyle.Max;
            siticonePanel2.RippleAlpha = 50;
            siticonePanel2.RippleAlphaDecrement = 3;
            siticonePanel2.RippleColor = Color.FromArgb(50, 255, 255, 255);
            siticonePanel2.RippleMaxSize = 600F;
            siticonePanel2.RippleSpeed = 15F;
            siticonePanel2.ShowBorder = true;
            siticonePanel2.Size = new Size(1083, 414);
            siticonePanel2.TabIndex = 106;
            siticonePanel2.TabStop = true;
            siticonePanel2.UseBorderGradient = false;
            siticonePanel2.UseMultiGradient = false;
            siticonePanel2.UsePatternTexture = false;
            siticonePanel2.UseRadialGradient = false;
            // 
            // btnOpenRecord
            // 
            btnOpenRecord.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnOpenRecord.AccessibleName = "Open Record";
            btnOpenRecord.BadgeBackColor = Color.Black;
            btnOpenRecord.BadgeBorderColor = Color.Empty;
            btnOpenRecord.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnOpenRecord.BadgeValueForeColor = Color.White;
            btnOpenRecord.BorderColor = Color.FromArgb(15, 76, 76);
            btnOpenRecord.BorderWidth = 2;
            btnOpenRecord.BusyIndicatorColor = Color.Empty;
            btnOpenRecord.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnOpenRecord.CornerRadiusBottomLeft = 24;
            btnOpenRecord.CornerRadiusBottomRight = 24;
            btnOpenRecord.CornerRadiusTopLeft = 24;
            btnOpenRecord.CornerRadiusTopRight = 24;
            btnOpenRecord.CustomCursor = Cursors.Default;
            btnOpenRecord.DisabledBackColor = Color.Empty;
            btnOpenRecord.DisabledBorderColor = Color.Empty;
            btnOpenRecord.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnOpenRecord.FocusRingColor = Color.Empty;
            btnOpenRecord.Font = new Font("Segoe UI Semibold", 10.2F);
            btnOpenRecord.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnOpenRecord.GradientColor = Color.FromArgb(0, 227, 64);
            btnOpenRecord.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnOpenRecord.HoverBorderColor = Color.Empty;
            btnOpenRecord.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnOpenRecord.ImageSize = new Size(16, 16);
            btnOpenRecord.IsRadial = true;
            btnOpenRecord.Location = new Point(896, 346);
            btnOpenRecord.Margin = new Padding(6, 3, 3, 3);
            btnOpenRecord.Name = "btnOpenRecord";
            btnOpenRecord.ParticleColor = Color.FromArgb(200, 200, 200);
            btnOpenRecord.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnOpenRecord.PressedBorderColor = Color.Empty;
            btnOpenRecord.PressedTextColor = Color.Empty;
            btnOpenRecord.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnOpenRecord.RippleColor = Color.FromArgb(0, 0, 0);
            btnOpenRecord.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnOpenRecord.ShadowOffset = new Point(0, 2);
            btnOpenRecord.Size = new Size(163, 52);
            btnOpenRecord.TabIndex = 109;
            btnOpenRecord.Text = "Open Record";
            btnOpenRecord.TextColor = Color.FromArgb(0, 0, 0);
            btnOpenRecord.ToggledBackColor = Color.Empty;
            btnOpenRecord.ToggledBorderColor = Color.Empty;
            btnOpenRecord.ToggledTextColor = Color.Empty;
            btnOpenRecord.Click += btnOpenRecord_Click;
            // 
            // dgvRecords
            // 
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(23, 66);
            dgvRecords.Name = "dgvRecords";
            dgvRecords.RowHeadersWidth = 51;
            dgvRecords.Size = new Size(1036, 266);
            dgvRecords.TabIndex = 107;
            // 
            // siticoneLabel14
            // 
            siticoneLabel14.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel14.ForeColor = SystemColors.ActiveCaptionText;
            siticoneLabel14.Location = new Point(18, 21);
            siticoneLabel14.Name = "siticoneLabel14";
            siticoneLabel14.Size = new Size(312, 42);
            siticoneLabel14.TabIndex = 89;
            siticoneLabel14.Text = "Medical Records";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BorderRadius = 8;
            btnBack.BounceDuration = 500;
            btnBack.BounceStrength = 0.3F;
            btnBack.CanBeep = true;
            btnBack.CanShake = true;
            btnBack.EnableParticles = true;
            btnBack.EnablePulseEffect = true;
            btnBack.EnableRippleEffect = true;
            btnBack.EnableShadow = true;
            btnBack.HoverAnimationSpeed = 200;
            btnBack.HoverColor = Color.FromArgb(240, 240, 240);
            btnBack.HoverOpacity = 150;
            btnBack.IconColor = Color.FromArgb(64, 64, 64);
            btnBack.IconSize = 20F;
            btnBack.IconStrokeWidth = 2F;
            btnBack.InteractiveBounce = false;
            btnBack.IsInteractive = true;
            btnBack.IsReadOnly = false;
            btnBack.Location = new Point(19, 19);
            btnBack.Name = "btnBack";
            btnBack.ParticleColor = Color.FromArgb(100, 149, 237);
            btnBack.ParticleCount = 20;
            btnBack.ParticleSpeed = 3F;
            btnBack.PressAnimationSpeed = 100;
            btnBack.PressColor = Color.FromArgb(240, 240, 240);
            btnBack.PressDepthOffset = 2;
            btnBack.PressShadowColor = Color.FromArgb(240, 240, 240);
            btnBack.ShadowColor = Color.FromArgb(50, 0, 0, 0);
            btnBack.ShadowDepth = 3;
            btnBack.Size = new Size(50, 50);
            btnBack.TabIndex = 107;
            btnBack.Text = "siticoneNavBackButton1";
            btnBack.Click += btnBack_Click;
            // 
            // siticoneLabel16
            // 
            siticoneLabel16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel16.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel16.Location = new Point(60, 27);
            siticoneLabel16.Name = "siticoneLabel16";
            siticoneLabel16.Size = new Size(344, 32);
            siticoneLabel16.TabIndex = 108;
            siticoneLabel16.Text = "Patients";
            siticoneLabel16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PatientDetailsScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(siticoneLabel16);
            Controls.Add(btnBack);
            Controls.Add(siticonePanel2);
            Controls.Add(dgvAppts);
            Controls.Add(siticonePanel1);
            Controls.Add(pnlInfo);
            Controls.Add(picAvatar);
            Controls.Add(lblName);
            Controls.Add(lblSub);
            Name = "PatientDetailsScreen";
            Size = new Size(1136, 1196);
            pnlInfo.ResumeLayout(false);
            siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAppts).EndInit();
            siticonePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SiticonePanel pnlInfo;
        private SiticoneLabel lblIdNumber;
        private SiticoneLabel lblIdType;
        private SiticoneHSeparator siticonehSeparator3;
        private SiticoneHSeparator siticonehSeparator2;
        private SiticoneLabel siticoneLabel4;
        private SiticoneLabel siticoneLabel2;
        private SiticoneLabel lblSub;
        private SiticoneLabel lblName;
        private SiticonePictureBox picAvatar;
        private SiticoneLabel siticoneLabel15;
        private SiticoneLabel lblRegistered;
        private SiticoneLabel siticoneLabel13;
        private SiticoneLabel lblAddress;
        private SiticoneHSeparator siticonehSeparator7;
        private SiticoneLabel siticoneLabel11;
        private SiticoneLabel lblEmail;
        private SiticoneHSeparator siticonehSeparator6;
        private SiticoneLabel siticoneLabel9;
        private SiticoneLabel lblPhone;
        private SiticoneHSeparator siticonehSeparator5;
        private SiticoneLabel siticoneLabel7;
        private SiticoneLabel lblNationality;
        private SiticoneHSeparator siticonehSeparator4;
        private SiticoneLabel siticoneLabel5;
        private SiticonePanel siticonePanel1;
        private SiticoneLabel siticoneLabel25;
        private DataGridView dgvAppts;
        private SiticonePanel siticonePanel2;
        private DataGridView dgvRecords;
        private SiticoneLabel siticoneLabel14;
        private SiticoneNavBackButton btnBack;
        private SiticoneLabel siticoneLabel16;
        private SiticoneButton btnOpenRecord;
    }
}
