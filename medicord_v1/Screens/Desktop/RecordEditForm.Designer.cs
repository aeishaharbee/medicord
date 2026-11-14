namespace medicord_v1.Screens.Desktop
{
    partial class RecordEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordEditForm));
            lblHeading = new SiticoneLabel();
            lblDoctor = new SiticoneLabel();
            siticoneLabel9 = new SiticoneLabel();
            siticoneLabel8 = new SiticoneLabel();
            siticoneLabel6 = new SiticoneLabel();
            siticoneLabel4 = new SiticoneLabel();
            txtTitle = new SiticoneTextBox();
            ddCategory = new SiticoneDropdown();
            ddPatient = new SiticoneDropdown();
            siticoneAdvancedPanel1 = new SiticoneAdvancedPanel();
            lblFile = new SiticoneLabel();
            btnBrowse = new SiticoneButton();
            siticoneLabel1 = new SiticoneLabel();
            ddDoctor = new SiticoneDropdown();
            siticoneLabel2 = new SiticoneLabel();
            txtNotes = new SiticoneTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCancel = new SiticoneButton();
            btnSave = new SiticoneButton();
            dtpDate = new SiticoneDateTimePicker();
            siticoneAdvancedPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeading.ForeColor = SystemColors.ActiveCaptionText;
            lblHeading.Location = new Point(34, 28);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(599, 51);
            lblHeading.TabIndex = 62;
            lblHeading.Text = "Upload Medical Record";
            // 
            // lblDoctor
            // 
            lblDoctor.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoctor.ForeColor = Color.FromArgb(15, 76, 76);
            lblDoctor.Location = new Point(34, 416);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(309, 26);
            lblDoctor.TabIndex = 86;
            lblDoctor.Text = "Attending doctor";
            // 
            // siticoneLabel9
            // 
            siticoneLabel9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel9.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel9.Location = new Point(345, 202);
            siticoneLabel9.Name = "siticoneLabel9";
            siticoneLabel9.Size = new Size(160, 26);
            siticoneLabel9.TabIndex = 85;
            siticoneLabel9.Text = "Checkup date";
            // 
            // siticoneLabel8
            // 
            siticoneLabel8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel8.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel8.Location = new Point(39, 307);
            siticoneLabel8.Name = "siticoneLabel8";
            siticoneLabel8.Size = new Size(160, 26);
            siticoneLabel8.TabIndex = 84;
            siticoneLabel8.Text = "Title";
            // 
            // siticoneLabel6
            // 
            siticoneLabel6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel6.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel6.Location = new Point(39, 200);
            siticoneLabel6.Name = "siticoneLabel6";
            siticoneLabel6.Size = new Size(160, 26);
            siticoneLabel6.TabIndex = 83;
            siticoneLabel6.Text = "Category";
            // 
            // siticoneLabel4
            // 
            siticoneLabel4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel4.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel4.Location = new Point(39, 95);
            siticoneLabel4.Name = "siticoneLabel4";
            siticoneLabel4.Size = new Size(160, 26);
            siticoneLabel4.TabIndex = 82;
            siticoneLabel4.Text = "Patient";
            // 
            // txtTitle
            // 
            txtTitle.AccessibleDescription = "A customizable text input field.";
            txtTitle.AccessibleName = "Text Box";
            txtTitle.AccessibleRole = AccessibleRole.Text;
            txtTitle.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtTitle.BorderColor2 = Color.FromArgb(210, 210, 210);
            txtTitle.BorderFocusColor1 = Color.FromArgb(33, 150, 243);
            txtTitle.BorderFocusColor2 = Color.FromArgb(33, 150, 243);
            txtTitle.BorderSize = 2;
            txtTitle.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtTitle.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtTitle.CornerRadiusBottomLeft = 10;
            txtTitle.CornerRadiusBottomRight = 10;
            txtTitle.CornerRadiusTopLeft = 10;
            txtTitle.CornerRadiusTopRight = 10;
            txtTitle.CursorColor = Color.FromArgb(32, 32, 32);
            txtTitle.DisabledBackColor = Color.WhiteSmoke;
            txtTitle.DisabledBorderColor = Color.LightGray;
            txtTitle.DisabledTextColor = Color.Gray;
            txtTitle.FillColor1 = Color.White;
            txtTitle.FillColor2 = Color.White;
            txtTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.ForeColor = Color.Black;
            txtTitle.HoverBorderColor1 = Color.Gray;
            txtTitle.HoverBorderColor2 = Color.Gray;
            txtTitle.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtTitle.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtTitle.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtTitle.Location = new Point(34, 336);
            txtTitle.Name = "txtTitle";
            txtTitle.PlaceholderColor = Color.Gray;
            txtTitle.PlaceholderText = "e.g. Blood Test Results";
            txtTitle.ReadOnlyBorderColor1 = Color.LightGray;
            txtTitle.ReadOnlyBorderColor2 = Color.LightGray;
            txtTitle.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtTitle.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtTitle.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtTitle.ReadOnlyTextColor = Color.Empty;
            txtTitle.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtTitle.SelectionForeColor = SystemColors.HighlightText;
            txtTitle.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtTitle.Size = new Size(599, 63);
            txtTitle.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtTitle.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtTitle.SolidBorderHoverColor = Color.Gray;
            txtTitle.SolidFillColor = Color.White;
            txtTitle.TabIndex = 80;
            // 
            // ddCategory
            // 
            ddCategory.AllowMultipleSelection = false;
            ddCategory.BackColor = Color.FromArgb(255, 255, 255);
            ddCategory.BorderColor = Color.FromArgb(210, 210, 210);
            ddCategory.BorderSize = 2;
            ddCategory.CanBeep = false;
            ddCategory.CanShake = true;
            ddCategory.CornerRadius = 10;
            ddCategory.DataSource = null;
            ddCategory.DisplayMember = null;
            ddCategory.DropdownBackColor = Color.FromArgb(255, 255, 255);
            ddCategory.DropdownWidth = 0;
            ddCategory.DropShadowEnabled = false;
            ddCategory.EnableSearch = true;
            ddCategory.Font = new Font("Segoe UI", 10F);
            ddCategory.ForeColor = Color.FromArgb(60, 60, 60);
            ddCategory.HoveredItemBackColor = Color.FromArgb(240, 240, 240);
            ddCategory.HoveredItemTextColor = Color.FromArgb(30, 30, 30);
            ddCategory.IsReadonly = false;
            ddCategory.ItemHeight = 30;
            ddCategory.Location = new Point(34, 231);
            ddCategory.MaxDropDownItems = 8;
            ddCategory.Name = "ddCategory";
            ddCategory.NotFoundBackColor = Color.Transparent;
            ddCategory.NotFoundFont = null;
            ddCategory.NotFoundTextColor = Color.Gray;
            ddCategory.PlaceholderColor = Color.FromArgb(128, 128, 128);
            ddCategory.PlaceholderDisappearsOnFocus = false;
            ddCategory.PlaceholderText = "Select category";
            ddCategory.SearchTextColor = Color.FromArgb(0, 0, 0);
            ddCategory.SearchTextFont = null;
            ddCategory.SelectedIndex = -1;
            ddCategory.SelectedItem = null;
            ddCategory.SelectedItemBackColor = Color.FromArgb(230, 240, 250);
            ddCategory.SelectedItemTextColor = Color.FromArgb(30, 30, 30);
            ddCategory.SelectedValue = null;
            ddCategory.Size = new Size(286, 61);
            ddCategory.TabIndex = 77;
            ddCategory.UnselectedItemTextColor = Color.FromArgb(60, 60, 60);
            ddCategory.ValueMember = null;
            // 
            // ddPatient
            // 
            ddPatient.AllowMultipleSelection = false;
            ddPatient.BackColor = Color.FromArgb(255, 255, 255);
            ddPatient.BorderColor = Color.FromArgb(210, 210, 210);
            ddPatient.BorderSize = 2;
            ddPatient.CanBeep = false;
            ddPatient.CanShake = true;
            ddPatient.CornerRadius = 10;
            ddPatient.DataSource = null;
            ddPatient.DisplayMember = null;
            ddPatient.DropdownBackColor = Color.FromArgb(255, 255, 255);
            ddPatient.DropdownWidth = 0;
            ddPatient.DropShadowEnabled = false;
            ddPatient.EnableSearch = true;
            ddPatient.Font = new Font("Segoe UI", 10F);
            ddPatient.ForeColor = Color.FromArgb(60, 60, 60);
            ddPatient.HoveredItemBackColor = Color.FromArgb(240, 240, 240);
            ddPatient.HoveredItemTextColor = Color.FromArgb(30, 30, 30);
            ddPatient.IsReadonly = false;
            ddPatient.ItemHeight = 30;
            ddPatient.Location = new Point(34, 126);
            ddPatient.MaxDropDownItems = 8;
            ddPatient.Name = "ddPatient";
            ddPatient.NotFoundBackColor = Color.Transparent;
            ddPatient.NotFoundFont = null;
            ddPatient.NotFoundTextColor = Color.Gray;
            ddPatient.PlaceholderColor = Color.FromArgb(128, 128, 128);
            ddPatient.PlaceholderDisappearsOnFocus = false;
            ddPatient.PlaceholderText = "Select patient";
            ddPatient.SearchTextColor = Color.FromArgb(0, 0, 0);
            ddPatient.SearchTextFont = null;
            ddPatient.SelectedIndex = -1;
            ddPatient.SelectedItem = null;
            ddPatient.SelectedItemBackColor = Color.FromArgb(230, 240, 250);
            ddPatient.SelectedItemTextColor = Color.FromArgb(30, 30, 30);
            ddPatient.SelectedValue = null;
            ddPatient.Size = new Size(599, 61);
            ddPatient.TabIndex = 88;
            ddPatient.UnselectedItemTextColor = Color.FromArgb(60, 60, 60);
            ddPatient.ValueMember = null;
            // 
            // siticoneAdvancedPanel1
            // 
            siticoneAdvancedPanel1.ActiveBackColor = Color.Empty;
            siticoneAdvancedPanel1.ActiveBorderColor = Color.Empty;
            siticoneAdvancedPanel1.AdvancedBorderStyle = SiticoneAdvancedPanel.BorderStyleEx.Dash;
            siticoneAdvancedPanel1.AnimationDuration = 500;
            siticoneAdvancedPanel1.AnimationType = SiticoneAdvancedPanel.AnimationTypeEx.Fade;
            siticoneAdvancedPanel1.BackgroundImageCustom = null;
            siticoneAdvancedPanel1.BackgroundImageOpacity = 1F;
            siticoneAdvancedPanel1.BackgroundImageSizeMode = SiticoneAdvancedPanel.ImageSizeModeEx.Stretch;
            siticoneAdvancedPanel1.BackgroundOverlayColor = Color.FromArgb(0, 0, 0, 0);
            siticoneAdvancedPanel1.BorderDashPattern = new float[]
    {
    3F,
    1F
    };
            siticoneAdvancedPanel1.BorderGlowColor = Color.Cyan;
            siticoneAdvancedPanel1.BorderGlowSize = 3F;
            siticoneAdvancedPanel1.BorderWidth = 2F;
            siticoneAdvancedPanel1.BottomLeftRadius = 5;
            siticoneAdvancedPanel1.BottomRightRadius = 5;
            siticoneAdvancedPanel1.ContentAlignmentCustom = ContentAlignment.MiddleCenter;
            siticoneAdvancedPanel1.Controls.Add(lblFile);
            siticoneAdvancedPanel1.Controls.Add(btnBrowse);
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
            siticoneAdvancedPanel1.Location = new Point(34, 659);
            siticoneAdvancedPanel1.Name = "siticoneAdvancedPanel1";
            siticoneAdvancedPanel1.Padding = new Padding(10);
            siticoneAdvancedPanel1.RadialGradientCenter = (PointF)resources.GetObject("siticoneAdvancedPanel1.RadialGradientCenter");
            siticoneAdvancedPanel1.RadialGradientRadius = 1F;
            siticoneAdvancedPanel1.ScaleRatio = 0.8F;
            siticoneAdvancedPanel1.SecondaryBorderColor = Color.DarkGray;
            siticoneAdvancedPanel1.ShadowBlur = 10;
            siticoneAdvancedPanel1.ShadowColor = Color.Black;
            siticoneAdvancedPanel1.ShadowDepth = 5;
            siticoneAdvancedPanel1.ShadowOffset = new Point(2, 2);
            siticoneAdvancedPanel1.ShadowOpacity = 0.3F;
            siticoneAdvancedPanel1.Size = new Size(599, 93);
            siticoneAdvancedPanel1.SlideDirection = new Point(0, -30);
            siticoneAdvancedPanel1.TabIndex = 89;
            siticoneAdvancedPanel1.TopLeftRadius = 5;
            siticoneAdvancedPanel1.TopRightRadius = 5;
            // 
            // lblFile
            // 
            lblFile.Font = new Font("Segoe UI", 10F);
            lblFile.ForeColor = Color.Gray;
            lblFile.Location = new Point(13, 9);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(383, 72);
            lblFile.TabIndex = 35;
            lblFile.Text = "No file chosen - PDF only, max 10 MB";
            lblFile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnBrowse
            // 
            btnBrowse.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnBrowse.AccessibleName = "Browse";
            btnBrowse.BadgeBackColor = Color.Black;
            btnBrowse.BadgeBorderColor = Color.Empty;
            btnBrowse.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnBrowse.BadgeValueForeColor = Color.White;
            btnBrowse.BorderColor = Color.FromArgb(213, 216, 220);
            btnBrowse.BusyIndicatorColor = Color.Empty;
            btnBrowse.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnBrowse.CustomCursor = Cursors.Default;
            btnBrowse.DisabledBackColor = Color.Empty;
            btnBrowse.DisabledBorderColor = Color.Empty;
            btnBrowse.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnBrowse.FocusRingColor = Color.Empty;
            btnBrowse.Font = new Font("Segoe UI Semibold", 10.2F);
            btnBrowse.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnBrowse.GradientColor = Color.FromArgb(0, 227, 64);
            btnBrowse.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnBrowse.HoverBorderColor = Color.Empty;
            btnBrowse.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnBrowse.ImageSize = new Size(16, 16);
            btnBrowse.Location = new Point(418, 19);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.ParticleColor = Color.FromArgb(200, 200, 200);
            btnBrowse.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnBrowse.PressedBorderColor = Color.Empty;
            btnBrowse.PressedTextColor = Color.Empty;
            btnBrowse.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnBrowse.RippleColor = Color.FromArgb(0, 0, 0);
            btnBrowse.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnBrowse.ShadowOffset = new Point(0, 2);
            btnBrowse.Size = new Size(165, 54);
            btnBrowse.TabIndex = 35;
            btnBrowse.Text = "Browse";
            btnBrowse.TextColor = Color.FromArgb(0, 0, 0);
            btnBrowse.ToggledBackColor = Color.Empty;
            btnBrowse.ToggledBorderColor = Color.Empty;
            btnBrowse.ToggledTextColor = Color.Empty;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // siticoneLabel1
            // 
            siticoneLabel1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel1.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel1.Location = new Point(39, 630);
            siticoneLabel1.Name = "siticoneLabel1";
            siticoneLabel1.Size = new Size(309, 26);
            siticoneLabel1.TabIndex = 90;
            siticoneLabel1.Text = "PDF File";
            // 
            // ddDoctor
            // 
            ddDoctor.AllowMultipleSelection = false;
            ddDoctor.BackColor = Color.FromArgb(255, 255, 255);
            ddDoctor.BorderColor = Color.FromArgb(210, 210, 210);
            ddDoctor.BorderSize = 2;
            ddDoctor.CanBeep = false;
            ddDoctor.CanShake = true;
            ddDoctor.CornerRadius = 10;
            ddDoctor.DataSource = null;
            ddDoctor.DisplayMember = null;
            ddDoctor.DropdownBackColor = Color.FromArgb(255, 255, 255);
            ddDoctor.DropdownWidth = 0;
            ddDoctor.DropShadowEnabled = false;
            ddDoctor.EnableSearch = true;
            ddDoctor.Font = new Font("Segoe UI", 10F);
            ddDoctor.ForeColor = Color.FromArgb(60, 60, 60);
            ddDoctor.HoveredItemBackColor = Color.FromArgb(240, 240, 240);
            ddDoctor.HoveredItemTextColor = Color.FromArgb(30, 30, 30);
            ddDoctor.IsReadonly = false;
            ddDoctor.ItemHeight = 30;
            ddDoctor.Location = new Point(34, 445);
            ddDoctor.MaxDropDownItems = 8;
            ddDoctor.Name = "ddDoctor";
            ddDoctor.NotFoundBackColor = Color.Transparent;
            ddDoctor.NotFoundFont = null;
            ddDoctor.NotFoundTextColor = Color.Gray;
            ddDoctor.PlaceholderColor = Color.FromArgb(128, 128, 128);
            ddDoctor.PlaceholderDisappearsOnFocus = false;
            ddDoctor.PlaceholderText = "Select doctor";
            ddDoctor.SearchTextColor = Color.FromArgb(0, 0, 0);
            ddDoctor.SearchTextFont = null;
            ddDoctor.SelectedIndex = -1;
            ddDoctor.SelectedItem = null;
            ddDoctor.SelectedItemBackColor = Color.FromArgb(230, 240, 250);
            ddDoctor.SelectedItemTextColor = Color.FromArgb(30, 30, 30);
            ddDoctor.SelectedValue = null;
            ddDoctor.Size = new Size(599, 61);
            ddDoctor.TabIndex = 91;
            ddDoctor.UnselectedItemTextColor = Color.FromArgb(60, 60, 60);
            ddDoctor.ValueMember = null;
            // 
            // siticoneLabel2
            // 
            siticoneLabel2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel2.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel2.Location = new Point(39, 522);
            siticoneLabel2.Name = "siticoneLabel2";
            siticoneLabel2.Size = new Size(160, 26);
            siticoneLabel2.TabIndex = 93;
            siticoneLabel2.Text = "Notes (optional)";
            // 
            // txtNotes
            // 
            txtNotes.AccessibleDescription = "A customizable text input field.";
            txtNotes.AccessibleName = "Text Box";
            txtNotes.AccessibleRole = AccessibleRole.Text;
            txtNotes.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtNotes.BorderColor2 = Color.FromArgb(210, 210, 210);
            txtNotes.BorderFocusColor1 = Color.FromArgb(33, 150, 243);
            txtNotes.BorderFocusColor2 = Color.FromArgb(33, 150, 243);
            txtNotes.BorderSize = 2;
            txtNotes.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtNotes.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtNotes.CornerRadiusBottomLeft = 10;
            txtNotes.CornerRadiusBottomRight = 10;
            txtNotes.CornerRadiusTopLeft = 10;
            txtNotes.CornerRadiusTopRight = 10;
            txtNotes.CursorColor = Color.FromArgb(32, 32, 32);
            txtNotes.DisabledBackColor = Color.WhiteSmoke;
            txtNotes.DisabledBorderColor = Color.LightGray;
            txtNotes.DisabledTextColor = Color.Gray;
            txtNotes.FillColor1 = Color.White;
            txtNotes.FillColor2 = Color.White;
            txtNotes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.ForeColor = Color.Black;
            txtNotes.HoverBorderColor1 = Color.Gray;
            txtNotes.HoverBorderColor2 = Color.Gray;
            txtNotes.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtNotes.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtNotes.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtNotes.Location = new Point(34, 551);
            txtNotes.Name = "txtNotes";
            txtNotes.PlaceholderColor = Color.Gray;
            txtNotes.PlaceholderText = "Short notes for the patient's file";
            txtNotes.ReadOnlyBorderColor1 = Color.LightGray;
            txtNotes.ReadOnlyBorderColor2 = Color.LightGray;
            txtNotes.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtNotes.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtNotes.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtNotes.ReadOnlyTextColor = Color.Empty;
            txtNotes.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtNotes.SelectionForeColor = SystemColors.HighlightText;
            txtNotes.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtNotes.Size = new Size(599, 63);
            txtNotes.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtNotes.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtNotes.SolidBorderHoverColor = Color.Gray;
            txtNotes.SolidFillColor = Color.White;
            txtNotes.TabIndex = 92;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(btnCancel, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 1, 0);
            tableLayoutPanel1.Location = new Point(345, 773);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(288, 58);
            tableLayoutPanel1.TabIndex = 94;
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
            btnCancel.Size = new Size(106, 52);
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
            btnSave.AccessibleName = "Save record";
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
            btnSave.Location = new Point(121, 3);
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
            btnSave.Size = new Size(164, 52);
            btnSave.TabIndex = 40;
            btnSave.Text = "Save record";
            btnSave.TextColor = Color.FromArgb(0, 0, 0);
            btnSave.ToggledBackColor = Color.Empty;
            btnSave.ToggledBorderColor = Color.Empty;
            btnSave.ToggledTextColor = Color.Empty;
            btnSave.Click += btnSave_Click;
            // 
            // dtpDate
            // 
            dtpDate.AutoScaleFonts = true;
            dtpDate.BackColor = Color.Transparent;
            dtpDate.BaseCalendarFormSize = new Size(535, 460);
            dtpDate.BorderColor = Color.FromArgb(210, 210, 210);
            dtpDate.BorderWidth = 2;
            dtpDate.BottomLeftBorderRadius = 8;
            dtpDate.BottomRightBorderRadius = 8;
            dtpDate.CalendarBackgroundColor = Color.White;
            dtpDate.CalendarChevronColor = Color.Gray;
            dtpDate.CalendarChevronHoverColor = Color.Blue;
            dtpDate.CalendarDayButtonBackColor = Color.White;
            dtpDate.CalendarDayButtonForeColor = Color.Black;
            dtpDate.CalendarDayHeaderBackColor = Color.White;
            dtpDate.CalendarDayHeaderForeColor = Color.FromArgb(100, 100, 100);
            dtpDate.CalendarDayLabelFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            dtpDate.CalendarDisabledDateBackColor = Color.LightGray;
            dtpDate.CalendarDisabledDateForeColor = Color.DarkGray;
            dtpDate.CalendarFormAnimationSpeed = 15;
            dtpDate.CalendarFormAnimationStep = 0.08D;
            dtpDate.CalendarFormBackColor = Color.White;
            dtpDate.CalendarFormBorderColor = Color.FromArgb(220, 220, 220);
            dtpDate.CalendarFormBorderWidth = 2;
            dtpDate.CalendarFormCornerRadius = 2;
            dtpDate.CalendarFormFadeOutStep = 0.1D;
            dtpDate.CalendarFormHeight = 460;
            dtpDate.CalendarFormShadowColor = Color.FromArgb(50, 0, 0, 0);
            dtpDate.CalendarFormShadowDepth = 5;
            dtpDate.CalendarFormWidth = 535;
            dtpDate.CalendarGridMargin = new Padding(8);
            dtpDate.CalendarGridPadding = new Padding(5);
            dtpDate.CalendarLockedDateBackColor = Color.LightGray;
            dtpDate.CalendarLockedDateForeColor = Color.DarkGray;
            dtpDate.CalendarLockedDates = (List<DateTime>)resources.GetObject("dtpDate.CalendarLockedDates");
            dtpDate.CalendarMargin = 5;
            dtpDate.CalendarMaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDate.CalendarMaxYear = 2126;
            dtpDate.CalendarMinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDate.CalendarMinYear = 1926;
            dtpDate.CalendarRangeDateBackColor = Color.LightBlue;
            dtpDate.CalendarRangeEndDateBackColor = Color.DodgerBlue;
            dtpDate.CalendarRangeSelectedForeColor = Color.Black;
            dtpDate.CalendarRangeStartDateBackColor = Color.DodgerBlue;
            dtpDate.CalendarSelectedDateBackColor = Color.Black;
            dtpDate.CalendarSelectedDateForeColor = Color.White;
            dtpDate.CalendarSelectionMode = SiticoneNetCoreUI.SelectionMode.Single;
            dtpDate.CalendarTodayBackColor = Color.White;
            dtpDate.CalendarTodayForeColor = Color.Black;
            dtpDate.CalendarYearPickerHeight = 10;
            dtpDate.CanBeep = true;
            dtpDate.CanShake = true;
            dtpDate.ChevronColor = Color.Gray;
            dtpDate.ChevronHoverBackColor = Color.FromArgb(220, 225, 245);
            dtpDate.ChevronHoverColor = Color.Black;
            dtpDate.ChevronPanelBorderRadius = 0;
            dtpDate.ChevronPanelHeight = 32;
            dtpDate.ChevronPenThickness = 1.8F;
            dtpDate.ChevronRightMargin = 18;
            dtpDate.ChevronSize = new Size(9, 14);
            dtpDate.ChevronStep = 15F;
            dtpDate.ChevronTimerInterval = 15;
            dtpDate.ClearIconColor = Color.Gray;
            dtpDate.ClearIconHoverColor = Color.Red;
            dtpDate.ClearIconRightMargin = 48;
            dtpDate.ClearIconSize = 11;
            dtpDate.ContainerPanelMargin = new Padding(5);
            dtpDate.ContainerPanelPadding = new Padding(0);
            dtpDate.CustomDateFormat = "d";
            dtpDate.CustomDateFormatter = null;
            dtpDate.DateFormat = DateFormat.LongDate;
            dtpDate.DayButtonBorderRadius = 0;
            dtpDate.DayButtonClickBackColor = Color.FromArgb(220, 230, 250);
            dtpDate.DayButtonFont = new Font("Segoe UI", 10.5F);
            dtpDate.DayButtonHoverBackColor = Color.FromArgb(235, 240, 255);
            dtpDate.DayButtonHoverForeColor = Color.Black;
            dtpDate.DayButtonMargin = new Padding(3);
            dtpDate.DayButtonRowHeight = 16.66F;
            dtpDate.DayHeaderFont = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dtpDate.DayHeaderForeColor = Color.FromArgb(100, 100, 100);
            dtpDate.DayHeaderMargin = new Padding(1, 1, 1, 8);
            dtpDate.DayHeaderRowHeight = 30F;
            dtpDate.DisabledDayFont = new Font("Segoe UI", 10F, FontStyle.Italic);
            dtpDate.DropdownBackColor = Color.White;
            dtpDate.DropdownFont = new Font("Segoe UI", 11F);
            dtpDate.DropdownHeight = 250;
            dtpDate.FillColor = Color.White;
            dtpDate.FirstDayOfWeek = DayOfWeek.Sunday;
            dtpDate.Font = new Font("Segoe UI", 10F);
            dtpDate.ForeColor = Color.DimGray;
            dtpDate.GradientEndColor = Color.Gray;
            dtpDate.GradientStartColor = Color.White;
            dtpDate.HighlightWeekends = true;
            dtpDate.IconSize = 16;
            dtpDate.IsReadonly = false;
            dtpDate.Location = new Point(341, 232);
            dtpDate.LockedDates = (List<DateTime>)resources.GetObject("dtpDate.LockedDates");
            dtpDate.MakeRadial = false;
            dtpDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDate.MaxFontScale = 1.8F;
            dtpDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDate.MinFontScale = 0.4F;
            dtpDate.MinimumFormSize = new Size(150, 150);
            dtpDate.MonthChevronPanelMargin = new Padding(4, 17, 4, 0);
            dtpDate.MonthChevronSpacing = 5;
            dtpDate.MonthComboBoxMargin = new Padding(0, 17, 5, 0);
            dtpDate.MonthComboBoxSize = new Size(130, 30);
            dtpDate.Name = "dtpDate";
            dtpDate.NavigationFlowPadding = new Padding(12, 0, 12, 0);
            dtpDate.NavigationPanelBackColor = Color.FromArgb(245, 245, 250);
            dtpDate.NavigationPanelHeight = 65;
            dtpDate.NextMonthPanelWidth = 34;
            dtpDate.NextYearPanelWidth = 40;
            dtpDate.PlaceholderText = "Date";
            dtpDate.PrevMonthPanelWidth = 34;
            dtpDate.PrevYearPanelWidth = 40;
            dtpDate.RangeStartEndCornerRadius = 0;
            dtpDate.ReadonlyBorderColor = Color.Gray;
            dtpDate.ReadonlyFillColor = Color.LightGray;
            dtpDate.ReadOnlyForeColor = Color.DarkGray;
            dtpDate.ReadonlyPlaceHolderColor = Color.DarkGray;
            dtpDate.SelectedDate = null;
            dtpDate.SelectedDateBorderColor = Color.Black;
            dtpDate.SelectedDateBorderThickness = 1F;
            dtpDate.SelectedDates = (List<DateTime>)resources.GetObject("dtpDate.SelectedDates");
            dtpDate.SelectionMode = SiticoneNetCoreUI.SelectionMode.Single;
            dtpDate.ShakeAmplitude = 4;
            dtpDate.ShakeTimerInterval = 30;
            dtpDate.ShakeTotalShakes = 8;
            dtpDate.ShowClearButton = true;
            dtpDate.ShowMonthYearNavigation = true;
            dtpDate.ShowTodayButton = true;
            dtpDate.Size = new Size(292, 61);
            dtpDate.TabIndex = 95;
            dtpDate.Text = "siticoneDateTimePicker1";
            dtpDate.TodayBorderColor = Color.Black;
            dtpDate.TodayBorderThickness = 2F;
            dtpDate.TodayButtonBackColor = Color.Black;
            dtpDate.TodayButtonBorderRadius = 0;
            dtpDate.TodayButtonClickBackColor = Color.Black;
            dtpDate.TodayButtonFont = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dtpDate.TodayButtonForeColor = Color.White;
            dtpDate.TodayButtonHoverBackColor = Color.FromArgb(64, 64, 64);
            dtpDate.TodayButtonMargin = new Padding(0, 17, 15, 0);
            dtpDate.TodayButtonSize = new Size(70, 35);
            dtpDate.TodayButtonText = "Today";
            dtpDate.TodayTextColor = Color.Black;
            dtpDate.TodayTextFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            dtpDate.TopLeftBorderRadius = 8;
            dtpDate.TopRightBorderRadius = 8;
            dtpDate.UseCalendarFormAnimation = true;
            dtpDate.UseCalendarFormShadow = true;
            dtpDate.UseChevronAnimation = true;
            dtpDate.UseGradientFill = false;
            dtpDate.Value = null;
            dtpDate.WeekendDayBackColor = Color.FromArgb(250, 250, 250);
            dtpDate.WeekendDayForeColor = Color.FromArgb(180, 0, 0);
            dtpDate.YearChevronPanelMargin = new Padding(4, 17, 4, 0);
            dtpDate.YearChevronSpacing = 1;
            dtpDate.YearComboBoxMargin = new Padding(5, 17, 0, 0);
            dtpDate.YearComboBoxSize = new Size(90, 30);
            // 
            // RecordEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 852);
            Controls.Add(dtpDate);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(siticoneLabel2);
            Controls.Add(txtNotes);
            Controls.Add(ddDoctor);
            Controls.Add(siticoneLabel1);
            Controls.Add(siticoneAdvancedPanel1);
            Controls.Add(ddPatient);
            Controls.Add(lblDoctor);
            Controls.Add(siticoneLabel9);
            Controls.Add(siticoneLabel8);
            Controls.Add(siticoneLabel6);
            Controls.Add(siticoneLabel4);
            Controls.Add(txtTitle);
            Controls.Add(ddCategory);
            Controls.Add(lblHeading);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RecordEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "RecordEditForm";
            siticoneAdvancedPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneLabel lblHeading;
        private SiticoneLabel lblDoctor;
        private SiticoneLabel siticoneLabel9;
        private SiticoneLabel siticoneLabel8;
        private SiticoneLabel siticoneLabel6;
        private SiticoneLabel siticoneLabel4;
        private SiticoneTextBox txtTitle;
        private SiticoneDropdown ddCategory;
        private SiticoneDropdown ddPatient;
        private SiticoneAdvancedPanel siticoneAdvancedPanel1;
        private SiticoneLabel lblFile;
        private SiticoneButton btnBrowse;
        private SiticoneLabel siticoneLabel1;
        private SiticoneDropdown ddDoctor;
        private SiticoneLabel siticoneLabel2;
        private SiticoneTextBox txtNotes;
        private TableLayoutPanel tableLayoutPanel1;
        private SiticoneButton btnCancel;
        private SiticoneButton btnSave;
        private SiticoneDateTimePicker dtpDate;
    }
}