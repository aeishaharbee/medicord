namespace medicord_v1.Screens.Desktop
{
    partial class RecordsScreen
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
            txtSearch = new SiticoneTextBox();
            lblCount = new SiticoneLabel();
            siticoneLabel3 = new SiticoneLabel();
            siticonePanel1 = new SiticonePanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnOther = new SiticoneButton();
            btnLab = new SiticoneButton();
            btnAll = new SiticoneButton();
            btnRx = new SiticoneButton();
            btnVisit = new SiticoneButton();
            pnlTable = new SiticonePanel();
            dgv = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDelete = new SiticoneButton();
            btnOpen = new SiticoneButton();
            btnEdit = new SiticoneButton();
            btnUpload = new SiticoneButton();
            siticonePanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.AccessibleDescription = "A customizable text input field.";
            txtSearch.AccessibleName = "Text Box";
            txtSearch.AccessibleRole = AccessibleRole.Text;
            txtSearch.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtSearch.BorderColor2 = Color.FromArgb(220, 220, 220);
            txtSearch.BorderFocusColor1 = Color.FromArgb(180, 180, 180);
            txtSearch.BorderFocusColor2 = Color.FromArgb(180, 180, 180);
            txtSearch.BorderSize = 2;
            txtSearch.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtSearch.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtSearch.CornerRadiusBottomLeft = 10;
            txtSearch.CornerRadiusBottomRight = 10;
            txtSearch.CornerRadiusTopLeft = 10;
            txtSearch.CornerRadiusTopRight = 10;
            txtSearch.CursorColor = Color.FromArgb(32, 32, 32);
            txtSearch.DisabledBackColor = Color.WhiteSmoke;
            txtSearch.DisabledBorderColor = Color.LightGray;
            txtSearch.DisabledTextColor = Color.Gray;
            txtSearch.FillColor1 = Color.FromArgb(245, 245, 245);
            txtSearch.FillColor2 = Color.FromArgb(235, 235, 235);
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(50, 50, 50);
            txtSearch.HoverBorderColor1 = Color.Gray;
            txtSearch.HoverBorderColor2 = Color.Gray;
            txtSearch.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtSearch.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtSearch.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtSearch.Location = new Point(28, 145);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderColor = Color.Gray;
            txtSearch.PlaceholderText = "Search by Patient, Title or Doctor";
            txtSearch.ReadOnlyBorderColor1 = Color.LightGray;
            txtSearch.ReadOnlyBorderColor2 = Color.LightGray;
            txtSearch.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtSearch.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtSearch.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtSearch.ReadOnlyTextColor = Color.Empty;
            txtSearch.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtSearch.SelectionForeColor = SystemColors.HighlightText;
            txtSearch.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtSearch.Size = new Size(417, 66);
            txtSearch.SolidBorderColor = Color.FromArgb(220, 220, 220);
            txtSearch.SolidBorderFocusColor = Color.FromArgb(180, 180, 180);
            txtSearch.SolidBorderHoverColor = Color.Gray;
            txtSearch.SolidFillColor = Color.White;
            txtSearch.TabIndex = 60;
            // 
            // lblCount
            // 
            lblCount.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount.ForeColor = Color.FromArgb(15, 76, 76);
            lblCount.Location = new Point(28, 83);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(274, 46);
            lblCount.TabIndex = 59;
            lblCount.Text = "[00] medical records";
            // 
            // siticoneLabel3
            // 
            siticoneLabel3.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel3.ForeColor = SystemColors.ActiveCaptionText;
            siticoneLabel3.Location = new Point(26, 29);
            siticoneLabel3.Name = "siticoneLabel3";
            siticoneLabel3.Size = new Size(274, 60);
            siticoneLabel3.TabIndex = 58;
            siticoneLabel3.Text = "Records";
            // 
            // siticonePanel1
            // 
            siticonePanel1.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            siticonePanel1.BackColor = Color.Transparent;
            siticonePanel1.BorderAlignment = PenAlignment.Center;
            siticonePanel1.BorderColor = Color.FromArgb(218, 223, 230);
            siticonePanel1.BorderDashPattern = null;
            siticonePanel1.BorderGradientEndColor = Color.Purple;
            siticonePanel1.BorderGradientStartColor = Color.Blue;
            siticonePanel1.BorderThickness = 2F;
            siticonePanel1.Controls.Add(tableLayoutPanel2);
            siticonePanel1.CornerRadiusBottomLeft = 28F;
            siticonePanel1.CornerRadiusBottomRight = 28F;
            siticonePanel1.CornerRadiusTopLeft = 28F;
            siticonePanel1.CornerRadiusTopRight = 28F;
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
            siticonePanel1.Location = new Point(526, 145);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.PatternColor = Color.FromArgb(30, 0, 0, 0);
            siticonePanel1.PatternStyle = HatchStyle.Max;
            siticonePanel1.RippleAlpha = 50;
            siticonePanel1.RippleAlphaDecrement = 3;
            siticonePanel1.RippleColor = Color.FromArgb(50, 255, 255, 255);
            siticonePanel1.RippleMaxSize = 600F;
            siticonePanel1.RippleSpeed = 15F;
            siticonePanel1.ShowBorder = true;
            siticonePanel1.Size = new Size(581, 68);
            siticonePanel1.TabIndex = 61;
            siticonePanel1.TabStop = true;
            siticonePanel1.UseBorderGradient = false;
            siticonePanel1.UseMultiGradient = false;
            siticonePanel1.UsePatternTexture = false;
            siticonePanel1.UseRadialGradient = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanel2.Controls.Add(btnOther, 4, 0);
            tableLayoutPanel2.Controls.Add(btnLab, 2, 0);
            tableLayoutPanel2.Controls.Add(btnAll, 0, 0);
            tableLayoutPanel2.Controls.Add(btnRx, 3, 0);
            tableLayoutPanel2.Controls.Add(btnVisit, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(3);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(576, 64);
            tableLayoutPanel2.TabIndex = 41;
            // 
            // btnOther
            // 
            btnOther.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnOther.AccessibleName = "Other";
            btnOther.BadgeBackColor = Color.Black;
            btnOther.BadgeBorderColor = Color.Empty;
            btnOther.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnOther.BadgeValueForeColor = Color.White;
            btnOther.BorderColor = Color.FromArgb(15, 76, 76);
            btnOther.BorderWidth = 0;
            btnOther.BusyIndicatorColor = Color.Empty;
            btnOther.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnOther.CornerRadiusBottomLeft = 24;
            btnOther.CornerRadiusBottomRight = 24;
            btnOther.CornerRadiusTopLeft = 24;
            btnOther.CornerRadiusTopRight = 24;
            btnOther.CustomCursor = Cursors.Default;
            btnOther.DisabledBackColor = Color.Empty;
            btnOther.DisabledBorderColor = Color.Empty;
            btnOther.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnOther.Dock = DockStyle.Fill;
            btnOther.FocusRingColor = Color.Empty;
            btnOther.Font = new Font("Segoe UI Semibold", 10.2F);
            btnOther.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnOther.GradientColor = Color.FromArgb(0, 227, 64);
            btnOther.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnOther.HoverBorderColor = Color.Empty;
            btnOther.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnOther.ImageSize = new Size(16, 16);
            btnOther.IsRadial = true;
            btnOther.Location = new Point(475, 6);
            btnOther.Margin = new Padding(6, 3, 3, 3);
            btnOther.Name = "btnOther";
            btnOther.ParticleColor = Color.FromArgb(200, 200, 200);
            btnOther.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnOther.PressedBorderColor = Color.Empty;
            btnOther.PressedTextColor = Color.Empty;
            btnOther.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnOther.RippleColor = Color.FromArgb(0, 0, 0);
            btnOther.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnOther.ShadowOffset = new Point(0, 2);
            btnOther.Size = new Size(95, 52);
            btnOther.TabIndex = 44;
            btnOther.Text = "Other";
            btnOther.TextColor = Color.FromArgb(0, 0, 0);
            btnOther.ToggledBackColor = Color.Empty;
            btnOther.ToggledBorderColor = Color.Empty;
            btnOther.ToggledTextColor = Color.Empty;
            // 
            // btnLab
            // 
            btnLab.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnLab.AccessibleName = "Lab Result";
            btnLab.BadgeBackColor = Color.Black;
            btnLab.BadgeBorderColor = Color.Empty;
            btnLab.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnLab.BadgeValueForeColor = Color.White;
            btnLab.BorderColor = Color.FromArgb(15, 76, 76);
            btnLab.BorderWidth = 0;
            btnLab.BusyIndicatorColor = Color.Empty;
            btnLab.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnLab.CornerRadiusBottomLeft = 24;
            btnLab.CornerRadiusBottomRight = 24;
            btnLab.CornerRadiusTopLeft = 24;
            btnLab.CornerRadiusTopRight = 24;
            btnLab.CustomCursor = Cursors.Default;
            btnLab.DisabledBackColor = Color.Empty;
            btnLab.DisabledBorderColor = Color.Empty;
            btnLab.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnLab.Dock = DockStyle.Fill;
            btnLab.FocusRingColor = Color.Empty;
            btnLab.Font = new Font("Segoe UI Semibold", 10.2F);
            btnLab.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnLab.GradientColor = Color.FromArgb(0, 227, 64);
            btnLab.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnLab.HoverBorderColor = Color.Empty;
            btnLab.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnLab.ImageSize = new Size(16, 16);
            btnLab.IsRadial = true;
            btnLab.Location = new Point(168, 6);
            btnLab.Margin = new Padding(6, 3, 3, 3);
            btnLab.Name = "btnLab";
            btnLab.ParticleColor = Color.FromArgb(200, 200, 200);
            btnLab.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnLab.PressedBorderColor = Color.Empty;
            btnLab.PressedTextColor = Color.Empty;
            btnLab.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnLab.RippleColor = Color.FromArgb(0, 0, 0);
            btnLab.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnLab.ShadowOffset = new Point(0, 2);
            btnLab.Size = new Size(139, 52);
            btnLab.TabIndex = 43;
            btnLab.Text = "Lab Result";
            btnLab.TextColor = Color.FromArgb(0, 0, 0);
            btnLab.ToggledBackColor = Color.Empty;
            btnLab.ToggledBorderColor = Color.Empty;
            btnLab.ToggledTextColor = Color.Empty;
            // 
            // btnAll
            // 
            btnAll.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnAll.AccessibleName = "All";
            btnAll.BadgeBackColor = Color.Black;
            btnAll.BadgeBorderColor = Color.Empty;
            btnAll.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnAll.BadgeValueForeColor = Color.White;
            btnAll.BorderColor = Color.FromArgb(15, 76, 76);
            btnAll.BorderWidth = 0;
            btnAll.BusyIndicatorColor = Color.Empty;
            btnAll.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnAll.CornerRadiusBottomLeft = 24;
            btnAll.CornerRadiusBottomRight = 24;
            btnAll.CornerRadiusTopLeft = 24;
            btnAll.CornerRadiusTopRight = 24;
            btnAll.CustomCursor = Cursors.Default;
            btnAll.DisabledBackColor = Color.Empty;
            btnAll.DisabledBorderColor = Color.Empty;
            btnAll.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnAll.Dock = DockStyle.Fill;
            btnAll.FocusRingColor = Color.Empty;
            btnAll.Font = new Font("Segoe UI Semibold", 10.2F);
            btnAll.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnAll.GradientColor = Color.FromArgb(0, 227, 64);
            btnAll.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnAll.HoverBorderColor = Color.Empty;
            btnAll.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnAll.ImageSize = new Size(16, 16);
            btnAll.IsRadial = true;
            btnAll.Location = new Point(6, 6);
            btnAll.Margin = new Padding(3, 3, 6, 3);
            btnAll.Name = "btnAll";
            btnAll.ParticleColor = Color.FromArgb(200, 200, 200);
            btnAll.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnAll.PressedBorderColor = Color.Empty;
            btnAll.PressedTextColor = Color.Empty;
            btnAll.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnAll.RippleColor = Color.FromArgb(0, 0, 0);
            btnAll.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnAll.ShadowOffset = new Point(0, 2);
            btnAll.Size = new Size(59, 52);
            btnAll.TabIndex = 41;
            btnAll.Text = "All";
            btnAll.TextColor = Color.FromArgb(0, 0, 0);
            btnAll.ToggledBackColor = Color.Empty;
            btnAll.ToggledBorderColor = Color.Empty;
            btnAll.ToggledTextColor = Color.Empty;
            // 
            // btnRx
            // 
            btnRx.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnRx.AccessibleName = "Prescription";
            btnRx.BadgeBackColor = Color.Black;
            btnRx.BadgeBorderColor = Color.Empty;
            btnRx.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnRx.BadgeValueForeColor = Color.White;
            btnRx.BorderColor = Color.FromArgb(15, 76, 76);
            btnRx.BorderWidth = 0;
            btnRx.BusyIndicatorColor = Color.Empty;
            btnRx.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnRx.CornerRadiusBottomLeft = 24;
            btnRx.CornerRadiusBottomRight = 24;
            btnRx.CornerRadiusTopLeft = 24;
            btnRx.CornerRadiusTopRight = 24;
            btnRx.CustomCursor = Cursors.Default;
            btnRx.DisabledBackColor = Color.Empty;
            btnRx.DisabledBorderColor = Color.Empty;
            btnRx.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnRx.Dock = DockStyle.Fill;
            btnRx.FocusRingColor = Color.Empty;
            btnRx.Font = new Font("Segoe UI Semibold", 10.2F);
            btnRx.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnRx.GradientColor = Color.FromArgb(0, 227, 64);
            btnRx.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnRx.HoverBorderColor = Color.Empty;
            btnRx.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnRx.ImageSize = new Size(16, 16);
            btnRx.IsRadial = true;
            btnRx.Location = new Point(316, 6);
            btnRx.Margin = new Padding(6, 3, 3, 3);
            btnRx.Name = "btnRx";
            btnRx.ParticleColor = Color.FromArgb(200, 200, 200);
            btnRx.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnRx.PressedBorderColor = Color.Empty;
            btnRx.PressedTextColor = Color.Empty;
            btnRx.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnRx.RippleColor = Color.FromArgb(0, 0, 0);
            btnRx.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnRx.ShadowOffset = new Point(0, 2);
            btnRx.Size = new Size(150, 52);
            btnRx.TabIndex = 40;
            btnRx.Text = "Prescription";
            btnRx.TextColor = Color.FromArgb(0, 0, 0);
            btnRx.ToggledBackColor = Color.Empty;
            btnRx.ToggledBorderColor = Color.Empty;
            btnRx.ToggledTextColor = Color.Empty;
            // 
            // btnVisit
            // 
            btnVisit.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnVisit.AccessibleName = "Visit";
            btnVisit.BadgeBackColor = Color.Black;
            btnVisit.BadgeBorderColor = Color.Empty;
            btnVisit.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnVisit.BadgeValueForeColor = Color.White;
            btnVisit.BorderColor = Color.FromArgb(15, 76, 76);
            btnVisit.BorderWidth = 0;
            btnVisit.BusyIndicatorColor = Color.Empty;
            btnVisit.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnVisit.CornerRadiusBottomLeft = 24;
            btnVisit.CornerRadiusBottomRight = 24;
            btnVisit.CornerRadiusTopLeft = 24;
            btnVisit.CornerRadiusTopRight = 24;
            btnVisit.CustomCursor = Cursors.Default;
            btnVisit.DisabledBackColor = Color.Empty;
            btnVisit.DisabledBorderColor = Color.Empty;
            btnVisit.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnVisit.Dock = DockStyle.Fill;
            btnVisit.FocusRingColor = Color.Empty;
            btnVisit.Font = new Font("Segoe UI Semibold", 10.2F);
            btnVisit.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnVisit.GradientColor = Color.FromArgb(0, 227, 64);
            btnVisit.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnVisit.HoverBorderColor = Color.Empty;
            btnVisit.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnVisit.ImageSize = new Size(16, 16);
            btnVisit.IsRadial = true;
            btnVisit.Location = new Point(77, 6);
            btnVisit.Margin = new Padding(6, 3, 3, 3);
            btnVisit.Name = "btnVisit";
            btnVisit.ParticleColor = Color.FromArgb(200, 200, 200);
            btnVisit.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnVisit.PressedBorderColor = Color.Empty;
            btnVisit.PressedTextColor = Color.Empty;
            btnVisit.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnVisit.RippleColor = Color.FromArgb(0, 0, 0);
            btnVisit.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnVisit.ShadowOffset = new Point(0, 2);
            btnVisit.Size = new Size(82, 52);
            btnVisit.TabIndex = 42;
            btnVisit.Text = "Visit";
            btnVisit.TextColor = Color.FromArgb(0, 0, 0);
            btnVisit.ToggledBackColor = Color.Empty;
            btnVisit.ToggledBorderColor = Color.Empty;
            btnVisit.ToggledTextColor = Color.Empty;
            // 
            // pnlTable
            // 
            pnlTable.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            pnlTable.BackColor = Color.Transparent;
            pnlTable.BorderAlignment = PenAlignment.Center;
            pnlTable.BorderColor = Color.FromArgb(210, 210, 210);
            pnlTable.BorderDashPattern = null;
            pnlTable.BorderGradientEndColor = Color.Purple;
            pnlTable.BorderGradientStartColor = Color.Blue;
            pnlTable.BorderThickness = 2F;
            pnlTable.Controls.Add(dgv);
            pnlTable.CornerRadiusBottomLeft = 25F;
            pnlTable.CornerRadiusBottomRight = 25F;
            pnlTable.CornerRadiusTopLeft = 25F;
            pnlTable.CornerRadiusTopRight = 25F;
            pnlTable.EnableAcrylicEffect = false;
            pnlTable.EnableMicaEffect = false;
            pnlTable.EnableRippleEffect = false;
            pnlTable.FillColor = Color.White;
            pnlTable.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            pnlTable.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            pnlTable.Location = new Point(28, 249);
            pnlTable.Name = "pnlTable";
            pnlTable.PatternColor = Color.FromArgb(30, 0, 0, 0);
            pnlTable.PatternStyle = HatchStyle.Max;
            pnlTable.RippleAlpha = 50;
            pnlTable.RippleAlphaDecrement = 3;
            pnlTable.RippleColor = Color.FromArgb(50, 255, 255, 255);
            pnlTable.RippleMaxSize = 600F;
            pnlTable.RippleSpeed = 15F;
            pnlTable.ShowBorder = true;
            pnlTable.Size = new Size(1079, 517);
            pnlTable.TabIndex = 62;
            pnlTable.TabStop = true;
            pnlTable.UseBorderGradient = false;
            pnlTable.UseMultiGradient = false;
            pnlTable.UsePatternTexture = false;
            pnlTable.UseRadialGradient = false;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(21, 14);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(1033, 487);
            dgv.TabIndex = 26;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnDelete, 2, 0);
            tableLayoutPanel1.Controls.Add(btnOpen, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEdit, 1, 0);
            tableLayoutPanel1.Location = new Point(671, 818);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(433, 58);
            tableLayoutPanel1.TabIndex = 63;
            // 
            // btnDelete
            // 
            btnDelete.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnDelete.AccessibleName = "Delete";
            btnDelete.BadgeBackColor = Color.Black;
            btnDelete.BadgeBorderColor = Color.Empty;
            btnDelete.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnDelete.BadgeValueForeColor = Color.White;
            btnDelete.BorderColor = Color.FromArgb(15, 76, 76);
            btnDelete.BorderWidth = 2;
            btnDelete.BusyIndicatorColor = Color.Empty;
            btnDelete.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnDelete.CornerRadiusBottomLeft = 24;
            btnDelete.CornerRadiusBottomRight = 24;
            btnDelete.CornerRadiusTopLeft = 24;
            btnDelete.CornerRadiusTopRight = 24;
            btnDelete.CustomCursor = Cursors.Default;
            btnDelete.DisabledBackColor = Color.Empty;
            btnDelete.DisabledBorderColor = Color.Empty;
            btnDelete.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FocusRingColor = Color.Empty;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F);
            btnDelete.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnDelete.GradientColor = Color.FromArgb(0, 227, 64);
            btnDelete.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnDelete.HoverBorderColor = Color.Empty;
            btnDelete.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnDelete.ImageSize = new Size(16, 16);
            btnDelete.IsRadial = true;
            btnDelete.Location = new Point(291, 3);
            btnDelete.Margin = new Padding(3, 3, 6, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.ParticleColor = Color.FromArgb(200, 200, 200);
            btnDelete.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnDelete.PressedBorderColor = Color.Empty;
            btnDelete.PressedTextColor = Color.Empty;
            btnDelete.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnDelete.RippleColor = Color.FromArgb(0, 0, 0);
            btnDelete.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnDelete.ShadowOffset = new Point(0, 2);
            btnDelete.Size = new Size(136, 52);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Delete";
            btnDelete.TextColor = Color.FromArgb(0, 0, 0);
            btnDelete.ToggledBackColor = Color.Empty;
            btnDelete.ToggledBorderColor = Color.Empty;
            btnDelete.ToggledTextColor = Color.Empty;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnOpen
            // 
            btnOpen.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnOpen.AccessibleName = "Open";
            btnOpen.BadgeBackColor = Color.Black;
            btnOpen.BadgeBorderColor = Color.Empty;
            btnOpen.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnOpen.BadgeValueForeColor = Color.White;
            btnOpen.BorderColor = Color.FromArgb(15, 76, 76);
            btnOpen.BorderWidth = 2;
            btnOpen.BusyIndicatorColor = Color.Empty;
            btnOpen.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnOpen.CornerRadiusBottomLeft = 24;
            btnOpen.CornerRadiusBottomRight = 24;
            btnOpen.CornerRadiusTopLeft = 24;
            btnOpen.CornerRadiusTopRight = 24;
            btnOpen.CustomCursor = Cursors.Default;
            btnOpen.DisabledBackColor = Color.Empty;
            btnOpen.DisabledBorderColor = Color.Empty;
            btnOpen.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnOpen.Dock = DockStyle.Fill;
            btnOpen.FocusRingColor = Color.Empty;
            btnOpen.Font = new Font("Segoe UI Semibold", 10.2F);
            btnOpen.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnOpen.GradientColor = Color.FromArgb(0, 227, 64);
            btnOpen.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnOpen.HoverBorderColor = Color.Empty;
            btnOpen.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnOpen.ImageSize = new Size(16, 16);
            btnOpen.IsRadial = true;
            btnOpen.Location = new Point(3, 3);
            btnOpen.Margin = new Padding(3, 3, 6, 3);
            btnOpen.Name = "btnOpen";
            btnOpen.ParticleColor = Color.FromArgb(200, 200, 200);
            btnOpen.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnOpen.PressedBorderColor = Color.Empty;
            btnOpen.PressedTextColor = Color.Empty;
            btnOpen.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnOpen.RippleColor = Color.FromArgb(0, 0, 0);
            btnOpen.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnOpen.ShadowOffset = new Point(0, 2);
            btnOpen.Size = new Size(135, 52);
            btnOpen.TabIndex = 41;
            btnOpen.Text = "Open";
            btnOpen.TextColor = Color.FromArgb(0, 0, 0);
            btnOpen.ToggledBackColor = Color.Empty;
            btnOpen.ToggledBorderColor = Color.Empty;
            btnOpen.ToggledTextColor = Color.Empty;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnEdit
            // 
            btnEdit.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnEdit.AccessibleName = "Edit";
            btnEdit.BadgeBackColor = Color.Black;
            btnEdit.BadgeBorderColor = Color.Empty;
            btnEdit.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnEdit.BadgeValueForeColor = Color.White;
            btnEdit.BorderColor = Color.FromArgb(15, 76, 76);
            btnEdit.BorderWidth = 2;
            btnEdit.BusyIndicatorColor = Color.Empty;
            btnEdit.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnEdit.CornerRadiusBottomLeft = 24;
            btnEdit.CornerRadiusBottomRight = 24;
            btnEdit.CornerRadiusTopLeft = 24;
            btnEdit.CornerRadiusTopRight = 24;
            btnEdit.CustomCursor = Cursors.Default;
            btnEdit.DisabledBackColor = Color.Empty;
            btnEdit.DisabledBorderColor = Color.Empty;
            btnEdit.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.FocusRingColor = Color.Empty;
            btnEdit.Font = new Font("Segoe UI Semibold", 10.2F);
            btnEdit.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnEdit.GradientColor = Color.FromArgb(0, 227, 64);
            btnEdit.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnEdit.HoverBorderColor = Color.Empty;
            btnEdit.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnEdit.ImageSize = new Size(16, 16);
            btnEdit.IsRadial = true;
            btnEdit.Location = new Point(147, 3);
            btnEdit.Margin = new Padding(3, 3, 6, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.ParticleColor = Color.FromArgb(200, 200, 200);
            btnEdit.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnEdit.PressedBorderColor = Color.Empty;
            btnEdit.PressedTextColor = Color.Empty;
            btnEdit.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnEdit.RippleColor = Color.FromArgb(0, 0, 0);
            btnEdit.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnEdit.ShadowOffset = new Point(0, 2);
            btnEdit.Size = new Size(135, 52);
            btnEdit.TabIndex = 42;
            btnEdit.Text = "Edit";
            btnEdit.TextColor = Color.FromArgb(0, 0, 0);
            btnEdit.ToggledBackColor = Color.Empty;
            btnEdit.ToggledBorderColor = Color.Empty;
            btnEdit.ToggledTextColor = Color.Empty;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnUpload
            // 
            btnUpload.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnUpload.AccessibleName = "Uplaod New Record";
            btnUpload.BadgeBackColor = Color.Black;
            btnUpload.BadgeBorderColor = Color.Empty;
            btnUpload.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnUpload.BadgeValueForeColor = Color.White;
            btnUpload.BorderColor = Color.FromArgb(213, 216, 220);
            btnUpload.BusyIndicatorColor = Color.Empty;
            btnUpload.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnUpload.CornerRadiusBottomLeft = 20;
            btnUpload.CornerRadiusBottomRight = 20;
            btnUpload.CornerRadiusTopLeft = 20;
            btnUpload.CornerRadiusTopRight = 20;
            btnUpload.CustomCursor = Cursors.Default;
            btnUpload.DisabledBackColor = Color.Empty;
            btnUpload.DisabledBorderColor = Color.Empty;
            btnUpload.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnUpload.FocusRingColor = Color.Empty;
            btnUpload.Font = new Font("Segoe UI Semibold", 10.2F);
            btnUpload.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnUpload.GradientColor = Color.FromArgb(0, 227, 64);
            btnUpload.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnUpload.HoverBorderColor = Color.Empty;
            btnUpload.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnUpload.ImagePadding = 3;
            btnUpload.ImageSize = new Size(30, 30);
            btnUpload.Location = new Point(886, 34);
            btnUpload.Name = "btnUpload";
            btnUpload.ParticleColor = Color.FromArgb(200, 200, 200);
            btnUpload.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnUpload.PressedBorderColor = Color.Empty;
            btnUpload.PressedTextColor = Color.Empty;
            btnUpload.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnUpload.RippleColor = Color.FromArgb(0, 0, 0);
            btnUpload.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnUpload.ShadowOffset = new Point(0, 2);
            btnUpload.Size = new Size(218, 55);
            btnUpload.TabIndex = 69;
            btnUpload.Text = "Uplaod New Record";
            btnUpload.TextColor = Color.FromArgb(0, 0, 0);
            btnUpload.ToggledBackColor = Color.Empty;
            btnUpload.ToggledBorderColor = Color.Empty;
            btnUpload.ToggledTextColor = Color.Empty;
            btnUpload.Click += btnUpload_Click;
            // 
            // RecordsScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUpload);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnlTable);
            Controls.Add(siticonePanel1);
            Controls.Add(txtSearch);
            Controls.Add(lblCount);
            Controls.Add(siticoneLabel3);
            Name = "RecordsScreen";
            Size = new Size(1136, 899);
            siticonePanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneTextBox txtSearch;
        private SiticoneLabel lblCount;
        private SiticoneLabel siticoneLabel3;
        private SiticonePanel siticonePanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private SiticoneButton btnLab;
        private SiticoneButton btnAll;
        private SiticoneButton btnRx;
        private SiticoneButton btnVisit;
        private SiticonePanel pnlTable;
        private DataGridView dgv;
        private TableLayoutPanel tableLayoutPanel1;
        private SiticoneButton btnDelete;
        private SiticoneButton btnOpen;
        private SiticoneButton btnEdit;
        private SiticoneButton btnUpload;
        private SiticoneButton btnOther;
    }
}
