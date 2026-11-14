namespace medicord_v1.Forms
{
    partial class MobileShell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MobileShell));
            pnlNav = new SiticonePanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNavProfile = new SiticoneButtonAdvanced();
            btnNavRecords = new SiticoneButtonAdvanced();
            btnNavAppts = new SiticoneButtonAdvanced();
            btnNavHome = new SiticoneButtonAdvanced();
            pnlContent = new SiticoneContentPanel();
            pnlNav.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNav
            // 
            pnlNav.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            pnlNav.BackColor = Color.Transparent;
            pnlNav.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            pnlNav.BorderColor = Color.Gray;
            pnlNav.BorderDashPattern = null;
            pnlNav.BorderGradientEndColor = Color.Purple;
            pnlNav.BorderGradientStartColor = Color.Blue;
            pnlNav.BorderThickness = 2F;
            pnlNav.Controls.Add(tableLayoutPanel1);
            pnlNav.CornerRadiusBottomLeft = 5F;
            pnlNav.CornerRadiusBottomRight = 5F;
            pnlNav.CornerRadiusTopLeft = 28F;
            pnlNav.CornerRadiusTopRight = 28F;
            pnlNav.Dock = DockStyle.Bottom;
            pnlNav.EnableAcrylicEffect = false;
            pnlNav.EnableMicaEffect = false;
            pnlNav.EnableRippleEffect = false;
            pnlNav.FillColor = Color.White;
            pnlNav.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            pnlNav.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            pnlNav.Location = new Point(0, 828);
            pnlNav.Name = "pnlNav";
            pnlNav.PatternColor = Color.FromArgb(30, 0, 0, 0);
            pnlNav.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            pnlNav.RippleAlpha = 50;
            pnlNav.RippleAlphaDecrement = 3;
            pnlNav.RippleColor = Color.FromArgb(50, 255, 255, 255);
            pnlNav.RippleMaxSize = 600F;
            pnlNav.RippleSpeed = 15F;
            pnlNav.ShowBorder = true;
            pnlNav.Size = new Size(522, 85);
            pnlNav.TabIndex = 0;
            pnlNav.TabStop = true;
            pnlNav.UseBorderGradient = false;
            pnlNav.UseMultiGradient = false;
            pnlNav.UsePatternTexture = false;
            pnlNav.UseRadialGradient = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnNavProfile, 3, 0);
            tableLayoutPanel1.Controls.Add(btnNavRecords, 2, 0);
            tableLayoutPanel1.Controls.Add(btnNavAppts, 1, 0);
            tableLayoutPanel1.Controls.Add(btnNavHome, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(517, 81);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNavProfile
            // 
            btnNavProfile.BackColor = Color.Transparent;
            btnNavProfile.BadgeBackColor = Color.Red;
            btnNavProfile.BadgeForeColor = Color.White;
            btnNavProfile.BadgeRadius = 8;
            btnNavProfile.BadgeRightMargin = 10;
            btnNavProfile.BadgeValue = 0;
            btnNavProfile.BorderColor = Color.White;
            btnNavProfile.BorderColorEnd = Color.Gray;
            btnNavProfile.BorderColorStart = Color.White;
            btnNavProfile.BorderRadiusBottomLeft = 23;
            btnNavProfile.BorderRadiusBottomRight = 23;
            btnNavProfile.BorderRadiusTopLeft = 23;
            btnNavProfile.BorderRadiusTopRight = 23;
            btnNavProfile.BorderThickness = 2;
            btnNavProfile.ButtonColorEnd = Color.White;
            btnNavProfile.ButtonColorStart = Color.White;
            btnNavProfile.ButtonImage = (Image)resources.GetObject("btnNavProfile.ButtonImage");
            btnNavProfile.CanBeep = false;
            btnNavProfile.CanShake = false;
            btnNavProfile.ClickSoundPath = null;
            btnNavProfile.DisabledOverlayOpacity = 0.5F;
            btnNavProfile.Dock = DockStyle.Fill;
            btnNavProfile.EnableBorderGradient = false;
            btnNavProfile.EnableClickSound = false;
            btnNavProfile.EnableFocusBorder = false;
            btnNavProfile.EnableHoverSound = false;
            btnNavProfile.EnablePressScale = false;
            btnNavProfile.EnableTextShadow = false;
            btnNavProfile.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnNavProfile.FocusBorderThickness = 2;
            btnNavProfile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavProfile.ForeColor = Color.FromArgb(15, 76, 76);
            btnNavProfile.HoverColor = Color.FromArgb(231, 243, 239);
            btnNavProfile.HoverSoundPath = null;
            btnNavProfile.HoverTransitionSpeed = 0.08F;
            btnNavProfile.ImageAlign = ContentAlignment.MiddleCenter;
            btnNavProfile.ImageLeftMargin = 5;
            btnNavProfile.ImageRightMargin = 8;
            btnNavProfile.ImageSize = 35;
            btnNavProfile.IsReadOnly = false;
            btnNavProfile.Location = new Point(390, 3);
            btnNavProfile.MakeRadial = false;
            btnNavProfile.Name = "btnNavProfile";
            btnNavProfile.PressAnimationSpeed = 0.2F;
            btnNavProfile.PressDepth = 1;
            btnNavProfile.RippleColor = Color.FromArgb(78, 127, 122);
            btnNavProfile.RippleExpandSpeedFactor = 0.05F;
            btnNavProfile.RippleFadeSpeedFactor = 0.03F;
            btnNavProfile.ShadowBlurFactor = 0.85F;
            btnNavProfile.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnNavProfile.ShadowOffsetX = 3;
            btnNavProfile.ShadowOffsetY = 3;
            btnNavProfile.Size = new Size(124, 75);
            btnNavProfile.TabIndex = 14;
            btnNavProfile.TextAlign = ContentAlignment.MiddleCenter;
            btnNavProfile.TextPaddingBottom = 0;
            btnNavProfile.TextPaddingLeft = 0;
            btnNavProfile.TextPaddingRight = 0;
            btnNavProfile.TextPaddingTop = 0;
            btnNavProfile.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnNavProfile.TextShadowOffsetX = 1;
            btnNavProfile.TextShadowOffsetY = 1;
            // 
            // btnNavRecords
            // 
            btnNavRecords.BackColor = Color.Transparent;
            btnNavRecords.BadgeBackColor = Color.Red;
            btnNavRecords.BadgeForeColor = Color.White;
            btnNavRecords.BadgeRadius = 8;
            btnNavRecords.BadgeRightMargin = 10;
            btnNavRecords.BadgeValue = 0;
            btnNavRecords.BorderColor = Color.White;
            btnNavRecords.BorderColorEnd = Color.Gray;
            btnNavRecords.BorderColorStart = Color.White;
            btnNavRecords.BorderRadiusBottomLeft = 23;
            btnNavRecords.BorderRadiusBottomRight = 23;
            btnNavRecords.BorderRadiusTopLeft = 23;
            btnNavRecords.BorderRadiusTopRight = 23;
            btnNavRecords.BorderThickness = 2;
            btnNavRecords.ButtonColorEnd = Color.White;
            btnNavRecords.ButtonColorStart = Color.White;
            btnNavRecords.ButtonImage = (Image)resources.GetObject("btnNavRecords.ButtonImage");
            btnNavRecords.CanBeep = false;
            btnNavRecords.CanShake = false;
            btnNavRecords.ClickSoundPath = null;
            btnNavRecords.DisabledOverlayOpacity = 0.5F;
            btnNavRecords.Dock = DockStyle.Fill;
            btnNavRecords.EnableBorderGradient = false;
            btnNavRecords.EnableClickSound = false;
            btnNavRecords.EnableFocusBorder = false;
            btnNavRecords.EnableHoverSound = false;
            btnNavRecords.EnablePressScale = false;
            btnNavRecords.EnableTextShadow = false;
            btnNavRecords.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnNavRecords.FocusBorderThickness = 2;
            btnNavRecords.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavRecords.ForeColor = Color.FromArgb(15, 76, 76);
            btnNavRecords.HoverColor = Color.FromArgb(231, 243, 239);
            btnNavRecords.HoverSoundPath = null;
            btnNavRecords.HoverTransitionSpeed = 0.08F;
            btnNavRecords.ImageAlign = ContentAlignment.MiddleCenter;
            btnNavRecords.ImageLeftMargin = 5;
            btnNavRecords.ImageRightMargin = 8;
            btnNavRecords.ImageSize = 35;
            btnNavRecords.IsReadOnly = false;
            btnNavRecords.Location = new Point(261, 3);
            btnNavRecords.MakeRadial = false;
            btnNavRecords.Name = "btnNavRecords";
            btnNavRecords.PressAnimationSpeed = 0.2F;
            btnNavRecords.PressDepth = 1;
            btnNavRecords.RippleColor = Color.FromArgb(78, 127, 122);
            btnNavRecords.RippleExpandSpeedFactor = 0.05F;
            btnNavRecords.RippleFadeSpeedFactor = 0.03F;
            btnNavRecords.ShadowBlurFactor = 0.85F;
            btnNavRecords.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnNavRecords.ShadowOffsetX = 3;
            btnNavRecords.ShadowOffsetY = 3;
            btnNavRecords.Size = new Size(123, 75);
            btnNavRecords.TabIndex = 13;
            btnNavRecords.TextAlign = ContentAlignment.MiddleCenter;
            btnNavRecords.TextPaddingBottom = 0;
            btnNavRecords.TextPaddingLeft = 0;
            btnNavRecords.TextPaddingRight = 0;
            btnNavRecords.TextPaddingTop = 0;
            btnNavRecords.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnNavRecords.TextShadowOffsetX = 1;
            btnNavRecords.TextShadowOffsetY = 1;
            // 
            // btnNavAppts
            // 
            btnNavAppts.BackColor = Color.Transparent;
            btnNavAppts.BadgeBackColor = Color.Red;
            btnNavAppts.BadgeForeColor = Color.White;
            btnNavAppts.BadgeRadius = 8;
            btnNavAppts.BadgeRightMargin = 10;
            btnNavAppts.BadgeValue = 0;
            btnNavAppts.BorderColor = Color.White;
            btnNavAppts.BorderColorEnd = Color.Gray;
            btnNavAppts.BorderColorStart = Color.White;
            btnNavAppts.BorderRadiusBottomLeft = 23;
            btnNavAppts.BorderRadiusBottomRight = 23;
            btnNavAppts.BorderRadiusTopLeft = 23;
            btnNavAppts.BorderRadiusTopRight = 23;
            btnNavAppts.BorderThickness = 2;
            btnNavAppts.ButtonColorEnd = Color.White;
            btnNavAppts.ButtonColorStart = Color.White;
            btnNavAppts.ButtonImage = (Image)resources.GetObject("btnNavAppts.ButtonImage");
            btnNavAppts.CanBeep = false;
            btnNavAppts.CanShake = false;
            btnNavAppts.ClickSoundPath = null;
            btnNavAppts.DisabledOverlayOpacity = 0.5F;
            btnNavAppts.Dock = DockStyle.Fill;
            btnNavAppts.EnableBorderGradient = false;
            btnNavAppts.EnableClickSound = false;
            btnNavAppts.EnableFocusBorder = false;
            btnNavAppts.EnableHoverSound = false;
            btnNavAppts.EnablePressScale = false;
            btnNavAppts.EnableTextShadow = false;
            btnNavAppts.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnNavAppts.FocusBorderThickness = 2;
            btnNavAppts.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavAppts.ForeColor = Color.FromArgb(15, 76, 76);
            btnNavAppts.HoverColor = Color.FromArgb(231, 243, 239);
            btnNavAppts.HoverSoundPath = null;
            btnNavAppts.HoverTransitionSpeed = 0.08F;
            btnNavAppts.ImageAlign = ContentAlignment.MiddleCenter;
            btnNavAppts.ImageLeftMargin = 5;
            btnNavAppts.ImageRightMargin = 8;
            btnNavAppts.ImageSize = 35;
            btnNavAppts.IsReadOnly = false;
            btnNavAppts.Location = new Point(132, 3);
            btnNavAppts.MakeRadial = false;
            btnNavAppts.Name = "btnNavAppts";
            btnNavAppts.PressAnimationSpeed = 0.2F;
            btnNavAppts.PressDepth = 1;
            btnNavAppts.RippleColor = Color.FromArgb(78, 127, 122);
            btnNavAppts.RippleExpandSpeedFactor = 0.05F;
            btnNavAppts.RippleFadeSpeedFactor = 0.03F;
            btnNavAppts.ShadowBlurFactor = 0.85F;
            btnNavAppts.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnNavAppts.ShadowOffsetX = 3;
            btnNavAppts.ShadowOffsetY = 3;
            btnNavAppts.Size = new Size(123, 75);
            btnNavAppts.TabIndex = 12;
            btnNavAppts.TextAlign = ContentAlignment.MiddleCenter;
            btnNavAppts.TextPaddingBottom = 0;
            btnNavAppts.TextPaddingLeft = 0;
            btnNavAppts.TextPaddingRight = 0;
            btnNavAppts.TextPaddingTop = 0;
            btnNavAppts.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnNavAppts.TextShadowOffsetX = 1;
            btnNavAppts.TextShadowOffsetY = 1;
            // 
            // btnNavHome
            // 
            btnNavHome.BackColor = Color.Transparent;
            btnNavHome.BadgeBackColor = Color.Red;
            btnNavHome.BadgeForeColor = Color.White;
            btnNavHome.BadgeRadius = 8;
            btnNavHome.BadgeRightMargin = 10;
            btnNavHome.BadgeValue = 0;
            btnNavHome.BorderColor = Color.FromArgb(15, 76, 76);
            btnNavHome.BorderColorEnd = Color.Gray;
            btnNavHome.BorderColorStart = Color.White;
            btnNavHome.BorderRadiusBottomLeft = 23;
            btnNavHome.BorderRadiusBottomRight = 23;
            btnNavHome.BorderRadiusTopLeft = 23;
            btnNavHome.BorderRadiusTopRight = 23;
            btnNavHome.BorderThickness = 2;
            btnNavHome.ButtonColorEnd = Color.White;
            btnNavHome.ButtonColorStart = Color.White;
            btnNavHome.ButtonImage = (Image)resources.GetObject("btnNavHome.ButtonImage");
            btnNavHome.CanBeep = false;
            btnNavHome.CanShake = false;
            btnNavHome.ClickSoundPath = null;
            btnNavHome.DisabledOverlayOpacity = 0.5F;
            btnNavHome.Dock = DockStyle.Fill;
            btnNavHome.EnableBorderGradient = false;
            btnNavHome.EnableClickSound = false;
            btnNavHome.EnableFocusBorder = false;
            btnNavHome.EnableHoverSound = false;
            btnNavHome.EnablePressScale = false;
            btnNavHome.EnableTextShadow = false;
            btnNavHome.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnNavHome.FocusBorderThickness = 2;
            btnNavHome.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNavHome.ForeColor = Color.FromArgb(15, 76, 76);
            btnNavHome.HoverColor = Color.FromArgb(231, 243, 239);
            btnNavHome.HoverSoundPath = null;
            btnNavHome.HoverTransitionSpeed = 0.08F;
            btnNavHome.ImageAlign = ContentAlignment.MiddleCenter;
            btnNavHome.ImageLeftMargin = 5;
            btnNavHome.ImageRightMargin = 8;
            btnNavHome.ImageSize = 35;
            btnNavHome.IsReadOnly = false;
            btnNavHome.Location = new Point(3, 3);
            btnNavHome.MakeRadial = false;
            btnNavHome.Name = "btnNavHome";
            btnNavHome.PressAnimationSpeed = 0.2F;
            btnNavHome.PressDepth = 1;
            btnNavHome.RippleColor = Color.FromArgb(78, 127, 122);
            btnNavHome.RippleExpandSpeedFactor = 0.05F;
            btnNavHome.RippleFadeSpeedFactor = 0.03F;
            btnNavHome.ShadowBlurFactor = 0.85F;
            btnNavHome.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnNavHome.ShadowOffsetX = 3;
            btnNavHome.ShadowOffsetY = 3;
            btnNavHome.Size = new Size(123, 75);
            btnNavHome.TabIndex = 11;
            btnNavHome.TextAlign = ContentAlignment.MiddleCenter;
            btnNavHome.TextPaddingBottom = 0;
            btnNavHome.TextPaddingLeft = 0;
            btnNavHome.TextPaddingRight = 0;
            btnNavHome.TextPaddingTop = 0;
            btnNavHome.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnNavHome.TextShadowOffsetX = 1;
            btnNavHome.TextShadowOffsetY = 1;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = SystemColors.Control;
            pnlContent.ContentBackColor = Color.FromArgb(245, 245, 245);
            pnlContent.ContentPadding = new Padding(0);
            pnlContent.DefaultTitleFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.EmptyContentMessageColor = Color.Gray;
            pnlContent.EmptyContentMessageFont = new Font("Segoe UI", 12F);
            pnlContent.Font = new Font("Segoe UI", 8F);
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(522, 828);
            pnlContent.TabIndex = 1;
            pnlContent.TargetNavbar = null;
            pnlContent.TitleBackColor = Color.White;
            pnlContent.TitleForeColor = Color.FromArgb(50, 50, 50);
            pnlContent.TitlePadding = new Padding(20, 0, 20, 0);
            pnlContent.TitleSeparatorColor = Color.Silver;
            // 
            // MobileShell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 913);
            Controls.Add(pnlContent);
            Controls.Add(pnlNav);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MobileShell";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Medicord (Mobile)";
            pnlNav.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneNetCoreUI.SiticonePanel pnlNav;
        private SiticoneNetCoreUI.SiticoneContentPanel pnlContent;
        private TableLayoutPanel tableLayoutPanel1;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btnNavHome;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btnNavProfile;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btnNavRecords;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btnNavAppts;
    }
}