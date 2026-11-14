namespace medicord_v1.Screens.Desktop
{
    partial class DashboardScreen
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
            lblGreeting = new SiticoneLabel();
            pnlTable = new SiticonePanel();
            dgvToday = new DataGridView();
            siticoneLabel1 = new SiticoneLabel();
            btnViewAll = new SiticoneButton();
            lblDate = new SiticoneLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            kpiPend = new KpiCard();
            kpiStaff = new KpiCard();
            kpiDone = new KpiCard();
            kpiToday = new KpiCard();
            pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvToday).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblGreeting
            // 
            lblGreeting.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGreeting.ForeColor = SystemColors.ActiveCaptionText;
            lblGreeting.Location = new Point(34, 65);
            lblGreeting.Name = "lblGreeting";
            lblGreeting.Size = new Size(1043, 60);
            lblGreeting.TabIndex = 21;
            lblGreeting.Text = "Dashboard";
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
            pnlTable.Controls.Add(dgvToday);
            pnlTable.Controls.Add(siticoneLabel1);
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
            pnlTable.Location = new Point(34, 328);
            pnlTable.Name = "pnlTable";
            pnlTable.PatternColor = Color.FromArgb(30, 0, 0, 0);
            pnlTable.PatternStyle = HatchStyle.Max;
            pnlTable.RippleAlpha = 50;
            pnlTable.RippleAlphaDecrement = 3;
            pnlTable.RippleColor = Color.FromArgb(50, 255, 255, 255);
            pnlTable.RippleMaxSize = 600F;
            pnlTable.RippleSpeed = 15F;
            pnlTable.ShowBorder = true;
            pnlTable.Size = new Size(1051, 449);
            pnlTable.TabIndex = 23;
            pnlTable.TabStop = true;
            pnlTable.UseBorderGradient = false;
            pnlTable.UseMultiGradient = false;
            pnlTable.UsePatternTexture = false;
            pnlTable.UseRadialGradient = false;
            // 
            // dgvToday
            // 
            dgvToday.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToday.Location = new Point(21, 66);
            dgvToday.Name = "dgvToday";
            dgvToday.RowHeadersWidth = 51;
            dgvToday.Size = new Size(1009, 360);
            dgvToday.TabIndex = 26;
            // 
            // siticoneLabel1
            // 
            siticoneLabel1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel1.ForeColor = SystemColors.ActiveCaptionText;
            siticoneLabel1.Location = new Point(16, 18);
            siticoneLabel1.Name = "siticoneLabel1";
            siticoneLabel1.Size = new Size(312, 42);
            siticoneLabel1.TabIndex = 25;
            siticoneLabel1.Text = "Today's appointments";
            // 
            // btnViewAll
            // 
            btnViewAll.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnViewAll.AccessibleName = "View All";
            btnViewAll.BadgeBackColor = Color.Black;
            btnViewAll.BadgeBorderColor = Color.Empty;
            btnViewAll.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnViewAll.BadgeValueForeColor = Color.White;
            btnViewAll.BorderColor = Color.FromArgb(15, 76, 76);
            btnViewAll.BorderWidth = 2;
            btnViewAll.BusyIndicatorColor = Color.Empty;
            btnViewAll.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnViewAll.CornerRadiusBottomLeft = 24;
            btnViewAll.CornerRadiusBottomRight = 24;
            btnViewAll.CornerRadiusTopLeft = 24;
            btnViewAll.CornerRadiusTopRight = 24;
            btnViewAll.CustomCursor = Cursors.Default;
            btnViewAll.DisabledBackColor = Color.Empty;
            btnViewAll.DisabledBorderColor = Color.Empty;
            btnViewAll.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnViewAll.FocusRingColor = Color.Empty;
            btnViewAll.Font = new Font("Segoe UI Semibold", 10.2F);
            btnViewAll.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnViewAll.GradientColor = Color.FromArgb(0, 227, 64);
            btnViewAll.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnViewAll.HoverBorderColor = Color.Empty;
            btnViewAll.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnViewAll.ImageSize = new Size(16, 16);
            btnViewAll.IsRadial = true;
            btnViewAll.Location = new Point(940, 805);
            btnViewAll.Margin = new Padding(3, 3, 6, 3);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.ParticleColor = Color.FromArgb(200, 200, 200);
            btnViewAll.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnViewAll.PressedBorderColor = Color.Empty;
            btnViewAll.PressedTextColor = Color.Empty;
            btnViewAll.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnViewAll.RippleColor = Color.FromArgb(0, 0, 0);
            btnViewAll.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnViewAll.ShadowOffset = new Point(0, 2);
            btnViewAll.Size = new Size(124, 52);
            btnViewAll.TabIndex = 42;
            btnViewAll.Text = "View All";
            btnViewAll.TextColor = Color.FromArgb(0, 0, 0);
            btnViewAll.ToggledBackColor = Color.Empty;
            btnViewAll.ToggledBorderColor = Color.Empty;
            btnViewAll.ToggledTextColor = Color.Empty;
            btnViewAll.Click += btnViewAll_Click;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.Gray;
            lblDate.Location = new Point(42, 31);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(520, 34);
            lblDate.TabIndex = 43;
            lblDate.Text = "Worker Portal";
            lblDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(kpiPend, 3, 0);
            tableLayoutPanel1.Controls.Add(kpiStaff, 2, 0);
            tableLayoutPanel1.Controls.Add(kpiDone, 1, 0);
            tableLayoutPanel1.Controls.Add(kpiToday, 0, 0);
            tableLayoutPanel1.Location = new Point(34, 139);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1051, 178);
            tableLayoutPanel1.TabIndex = 44;
            // 
            // kpiPend
            // 
            kpiPend.BackColor = Color.FromArgb(240, 240, 240);
            kpiPend.Dock = DockStyle.Fill;
            kpiPend.Location = new Point(794, 8);
            kpiPend.Margin = new Padding(8);
            kpiPend.Name = "kpiPend";
            kpiPend.Size = new Size(249, 162);
            kpiPend.TabIndex = 3;
            kpiPend.Text = "kpiCard4";
            // 
            // kpiStaff
            // 
            kpiStaff.BackColor = Color.FromArgb(240, 240, 240);
            kpiStaff.Dock = DockStyle.Fill;
            kpiStaff.Location = new Point(532, 8);
            kpiStaff.Margin = new Padding(8);
            kpiStaff.Name = "kpiStaff";
            kpiStaff.Size = new Size(246, 162);
            kpiStaff.TabIndex = 2;
            kpiStaff.Text = "kpiCard3";
            // 
            // kpiDone
            // 
            kpiDone.BackColor = Color.FromArgb(240, 240, 240);
            kpiDone.Dock = DockStyle.Fill;
            kpiDone.Location = new Point(270, 8);
            kpiDone.Margin = new Padding(8);
            kpiDone.Name = "kpiDone";
            kpiDone.Size = new Size(246, 162);
            kpiDone.TabIndex = 1;
            kpiDone.Text = "kpiCard2";
            // 
            // kpiToday
            // 
            kpiToday.BackColor = Color.FromArgb(240, 240, 240);
            kpiToday.Dock = DockStyle.Fill;
            kpiToday.Location = new Point(8, 8);
            kpiToday.Margin = new Padding(8);
            kpiToday.Name = "kpiToday";
            kpiToday.Size = new Size(246, 162);
            kpiToday.TabIndex = 0;
            kpiToday.Text = "kpiCard1";
            // 
            // DashboardScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblDate);
            Controls.Add(btnViewAll);
            Controls.Add(pnlTable);
            Controls.Add(lblGreeting);
            Name = "DashboardScreen";
            Size = new Size(1136, 899);
            pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvToday).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SiticoneLabel lblGreeting;
        private SiticonePanel pnlTable;
        private DataGridView dgvToday;
        private SiticoneLabel siticoneLabel1;
        private SiticoneButton btnViewAll;
        private SiticoneLabel lblDate;
        private TableLayoutPanel tableLayoutPanel1;
        private KpiCard kpiToday;
        private KpiCard kpiPend;
        private KpiCard kpiStaff;
        private KpiCard kpiDone;
    }
}
