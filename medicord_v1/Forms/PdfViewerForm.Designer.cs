namespace medicord_v1.Forms
{
    partial class PdfViewerForm
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
            siticonePanel1 = new SiticonePanel();
            btnSave = new SiticoneButton();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // siticonePanel1
            // 
            siticonePanel1.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            siticonePanel1.BackColor = Color.Transparent;
            siticonePanel1.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            siticonePanel1.BorderColor = Color.Transparent;
            siticonePanel1.BorderDashPattern = null;
            siticonePanel1.BorderGradientEndColor = Color.Purple;
            siticonePanel1.BorderGradientStartColor = Color.Blue;
            siticonePanel1.BorderThickness = 2F;
            siticonePanel1.Controls.Add(btnSave);
            siticonePanel1.CornerRadiusBottomLeft = 0F;
            siticonePanel1.CornerRadiusBottomRight = 0F;
            siticonePanel1.CornerRadiusTopLeft = 0F;
            siticonePanel1.CornerRadiusTopRight = 0F;
            siticonePanel1.Dock = DockStyle.Top;
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
            siticonePanel1.Location = new Point(0, 0);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.PatternColor = Color.FromArgb(30, 0, 0, 0);
            siticonePanel1.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            siticonePanel1.RippleAlpha = 50;
            siticonePanel1.RippleAlphaDecrement = 3;
            siticonePanel1.RippleColor = Color.FromArgb(50, 255, 255, 255);
            siticonePanel1.RippleMaxSize = 600F;
            siticonePanel1.RippleSpeed = 15F;
            siticonePanel1.ShowBorder = true;
            siticonePanel1.Size = new Size(982, 67);
            siticonePanel1.TabIndex = 0;
            siticonePanel1.TabStop = true;
            siticonePanel1.UseBorderGradient = false;
            siticonePanel1.UseMultiGradient = false;
            siticonePanel1.UsePatternTexture = false;
            siticonePanel1.UseRadialGradient = false;
            // 
            // btnSave
            // 
            btnSave.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnSave.AccessibleName = "Save a copy";
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
            btnSave.Location = new Point(829, 7);
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
            btnSave.Size = new Size(143, 52);
            btnSave.TabIndex = 41;
            btnSave.Text = "Save a copy";
            btnSave.TextColor = Color.FromArgb(0, 0, 0);
            btnSave.ToggledBackColor = Color.Empty;
            btnSave.ToggledBorderColor = Color.Empty;
            btnSave.ToggledTextColor = Color.Empty;
            btnSave.Click += btnSave_Click;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(0, 67);
            webView.Name = "webView";
            webView.Size = new Size(982, 666);
            webView.TabIndex = 1;
            webView.ZoomFactor = 1D;
            // 
            // PdfViewerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 733);
            Controls.Add(webView);
            Controls.Add(siticonePanel1);
            Name = "PdfViewerForm";
            Text = "View Medical Record";
            siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SiticonePanel siticonePanel1;
        private SiticoneButton btnSave;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}