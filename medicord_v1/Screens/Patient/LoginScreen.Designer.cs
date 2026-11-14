namespace medicord_v1.Screens.Patient
{
    partial class LoginScreen
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
            lnkRegister = new SiticoneLinkedLabel();
            siticoneLabel2 = new SiticoneLabel();
            btnToLogin = new SiticoneButtonAdvanced();
            siticoneLabel1 = new SiticoneLabel();
            siticoneLabel4 = new SiticoneLabel();
            btnBack = new SiticoneNavBackButton();
            txtEmailAddress = new SiticoneTextBox();
            lblEmail = new SiticoneLabel();
            txtPassword = new SiticoneTextBox();
            lblNewPassword = new SiticoneLabel();
            SuspendLayout();
            // 
            // lnkRegister
            // 
            lnkRegister.ActiveLinkColor = Color.FromArgb(78, 127, 122);
            lnkRegister.BackColor = Color.Transparent;
            lnkRegister.Font = new Font("Segoe UI", 10F);
            lnkRegister.LinkColor = Color.FromArgb(15, 76, 76);
            lnkRegister.Location = new Point(319, 759);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(72, 29);
            lnkRegister.TabIndex = 26;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Sign up.";
            lnkRegister.TextAlign = ContentAlignment.MiddleRight;
            lnkRegister.VisitedLinkColor = Color.FromArgb(15, 76, 76);
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            // 
            // siticoneLabel2
            // 
            siticoneLabel2.Font = new Font("Segoe UI", 10F);
            siticoneLabel2.ForeColor = Color.Black;
            siticoneLabel2.Location = new Point(85, 752);
            siticoneLabel2.Name = "siticoneLabel2";
            siticoneLabel2.Size = new Size(352, 40);
            siticoneLabel2.TabIndex = 25;
            siticoneLabel2.Text = "Don't have an account? Sign up.";
            siticoneLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnToLogin
            // 
            btnToLogin.BackColor = Color.Transparent;
            btnToLogin.BadgeBackColor = Color.Red;
            btnToLogin.BadgeForeColor = Color.White;
            btnToLogin.BadgeRadius = 8;
            btnToLogin.BadgeRightMargin = 10;
            btnToLogin.BadgeValue = 0;
            btnToLogin.BorderColor = Color.FromArgb(150, 255, 255, 255);
            btnToLogin.BorderColorEnd = Color.Gray;
            btnToLogin.BorderColorStart = Color.White;
            btnToLogin.BorderRadiusBottomLeft = 35;
            btnToLogin.BorderRadiusBottomRight = 35;
            btnToLogin.BorderRadiusTopLeft = 35;
            btnToLogin.BorderRadiusTopRight = 35;
            btnToLogin.BorderThickness = 1;
            btnToLogin.ButtonColorEnd = Color.FromArgb(15, 76, 76);
            btnToLogin.ButtonColorStart = Color.FromArgb(15, 76, 76);
            btnToLogin.ButtonImage = null;
            btnToLogin.CanBeep = false;
            btnToLogin.CanShake = false;
            btnToLogin.ClickSoundPath = null;
            btnToLogin.DisabledOverlayOpacity = 0.5F;
            btnToLogin.EnableBorderGradient = false;
            btnToLogin.EnableClickSound = false;
            btnToLogin.EnableFocusBorder = false;
            btnToLogin.EnableHoverSound = false;
            btnToLogin.EnablePressScale = false;
            btnToLogin.EnableTextShadow = false;
            btnToLogin.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnToLogin.FocusBorderThickness = 2;
            btnToLogin.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnToLogin.ForeColor = Color.White;
            btnToLogin.HoverColor = Color.FromArgb(78, 127, 122);
            btnToLogin.HoverSoundPath = null;
            btnToLogin.HoverTransitionSpeed = 0.08F;
            btnToLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnToLogin.ImageLeftMargin = 5;
            btnToLogin.ImageRightMargin = 8;
            btnToLogin.ImageSize = 24;
            btnToLogin.IsReadOnly = false;
            btnToLogin.Location = new Point(55, 660);
            btnToLogin.MakeRadial = false;
            btnToLogin.Name = "btnToLogin";
            btnToLogin.PressAnimationSpeed = 0.2F;
            btnToLogin.PressDepth = 1;
            btnToLogin.RippleColor = Color.FromArgb(231, 243, 239);
            btnToLogin.RippleExpandSpeedFactor = 0.05F;
            btnToLogin.RippleFadeSpeedFactor = 0.03F;
            btnToLogin.ShadowBlurFactor = 0.85F;
            btnToLogin.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnToLogin.ShadowOffsetX = 3;
            btnToLogin.ShadowOffsetY = 3;
            btnToLogin.Size = new Size(402, 71);
            btnToLogin.TabIndex = 24;
            btnToLogin.Text = "Log In";
            btnToLogin.TextAlign = ContentAlignment.MiddleCenter;
            btnToLogin.TextPaddingBottom = 0;
            btnToLogin.TextPaddingLeft = 0;
            btnToLogin.TextPaddingRight = 0;
            btnToLogin.TextPaddingTop = 0;
            btnToLogin.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnToLogin.TextShadowOffsetX = 1;
            btnToLogin.TextShadowOffsetY = 1;
            btnToLogin.Click += btnToLogin_Click;
            // 
            // siticoneLabel1
            // 
            siticoneLabel1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel1.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel1.Location = new Point(62, 258);
            siticoneLabel1.Name = "siticoneLabel1";
            siticoneLabel1.Size = new Size(382, 38);
            siticoneLabel1.TabIndex = 20;
            siticoneLabel1.Text = "Enter your email and password.";
            siticoneLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // siticoneLabel4
            // 
            siticoneLabel4.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel4.ForeColor = Color.Black;
            siticoneLabel4.Location = new Point(55, 172);
            siticoneLabel4.Name = "siticoneLabel4";
            siticoneLabel4.Size = new Size(382, 86);
            siticoneLabel4.TabIndex = 19;
            siticoneLabel4.Text = "Log In";
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
            btnBack.Location = new Point(30, 68);
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
            btnBack.TabIndex = 18;
            btnBack.Text = "siticoneNavBackButton1";
            btnBack.Click += btnBack_Click;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.AccessibleDescription = "A customizable text input field.";
            txtEmailAddress.AccessibleName = "Text Box";
            txtEmailAddress.AccessibleRole = AccessibleRole.Text;
            txtEmailAddress.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtEmailAddress.BorderColor2 = Color.FromArgb(210, 210, 210);
            txtEmailAddress.BorderFocusColor1 = Color.FromArgb(33, 150, 243);
            txtEmailAddress.BorderFocusColor2 = Color.FromArgb(33, 150, 243);
            txtEmailAddress.BorderSize = 2;
            txtEmailAddress.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtEmailAddress.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtEmailAddress.CornerRadiusBottomLeft = 10;
            txtEmailAddress.CornerRadiusBottomRight = 10;
            txtEmailAddress.CornerRadiusTopLeft = 10;
            txtEmailAddress.CornerRadiusTopRight = 10;
            txtEmailAddress.CursorColor = Color.FromArgb(32, 32, 32);
            txtEmailAddress.DisabledBackColor = Color.WhiteSmoke;
            txtEmailAddress.DisabledBorderColor = Color.LightGray;
            txtEmailAddress.DisabledTextColor = Color.Gray;
            txtEmailAddress.FillColor1 = Color.White;
            txtEmailAddress.FillColor2 = Color.White;
            txtEmailAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailAddress.ForeColor = Color.Black;
            txtEmailAddress.HoverBorderColor1 = Color.Gray;
            txtEmailAddress.HoverBorderColor2 = Color.Gray;
            txtEmailAddress.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtEmailAddress.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtEmailAddress.InputFilter = SiticoneTextBox.SiticoneInputFilter.NoWhiteSpace;
            txtEmailAddress.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtEmailAddress.Location = new Point(62, 361);
            txtEmailAddress.MaxLength = 100;
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.PlaceholderColor = Color.Gray;
            txtEmailAddress.PlaceholderText = "Email address";
            txtEmailAddress.ReadOnlyBorderColor1 = Color.LightGray;
            txtEmailAddress.ReadOnlyBorderColor2 = Color.LightGray;
            txtEmailAddress.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtEmailAddress.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtEmailAddress.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtEmailAddress.ReadOnlyTextColor = Color.Empty;
            txtEmailAddress.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtEmailAddress.SelectionForeColor = SystemColors.HighlightText;
            txtEmailAddress.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtEmailAddress.Size = new Size(395, 56);
            txtEmailAddress.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtEmailAddress.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtEmailAddress.SolidBorderHoverColor = Color.Gray;
            txtEmailAddress.SolidFillColor = Color.White;
            txtEmailAddress.TabIndex = 117;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(15, 76, 76);
            lblEmail.Location = new Point(67, 333);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(134, 26);
            lblEmail.TabIndex = 116;
            lblEmail.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.AccessibleDescription = "A customizable text input field.";
            txtPassword.AccessibleName = "Text Box";
            txtPassword.AccessibleRole = AccessibleRole.Text;
            txtPassword.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtPassword.BorderColor2 = Color.FromArgb(210, 210, 210);
            txtPassword.BorderFocusColor1 = Color.FromArgb(33, 150, 243);
            txtPassword.BorderFocusColor2 = Color.FromArgb(33, 150, 243);
            txtPassword.BorderSize = 2;
            txtPassword.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtPassword.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtPassword.CornerRadiusBottomLeft = 10;
            txtPassword.CornerRadiusBottomRight = 10;
            txtPassword.CornerRadiusTopLeft = 10;
            txtPassword.CornerRadiusTopRight = 10;
            txtPassword.CursorColor = Color.FromArgb(32, 32, 32);
            txtPassword.DisabledBackColor = Color.WhiteSmoke;
            txtPassword.DisabledBorderColor = Color.LightGray;
            txtPassword.DisabledTextColor = Color.Gray;
            txtPassword.FillColor1 = Color.White;
            txtPassword.FillColor2 = Color.White;
            txtPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.HoverBorderColor1 = Color.Gray;
            txtPassword.HoverBorderColor2 = Color.Gray;
            txtPassword.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtPassword.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtPassword.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtPassword.Location = new Point(62, 488);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderColor = Color.Gray;
            txtPassword.PlaceholderText = "At least 8 characters";
            txtPassword.ReadOnlyBorderColor1 = Color.LightGray;
            txtPassword.ReadOnlyBorderColor2 = Color.LightGray;
            txtPassword.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtPassword.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtPassword.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtPassword.ReadOnlyTextColor = Color.Empty;
            txtPassword.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtPassword.SelectionForeColor = SystemColors.HighlightText;
            txtPassword.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtPassword.Size = new Size(395, 57);
            txtPassword.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtPassword.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtPassword.SolidBorderHoverColor = Color.Gray;
            txtPassword.SolidFillColor = Color.White;
            txtPassword.TabIndex = 115;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            lblNewPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPassword.ForeColor = Color.FromArgb(15, 76, 76);
            lblNewPassword.Location = new Point(67, 457);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(134, 26);
            lblNewPassword.TabIndex = 114;
            lblNewPassword.Text = "Password";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtEmailAddress);
            Controls.Add(lblEmail);
            Controls.Add(txtPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(lnkRegister);
            Controls.Add(siticoneLabel2);
            Controls.Add(btnToLogin);
            Controls.Add(siticoneLabel1);
            Controls.Add(siticoneLabel4);
            Controls.Add(btnBack);
            Name = "LoginScreen";
            Size = new Size(522, 865);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneNetCoreUI.SiticoneLinkedLabel siticoneLinkedLabel2;
        private SiticoneNetCoreUI.SiticoneLabel siticoneLabel2;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btnToLogin;
        private SiticoneNetCoreUI.SiticoneMaterialTextbox siticoneMaterialTextbox2;
        private SiticoneNetCoreUI.SiticoneLabel siticoneLabel1;
        private SiticoneNetCoreUI.SiticoneLabel siticoneLabel4;
        private SiticoneNetCoreUI.SiticoneNavBackButton btnBack;
        private SiticoneNetCoreUI.SiticoneLinkedLabel lnkRegister;
        private SiticoneLabel lblEmail;
        private SiticoneTextBox txtPassword;
        private SiticoneLabel lblNewPassword;
        private SiticoneTextBox txtEmailAddress;
    }
}
