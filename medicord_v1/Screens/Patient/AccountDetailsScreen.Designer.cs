namespace medicord_v1.Screens.Patient
{
    partial class AccountDetailsScreen
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
            siticoneLabel4 = new SiticoneLabel();
            btnBack = new SiticoneNavBackButton();
            siticoneLabel15 = new SiticoneLabel();
            stcSeparator = new SiticoneHSeparator();
            txtEmail = new SiticoneTextBox();
            lblEmail = new SiticoneLabel();
            txtConfirm = new SiticoneTextBox();
            txtCurrent = new SiticoneTextBox();
            txtNewPassword = new SiticoneTextBox();
            lblConfirmPassword = new SiticoneLabel();
            lblNewPassword = new SiticoneLabel();
            lblCurrentPassword = new SiticoneLabel();
            txtFullName = new SiticoneTextBox();
            siticoneLabel1 = new SiticoneLabel();
            ddIdType = new SiticoneDropdown();
            txtIdNumber = new SiticoneTextBox();
            siticoneLabel2 = new SiticoneLabel();
            siticoneLabel3 = new SiticoneLabel();
            btnSave = new SiticoneButton();
            siticoneLabel5 = new SiticoneLabel();
            ddNationality = new SiticoneDropdown();
            SuspendLayout();
            // 
            // siticoneLabel4
            // 
            siticoneLabel4.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel4.ForeColor = Color.Black;
            siticoneLabel4.Location = new Point(66, 0);
            siticoneLabel4.Name = "siticoneLabel4";
            siticoneLabel4.Size = new Size(382, 79);
            siticoneLabel4.TabIndex = 29;
            siticoneLabel4.Text = "Account Details";
            siticoneLabel4.TextAlign = ContentAlignment.MiddleLeft;
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
            btnBack.Location = new Point(10, 16);
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
            btnBack.TabIndex = 28;
            btnBack.Text = "siticoneNavBackButton1";
            btnBack.Click += btnBack_Click;
            // 
            // siticoneLabel15
            // 
            siticoneLabel15.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            siticoneLabel15.ForeColor = Color.FromArgb(90, 107, 106);
            siticoneLabel15.Location = new Point(69, 69);
            siticoneLabel15.Name = "siticoneLabel15";
            siticoneLabel15.Size = new Size(416, 26);
            siticoneLabel15.TabIndex = 74;
            siticoneLabel15.Text = "Your name and ID appear on your medical records.";
            // 
            // stcSeparator
            // 
            stcSeparator.BackColor = Color.Transparent;
            stcSeparator.GradientEndColor = Color.Black;
            stcSeparator.GradientMode = SiticoneHSeparator.LinearGradientMode.None;
            stcSeparator.GradientStartColor = Color.White;
            stcSeparator.LineColor = Color.Silver;
            stcSeparator.LineWidth = 1;
            stcSeparator.Location = new Point(33, 680);
            stcSeparator.Name = "stcSeparator";
            stcSeparator.ParallelLines = 1;
            stcSeparator.ParallelLineSpacing = 4;
            stcSeparator.SegmentNumberColor = Color.Black;
            stcSeparator.SegmentNumberFont = new Font("Arial", 8F);
            stcSeparator.Segments = 1;
            stcSeparator.SegmentSpacing = 10;
            stcSeparator.SeparatorDashStyle = SiticoneHSeparator.CustomDashStyle.Solid;
            stcSeparator.ShowSegmentNumbers = false;
            stcSeparator.Size = new Size(463, 17);
            stcSeparator.TabIndex = 115;
            stcSeparator.Text = "siticonehSeparator1";
            // 
            // txtEmail
            // 
            txtEmail.AccessibleDescription = "A customizable text input field.";
            txtEmail.AccessibleName = "Text Box";
            txtEmail.AccessibleRole = AccessibleRole.Text;
            txtEmail.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtEmail.BorderColor2 = Color.FromArgb(210, 210, 210);
            txtEmail.BorderFocusColor1 = Color.FromArgb(33, 150, 243);
            txtEmail.BorderFocusColor2 = Color.FromArgb(33, 150, 243);
            txtEmail.BorderSize = 2;
            txtEmail.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtEmail.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtEmail.CornerRadiusBottomLeft = 10;
            txtEmail.CornerRadiusBottomRight = 10;
            txtEmail.CornerRadiusTopLeft = 10;
            txtEmail.CornerRadiusTopRight = 10;
            txtEmail.CursorColor = Color.FromArgb(32, 32, 32);
            txtEmail.DisabledBackColor = Color.WhiteSmoke;
            txtEmail.DisabledBorderColor = Color.LightGray;
            txtEmail.DisabledTextColor = Color.Gray;
            txtEmail.FillColor1 = Color.White;
            txtEmail.FillColor2 = Color.White;
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.Black;
            txtEmail.HoverBorderColor1 = Color.Gray;
            txtEmail.HoverBorderColor2 = Color.Gray;
            txtEmail.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtEmail.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtEmail.InputFilter = SiticoneTextBox.SiticoneInputFilter.NoWhiteSpace;
            txtEmail.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtEmail.Location = new Point(28, 430);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderColor = Color.Gray;
            txtEmail.PlaceholderText = "Email address";
            txtEmail.ReadOnlyBorderColor1 = Color.LightGray;
            txtEmail.ReadOnlyBorderColor2 = Color.LightGray;
            txtEmail.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtEmail.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtEmail.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtEmail.ReadOnlyTextColor = Color.Empty;
            txtEmail.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtEmail.SelectionForeColor = SystemColors.HighlightText;
            txtEmail.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtEmail.Size = new Size(469, 52);
            txtEmail.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtEmail.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtEmail.SolidBorderHoverColor = Color.Gray;
            txtEmail.SolidFillColor = Color.White;
            txtEmail.TabIndex = 113;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(15, 76, 76);
            lblEmail.Location = new Point(33, 402);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(160, 26);
            lblEmail.TabIndex = 112;
            lblEmail.Text = "Email";
            // 
            // txtConfirm
            // 
            txtConfirm.AccessibleDescription = "A customizable text input field.";
            txtConfirm.AccessibleName = "Text Box";
            txtConfirm.AccessibleRole = AccessibleRole.Text;
            txtConfirm.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtConfirm.BorderColor2 = Color.FromArgb(210, 210, 210);
            txtConfirm.BorderFocusColor1 = Color.FromArgb(33, 150, 243);
            txtConfirm.BorderFocusColor2 = Color.FromArgb(33, 150, 243);
            txtConfirm.BorderSize = 2;
            txtConfirm.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtConfirm.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtConfirm.CornerRadiusBottomLeft = 10;
            txtConfirm.CornerRadiusBottomRight = 10;
            txtConfirm.CornerRadiusTopLeft = 10;
            txtConfirm.CornerRadiusTopRight = 10;
            txtConfirm.CursorColor = Color.FromArgb(32, 32, 32);
            txtConfirm.DisabledBackColor = Color.WhiteSmoke;
            txtConfirm.DisabledBorderColor = Color.LightGray;
            txtConfirm.DisabledTextColor = Color.Gray;
            txtConfirm.FillColor1 = Color.White;
            txtConfirm.FillColor2 = Color.White;
            txtConfirm.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirm.ForeColor = Color.Black;
            txtConfirm.HoverBorderColor1 = Color.Gray;
            txtConfirm.HoverBorderColor2 = Color.Gray;
            txtConfirm.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtConfirm.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtConfirm.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtConfirm.Location = new Point(28, 616);
            txtConfirm.MaxLength = 50;
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PlaceholderColor = Color.Gray;
            txtConfirm.PlaceholderText = "Re-enter new password";
            txtConfirm.ReadOnlyBorderColor1 = Color.LightGray;
            txtConfirm.ReadOnlyBorderColor2 = Color.LightGray;
            txtConfirm.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtConfirm.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtConfirm.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtConfirm.ReadOnlyTextColor = Color.Empty;
            txtConfirm.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtConfirm.SelectionForeColor = SystemColors.HighlightText;
            txtConfirm.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtConfirm.Size = new Size(469, 52);
            txtConfirm.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtConfirm.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtConfirm.SolidBorderHoverColor = Color.Gray;
            txtConfirm.SolidFillColor = Color.White;
            txtConfirm.TabIndex = 111;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // txtCurrent
            // 
            txtCurrent.AccessibleDescription = "A customizable text input field.";
            txtCurrent.AccessibleName = "Text Box";
            txtCurrent.AccessibleRole = AccessibleRole.Text;
            txtCurrent.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtCurrent.BorderColor2 = Color.FromArgb(210, 210, 210);
            txtCurrent.BorderFocusColor1 = Color.FromArgb(33, 150, 243);
            txtCurrent.BorderFocusColor2 = Color.FromArgb(33, 150, 243);
            txtCurrent.BorderSize = 2;
            txtCurrent.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtCurrent.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtCurrent.CornerRadiusBottomLeft = 10;
            txtCurrent.CornerRadiusBottomRight = 10;
            txtCurrent.CornerRadiusTopLeft = 10;
            txtCurrent.CornerRadiusTopRight = 10;
            txtCurrent.CursorColor = Color.FromArgb(32, 32, 32);
            txtCurrent.DisabledBackColor = Color.WhiteSmoke;
            txtCurrent.DisabledBorderColor = Color.LightGray;
            txtCurrent.DisabledTextColor = Color.Gray;
            txtCurrent.FillColor1 = Color.White;
            txtCurrent.FillColor2 = Color.White;
            txtCurrent.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrent.ForeColor = Color.Black;
            txtCurrent.HoverBorderColor1 = Color.Gray;
            txtCurrent.HoverBorderColor2 = Color.Gray;
            txtCurrent.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtCurrent.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtCurrent.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtCurrent.Location = new Point(28, 733);
            txtCurrent.MaxLength = 50;
            txtCurrent.Name = "txtCurrent";
            txtCurrent.PlaceholderColor = Color.Gray;
            txtCurrent.PlaceholderText = "Current password";
            txtCurrent.ReadOnlyBorderColor1 = Color.LightGray;
            txtCurrent.ReadOnlyBorderColor2 = Color.LightGray;
            txtCurrent.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtCurrent.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtCurrent.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtCurrent.ReadOnlyTextColor = Color.Empty;
            txtCurrent.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtCurrent.SelectionForeColor = SystemColors.HighlightText;
            txtCurrent.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtCurrent.Size = new Size(469, 52);
            txtCurrent.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtCurrent.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtCurrent.SolidBorderHoverColor = Color.Gray;
            txtCurrent.SolidFillColor = Color.White;
            txtCurrent.TabIndex = 110;
            txtCurrent.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            txtNewPassword.AccessibleDescription = "A customizable text input field.";
            txtNewPassword.AccessibleName = "Text Box";
            txtNewPassword.AccessibleRole = AccessibleRole.Text;
            txtNewPassword.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtNewPassword.BorderColor2 = Color.FromArgb(210, 210, 210);
            txtNewPassword.BorderFocusColor1 = Color.FromArgb(33, 150, 243);
            txtNewPassword.BorderFocusColor2 = Color.FromArgb(33, 150, 243);
            txtNewPassword.BorderSize = 2;
            txtNewPassword.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtNewPassword.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtNewPassword.CornerRadiusBottomLeft = 10;
            txtNewPassword.CornerRadiusBottomRight = 10;
            txtNewPassword.CornerRadiusTopLeft = 10;
            txtNewPassword.CornerRadiusTopRight = 10;
            txtNewPassword.CursorColor = Color.FromArgb(32, 32, 32);
            txtNewPassword.DisabledBackColor = Color.WhiteSmoke;
            txtNewPassword.DisabledBorderColor = Color.LightGray;
            txtNewPassword.DisabledTextColor = Color.Gray;
            txtNewPassword.FillColor1 = Color.White;
            txtNewPassword.FillColor2 = Color.White;
            txtNewPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.ForeColor = Color.Black;
            txtNewPassword.HoverBorderColor1 = Color.Gray;
            txtNewPassword.HoverBorderColor2 = Color.Gray;
            txtNewPassword.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtNewPassword.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtNewPassword.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtNewPassword.Location = new Point(28, 522);
            txtNewPassword.MaxLength = 50;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderColor = Color.Gray;
            txtNewPassword.PlaceholderText = "At least 8 characters";
            txtNewPassword.ReadOnlyBorderColor1 = Color.LightGray;
            txtNewPassword.ReadOnlyBorderColor2 = Color.LightGray;
            txtNewPassword.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtNewPassword.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtNewPassword.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtNewPassword.ReadOnlyTextColor = Color.Empty;
            txtNewPassword.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtNewPassword.SelectionForeColor = SystemColors.HighlightText;
            txtNewPassword.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtNewPassword.Size = new Size(469, 53);
            txtNewPassword.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtNewPassword.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtNewPassword.SolidBorderHoverColor = Color.Gray;
            txtNewPassword.SolidFillColor = Color.White;
            txtNewPassword.TabIndex = 109;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.FromArgb(15, 76, 76);
            lblConfirmPassword.Location = new Point(33, 587);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(268, 26);
            lblConfirmPassword.TabIndex = 108;
            lblConfirmPassword.Text = "Confirm new password";
            // 
            // lblNewPassword
            // 
            lblNewPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPassword.ForeColor = Color.FromArgb(15, 76, 76);
            lblNewPassword.Location = new Point(33, 491);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(160, 26);
            lblNewPassword.TabIndex = 107;
            lblNewPassword.Text = "New password";
            // 
            // lblCurrentPassword
            // 
            lblCurrentPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentPassword.ForeColor = Color.FromArgb(15, 76, 76);
            lblCurrentPassword.Location = new Point(33, 702);
            lblCurrentPassword.Name = "lblCurrentPassword";
            lblCurrentPassword.Size = new Size(445, 26);
            lblCurrentPassword.TabIndex = 106;
            lblCurrentPassword.Text = "Current password (required to save)";
            // 
            // txtFullName
            // 
            txtFullName.AccessibleDescription = "A customizable text input field.";
            txtFullName.AccessibleName = "Text Box";
            txtFullName.AccessibleRole = AccessibleRole.Text;
            txtFullName.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtFullName.BorderColor2 = Color.FromArgb(210, 210, 210);
            txtFullName.BorderFocusColor1 = Color.FromArgb(33, 150, 243);
            txtFullName.BorderFocusColor2 = Color.FromArgb(33, 150, 243);
            txtFullName.BorderSize = 2;
            txtFullName.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtFullName.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtFullName.CornerRadiusBottomLeft = 10;
            txtFullName.CornerRadiusBottomRight = 10;
            txtFullName.CornerRadiusTopLeft = 10;
            txtFullName.CornerRadiusTopRight = 10;
            txtFullName.CursorColor = Color.FromArgb(32, 32, 32);
            txtFullName.DisabledBackColor = Color.WhiteSmoke;
            txtFullName.DisabledBorderColor = Color.LightGray;
            txtFullName.DisabledTextColor = Color.Gray;
            txtFullName.FillColor1 = Color.White;
            txtFullName.FillColor2 = Color.White;
            txtFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.ForeColor = Color.Black;
            txtFullName.HoverBorderColor1 = Color.Gray;
            txtFullName.HoverBorderColor2 = Color.Gray;
            txtFullName.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtFullName.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtFullName.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtFullName.Location = new Point(28, 154);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderColor = Color.Gray;
            txtFullName.PlaceholderText = "Full Name";
            txtFullName.ReadOnlyBorderColor1 = Color.LightGray;
            txtFullName.ReadOnlyBorderColor2 = Color.LightGray;
            txtFullName.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtFullName.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtFullName.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtFullName.ReadOnlyTextColor = Color.Empty;
            txtFullName.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtFullName.SelectionForeColor = SystemColors.HighlightText;
            txtFullName.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtFullName.Size = new Size(469, 53);
            txtFullName.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtFullName.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtFullName.SolidBorderHoverColor = Color.Gray;
            txtFullName.SolidFillColor = Color.White;
            txtFullName.TabIndex = 116;
            // 
            // siticoneLabel1
            // 
            siticoneLabel1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel1.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel1.Location = new Point(33, 125);
            siticoneLabel1.Name = "siticoneLabel1";
            siticoneLabel1.Size = new Size(160, 26);
            siticoneLabel1.TabIndex = 117;
            siticoneLabel1.Text = "Full Name";
            // 
            // ddIdType
            // 
            ddIdType.AllowMultipleSelection = false;
            ddIdType.BackColor = Color.FromArgb(255, 255, 255);
            ddIdType.BorderColor = Color.FromArgb(210, 210, 210);
            ddIdType.BorderSize = 2;
            ddIdType.CanBeep = false;
            ddIdType.CanShake = true;
            ddIdType.CornerRadius = 10;
            ddIdType.DataSource = null;
            ddIdType.DisplayMember = null;
            ddIdType.DropdownBackColor = Color.FromArgb(255, 255, 255);
            ddIdType.DropdownWidth = 0;
            ddIdType.DropShadowEnabled = false;
            ddIdType.Font = new Font("Segoe UI", 10F);
            ddIdType.ForeColor = Color.FromArgb(60, 60, 60);
            ddIdType.HoveredItemBackColor = Color.FromArgb(240, 240, 240);
            ddIdType.HoveredItemTextColor = Color.FromArgb(30, 30, 30);
            ddIdType.IsReadonly = false;
            ddIdType.ItemHeight = 30;
            ddIdType.Location = new Point(28, 343);
            ddIdType.MaxDropDownItems = 8;
            ddIdType.Name = "ddIdType";
            ddIdType.NotFoundBackColor = Color.Transparent;
            ddIdType.NotFoundFont = null;
            ddIdType.NotFoundTextColor = Color.Gray;
            ddIdType.PlaceholderColor = Color.FromArgb(128, 128, 128);
            ddIdType.PlaceholderDisappearsOnFocus = false;
            ddIdType.PlaceholderText = "ID Type";
            ddIdType.SearchTextColor = Color.FromArgb(0, 0, 0);
            ddIdType.SearchTextFont = null;
            ddIdType.SelectedIndex = -1;
            ddIdType.SelectedItem = null;
            ddIdType.SelectedItemBackColor = Color.FromArgb(230, 240, 250);
            ddIdType.SelectedItemTextColor = Color.FromArgb(30, 30, 30);
            ddIdType.SelectedValue = null;
            ddIdType.Size = new Size(139, 51);
            ddIdType.TabIndex = 118;
            ddIdType.UnselectedItemTextColor = Color.FromArgb(60, 60, 60);
            ddIdType.ValueMember = null;
            // 
            // txtIdNumber
            // 
            txtIdNumber.AccessibleDescription = "A customizable text input field.";
            txtIdNumber.AccessibleName = "Text Box";
            txtIdNumber.AccessibleRole = AccessibleRole.Text;
            txtIdNumber.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtIdNumber.BorderColor2 = Color.FromArgb(210, 210, 210);
            txtIdNumber.BorderFocusColor1 = Color.FromArgb(33, 150, 243);
            txtIdNumber.BorderFocusColor2 = Color.FromArgb(33, 150, 243);
            txtIdNumber.BorderSize = 2;
            txtIdNumber.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtIdNumber.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtIdNumber.CornerRadiusBottomLeft = 10;
            txtIdNumber.CornerRadiusBottomRight = 10;
            txtIdNumber.CornerRadiusTopLeft = 10;
            txtIdNumber.CornerRadiusTopRight = 10;
            txtIdNumber.CursorColor = Color.FromArgb(32, 32, 32);
            txtIdNumber.DisabledBackColor = Color.WhiteSmoke;
            txtIdNumber.DisabledBorderColor = Color.LightGray;
            txtIdNumber.DisabledTextColor = Color.Gray;
            txtIdNumber.FillColor1 = Color.White;
            txtIdNumber.FillColor2 = Color.White;
            txtIdNumber.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdNumber.ForeColor = Color.Black;
            txtIdNumber.HoverBorderColor1 = Color.Gray;
            txtIdNumber.HoverBorderColor2 = Color.Gray;
            txtIdNumber.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtIdNumber.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtIdNumber.InputFilter = SiticoneTextBox.SiticoneInputFilter.DecimalNumber;
            txtIdNumber.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtIdNumber.Location = new Point(185, 343);
            txtIdNumber.MaxLength = 100;
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.PlaceholderColor = Color.Gray;
            txtIdNumber.PlaceholderText = "ID number";
            txtIdNumber.ReadOnlyBorderColor1 = Color.LightGray;
            txtIdNumber.ReadOnlyBorderColor2 = Color.LightGray;
            txtIdNumber.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtIdNumber.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtIdNumber.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtIdNumber.ReadOnlyTextColor = Color.Empty;
            txtIdNumber.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtIdNumber.SelectionForeColor = SystemColors.HighlightText;
            txtIdNumber.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtIdNumber.Size = new Size(312, 51);
            txtIdNumber.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtIdNumber.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtIdNumber.SolidBorderHoverColor = Color.Gray;
            txtIdNumber.SolidFillColor = Color.White;
            txtIdNumber.TabIndex = 119;
            // 
            // siticoneLabel2
            // 
            siticoneLabel2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel2.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel2.Location = new Point(33, 314);
            siticoneLabel2.Name = "siticoneLabel2";
            siticoneLabel2.Size = new Size(134, 26);
            siticoneLabel2.TabIndex = 120;
            siticoneLabel2.Text = "ID Type";
            // 
            // siticoneLabel3
            // 
            siticoneLabel3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel3.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel3.Location = new Point(190, 314);
            siticoneLabel3.Name = "siticoneLabel3";
            siticoneLabel3.Size = new Size(134, 26);
            siticoneLabel3.TabIndex = 121;
            siticoneLabel3.Text = "ID Number";
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
            btnSave.Location = new Point(28, 829);
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
            btnSave.Size = new Size(469, 52);
            btnSave.TabIndex = 122;
            btnSave.Text = "Save changes";
            btnSave.TextColor = Color.FromArgb(0, 0, 0);
            btnSave.ToggledBackColor = Color.Empty;
            btnSave.ToggledBorderColor = Color.Empty;
            btnSave.ToggledTextColor = Color.Empty;
            btnSave.Click += btnSave_Click;
            // 
            // siticoneLabel5
            // 
            siticoneLabel5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel5.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel5.Location = new Point(33, 221);
            siticoneLabel5.Name = "siticoneLabel5";
            siticoneLabel5.Size = new Size(134, 26);
            siticoneLabel5.TabIndex = 124;
            siticoneLabel5.Text = "Nationality";
            // 
            // ddNationality
            // 
            ddNationality.AllowMultipleSelection = false;
            ddNationality.BackColor = Color.FromArgb(255, 255, 255);
            ddNationality.BorderColor = Color.FromArgb(210, 210, 210);
            ddNationality.BorderSize = 2;
            ddNationality.CanBeep = false;
            ddNationality.CanShake = true;
            ddNationality.CornerRadius = 10;
            ddNationality.DataSource = null;
            ddNationality.DisplayMember = null;
            ddNationality.DropdownBackColor = Color.FromArgb(255, 255, 255);
            ddNationality.DropdownWidth = 0;
            ddNationality.DropShadowEnabled = false;
            ddNationality.EnableSearch = true;
            ddNationality.Font = new Font("Segoe UI", 10F);
            ddNationality.ForeColor = Color.FromArgb(60, 60, 60);
            ddNationality.HoveredItemBackColor = Color.FromArgb(240, 240, 240);
            ddNationality.HoveredItemTextColor = Color.FromArgb(30, 30, 30);
            ddNationality.IsReadonly = false;
            ddNationality.ItemHeight = 30;
            ddNationality.Location = new Point(28, 250);
            ddNationality.MaxDropDownItems = 8;
            ddNationality.Name = "ddNationality";
            ddNationality.NotFoundBackColor = Color.Transparent;
            ddNationality.NotFoundFont = null;
            ddNationality.NotFoundTextColor = Color.Gray;
            ddNationality.PlaceholderColor = Color.FromArgb(128, 128, 128);
            ddNationality.PlaceholderDisappearsOnFocus = false;
            ddNationality.PlaceholderText = "Nationality";
            ddNationality.SearchTextColor = Color.FromArgb(0, 0, 0);
            ddNationality.SearchTextFont = null;
            ddNationality.SelectedIndex = -1;
            ddNationality.SelectedItem = null;
            ddNationality.SelectedItemBackColor = Color.FromArgb(230, 240, 250);
            ddNationality.SelectedItemTextColor = Color.FromArgb(30, 30, 30);
            ddNationality.SelectedValue = null;
            ddNationality.Size = new Size(469, 51);
            ddNationality.TabIndex = 123;
            ddNationality.UnselectedItemTextColor = Color.FromArgb(60, 60, 60);
            ddNationality.ValueMember = null;
            // 
            // AccountDetailsScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(siticoneLabel5);
            Controls.Add(ddNationality);
            Controls.Add(btnSave);
            Controls.Add(siticoneLabel3);
            Controls.Add(siticoneLabel2);
            Controls.Add(txtIdNumber);
            Controls.Add(ddIdType);
            Controls.Add(siticoneLabel1);
            Controls.Add(txtFullName);
            Controls.Add(stcSeparator);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtConfirm);
            Controls.Add(txtCurrent);
            Controls.Add(txtNewPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(lblCurrentPassword);
            Controls.Add(siticoneLabel15);
            Controls.Add(siticoneLabel4);
            Controls.Add(btnBack);
            Name = "AccountDetailsScreen";
            Size = new Size(522, 903);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneLabel siticoneLabel4;
        private SiticoneNavBackButton btnBack;
        private SiticoneLabel siticoneLabel15;
        private SiticoneHSeparator stcSeparator;
        private SiticoneTextBox txtEmail;
        private SiticoneLabel lblEmail;
        private SiticoneTextBox txtConfirm;
        private SiticoneTextBox txtCurrent;
        private SiticoneTextBox txtNewPassword;
        private SiticoneLabel lblConfirmPassword;
        private SiticoneLabel lblNewPassword;
        private SiticoneLabel lblCurrentPassword;
        private SiticoneTextBox txtFullName;
        private SiticoneLabel siticoneLabel1;
        private SiticoneDropdown ddIdType;
        private SiticoneTextBox txtIdNumber;
        private SiticoneLabel siticoneLabel2;
        private SiticoneLabel siticoneLabel3;
        private SiticoneButton btnSave;
        private SiticoneLabel siticoneLabel5;
        private SiticoneDropdown ddNationality;
    }
}
