namespace medicord_v1.Screens.Desktop
{
    partial class DesktopDoneScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopDoneScreen));
            pnlCard = new SiticonePanel();
            btnLogin = new SiticoneButton();
            lblSub = new SiticoneLabel();
            lblCode = new SiticoneLabel();
            siticoneLabel4 = new SiticoneLabel();
            siticonePictureBox1 = new SiticonePictureBox();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCard
            // 
            pnlCard.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            pnlCard.BackColor = Color.Transparent;
            pnlCard.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            pnlCard.BorderColor = Color.FromArgb(210, 210, 210);
            pnlCard.BorderDashPattern = null;
            pnlCard.BorderGradientEndColor = Color.Purple;
            pnlCard.BorderGradientStartColor = Color.Blue;
            pnlCard.BorderThickness = 2F;
            pnlCard.Controls.Add(btnLogin);
            pnlCard.Controls.Add(lblSub);
            pnlCard.Controls.Add(lblCode);
            pnlCard.Controls.Add(siticoneLabel4);
            pnlCard.Controls.Add(siticonePictureBox1);
            pnlCard.CornerRadiusBottomLeft = 0F;
            pnlCard.CornerRadiusBottomRight = 0F;
            pnlCard.CornerRadiusTopLeft = 0F;
            pnlCard.CornerRadiusTopRight = 0F;
            pnlCard.EnableAcrylicEffect = false;
            pnlCard.EnableMicaEffect = false;
            pnlCard.EnableRippleEffect = false;
            pnlCard.FillColor = Color.White;
            pnlCard.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            pnlCard.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            pnlCard.Location = new Point(379, 125);
            pnlCard.Name = "pnlCard";
            pnlCard.PatternColor = Color.FromArgb(30, 0, 0, 0);
            pnlCard.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            pnlCard.RippleAlpha = 50;
            pnlCard.RippleAlphaDecrement = 3;
            pnlCard.RippleColor = Color.FromArgb(50, 255, 255, 255);
            pnlCard.RippleMaxSize = 600F;
            pnlCard.RippleSpeed = 15F;
            pnlCard.ShowBorder = true;
            pnlCard.Size = new Size(682, 630);
            pnlCard.TabIndex = 0;
            pnlCard.TabStop = true;
            pnlCard.UseBorderGradient = false;
            pnlCard.UseMultiGradient = false;
            pnlCard.UsePatternTexture = false;
            pnlCard.UseRadialGradient = false;
            // 
            // btnLogin
            // 
            btnLogin.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnLogin.AccessibleName = "Log In";
            btnLogin.BadgeBackColor = Color.Black;
            btnLogin.BadgeBorderColor = Color.Empty;
            btnLogin.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnLogin.BadgeValueForeColor = Color.White;
            btnLogin.BorderColor = Color.FromArgb(213, 216, 220);
            btnLogin.BusyIndicatorColor = Color.Empty;
            btnLogin.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnLogin.CustomCursor = Cursors.Default;
            btnLogin.DisabledBackColor = Color.Empty;
            btnLogin.DisabledBorderColor = Color.Empty;
            btnLogin.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnLogin.FocusRingColor = Color.Empty;
            btnLogin.Font = new Font("Segoe UI Semibold", 10.2F);
            btnLogin.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnLogin.GradientColor = Color.FromArgb(0, 227, 64);
            btnLogin.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnLogin.HoverBorderColor = Color.Empty;
            btnLogin.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnLogin.ImageSize = new Size(16, 16);
            btnLogin.Location = new Point(94, 504);
            btnLogin.Name = "btnLogin";
            btnLogin.ParticleColor = Color.FromArgb(200, 200, 200);
            btnLogin.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnLogin.PressedBorderColor = Color.Empty;
            btnLogin.PressedTextColor = Color.Empty;
            btnLogin.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnLogin.RippleColor = Color.FromArgb(0, 0, 0);
            btnLogin.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnLogin.ShadowOffset = new Point(0, 2);
            btnLogin.Size = new Size(488, 62);
            btnLogin.TabIndex = 30;
            btnLogin.Text = "Log In";
            btnLogin.TextColor = Color.FromArgb(0, 0, 0);
            btnLogin.ToggledBackColor = Color.Empty;
            btnLogin.ToggledBorderColor = Color.Empty;
            btnLogin.ToggledTextColor = Color.Empty;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblSub
            // 
            lblSub.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSub.ForeColor = SystemColors.ActiveCaptionText;
            lblSub.Location = new Point(109, 334);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(472, 114);
            lblSub.TabIndex = 29;
            lblSub.Text = "Log in to start managing appointments and patient records.";
            lblSub.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCode
            // 
            lblCode.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCode.ForeColor = Color.FromArgb(15, 76, 76);
            lblCode.Location = new Point(94, 271);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(504, 56);
            lblCode.TabIndex = 28;
            lblCode.Text = "589632";
            lblCode.TextAlign = ContentAlignment.TopCenter;
            // 
            // siticoneLabel4
            // 
            siticoneLabel4.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel4.ForeColor = Color.Black;
            siticoneLabel4.Location = new Point(94, 202);
            siticoneLabel4.Name = "siticoneLabel4";
            siticoneLabel4.Size = new Size(504, 59);
            siticoneLabel4.TabIndex = 21;
            siticoneLabel4.Text = "You're all set!";
            siticoneLabel4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // siticonePictureBox1
            // 
            siticonePictureBox1.BackColor = Color.Transparent;
            siticonePictureBox1.BorderColor = Color.Black;
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
            siticonePictureBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            siticonePictureBox1.IsCircular = false;
            siticonePictureBox1.Location = new Point(280, 47);
            siticonePictureBox1.MaintainAspectRatio = true;
            siticonePictureBox1.Name = "siticonePictureBox1";
            siticonePictureBox1.PlaceholderImage = null;
            siticonePictureBox1.RotationAngle = 0F;
            siticonePictureBox1.Saturation = 1F;
            siticonePictureBox1.ShowBorder = false;
            siticonePictureBox1.Size = new Size(130, 131);
            siticonePictureBox1.SizeMode = SiticoneNetCoreUI.Helpers.Enum.SiticonePictureBoxSizeMode.Zoom;
            siticonePictureBox1.TabIndex = 0;
            siticonePictureBox1.Text = "siticonePictureBox1";
            // 
            // DesktopDoneScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlCard);
            Name = "DesktopDoneScreen";
            Size = new Size(1463, 903);
            pnlCard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SiticonePanel pnlCard;
        private SiticonePictureBox siticonePictureBox1;
        private SiticoneLabel siticoneLabel4;
        private SiticoneLabel lblCode;
        private SiticoneLabel lblSub;
        private SiticoneButton btnLogin;
    }
}
