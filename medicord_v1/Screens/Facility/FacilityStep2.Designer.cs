namespace medicord_v1.Screens.Facility
{
    partial class FacilityStep2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacilityStep2));
            pnlLeft = new SiticonePanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblStep4 = new SiticoneLabel();
            lblStep3 = new SiticoneLabel();
            lblStep2 = new SiticoneLabel();
            lblStep1 = new SiticoneLabel();
            siticonePictureBox1 = new SiticonePictureBox();
            siticoneShimmerLabel1 = new SiticoneShimmerLabel();
            pnlRight = new SiticonePanel();
            pnlForm = new SiticonePanel();
            txtCity = new SiticoneTextBox();
            txtAddress = new SiticoneTextBox();
            ddState = new SiticoneDropdown();
            txtPhone = new SiticoneTextBox();
            txtPostcode = new SiticoneTextBox();
            btnBack = new SiticoneButton();
            siticoneLabel1 = new SiticoneLabel();
            siticoneLabel4 = new SiticoneLabel();
            btnNext = new SiticoneButton();
            pnlLeft.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            pnlLeft.BackColor = Color.Transparent;
            pnlLeft.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            pnlLeft.BorderColor = Color.FromArgb(15, 76, 76);
            pnlLeft.BorderDashPattern = null;
            pnlLeft.BorderGradientEndColor = Color.Purple;
            pnlLeft.BorderGradientStartColor = Color.Blue;
            pnlLeft.BorderThickness = 2F;
            pnlLeft.Controls.Add(tableLayoutPanel1);
            pnlLeft.Controls.Add(siticonePictureBox1);
            pnlLeft.Controls.Add(siticoneShimmerLabel1);
            pnlLeft.CornerRadiusBottomLeft = 0F;
            pnlLeft.CornerRadiusBottomRight = 0F;
            pnlLeft.CornerRadiusTopLeft = 0F;
            pnlLeft.CornerRadiusTopRight = 0F;
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.EnableAcrylicEffect = false;
            pnlLeft.EnableMicaEffect = false;
            pnlLeft.EnableRippleEffect = false;
            pnlLeft.FillColor = Color.FromArgb(14, 79, 77);
            pnlLeft.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            pnlLeft.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.PatternColor = Color.FromArgb(30, 0, 0, 0);
            pnlLeft.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            pnlLeft.RippleAlpha = 50;
            pnlLeft.RippleAlphaDecrement = 3;
            pnlLeft.RippleColor = Color.FromArgb(50, 255, 255, 255);
            pnlLeft.RippleMaxSize = 600F;
            pnlLeft.RippleSpeed = 15F;
            pnlLeft.ShowBorder = true;
            pnlLeft.Size = new Size(500, 903);
            pnlLeft.TabIndex = 3;
            pnlLeft.TabStop = true;
            pnlLeft.UseBorderGradient = false;
            pnlLeft.UseMultiGradient = false;
            pnlLeft.UsePatternTexture = false;
            pnlLeft.UseRadialGradient = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(lblStep4, 0, 3);
            tableLayoutPanel1.Controls.Add(lblStep3, 0, 2);
            tableLayoutPanel1.Controls.Add(lblStep2, 0, 1);
            tableLayoutPanel1.Controls.Add(lblStep1, 0, 0);
            tableLayoutPanel1.Location = new Point(40, 229);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(353, 283);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // lblStep4
            // 
            lblStep4.Dock = DockStyle.Fill;
            lblStep4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStep4.ForeColor = Color.White;
            lblStep4.Location = new Point(3, 210);
            lblStep4.Name = "lblStep4";
            lblStep4.Size = new Size(347, 73);
            lblStep4.TabIndex = 43;
            lblStep4.Text = "4     Account";
            lblStep4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStep3
            // 
            lblStep3.Dock = DockStyle.Fill;
            lblStep3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStep3.ForeColor = Color.White;
            lblStep3.Location = new Point(3, 140);
            lblStep3.Name = "lblStep3";
            lblStep3.Size = new Size(347, 70);
            lblStep3.TabIndex = 41;
            lblStep3.Text = "3     Hours and Booking";
            lblStep3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStep2
            // 
            lblStep2.Dock = DockStyle.Fill;
            lblStep2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStep2.ForeColor = Color.White;
            lblStep2.Location = new Point(3, 70);
            lblStep2.Name = "lblStep2";
            lblStep2.Size = new Size(347, 70);
            lblStep2.TabIndex = 39;
            lblStep2.Text = "2     Address";
            lblStep2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStep1
            // 
            lblStep1.Dock = DockStyle.Fill;
            lblStep1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStep1.ForeColor = Color.White;
            lblStep1.Location = new Point(3, 0);
            lblStep1.Name = "lblStep1";
            lblStep1.Size = new Size(347, 70);
            lblStep1.TabIndex = 36;
            lblStep1.Text = "1     Facility Details";
            lblStep1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // siticonePictureBox1
            // 
            siticonePictureBox1.BackColor = Color.Transparent;
            siticonePictureBox1.BorderColor = Color.White;
            siticonePictureBox1.BorderWidth = 0;
            siticonePictureBox1.Brightness = 1F;
            siticonePictureBox1.Contrast = 1F;
            siticonePictureBox1.CornerRadius = 10;
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
            siticonePictureBox1.EnableShadow = true;
            siticonePictureBox1.EnableSlideshow = false;
            siticonePictureBox1.FlipHorizontal = false;
            siticonePictureBox1.FlipVertical = false;
            siticonePictureBox1.Grayscale = false;
            siticonePictureBox1.Image = (Image)resources.GetObject("siticonePictureBox1.Image");
            siticonePictureBox1.ImageOpacity = 1F;
            siticonePictureBox1.Images = (List<Image>)resources.GetObject("siticonePictureBox1.Images");
            siticonePictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            siticonePictureBox1.IsCircular = false;
            siticonePictureBox1.Location = new Point(40, 35);
            siticonePictureBox1.MaintainAspectRatio = true;
            siticonePictureBox1.Name = "siticonePictureBox1";
            siticonePictureBox1.PlaceholderImage = null;
            siticonePictureBox1.RotationAngle = 0F;
            siticonePictureBox1.Saturation = 1F;
            siticonePictureBox1.ShowBorder = false;
            siticonePictureBox1.Size = new Size(106, 108);
            siticonePictureBox1.SizeMode = SiticoneNetCoreUI.Helpers.Enum.SiticonePictureBoxSizeMode.Zoom;
            siticonePictureBox1.TabIndex = 16;
            siticonePictureBox1.Text = "siticonePictureBox1";
            // 
            // siticoneShimmerLabel1
            // 
            siticoneShimmerLabel1.BackColor = Color.Transparent;
            siticoneShimmerLabel1.BaseColor = Color.White;
            siticoneShimmerLabel1.Font = new Font("Segoe UI", 34.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneShimmerLabel1.ForeColor = Color.White;
            siticoneShimmerLabel1.Location = new Point(139, 59);
            siticoneShimmerLabel1.Name = "siticoneShimmerLabel1";
            siticoneShimmerLabel1.ShimmerColor = Color.Cyan;
            siticoneShimmerLabel1.Size = new Size(329, 62);
            siticoneShimmerLabel1.TabIndex = 13;
            siticoneShimmerLabel1.Text = "Medicord";
            // 
            // pnlRight
            // 
            pnlRight.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            pnlRight.BackColor = Color.Transparent;
            pnlRight.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            pnlRight.BorderColor = Color.Transparent;
            pnlRight.BorderDashPattern = null;
            pnlRight.BorderGradientEndColor = Color.Purple;
            pnlRight.BorderGradientStartColor = Color.Blue;
            pnlRight.BorderThickness = 2F;
            pnlRight.Controls.Add(pnlForm);
            pnlRight.CornerRadiusBottomLeft = 0F;
            pnlRight.CornerRadiusBottomRight = 0F;
            pnlRight.CornerRadiusTopLeft = 0F;
            pnlRight.CornerRadiusTopRight = 0F;
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.EnableAcrylicEffect = false;
            pnlRight.EnableMicaEffect = false;
            pnlRight.EnableRippleEffect = false;
            pnlRight.FillColor = Color.White;
            pnlRight.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            pnlRight.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            pnlRight.Location = new Point(500, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.PatternColor = Color.FromArgb(30, 0, 0, 0);
            pnlRight.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            pnlRight.RippleAlpha = 50;
            pnlRight.RippleAlphaDecrement = 3;
            pnlRight.RippleColor = Color.FromArgb(50, 255, 255, 255);
            pnlRight.RippleMaxSize = 600F;
            pnlRight.RippleSpeed = 15F;
            pnlRight.ShowBorder = true;
            pnlRight.Size = new Size(963, 903);
            pnlRight.TabIndex = 4;
            pnlRight.TabStop = true;
            pnlRight.UseBorderGradient = false;
            pnlRight.UseMultiGradient = false;
            pnlRight.UsePatternTexture = false;
            pnlRight.UseRadialGradient = false;
            // 
            // pnlForm
            // 
            pnlForm.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            pnlForm.BackColor = Color.Transparent;
            pnlForm.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            pnlForm.BorderColor = Color.Transparent;
            pnlForm.BorderDashPattern = null;
            pnlForm.BorderGradientEndColor = Color.Purple;
            pnlForm.BorderGradientStartColor = Color.Blue;
            pnlForm.BorderThickness = 2F;
            pnlForm.Controls.Add(txtCity);
            pnlForm.Controls.Add(txtAddress);
            pnlForm.Controls.Add(ddState);
            pnlForm.Controls.Add(txtPhone);
            pnlForm.Controls.Add(txtPostcode);
            pnlForm.Controls.Add(btnBack);
            pnlForm.Controls.Add(siticoneLabel1);
            pnlForm.Controls.Add(siticoneLabel4);
            pnlForm.Controls.Add(btnNext);
            pnlForm.CornerRadiusBottomLeft = 0F;
            pnlForm.CornerRadiusBottomRight = 0F;
            pnlForm.CornerRadiusTopLeft = 0F;
            pnlForm.CornerRadiusTopRight = 0F;
            pnlForm.EnableAcrylicEffect = false;
            pnlForm.EnableMicaEffect = false;
            pnlForm.EnableRippleEffect = false;
            pnlForm.FillColor = Color.White;
            pnlForm.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            pnlForm.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            pnlForm.Location = new Point(130, 0);
            pnlForm.Name = "pnlForm";
            pnlForm.PatternColor = Color.FromArgb(30, 0, 0, 0);
            pnlForm.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            pnlForm.RippleAlpha = 50;
            pnlForm.RippleAlphaDecrement = 3;
            pnlForm.RippleColor = Color.FromArgb(50, 255, 255, 255);
            pnlForm.RippleMaxSize = 600F;
            pnlForm.RippleSpeed = 15F;
            pnlForm.ShowBorder = true;
            pnlForm.Size = new Size(701, 903);
            pnlForm.TabIndex = 0;
            pnlForm.TabStop = true;
            pnlForm.UseBorderGradient = false;
            pnlForm.UseMultiGradient = false;
            pnlForm.UsePatternTexture = false;
            pnlForm.UseRadialGradient = false;
            // 
            // txtCity
            // 
            txtCity.AccessibleDescription = "A customizable text input field.";
            txtCity.AccessibleName = "Text Box";
            txtCity.AccessibleRole = AccessibleRole.Text;
            txtCity.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtCity.BorderColor2 = Color.FromArgb(210, 210, 210);
            txtCity.BorderFocusColor1 = Color.FromArgb(33, 150, 243);
            txtCity.BorderFocusColor2 = Color.FromArgb(33, 150, 243);
            txtCity.BorderSize = 2;
            txtCity.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtCity.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtCity.CornerRadiusBottomLeft = 10;
            txtCity.CornerRadiusBottomRight = 10;
            txtCity.CornerRadiusTopLeft = 10;
            txtCity.CornerRadiusTopRight = 10;
            txtCity.CursorColor = Color.FromArgb(32, 32, 32);
            txtCity.DisabledBackColor = Color.WhiteSmoke;
            txtCity.DisabledBorderColor = Color.LightGray;
            txtCity.DisabledTextColor = Color.Gray;
            txtCity.FillColor1 = Color.White;
            txtCity.FillColor2 = Color.White;
            txtCity.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.ForeColor = Color.Black;
            txtCity.HoverBorderColor1 = Color.Gray;
            txtCity.HoverBorderColor2 = Color.Gray;
            txtCity.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtCity.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtCity.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtCity.Location = new Point(32, 341);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderColor = Color.Gray;
            txtCity.PlaceholderText = "City";
            txtCity.ReadOnlyBorderColor1 = Color.LightGray;
            txtCity.ReadOnlyBorderColor2 = Color.LightGray;
            txtCity.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtCity.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtCity.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtCity.ReadOnlyTextColor = Color.Empty;
            txtCity.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtCity.SelectionForeColor = SystemColors.HighlightText;
            txtCity.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtCity.Size = new Size(303, 62);
            txtCity.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtCity.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtCity.SolidBorderHoverColor = Color.Gray;
            txtCity.SolidFillColor = Color.White;
            txtCity.TabIndex = 57;
            // 
            // txtAddress
            // 
            txtAddress.AccessibleDescription = "A customizable text input field.";
            txtAddress.AccessibleName = "Text Box";
            txtAddress.AccessibleRole = AccessibleRole.Text;
            txtAddress.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtAddress.BorderColor2 = Color.FromArgb(210, 210, 210);
            txtAddress.BorderFocusColor1 = Color.FromArgb(33, 150, 243);
            txtAddress.BorderFocusColor2 = Color.FromArgb(33, 150, 243);
            txtAddress.BorderSize = 2;
            txtAddress.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtAddress.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtAddress.CornerRadiusBottomLeft = 10;
            txtAddress.CornerRadiusBottomRight = 10;
            txtAddress.CornerRadiusTopLeft = 10;
            txtAddress.CornerRadiusTopRight = 10;
            txtAddress.CursorColor = Color.FromArgb(32, 32, 32);
            txtAddress.DisabledBackColor = Color.WhiteSmoke;
            txtAddress.DisabledBorderColor = Color.LightGray;
            txtAddress.DisabledTextColor = Color.Gray;
            txtAddress.FillColor1 = Color.White;
            txtAddress.FillColor2 = Color.White;
            txtAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.ForeColor = Color.Black;
            txtAddress.HoverBorderColor1 = Color.Gray;
            txtAddress.HoverBorderColor2 = Color.Gray;
            txtAddress.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtAddress.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtAddress.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtAddress.Location = new Point(32, 226);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderColor = Color.Gray;
            txtAddress.PlaceholderText = "Address Line";
            txtAddress.ReadOnlyBorderColor1 = Color.LightGray;
            txtAddress.ReadOnlyBorderColor2 = Color.LightGray;
            txtAddress.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtAddress.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtAddress.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtAddress.ReadOnlyTextColor = Color.Empty;
            txtAddress.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtAddress.SelectionForeColor = SystemColors.HighlightText;
            txtAddress.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtAddress.Size = new Size(633, 62);
            txtAddress.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtAddress.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtAddress.SolidBorderHoverColor = Color.Gray;
            txtAddress.SolidFillColor = Color.White;
            txtAddress.TabIndex = 56;
            // 
            // ddState
            // 
            ddState.AllowMultipleSelection = false;
            ddState.BackColor = Color.FromArgb(255, 255, 255);
            ddState.BorderColor = Color.FromArgb(210, 210, 210);
            ddState.BorderSize = 2;
            ddState.CanBeep = false;
            ddState.CanShake = true;
            ddState.CornerRadius = 10;
            ddState.DataSource = null;
            ddState.DisplayMember = null;
            ddState.DropdownBackColor = Color.FromArgb(255, 255, 255);
            ddState.DropdownWidth = 0;
            ddState.DropShadowEnabled = false;
            ddState.EnableSearch = true;
            ddState.Font = new Font("Segoe UI", 10F);
            ddState.ForeColor = Color.FromArgb(60, 60, 60);
            ddState.HoveredItemBackColor = Color.FromArgb(240, 240, 240);
            ddState.HoveredItemTextColor = Color.FromArgb(30, 30, 30);
            ddState.IsReadonly = false;
            ddState.ItemHeight = 30;
            ddState.Location = new Point(32, 457);
            ddState.MaxDropDownItems = 8;
            ddState.Name = "ddState";
            ddState.NotFoundBackColor = Color.Transparent;
            ddState.NotFoundFont = null;
            ddState.NotFoundTextColor = Color.Gray;
            ddState.PlaceholderColor = Color.FromArgb(128, 128, 128);
            ddState.PlaceholderDisappearsOnFocus = false;
            ddState.PlaceholderText = "State";
            ddState.SearchTextColor = Color.FromArgb(0, 0, 0);
            ddState.SearchTextFont = null;
            ddState.SelectedIndex = -1;
            ddState.SelectedItem = null;
            ddState.SelectedItemBackColor = Color.FromArgb(230, 240, 250);
            ddState.SelectedItemTextColor = Color.FromArgb(30, 30, 30);
            ddState.SelectedValue = null;
            ddState.Size = new Size(303, 61);
            ddState.TabIndex = 39;
            ddState.UnselectedItemTextColor = Color.FromArgb(60, 60, 60);
            ddState.ValueMember = null;
            // 
            // txtPhone
            // 
            txtPhone.AccessibleDescription = "A customizable text input field.";
            txtPhone.AccessibleName = "Text Box";
            txtPhone.AccessibleRole = AccessibleRole.Text;
            txtPhone.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtPhone.BorderColor2 = Color.FromArgb(210, 210, 210);
            txtPhone.BorderFocusColor1 = Color.FromArgb(33, 150, 243);
            txtPhone.BorderFocusColor2 = Color.FromArgb(33, 150, 243);
            txtPhone.BorderSize = 2;
            txtPhone.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtPhone.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtPhone.CornerRadiusBottomLeft = 10;
            txtPhone.CornerRadiusBottomRight = 10;
            txtPhone.CornerRadiusTopLeft = 10;
            txtPhone.CornerRadiusTopRight = 10;
            txtPhone.CursorColor = Color.FromArgb(32, 32, 32);
            txtPhone.DisabledBackColor = Color.WhiteSmoke;
            txtPhone.DisabledBorderColor = Color.LightGray;
            txtPhone.DisabledTextColor = Color.Gray;
            txtPhone.FillColor1 = Color.White;
            txtPhone.FillColor2 = Color.White;
            txtPhone.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.ForeColor = Color.Black;
            txtPhone.HoverBorderColor1 = Color.Gray;
            txtPhone.HoverBorderColor2 = Color.Gray;
            txtPhone.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtPhone.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtPhone.InputFilter = SiticoneTextBox.SiticoneInputFilter.NoWhiteSpace;
            txtPhone.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtPhone.Location = new Point(358, 456);
            txtPhone.MaxLength = 100;
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderColor = Color.Gray;
            txtPhone.PlaceholderText = "Phone Number";
            txtPhone.ReadOnlyBorderColor1 = Color.LightGray;
            txtPhone.ReadOnlyBorderColor2 = Color.LightGray;
            txtPhone.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtPhone.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtPhone.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtPhone.ReadOnlyTextColor = Color.Empty;
            txtPhone.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtPhone.SelectionForeColor = SystemColors.HighlightText;
            txtPhone.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtPhone.Size = new Size(307, 62);
            txtPhone.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtPhone.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtPhone.SolidBorderHoverColor = Color.Gray;
            txtPhone.SolidFillColor = Color.White;
            txtPhone.TabIndex = 38;
            // 
            // txtPostcode
            // 
            txtPostcode.AccessibleDescription = "A customizable text input field.";
            txtPostcode.AccessibleName = "Text Box";
            txtPostcode.AccessibleRole = AccessibleRole.Text;
            txtPostcode.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtPostcode.BorderColor2 = Color.FromArgb(210, 210, 210);
            txtPostcode.BorderFocusColor1 = Color.FromArgb(33, 150, 243);
            txtPostcode.BorderFocusColor2 = Color.FromArgb(33, 150, 243);
            txtPostcode.BorderSize = 2;
            txtPostcode.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtPostcode.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtPostcode.CornerRadiusBottomLeft = 10;
            txtPostcode.CornerRadiusBottomRight = 10;
            txtPostcode.CornerRadiusTopLeft = 10;
            txtPostcode.CornerRadiusTopRight = 10;
            txtPostcode.CursorColor = Color.FromArgb(32, 32, 32);
            txtPostcode.DisabledBackColor = Color.WhiteSmoke;
            txtPostcode.DisabledBorderColor = Color.LightGray;
            txtPostcode.DisabledTextColor = Color.Gray;
            txtPostcode.FillColor1 = Color.White;
            txtPostcode.FillColor2 = Color.White;
            txtPostcode.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPostcode.ForeColor = Color.Black;
            txtPostcode.HoverBorderColor1 = Color.Gray;
            txtPostcode.HoverBorderColor2 = Color.Gray;
            txtPostcode.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtPostcode.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtPostcode.InputFilter = SiticoneTextBox.SiticoneInputFilter.NoWhiteSpace;
            txtPostcode.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtPostcode.Location = new Point(358, 341);
            txtPostcode.MaxLength = 100;
            txtPostcode.Name = "txtPostcode";
            txtPostcode.PlaceholderColor = Color.Gray;
            txtPostcode.PlaceholderText = "Postcode";
            txtPostcode.ReadOnlyBorderColor1 = Color.LightGray;
            txtPostcode.ReadOnlyBorderColor2 = Color.LightGray;
            txtPostcode.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtPostcode.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtPostcode.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtPostcode.ReadOnlyTextColor = Color.Empty;
            txtPostcode.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtPostcode.SelectionForeColor = SystemColors.HighlightText;
            txtPostcode.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtPostcode.Size = new Size(307, 62);
            txtPostcode.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtPostcode.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtPostcode.SolidBorderHoverColor = Color.Gray;
            txtPostcode.SolidFillColor = Color.White;
            txtPostcode.TabIndex = 37;
            // 
            // btnBack
            // 
            btnBack.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnBack.AccessibleName = "Back ";
            btnBack.BadgeBackColor = Color.Black;
            btnBack.BadgeBorderColor = Color.Empty;
            btnBack.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnBack.BadgeValueForeColor = Color.White;
            btnBack.BorderColor = Color.FromArgb(213, 216, 220);
            btnBack.BusyIndicatorColor = Color.Empty;
            btnBack.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnBack.CustomCursor = Cursors.Default;
            btnBack.DisabledBackColor = Color.Empty;
            btnBack.DisabledBorderColor = Color.Empty;
            btnBack.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnBack.FocusRingColor = Color.Empty;
            btnBack.Font = new Font("Segoe UI Semibold", 10.2F);
            btnBack.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnBack.GradientColor = Color.FromArgb(0, 227, 64);
            btnBack.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnBack.HoverBorderColor = Color.Empty;
            btnBack.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnBack.ImageSize = new Size(16, 16);
            btnBack.Location = new Point(32, 720);
            btnBack.Name = "btnBack";
            btnBack.ParticleColor = Color.FromArgb(200, 200, 200);
            btnBack.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnBack.PressedBorderColor = Color.Empty;
            btnBack.PressedTextColor = Color.Empty;
            btnBack.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnBack.RippleColor = Color.FromArgb(0, 0, 0);
            btnBack.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnBack.ShadowOffset = new Point(0, 2);
            btnBack.Size = new Size(202, 62);
            btnBack.TabIndex = 35;
            btnBack.Text = "Back ";
            btnBack.TextColor = Color.FromArgb(0, 0, 0);
            btnBack.ToggledBackColor = Color.Empty;
            btnBack.ToggledBorderColor = Color.Empty;
            btnBack.ToggledTextColor = Color.Empty;
            btnBack.Click += btnBack_Click;
            // 
            // siticoneLabel1
            // 
            siticoneLabel1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel1.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel1.Location = new Point(32, 124);
            siticoneLabel1.Name = "siticoneLabel1";
            siticoneLabel1.Size = new Size(504, 38);
            siticoneLabel1.TabIndex = 27;
            siticoneLabel1.Text = "Step 2 of 4 - Address";
            siticoneLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // siticoneLabel4
            // 
            siticoneLabel4.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel4.ForeColor = Color.Black;
            siticoneLabel4.Location = new Point(26, 53);
            siticoneLabel4.Name = "siticoneLabel4";
            siticoneLabel4.Size = new Size(504, 86);
            siticoneLabel4.TabIndex = 20;
            siticoneLabel4.Text = "Where are you located?";
            siticoneLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnNext
            // 
            btnNext.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnNext.AccessibleName = "Next";
            btnNext.BadgeBackColor = Color.Black;
            btnNext.BadgeBorderColor = Color.Empty;
            btnNext.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnNext.BadgeValueForeColor = Color.White;
            btnNext.BorderColor = Color.FromArgb(213, 216, 220);
            btnNext.BusyIndicatorColor = Color.Empty;
            btnNext.ButtonBackColor = Color.FromArgb(245, 247, 250);
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
            btnNext.ImageSize = new Size(16, 16);
            btnNext.Location = new Point(463, 720);
            btnNext.Name = "btnNext";
            btnNext.ParticleColor = Color.FromArgb(200, 200, 200);
            btnNext.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnNext.PressedBorderColor = Color.Empty;
            btnNext.PressedTextColor = Color.Empty;
            btnNext.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnNext.RippleColor = Color.FromArgb(0, 0, 0);
            btnNext.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnNext.ShadowOffset = new Point(0, 2);
            btnNext.Size = new Size(202, 62);
            btnNext.TabIndex = 26;
            btnNext.Text = "Next";
            btnNext.TextColor = Color.FromArgb(0, 0, 0);
            btnNext.ToggledBackColor = Color.Empty;
            btnNext.ToggledBorderColor = Color.Empty;
            btnNext.ToggledTextColor = Color.Empty;
            btnNext.Click += btnNext_Click;
            // 
            // FacilityStep2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Name = "FacilityStep2";
            Size = new Size(1463, 903);
            pnlLeft.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SiticonePanel pnlLeft;
        private TableLayoutPanel tableLayoutPanel1;
        private SiticoneLabel lblStep4;
        private SiticoneLabel lblStep3;
        private SiticoneLabel lblStep2;
        private SiticoneLabel lblStep1;
        private SiticonePictureBox siticonePictureBox1;
        private SiticoneShimmerLabel siticoneShimmerLabel1;
        private SiticonePanel pnlRight;
        private SiticonePanel pnlForm;
        private SiticoneTextBox txtPostcode;
        private SiticoneButton btnBack;
        private SiticoneLabel siticoneLabel1;
        private SiticoneLabel siticoneLabel4;
        private SiticoneButton btnNext;
        private SiticoneTextBox txtPhone;
        private SiticoneDropdown ddState;
        private SiticoneTextBox txtAddress;
        private SiticoneTextBox txtCity;
    }
}
