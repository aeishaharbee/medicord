namespace medicord_v1.Screens
{
    partial class RoleChooserScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleChooserScreen));
            pnlForm = new SiticonePanel();
            siticoneLabel2 = new SiticoneLabel();
            siticoneLabel1 = new SiticoneLabel();
            btnWorker = new SiticoneButtonAdvanced();
            btnFacility = new SiticoneButtonAdvanced();
            btnBack = new SiticoneNavBackButton();
            siticoneLabel4 = new SiticoneLabel();
            pnlForm.SuspendLayout();
            SuspendLayout();
            // 
            // pnlForm
            // 
            pnlForm.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            pnlForm.BackColor = Color.Transparent;
            pnlForm.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            pnlForm.BorderColor = Color.Gray;
            pnlForm.BorderDashPattern = null;
            pnlForm.BorderGradientEndColor = Color.Purple;
            pnlForm.BorderGradientStartColor = Color.Blue;
            pnlForm.BorderThickness = 2F;
            pnlForm.Controls.Add(siticoneLabel2);
            pnlForm.Controls.Add(siticoneLabel1);
            pnlForm.Controls.Add(btnWorker);
            pnlForm.Controls.Add(btnFacility);
            pnlForm.Controls.Add(btnBack);
            pnlForm.Controls.Add(siticoneLabel4);
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
            pnlForm.Location = new Point(191, 59);
            pnlForm.Name = "pnlForm";
            pnlForm.PatternColor = Color.FromArgb(30, 0, 0, 0);
            pnlForm.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            pnlForm.RippleAlpha = 50;
            pnlForm.RippleAlphaDecrement = 3;
            pnlForm.RippleColor = Color.FromArgb(50, 255, 255, 255);
            pnlForm.RippleMaxSize = 600F;
            pnlForm.RippleSpeed = 15F;
            pnlForm.ShowBorder = true;
            pnlForm.Size = new Size(765, 785);
            pnlForm.TabIndex = 0;
            pnlForm.TabStop = true;
            pnlForm.UseBorderGradient = false;
            pnlForm.UseMultiGradient = false;
            pnlForm.UsePatternTexture = false;
            pnlForm.UseRadialGradient = false;
            // 
            // siticoneLabel2
            // 
            siticoneLabel2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel2.ForeColor = Color.Black;
            siticoneLabel2.Location = new Point(394, 587);
            siticoneLabel2.Name = "siticoneLabel2";
            siticoneLabel2.Size = new Size(329, 86);
            siticoneLabel2.TabIndex = 26;
            siticoneLabel2.Text = "I'm a health worker";
            siticoneLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // siticoneLabel1
            // 
            siticoneLabel1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel1.ForeColor = Color.Black;
            siticoneLabel1.Location = new Point(45, 587);
            siticoneLabel1.Name = "siticoneLabel1";
            siticoneLabel1.Size = new Size(329, 86);
            siticoneLabel1.TabIndex = 25;
            siticoneLabel1.Text = "I'm a health facility";
            siticoneLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnWorker
            // 
            btnWorker.BackColor = Color.Transparent;
            btnWorker.BadgeBackColor = Color.Red;
            btnWorker.BadgeForeColor = Color.White;
            btnWorker.BadgeRadius = 8;
            btnWorker.BadgeRightMargin = 10;
            btnWorker.BadgeValue = 0;
            btnWorker.BorderColor = Color.FromArgb(15, 76, 76);
            btnWorker.BorderColorEnd = Color.Gray;
            btnWorker.BorderColorStart = Color.White;
            btnWorker.BorderRadiusBottomLeft = 35;
            btnWorker.BorderRadiusBottomRight = 35;
            btnWorker.BorderRadiusTopLeft = 35;
            btnWorker.BorderRadiusTopRight = 35;
            btnWorker.BorderThickness = 5;
            btnWorker.ButtonColorEnd = Color.White;
            btnWorker.ButtonColorStart = Color.White;
            btnWorker.ButtonImage = (Image)resources.GetObject("btnWorker.ButtonImage");
            btnWorker.CanBeep = false;
            btnWorker.CanShake = false;
            btnWorker.ClickSoundPath = null;
            btnWorker.DisabledOverlayOpacity = 0.5F;
            btnWorker.EnableBorderGradient = false;
            btnWorker.EnableClickSound = false;
            btnWorker.EnableFocusBorder = false;
            btnWorker.EnableHoverSound = false;
            btnWorker.EnablePressScale = false;
            btnWorker.EnableTextShadow = false;
            btnWorker.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnWorker.FocusBorderThickness = 2;
            btnWorker.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWorker.ForeColor = Color.FromArgb(15, 76, 76);
            btnWorker.HoverColor = Color.FromArgb(231, 243, 239);
            btnWorker.HoverSoundPath = null;
            btnWorker.HoverTransitionSpeed = 0.08F;
            btnWorker.ImageAlign = ContentAlignment.MiddleCenter;
            btnWorker.ImageLeftMargin = 5;
            btnWorker.ImageRightMargin = 8;
            btnWorker.ImageSize = 150;
            btnWorker.IsReadOnly = false;
            btnWorker.Location = new Point(420, 287);
            btnWorker.MakeRadial = false;
            btnWorker.Name = "btnWorker";
            btnWorker.PressAnimationSpeed = 0.2F;
            btnWorker.PressDepth = 1;
            btnWorker.RippleColor = Color.FromArgb(78, 127, 122);
            btnWorker.RippleExpandSpeedFactor = 0.05F;
            btnWorker.RippleFadeSpeedFactor = 0.03F;
            btnWorker.ShadowBlurFactor = 0.85F;
            btnWorker.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnWorker.ShadowOffsetX = 3;
            btnWorker.ShadowOffsetY = 3;
            btnWorker.Size = new Size(278, 297);
            btnWorker.TabIndex = 24;
            btnWorker.TextAlign = ContentAlignment.MiddleCenter;
            btnWorker.TextPaddingBottom = 0;
            btnWorker.TextPaddingLeft = 0;
            btnWorker.TextPaddingRight = 0;
            btnWorker.TextPaddingTop = 0;
            btnWorker.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnWorker.TextShadowOffsetX = 1;
            btnWorker.TextShadowOffsetY = 1;
            btnWorker.Click += btnWorker_Click;
            // 
            // btnFacility
            // 
            btnFacility.BackColor = Color.Transparent;
            btnFacility.BadgeBackColor = Color.Red;
            btnFacility.BadgeForeColor = Color.White;
            btnFacility.BadgeRadius = 8;
            btnFacility.BadgeRightMargin = 10;
            btnFacility.BadgeValue = 0;
            btnFacility.BorderColor = Color.FromArgb(15, 76, 76);
            btnFacility.BorderColorEnd = Color.Gray;
            btnFacility.BorderColorStart = Color.White;
            btnFacility.BorderRadiusBottomLeft = 35;
            btnFacility.BorderRadiusBottomRight = 35;
            btnFacility.BorderRadiusTopLeft = 35;
            btnFacility.BorderRadiusTopRight = 35;
            btnFacility.BorderThickness = 5;
            btnFacility.ButtonColorEnd = Color.White;
            btnFacility.ButtonColorStart = Color.White;
            btnFacility.ButtonImage = (Image)resources.GetObject("btnFacility.ButtonImage");
            btnFacility.CanBeep = false;
            btnFacility.CanShake = false;
            btnFacility.ClickSoundPath = null;
            btnFacility.DisabledOverlayOpacity = 0.5F;
            btnFacility.EnableBorderGradient = false;
            btnFacility.EnableClickSound = false;
            btnFacility.EnableFocusBorder = false;
            btnFacility.EnableHoverSound = false;
            btnFacility.EnablePressScale = false;
            btnFacility.EnableTextShadow = false;
            btnFacility.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnFacility.FocusBorderThickness = 2;
            btnFacility.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFacility.ForeColor = Color.FromArgb(15, 76, 76);
            btnFacility.HoverColor = Color.FromArgb(231, 243, 239);
            btnFacility.HoverSoundPath = null;
            btnFacility.HoverTransitionSpeed = 0.08F;
            btnFacility.ImageAlign = ContentAlignment.MiddleCenter;
            btnFacility.ImageLeftMargin = 5;
            btnFacility.ImageRightMargin = 8;
            btnFacility.ImageSize = 150;
            btnFacility.IsReadOnly = false;
            btnFacility.Location = new Point(72, 287);
            btnFacility.MakeRadial = false;
            btnFacility.Name = "btnFacility";
            btnFacility.PressAnimationSpeed = 0.2F;
            btnFacility.PressDepth = 1;
            btnFacility.RippleColor = Color.FromArgb(78, 127, 122);
            btnFacility.RippleExpandSpeedFactor = 0.05F;
            btnFacility.RippleFadeSpeedFactor = 0.03F;
            btnFacility.ShadowBlurFactor = 0.85F;
            btnFacility.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnFacility.ShadowOffsetX = 3;
            btnFacility.ShadowOffsetY = 3;
            btnFacility.Size = new Size(278, 297);
            btnFacility.TabIndex = 23;
            btnFacility.TextAlign = ContentAlignment.MiddleCenter;
            btnFacility.TextPaddingBottom = 0;
            btnFacility.TextPaddingLeft = 0;
            btnFacility.TextPaddingRight = 0;
            btnFacility.TextPaddingTop = 0;
            btnFacility.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnFacility.TextShadowOffsetX = 1;
            btnFacility.TextShadowOffsetY = 1;
            btnFacility.Click += btnFacility_Click;
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
            btnBack.Location = new Point(32, 36);
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
            btnBack.TabIndex = 22;
            btnBack.Text = "siticoneNavBackButton1";
            btnBack.Click += btnBack_Click;
            // 
            // siticoneLabel4
            // 
            siticoneLabel4.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel4.ForeColor = Color.Black;
            siticoneLabel4.Location = new Point(133, 102);
            siticoneLabel4.Name = "siticoneLabel4";
            siticoneLabel4.Size = new Size(514, 86);
            siticoneLabel4.TabIndex = 21;
            siticoneLabel4.Text = "Choose your role";
            siticoneLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RoleChooserScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlForm);
            Name = "RoleChooserScreen";
            Size = new Size(1136, 899);
            pnlForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SiticonePanel pnlForm;
        private SiticoneLabel siticoneLabel4;
        private SiticoneNavBackButton btnBack;
        private SiticoneButtonAdvanced btnFacility;
        private SiticoneButtonAdvanced btnWorker;
        private SiticoneLabel siticoneLabel2;
        private SiticoneLabel siticoneLabel1;
    }
}
