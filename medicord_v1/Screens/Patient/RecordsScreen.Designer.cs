namespace medicord_v1.Screens.Patient
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
            siticoneLabel4 = new SiticoneLabel();
            lblEmpty = new SiticoneLabel();
            siticonePanel1 = new SiticonePanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnLab = new SiticoneButton();
            btnAll = new SiticoneButton();
            btnRx = new SiticoneButton();
            btnVisit = new SiticoneButton();
            flowList = new FlowLayoutPanel();
            txtSearch = new SiticoneTextBox();
            siticonePanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // siticoneLabel4
            // 
            siticoneLabel4.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel4.ForeColor = Color.Black;
            siticoneLabel4.Location = new Point(32, 26);
            siticoneLabel4.Name = "siticoneLabel4";
            siticoneLabel4.Size = new Size(335, 56);
            siticoneLabel4.TabIndex = 22;
            siticoneLabel4.Text = "Records";
            siticoneLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEmpty
            // 
            lblEmpty.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpty.ForeColor = Color.Black;
            lblEmpty.Location = new Point(82, 264);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new Size(352, 44);
            lblEmpty.TabIndex = 34;
            lblEmpty.Text = "No records yet";
            lblEmpty.TextAlign = ContentAlignment.MiddleCenter;
            lblEmpty.Visible = false;
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
            siticonePanel1.Location = new Point(32, 169);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.PatternColor = Color.FromArgb(30, 0, 0, 0);
            siticonePanel1.PatternStyle = HatchStyle.Max;
            siticonePanel1.RippleAlpha = 50;
            siticonePanel1.RippleAlphaDecrement = 3;
            siticonePanel1.RippleColor = Color.FromArgb(50, 255, 255, 255);
            siticonePanel1.RippleMaxSize = 600F;
            siticonePanel1.RippleSpeed = 15F;
            siticonePanel1.ShowBorder = true;
            siticonePanel1.Size = new Size(448, 53);
            siticonePanel1.TabIndex = 62;
            siticonePanel1.TabStop = true;
            siticonePanel1.UseBorderGradient = false;
            siticonePanel1.UseMultiGradient = false;
            siticonePanel1.UsePatternTexture = false;
            siticonePanel1.UseRadialGradient = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.2926826F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.1707325F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.3902435F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.1463432F));
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
            tableLayoutPanel2.Size = new Size(443, 49);
            tableLayoutPanel2.TabIndex = 41;
            // 
            // btnLab
            // 
            btnLab.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnLab.AccessibleName = "Labs";
            btnLab.BadgeBackColor = Color.Black;
            btnLab.BadgeBorderColor = Color.Empty;
            btnLab.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnLab.BadgeValueForeColor = Color.White;
            btnLab.BorderColor = Color.FromArgb(15, 76, 76);
            btnLab.BorderWidth = 0;
            btnLab.BusyIndicatorColor = Color.Empty;
            btnLab.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnLab.CornerRadiusBottomLeft = 16;
            btnLab.CornerRadiusBottomRight = 16;
            btnLab.CornerRadiusTopLeft = 16;
            btnLab.CornerRadiusTopRight = 16;
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
            btnLab.Location = new Point(189, 6);
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
            btnLab.Size = new Size(97, 37);
            btnLab.TabIndex = 43;
            btnLab.Text = "Labs";
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
            btnAll.CornerRadiusBottomLeft = 16;
            btnAll.CornerRadiusBottomRight = 16;
            btnAll.CornerRadiusTopLeft = 16;
            btnAll.CornerRadiusTopRight = 16;
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
            btnAll.Size = new Size(70, 37);
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
            btnRx.AccessibleName = "Prescriptions";
            btnRx.BadgeBackColor = Color.Black;
            btnRx.BadgeBorderColor = Color.Empty;
            btnRx.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnRx.BadgeValueForeColor = Color.White;
            btnRx.BorderColor = Color.FromArgb(15, 76, 76);
            btnRx.BorderWidth = 0;
            btnRx.BusyIndicatorColor = Color.Empty;
            btnRx.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnRx.CornerRadiusBottomLeft = 16;
            btnRx.CornerRadiusBottomRight = 16;
            btnRx.CornerRadiusTopLeft = 16;
            btnRx.CornerRadiusTopRight = 16;
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
            btnRx.Location = new Point(295, 6);
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
            btnRx.Size = new Size(142, 37);
            btnRx.TabIndex = 40;
            btnRx.Text = "Prescriptions";
            btnRx.TextColor = Color.FromArgb(0, 0, 0);
            btnRx.ToggledBackColor = Color.Empty;
            btnRx.ToggledBorderColor = Color.Empty;
            btnRx.ToggledTextColor = Color.Empty;
            // 
            // btnVisit
            // 
            btnVisit.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnVisit.AccessibleName = "Visits";
            btnVisit.BadgeBackColor = Color.Black;
            btnVisit.BadgeBorderColor = Color.Empty;
            btnVisit.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnVisit.BadgeValueForeColor = Color.White;
            btnVisit.BorderColor = Color.FromArgb(15, 76, 76);
            btnVisit.BorderWidth = 0;
            btnVisit.BusyIndicatorColor = Color.Empty;
            btnVisit.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnVisit.CornerRadiusBottomLeft = 16;
            btnVisit.CornerRadiusBottomRight = 16;
            btnVisit.CornerRadiusTopLeft = 16;
            btnVisit.CornerRadiusTopRight = 16;
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
            btnVisit.Location = new Point(88, 6);
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
            btnVisit.Size = new Size(92, 37);
            btnVisit.TabIndex = 42;
            btnVisit.Text = "Visits";
            btnVisit.TextColor = Color.FromArgb(0, 0, 0);
            btnVisit.ToggledBackColor = Color.Empty;
            btnVisit.ToggledBorderColor = Color.Empty;
            btnVisit.ToggledTextColor = Color.Empty;
            // 
            // flowList
            // 
            flowList.Anchor = AnchorStyles.Top;
            flowList.AutoScroll = true;
            flowList.FlowDirection = FlowDirection.TopDown;
            flowList.Location = new Point(40, 241);
            flowList.Name = "flowList";
            flowList.Size = new Size(451, 489);
            flowList.TabIndex = 63;
            flowList.WrapContents = false;
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
            txtSearch.Location = new Point(35, 98);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderColor = Color.Gray;
            txtSearch.PlaceholderText = "Search records";
            txtSearch.ReadOnlyBorderColor1 = Color.LightGray;
            txtSearch.ReadOnlyBorderColor2 = Color.LightGray;
            txtSearch.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtSearch.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtSearch.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtSearch.ReadOnlyTextColor = Color.Empty;
            txtSearch.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtSearch.SelectionForeColor = SystemColors.HighlightText;
            txtSearch.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtSearch.Size = new Size(442, 55);
            txtSearch.SolidBorderColor = Color.FromArgb(220, 220, 220);
            txtSearch.SolidBorderFocusColor = Color.FromArgb(180, 180, 180);
            txtSearch.SolidBorderHoverColor = Color.Gray;
            txtSearch.SolidFillColor = Color.White;
            txtSearch.TabIndex = 64;
            // 
            // RecordsScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtSearch);
            Controls.Add(lblEmpty);
            Controls.Add(flowList);
            Controls.Add(siticonePanel1);
            Controls.Add(siticoneLabel4);
            Name = "RecordsScreen";
            Size = new Size(522, 779);
            siticonePanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneLabel siticoneLabel4;
        private SiticoneLabel lblEmpty;
        private SiticonePanel siticonePanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private SiticoneButton btnLab;
        private SiticoneButton btnAll;
        private SiticoneButton btnRx;
        private SiticoneButton btnVisit;
        private FlowLayoutPanel flowList;
        private SiticoneTextBox txtSearch;
    }
}
