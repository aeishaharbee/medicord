namespace medicord_v1.Screens.Desktop
{
    partial class PatientsScreen
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
            siticoneLabel3 = new SiticoneLabel();
            lblCount = new SiticoneLabel();
            txtSearch = new SiticoneTextBox();
            btnViewDetails = new SiticoneButton();
            pnlTable = new SiticonePanel();
            dgv = new DataGridView();
            pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // siticoneLabel3
            // 
            siticoneLabel3.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel3.ForeColor = SystemColors.ActiveCaptionText;
            siticoneLabel3.Location = new Point(25, 29);
            siticoneLabel3.Name = "siticoneLabel3";
            siticoneLabel3.Size = new Size(274, 60);
            siticoneLabel3.TabIndex = 23;
            siticoneLabel3.Text = "Patients";
            // 
            // lblCount
            // 
            lblCount.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCount.ForeColor = Color.FromArgb(15, 76, 76);
            lblCount.Location = new Point(27, 83);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(274, 46);
            lblCount.TabIndex = 24;
            lblCount.Text = "[00] registered patients";
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
            txtSearch.Location = new Point(27, 148);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderColor = Color.Gray;
            txtSearch.PlaceholderText = "Search by Name, ID Number, or Phone";
            txtSearch.ReadOnlyBorderColor1 = Color.LightGray;
            txtSearch.ReadOnlyBorderColor2 = Color.LightGray;
            txtSearch.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtSearch.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtSearch.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtSearch.ReadOnlyTextColor = Color.Empty;
            txtSearch.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtSearch.SelectionForeColor = SystemColors.HighlightText;
            txtSearch.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtSearch.Size = new Size(504, 58);
            txtSearch.SolidBorderColor = Color.FromArgb(220, 220, 220);
            txtSearch.SolidBorderFocusColor = Color.FromArgb(180, 180, 180);
            txtSearch.SolidBorderHoverColor = Color.Gray;
            txtSearch.SolidFillColor = Color.White;
            txtSearch.TabIndex = 57;
            // 
            // btnViewDetails
            // 
            btnViewDetails.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btnViewDetails.AccessibleName = "View Details";
            btnViewDetails.BadgeBackColor = Color.Black;
            btnViewDetails.BadgeBorderColor = Color.Empty;
            btnViewDetails.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnViewDetails.BadgeValueForeColor = Color.White;
            btnViewDetails.BorderColor = Color.FromArgb(15, 76, 76);
            btnViewDetails.BorderWidth = 2;
            btnViewDetails.BusyIndicatorColor = Color.Empty;
            btnViewDetails.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btnViewDetails.CornerRadiusBottomLeft = 24;
            btnViewDetails.CornerRadiusBottomRight = 24;
            btnViewDetails.CornerRadiusTopLeft = 24;
            btnViewDetails.CornerRadiusTopRight = 24;
            btnViewDetails.CustomCursor = Cursors.Default;
            btnViewDetails.DisabledBackColor = Color.Empty;
            btnViewDetails.DisabledBorderColor = Color.Empty;
            btnViewDetails.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btnViewDetails.FocusRingColor = Color.Empty;
            btnViewDetails.Font = new Font("Segoe UI Semibold", 10.2F);
            btnViewDetails.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btnViewDetails.GradientColor = Color.FromArgb(0, 227, 64);
            btnViewDetails.HoverBackColor = Color.FromArgb(240, 240, 240);
            btnViewDetails.HoverBorderColor = Color.Empty;
            btnViewDetails.HoverTextColor = Color.FromArgb(0, 0, 0);
            btnViewDetails.ImageSize = new Size(16, 16);
            btnViewDetails.IsRadial = true;
            btnViewDetails.Location = new Point(945, 807);
            btnViewDetails.Margin = new Padding(3, 3, 6, 3);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.ParticleColor = Color.FromArgb(200, 200, 200);
            btnViewDetails.PressedBackColor = Color.FromArgb(225, 227, 230);
            btnViewDetails.PressedBorderColor = Color.Empty;
            btnViewDetails.PressedTextColor = Color.Empty;
            btnViewDetails.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btnViewDetails.RippleColor = Color.FromArgb(0, 0, 0);
            btnViewDetails.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btnViewDetails.ShadowOffset = new Point(0, 2);
            btnViewDetails.Size = new Size(161, 52);
            btnViewDetails.TabIndex = 42;
            btnViewDetails.Text = "View Details";
            btnViewDetails.TextColor = Color.FromArgb(0, 0, 0);
            btnViewDetails.ToggledBackColor = Color.Empty;
            btnViewDetails.ToggledBorderColor = Color.Empty;
            btnViewDetails.ToggledTextColor = Color.Empty;
            btnViewDetails.Click += btnViewDetails_Click_1;
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
            pnlTable.Location = new Point(27, 231);
            pnlTable.Name = "pnlTable";
            pnlTable.PatternColor = Color.FromArgb(30, 0, 0, 0);
            pnlTable.PatternStyle = HatchStyle.Max;
            pnlTable.RippleAlpha = 50;
            pnlTable.RippleAlphaDecrement = 3;
            pnlTable.RippleColor = Color.FromArgb(50, 255, 255, 255);
            pnlTable.RippleMaxSize = 600F;
            pnlTable.RippleSpeed = 15F;
            pnlTable.ShowBorder = true;
            pnlTable.Size = new Size(1079, 554);
            pnlTable.TabIndex = 63;
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
            dgv.Size = new Size(1033, 521);
            dgv.TabIndex = 26;
            // 
            // PatientsScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlTable);
            Controls.Add(btnViewDetails);
            Controls.Add(txtSearch);
            Controls.Add(lblCount);
            Controls.Add(siticoneLabel3);
            Name = "PatientsScreen";
            Size = new Size(1136, 899);
            pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SiticoneLabel siticoneLabel3;
        private SiticoneLabel lblCount;
        private SiticoneTextBox txtSearch;
        private SiticoneButton btnViewDetails;
        private SiticonePanel pnlTable;
        private DataGridView dgv;
    }
}
