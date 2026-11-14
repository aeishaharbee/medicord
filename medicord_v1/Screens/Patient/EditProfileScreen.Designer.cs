namespace medicord_v1.Screens.Patient
{
    partial class EditProfileScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfileScreen));
            btnBack = new SiticoneNavBackButton();
            siticoneLabel4 = new SiticoneLabel();
            picAvatar = new SiticonePictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnRemovePhoto = new SiticoneButton();
            btnChangePhoto = new SiticoneButton();
            siticoneLabel1 = new SiticoneLabel();
            siticoneLabel10 = new SiticoneLabel();
            siticoneLabel11 = new SiticoneLabel();
            siticoneLabel9 = new SiticoneLabel();
            siticoneLabel8 = new SiticoneLabel();
            txtPhone = new SiticoneTextBox();
            txtCity = new SiticoneTextBox();
            txtPostcode = new SiticoneTextBox();
            ddState = new SiticoneDropdown();
            btnSave = new SiticoneButton();
            btnAccount = new SiticoneButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            btnBack.IconSize = 24F;
            btnBack.IconStrokeWidth = 2F;
            btnBack.InteractiveBounce = false;
            btnBack.IsInteractive = true;
            btnBack.IsReadOnly = false;
            btnBack.Location = new Point(15, 29);
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
            btnBack.TabIndex = 20;
            btnBack.Text = "siticoneNavBackButton1";
            btnBack.Click += btnBack_Click;
            // 
            // siticoneLabel4
            // 
            siticoneLabel4.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel4.ForeColor = Color.Black;
            siticoneLabel4.Location = new Point(71, 15);
            siticoneLabel4.Name = "siticoneLabel4";
            siticoneLabel4.Size = new Size(382, 79);
            siticoneLabel4.TabIndex = 27;
            siticoneLabel4.Text = "Edit profile";
            siticoneLabel4.TextAlign = ContentAlignment.MiddleLeft;
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
            picAvatar.Location = new Point(53, 116);
            picAvatar.MaintainAspectRatio = true;
            picAvatar.Name = "picAvatar";
            picAvatar.PlaceholderImage = null;
            picAvatar.RotationAngle = 0F;
            picAvatar.Saturation = 1F;
            picAvatar.ShowBorder = true;
            picAvatar.Size = new Size(110, 110);
            picAvatar.SizeMode = SiticoneNetCoreUI.Helpers.Enum.SiticonePictureBoxSizeMode.Normal;
            picAvatar.TabIndex = 78;
            picAvatar.Text = "siticonePictureBox1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnRemovePhoto, 0, 0);
            tableLayoutPanel1.Controls.Add(btnChangePhoto, 1, 0);
            tableLayoutPanel1.Location = new Point(194, 177);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(276, 49);
            tableLayoutPanel1.TabIndex = 79;
            // 
            // btnRemovePhoto
            // 
            btnRemovePhoto.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnRemovePhoto.AccessibleName = "Remove";
            btnRemovePhoto.BadgeBackColor = Color.Black;
            btnRemovePhoto.BadgeBorderColor = Color.Empty;
            btnRemovePhoto.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnRemovePhoto.BadgeValueForeColor = Color.White;
            btnRemovePhoto.BorderColor = Color.FromArgb(15, 76, 76);
            btnRemovePhoto.BorderWidth = 2;
            btnRemovePhoto.BusyIndicatorColor = Color.Empty;
            btnRemovePhoto.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnRemovePhoto.CornerRadiusBottomLeft = 19;
            btnRemovePhoto.CornerRadiusBottomRight = 19;
            btnRemovePhoto.CornerRadiusTopLeft = 19;
            btnRemovePhoto.CornerRadiusTopRight = 19;
            btnRemovePhoto.CustomCursor = Cursors.Default;
            btnRemovePhoto.DisabledBackColor = Color.Empty;
            btnRemovePhoto.DisabledBorderColor = Color.Empty;
            btnRemovePhoto.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnRemovePhoto.Dock = DockStyle.Fill;
            btnRemovePhoto.FocusRingColor = Color.Empty;
            btnRemovePhoto.Font = new Font("Segoe UI Semibold", 10.2F);
            btnRemovePhoto.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnRemovePhoto.GradientColor = Color.FromArgb(0, 227, 64);
            btnRemovePhoto.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnRemovePhoto.HoverBorderColor = Color.Empty;
            btnRemovePhoto.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnRemovePhoto.ImageSize = new Size(16, 16);
            btnRemovePhoto.IsRadial = true;
            btnRemovePhoto.Location = new Point(6, 3);
            btnRemovePhoto.Margin = new Padding(6, 3, 3, 3);
            btnRemovePhoto.Name = "btnRemovePhoto";
            btnRemovePhoto.ParticleColor = Color.FromArgb(200, 200, 200);
            btnRemovePhoto.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnRemovePhoto.PressedBorderColor = Color.Empty;
            btnRemovePhoto.PressedTextColor = Color.Empty;
            btnRemovePhoto.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnRemovePhoto.RippleColor = Color.FromArgb(0, 0, 0);
            btnRemovePhoto.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnRemovePhoto.ShadowOffset = new Point(0, 2);
            btnRemovePhoto.Size = new Size(129, 43);
            btnRemovePhoto.TabIndex = 43;
            btnRemovePhoto.Text = "Remove";
            btnRemovePhoto.TextColor = Color.FromArgb(0, 0, 0);
            btnRemovePhoto.ToggledBackColor = Color.Empty;
            btnRemovePhoto.ToggledBorderColor = Color.Empty;
            btnRemovePhoto.ToggledTextColor = Color.Empty;
            btnRemovePhoto.Click += btnRemovePhoto_Click;
            // 
            // btnChangePhoto
            // 
            btnChangePhoto.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnChangePhoto.AccessibleName = "Change";
            btnChangePhoto.BadgeBackColor = Color.Black;
            btnChangePhoto.BadgeBorderColor = Color.Empty;
            btnChangePhoto.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnChangePhoto.BadgeValueForeColor = Color.White;
            btnChangePhoto.BorderColor = Color.FromArgb(15, 76, 76);
            btnChangePhoto.BorderWidth = 2;
            btnChangePhoto.BusyIndicatorColor = Color.Empty;
            btnChangePhoto.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnChangePhoto.CornerRadiusBottomLeft = 19;
            btnChangePhoto.CornerRadiusBottomRight = 19;
            btnChangePhoto.CornerRadiusTopLeft = 19;
            btnChangePhoto.CornerRadiusTopRight = 19;
            btnChangePhoto.CustomCursor = Cursors.Default;
            btnChangePhoto.DisabledBackColor = Color.Empty;
            btnChangePhoto.DisabledBorderColor = Color.Empty;
            btnChangePhoto.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnChangePhoto.Dock = DockStyle.Fill;
            btnChangePhoto.FocusRingColor = Color.Empty;
            btnChangePhoto.Font = new Font("Segoe UI Semibold", 10.2F);
            btnChangePhoto.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnChangePhoto.GradientColor = Color.FromArgb(0, 227, 64);
            btnChangePhoto.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnChangePhoto.HoverBorderColor = Color.Empty;
            btnChangePhoto.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnChangePhoto.ImageSize = new Size(16, 16);
            btnChangePhoto.IsRadial = true;
            btnChangePhoto.Location = new Point(144, 3);
            btnChangePhoto.Margin = new Padding(6, 3, 3, 3);
            btnChangePhoto.Name = "btnChangePhoto";
            btnChangePhoto.ParticleColor = Color.FromArgb(200, 200, 200);
            btnChangePhoto.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnChangePhoto.PressedBorderColor = Color.Empty;
            btnChangePhoto.PressedTextColor = Color.Empty;
            btnChangePhoto.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnChangePhoto.RippleColor = Color.FromArgb(0, 0, 0);
            btnChangePhoto.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnChangePhoto.ShadowOffset = new Point(0, 2);
            btnChangePhoto.Size = new Size(129, 43);
            btnChangePhoto.TabIndex = 40;
            btnChangePhoto.Text = "Change";
            btnChangePhoto.TextColor = Color.FromArgb(0, 0, 0);
            btnChangePhoto.ToggledBackColor = Color.Empty;
            btnChangePhoto.ToggledBorderColor = Color.Empty;
            btnChangePhoto.ToggledTextColor = Color.Empty;
            btnChangePhoto.Click += btnChangePhoto_Click;
            // 
            // siticoneLabel1
            // 
            siticoneLabel1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel1.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel1.Location = new Point(194, 116);
            siticoneLabel1.Name = "siticoneLabel1";
            siticoneLabel1.Size = new Size(160, 26);
            siticoneLabel1.TabIndex = 80;
            siticoneLabel1.Text = "Profile picture";
            siticoneLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // siticoneLabel10
            // 
            siticoneLabel10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel10.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel10.Location = new Point(49, 259);
            siticoneLabel10.Name = "siticoneLabel10";
            siticoneLabel10.Size = new Size(160, 26);
            siticoneLabel10.TabIndex = 88;
            siticoneLabel10.Text = "Phone Number";
            // 
            // siticoneLabel11
            // 
            siticoneLabel11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel11.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel11.Location = new Point(50, 475);
            siticoneLabel11.Name = "siticoneLabel11";
            siticoneLabel11.Size = new Size(160, 26);
            siticoneLabel11.TabIndex = 87;
            siticoneLabel11.Text = "State";
            // 
            // siticoneLabel9
            // 
            siticoneLabel9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel9.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel9.Location = new Point(266, 475);
            siticoneLabel9.Name = "siticoneLabel9";
            siticoneLabel9.Size = new Size(160, 26);
            siticoneLabel9.TabIndex = 86;
            siticoneLabel9.Text = "Postcode";
            // 
            // siticoneLabel8
            // 
            siticoneLabel8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel8.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel8.Location = new Point(50, 367);
            siticoneLabel8.Name = "siticoneLabel8";
            siticoneLabel8.Size = new Size(160, 26);
            siticoneLabel8.TabIndex = 85;
            siticoneLabel8.Text = "City";
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
            txtPhone.Location = new Point(45, 288);
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
            txtPhone.Size = new Size(425, 62);
            txtPhone.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtPhone.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtPhone.SolidBorderHoverColor = Color.Gray;
            txtPhone.SolidFillColor = Color.White;
            txtPhone.TabIndex = 84;
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
            txtCity.Location = new Point(45, 396);
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
            txtCity.Size = new Size(425, 62);
            txtCity.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtCity.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtCity.SolidBorderHoverColor = Color.Gray;
            txtCity.SolidFillColor = Color.White;
            txtCity.TabIndex = 83;
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
            txtPostcode.Location = new Point(262, 504);
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
            txtPostcode.Size = new Size(208, 62);
            txtPostcode.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtPostcode.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtPostcode.SolidBorderHoverColor = Color.Gray;
            txtPostcode.SolidFillColor = Color.White;
            txtPostcode.TabIndex = 82;
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
            ddState.Location = new Point(45, 504);
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
            ddState.Size = new Size(202, 61);
            ddState.TabIndex = 81;
            ddState.UnselectedItemTextColor = Color.FromArgb(60, 60, 60);
            ddState.ValueMember = null;
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
            btnSave.FocusRingColor = Color.Empty;
            btnSave.Font = new Font("Segoe UI Semibold", 10.2F);
            btnSave.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnSave.GradientColor = Color.FromArgb(0, 227, 64);
            btnSave.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnSave.HoverBorderColor = Color.Empty;
            btnSave.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnSave.ImageSize = new Size(16, 16);
            btnSave.IsRadial = true;
            btnSave.Location = new Point(45, 596);
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
            btnSave.Size = new Size(425, 52);
            btnSave.TabIndex = 90;
            btnSave.Text = "Save changes";
            btnSave.TextColor = Color.FromArgb(0, 0, 0);
            btnSave.ToggledBackColor = Color.Empty;
            btnSave.ToggledBorderColor = Color.Empty;
            btnSave.ToggledTextColor = Color.Empty;
            btnSave.Click += btnSave_Click;
            // 
            // btnAccount
            // 
            btnAccount.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnAccount.AccessibleName = "Change name, ID, email, or password";
            btnAccount.BadgeBackColor = Color.Black;
            btnAccount.BadgeBorderColor = Color.Empty;
            btnAccount.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnAccount.BadgeValueForeColor = Color.White;
            btnAccount.BorderColor = Color.FromArgb(15, 76, 76);
            btnAccount.BorderWidth = 2;
            btnAccount.BusyIndicatorColor = Color.Empty;
            btnAccount.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnAccount.CornerRadiusBottomLeft = 24;
            btnAccount.CornerRadiusBottomRight = 24;
            btnAccount.CornerRadiusTopLeft = 24;
            btnAccount.CornerRadiusTopRight = 24;
            btnAccount.CustomCursor = Cursors.Default;
            btnAccount.DisabledBackColor = Color.Empty;
            btnAccount.DisabledBorderColor = Color.Empty;
            btnAccount.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnAccount.FocusRingColor = Color.Empty;
            btnAccount.Font = new Font("Segoe UI Semibold", 10.2F);
            btnAccount.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnAccount.GradientColor = Color.FromArgb(0, 227, 64);
            btnAccount.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnAccount.HoverBorderColor = Color.Empty;
            btnAccount.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnAccount.ImageSize = new Size(16, 16);
            btnAccount.IsRadial = true;
            btnAccount.Location = new Point(45, 694);
            btnAccount.Margin = new Padding(6, 3, 3, 3);
            btnAccount.Name = "btnAccount";
            btnAccount.ParticleColor = Color.FromArgb(200, 200, 200);
            btnAccount.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnAccount.PressedBorderColor = Color.Empty;
            btnAccount.PressedTextColor = Color.Empty;
            btnAccount.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnAccount.RippleColor = Color.FromArgb(0, 0, 0);
            btnAccount.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnAccount.ShadowOffset = new Point(0, 2);
            btnAccount.Size = new Size(425, 52);
            btnAccount.TabIndex = 91;
            btnAccount.Text = "Change name, ID, email, or password";
            btnAccount.TextColor = Color.FromArgb(0, 0, 0);
            btnAccount.ToggledBackColor = Color.Empty;
            btnAccount.ToggledBorderColor = Color.Empty;
            btnAccount.ToggledTextColor = Color.Empty;
            btnAccount.Click += btnAccount_Click;
            // 
            // EditProfileScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAccount);
            Controls.Add(btnSave);
            Controls.Add(siticoneLabel10);
            Controls.Add(siticoneLabel11);
            Controls.Add(siticoneLabel9);
            Controls.Add(siticoneLabel8);
            Controls.Add(txtPhone);
            Controls.Add(txtCity);
            Controls.Add(txtPostcode);
            Controls.Add(ddState);
            Controls.Add(siticoneLabel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(picAvatar);
            Controls.Add(siticoneLabel4);
            Controls.Add(btnBack);
            Name = "EditProfileScreen";
            Size = new Size(522, 779);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneNavBackButton btnBack;
        private SiticoneLabel siticoneLabel4;
        private SiticonePictureBox picAvatar;
        private TableLayoutPanel tableLayoutPanel1;
        private SiticoneButton btnRemovePhoto;
        private SiticoneButton btnChangePhoto;
        private SiticoneLabel siticoneLabel1;
        private SiticoneLabel siticoneLabel10;
        private SiticoneLabel siticoneLabel11;
        private SiticoneLabel siticoneLabel9;
        private SiticoneLabel siticoneLabel8;
        private SiticoneTextBox txtPhone;
        private SiticoneTextBox txtCity;
        private SiticoneTextBox txtPostcode;
        private SiticoneDropdown ddState;
        private SiticoneButton btnSave;
        private SiticoneButton btnAccount;
    }
}
