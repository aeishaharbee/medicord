namespace medicord_v1.Screens.Patient
{
    partial class RegisterStep3
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
            btnRegister = new SiticoneButtonAdvanced();
            btnBack = new SiticoneNavBackButton();
            siticoneLabel1 = new SiticoneLabel();
            txtEmail = new SiticoneTextBox();
            lblEmail = new SiticoneLabel();
            txtPassword = new SiticoneTextBox();
            lblNewPassword = new SiticoneLabel();
            txtConfirmPassword = new SiticoneTextBox();
            siticoneLabel2 = new SiticoneLabel();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.BadgeBackColor = Color.Red;
            btnRegister.BadgeForeColor = Color.White;
            btnRegister.BadgeRadius = 8;
            btnRegister.BadgeRightMargin = 10;
            btnRegister.BadgeValue = 0;
            btnRegister.BorderColor = Color.FromArgb(15, 76, 76);
            btnRegister.BorderColorEnd = Color.Gray;
            btnRegister.BorderColorStart = Color.White;
            btnRegister.BorderRadiusBottomLeft = 35;
            btnRegister.BorderRadiusBottomRight = 35;
            btnRegister.BorderRadiusTopLeft = 35;
            btnRegister.BorderRadiusTopRight = 35;
            btnRegister.BorderThickness = 2;
            btnRegister.ButtonColorEnd = Color.White;
            btnRegister.ButtonColorStart = Color.White;
            btnRegister.ButtonImage = null;
            btnRegister.CanBeep = false;
            btnRegister.CanShake = false;
            btnRegister.ClickSoundPath = null;
            btnRegister.DisabledOverlayOpacity = 0.5F;
            btnRegister.EnableBorderGradient = false;
            btnRegister.EnableClickSound = false;
            btnRegister.EnableFocusBorder = false;
            btnRegister.EnableHoverSound = false;
            btnRegister.EnablePressScale = false;
            btnRegister.EnableTextShadow = false;
            btnRegister.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnRegister.FocusBorderThickness = 2;
            btnRegister.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.FromArgb(15, 76, 76);
            btnRegister.HoverColor = Color.FromArgb(231, 243, 239);
            btnRegister.HoverSoundPath = null;
            btnRegister.HoverTransitionSpeed = 0.08F;
            btnRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegister.ImageLeftMargin = 5;
            btnRegister.ImageRightMargin = 8;
            btnRegister.ImageSize = 24;
            btnRegister.IsReadOnly = false;
            btnRegister.Location = new Point(56, 647);
            btnRegister.MakeRadial = false;
            btnRegister.Name = "btnRegister";
            btnRegister.PressAnimationSpeed = 0.2F;
            btnRegister.PressDepth = 1;
            btnRegister.RippleColor = Color.FromArgb(78, 127, 122);
            btnRegister.RippleExpandSpeedFactor = 0.05F;
            btnRegister.RippleFadeSpeedFactor = 0.03F;
            btnRegister.ShadowBlurFactor = 0.85F;
            btnRegister.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnRegister.ShadowOffsetX = 3;
            btnRegister.ShadowOffsetY = 3;
            btnRegister.Size = new Size(397, 71);
            btnRegister.TabIndex = 39;
            btnRegister.Text = "REGISTER";
            btnRegister.TextAlign = ContentAlignment.MiddleCenter;
            btnRegister.TextPaddingBottom = 0;
            btnRegister.TextPaddingLeft = 0;
            btnRegister.TextPaddingRight = 0;
            btnRegister.TextPaddingTop = 0;
            btnRegister.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnRegister.TextShadowOffsetX = 1;
            btnRegister.TextShadowOffsetY = 1;
            btnRegister.Click += btnToRegister_Click;
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
            btnBack.Location = new Point(20, 41);
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
            btnBack.TabIndex = 35;
            btnBack.Text = "siticoneNavBackButton1";
            btnBack.Click += btnBack_Click;
            // 
            // siticoneLabel1
            // 
            siticoneLabel1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel1.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel1.Location = new Point(57, 122);
            siticoneLabel1.Name = "siticoneLabel1";
            siticoneLabel1.Size = new Size(382, 97);
            siticoneLabel1.TabIndex = 34;
            siticoneLabel1.Text = "This is used to access your account in the future.";
            siticoneLabel1.TextAlign = ContentAlignment.MiddleLeft;
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
            txtEmail.Location = new Point(56, 278);
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
            txtEmail.Size = new Size(395, 56);
            txtEmail.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtEmail.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtEmail.SolidBorderHoverColor = Color.Gray;
            txtEmail.SolidFillColor = Color.White;
            txtEmail.TabIndex = 121;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(15, 76, 76);
            lblEmail.Location = new Point(61, 250);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(134, 26);
            lblEmail.TabIndex = 120;
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
            txtPassword.Location = new Point(56, 405);
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
            txtPassword.TabIndex = 119;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            lblNewPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPassword.ForeColor = Color.FromArgb(15, 76, 76);
            lblNewPassword.Location = new Point(61, 374);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(134, 26);
            lblNewPassword.TabIndex = 118;
            lblNewPassword.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.AccessibleDescription = "A customizable text input field.";
            txtConfirmPassword.AccessibleName = "Text Box";
            txtConfirmPassword.AccessibleRole = AccessibleRole.Text;
            txtConfirmPassword.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtConfirmPassword.BorderColor2 = Color.FromArgb(210, 210, 210);
            txtConfirmPassword.BorderFocusColor1 = Color.FromArgb(33, 150, 243);
            txtConfirmPassword.BorderFocusColor2 = Color.FromArgb(33, 150, 243);
            txtConfirmPassword.BorderSize = 2;
            txtConfirmPassword.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtConfirmPassword.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtConfirmPassword.CornerRadiusBottomLeft = 10;
            txtConfirmPassword.CornerRadiusBottomRight = 10;
            txtConfirmPassword.CornerRadiusTopLeft = 10;
            txtConfirmPassword.CornerRadiusTopRight = 10;
            txtConfirmPassword.CursorColor = Color.FromArgb(32, 32, 32);
            txtConfirmPassword.DisabledBackColor = Color.WhiteSmoke;
            txtConfirmPassword.DisabledBorderColor = Color.LightGray;
            txtConfirmPassword.DisabledTextColor = Color.Gray;
            txtConfirmPassword.FillColor1 = Color.White;
            txtConfirmPassword.FillColor2 = Color.White;
            txtConfirmPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.ForeColor = Color.Black;
            txtConfirmPassword.HoverBorderColor1 = Color.Gray;
            txtConfirmPassword.HoverBorderColor2 = Color.Gray;
            txtConfirmPassword.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtConfirmPassword.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtConfirmPassword.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtConfirmPassword.Location = new Point(56, 534);
            txtConfirmPassword.MaxLength = 50;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderColor = Color.Gray;
            txtConfirmPassword.PlaceholderText = "Re-type your password";
            txtConfirmPassword.ReadOnlyBorderColor1 = Color.LightGray;
            txtConfirmPassword.ReadOnlyBorderColor2 = Color.LightGray;
            txtConfirmPassword.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtConfirmPassword.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtConfirmPassword.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtConfirmPassword.ReadOnlyTextColor = Color.Empty;
            txtConfirmPassword.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtConfirmPassword.SelectionForeColor = SystemColors.HighlightText;
            txtConfirmPassword.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtConfirmPassword.Size = new Size(395, 57);
            txtConfirmPassword.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtConfirmPassword.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtConfirmPassword.SolidBorderHoverColor = Color.Gray;
            txtConfirmPassword.SolidFillColor = Color.White;
            txtConfirmPassword.TabIndex = 123;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // siticoneLabel2
            // 
            siticoneLabel2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel2.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel2.Location = new Point(61, 503);
            siticoneLabel2.Name = "siticoneLabel2";
            siticoneLabel2.Size = new Size(201, 26);
            siticoneLabel2.TabIndex = 122;
            siticoneLabel2.Text = "Confirm Password";
            // 
            // RegisterStep3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtConfirmPassword);
            Controls.Add(siticoneLabel2);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(btnRegister);
            Controls.Add(btnBack);
            Controls.Add(siticoneLabel1);
            Name = "RegisterStep3";
            Size = new Size(522, 865);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneNetCoreUI.SiticoneButtonAdvanced btnRegister;
        private SiticoneNetCoreUI.SiticoneNavBackButton btnBack;
        private SiticoneNetCoreUI.SiticoneLabel siticoneLabel1;
        private SiticoneTextBox txtEmail;
        private SiticoneLabel lblEmail;
        private SiticoneTextBox txtPassword;
        private SiticoneLabel lblNewPassword;
        private SiticoneTextBox txtConfirmPassword;
        private SiticoneLabel siticoneLabel2;
    }
}
