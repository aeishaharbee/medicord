namespace medicord_v1.Screens.Patient
{
    partial class BookAppointmentScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAppointmentScreen));
            btnBack = new SiticoneNavBackButton();
            cmbFacility = new SiticoneDropdown();
            siticoneLabel4 = new SiticoneLabel();
            cmbPurpose = new SiticoneDropdown();
            txtSymptoms = new SiticoneTextBox();
            dtpDate = new SiticoneDateTimePicker();
            flpSlots = new FlowLayoutPanel();
            lblNoSlots = new SiticoneLabel();
            siticoneLabel1 = new SiticoneLabel();
            btnRequest = new SiticoneButtonAdvanced();
            siticoneLabel10 = new SiticoneLabel();
            siticoneLabel2 = new SiticoneLabel();
            siticoneLabel3 = new SiticoneLabel();
            siticoneLabel5 = new SiticoneLabel();
            lblFor = new SiticoneLabel();
            SuspendLayout();
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
            btnBack.Location = new Point(9, 20);
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
            btnBack.TabIndex = 19;
            btnBack.Text = "siticoneNavBackButton1";
            btnBack.Click += btnBack_Click;
            // 
            // cmbFacility
            // 
            cmbFacility.AllowMultipleSelection = false;
            cmbFacility.BackColor = Color.FromArgb(255, 255, 255);
            cmbFacility.BorderColor = Color.FromArgb(210, 210, 210);
            cmbFacility.BorderSize = 2;
            cmbFacility.CanBeep = false;
            cmbFacility.CanShake = true;
            cmbFacility.CornerRadius = 10;
            cmbFacility.DataSource = null;
            cmbFacility.DisplayMember = null;
            cmbFacility.DropdownBackColor = Color.FromArgb(255, 255, 255);
            cmbFacility.DropdownWidth = 0;
            cmbFacility.DropShadowEnabled = false;
            cmbFacility.Font = new Font("Segoe UI", 10F);
            cmbFacility.ForeColor = Color.FromArgb(60, 60, 60);
            cmbFacility.HoveredItemBackColor = Color.FromArgb(240, 240, 240);
            cmbFacility.HoveredItemTextColor = Color.FromArgb(30, 30, 30);
            cmbFacility.IsReadonly = false;
            cmbFacility.ItemHeight = 30;
            cmbFacility.Location = new Point(52, 162);
            cmbFacility.MaxDropDownItems = 8;
            cmbFacility.Name = "cmbFacility";
            cmbFacility.NotFoundBackColor = Color.Transparent;
            cmbFacility.NotFoundFont = null;
            cmbFacility.NotFoundTextColor = Color.Gray;
            cmbFacility.PlaceholderColor = Color.FromArgb(128, 128, 128);
            cmbFacility.PlaceholderDisappearsOnFocus = false;
            cmbFacility.PlaceholderText = "Clinic";
            cmbFacility.SearchTextColor = Color.FromArgb(0, 0, 0);
            cmbFacility.SearchTextFont = null;
            cmbFacility.SelectedIndex = -1;
            cmbFacility.SelectedItem = null;
            cmbFacility.SelectedItemBackColor = Color.FromArgb(230, 240, 250);
            cmbFacility.SelectedItemTextColor = Color.FromArgb(30, 30, 30);
            cmbFacility.SelectedValue = null;
            cmbFacility.Size = new Size(420, 49);
            cmbFacility.TabIndex = 25;
            cmbFacility.UnselectedItemTextColor = Color.FromArgb(60, 60, 60);
            cmbFacility.ValueMember = null;
            // 
            // siticoneLabel4
            // 
            siticoneLabel4.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel4.ForeColor = Color.Black;
            siticoneLabel4.Location = new Point(50, 12);
            siticoneLabel4.Name = "siticoneLabel4";
            siticoneLabel4.Size = new Size(382, 69);
            siticoneLabel4.TabIndex = 26;
            siticoneLabel4.Text = "Book appointment";
            siticoneLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbPurpose
            // 
            cmbPurpose.AllowMultipleSelection = false;
            cmbPurpose.BackColor = Color.FromArgb(255, 255, 255);
            cmbPurpose.BorderColor = Color.FromArgb(210, 210, 210);
            cmbPurpose.BorderSize = 2;
            cmbPurpose.CanBeep = false;
            cmbPurpose.CanShake = true;
            cmbPurpose.CornerRadius = 10;
            cmbPurpose.DataSource = null;
            cmbPurpose.DisplayMember = null;
            cmbPurpose.DropdownBackColor = Color.FromArgb(255, 255, 255);
            cmbPurpose.DropdownWidth = 0;
            cmbPurpose.DropShadowEnabled = false;
            cmbPurpose.Font = new Font("Segoe UI", 10F);
            cmbPurpose.ForeColor = Color.FromArgb(60, 60, 60);
            cmbPurpose.HoveredItemBackColor = Color.FromArgb(240, 240, 240);
            cmbPurpose.HoveredItemTextColor = Color.FromArgb(30, 30, 30);
            cmbPurpose.IsReadonly = false;
            cmbPurpose.ItemHeight = 30;
            cmbPurpose.Location = new Point(52, 251);
            cmbPurpose.MaxDropDownItems = 8;
            cmbPurpose.Name = "cmbPurpose";
            cmbPurpose.NotFoundBackColor = Color.Transparent;
            cmbPurpose.NotFoundFont = null;
            cmbPurpose.NotFoundTextColor = Color.Gray;
            cmbPurpose.PlaceholderColor = Color.FromArgb(128, 128, 128);
            cmbPurpose.PlaceholderDisappearsOnFocus = false;
            cmbPurpose.PlaceholderText = "Purpose";
            cmbPurpose.SearchTextColor = Color.FromArgb(0, 0, 0);
            cmbPurpose.SearchTextFont = null;
            cmbPurpose.SelectedIndex = -1;
            cmbPurpose.SelectedItem = null;
            cmbPurpose.SelectedItemBackColor = Color.FromArgb(230, 240, 250);
            cmbPurpose.SelectedItemTextColor = Color.FromArgb(30, 30, 30);
            cmbPurpose.SelectedValue = null;
            cmbPurpose.Size = new Size(420, 49);
            cmbPurpose.TabIndex = 27;
            cmbPurpose.UnselectedItemTextColor = Color.FromArgb(60, 60, 60);
            cmbPurpose.ValueMember = null;
            // 
            // txtSymptoms
            // 
            txtSymptoms.AccessibleDescription = "A customizable text input field.";
            txtSymptoms.AccessibleName = "Text Box";
            txtSymptoms.AccessibleRole = AccessibleRole.Text;
            txtSymptoms.BorderColor1 = Color.FromArgb(210, 210, 210);
            txtSymptoms.BorderColor2 = Color.FromArgb(210, 210, 210);
            txtSymptoms.BorderFocusColor1 = Color.FromArgb(33, 150, 243);
            txtSymptoms.BorderFocusColor2 = Color.FromArgb(33, 150, 243);
            txtSymptoms.BorderSize = 2;
            txtSymptoms.ClearButtonColor = Color.FromArgb(140, 140, 140);
            txtSymptoms.ClearButtonHoverColor = Color.FromArgb(70, 70, 70);
            txtSymptoms.CornerRadiusBottomLeft = 10;
            txtSymptoms.CornerRadiusBottomRight = 10;
            txtSymptoms.CornerRadiusTopLeft = 10;
            txtSymptoms.CornerRadiusTopRight = 10;
            txtSymptoms.CursorColor = Color.FromArgb(32, 32, 32);
            txtSymptoms.DisabledBackColor = Color.WhiteSmoke;
            txtSymptoms.DisabledBorderColor = Color.LightGray;
            txtSymptoms.DisabledTextColor = Color.Gray;
            txtSymptoms.FillColor1 = Color.White;
            txtSymptoms.FillColor2 = Color.White;
            txtSymptoms.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSymptoms.ForeColor = Color.Black;
            txtSymptoms.HoverBorderColor1 = Color.Gray;
            txtSymptoms.HoverBorderColor2 = Color.Gray;
            txtSymptoms.InactiveSelectionBackColor = Color.FromArgb(205, 205, 205);
            txtSymptoms.InactiveSelectionForeColor = Color.FromArgb(40, 40, 40);
            txtSymptoms.InvalidBorderColor = Color.FromArgb(220, 53, 69);
            txtSymptoms.Location = new Point(52, 343);
            txtSymptoms.Name = "txtSymptoms";
            txtSymptoms.PlaceholderColor = Color.Gray;
            txtSymptoms.PlaceholderText = "Describe your symptoms";
            txtSymptoms.ReadOnlyBorderColor1 = Color.LightGray;
            txtSymptoms.ReadOnlyBorderColor2 = Color.LightGray;
            txtSymptoms.ReadOnlyFillColor1 = Color.WhiteSmoke;
            txtSymptoms.ReadOnlyFillColor2 = Color.WhiteSmoke;
            txtSymptoms.ReadOnlyPlaceholderColor = Color.DarkGray;
            txtSymptoms.ReadOnlyTextColor = Color.Empty;
            txtSymptoms.SelectionBackColor = Color.FromArgb(77, 77, 255);
            txtSymptoms.SelectionForeColor = SystemColors.HighlightText;
            txtSymptoms.ShadowColor = Color.FromArgb(30, 0, 100, 200);
            txtSymptoms.Size = new Size(420, 50);
            txtSymptoms.SolidBorderColor = Color.FromArgb(210, 210, 210);
            txtSymptoms.SolidBorderFocusColor = Color.FromArgb(33, 150, 243);
            txtSymptoms.SolidBorderHoverColor = Color.Gray;
            txtSymptoms.SolidFillColor = Color.White;
            txtSymptoms.TabIndex = 29;
            // 
            // dtpDate
            // 
            dtpDate.AutoScaleFonts = true;
            dtpDate.BackColor = Color.Transparent;
            dtpDate.BaseCalendarFormSize = new Size(535, 460);
            dtpDate.BorderColor = Color.FromArgb(210, 210, 210);
            dtpDate.BorderWidth = 2;
            dtpDate.BottomLeftBorderRadius = 8;
            dtpDate.BottomRightBorderRadius = 8;
            dtpDate.CalendarBackgroundColor = Color.White;
            dtpDate.CalendarChevronColor = Color.Gray;
            dtpDate.CalendarChevronHoverColor = Color.Blue;
            dtpDate.CalendarDayButtonBackColor = Color.White;
            dtpDate.CalendarDayButtonForeColor = Color.Black;
            dtpDate.CalendarDayHeaderBackColor = Color.White;
            dtpDate.CalendarDayHeaderForeColor = Color.FromArgb(100, 100, 100);
            dtpDate.CalendarDayLabelFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            dtpDate.CalendarDisabledDateBackColor = Color.LightGray;
            dtpDate.CalendarDisabledDateForeColor = Color.DarkGray;
            dtpDate.CalendarFormAnimationSpeed = 15;
            dtpDate.CalendarFormAnimationStep = 0.08D;
            dtpDate.CalendarFormBackColor = Color.White;
            dtpDate.CalendarFormBorderColor = Color.FromArgb(220, 220, 220);
            dtpDate.CalendarFormBorderWidth = 2;
            dtpDate.CalendarFormCornerRadius = 2;
            dtpDate.CalendarFormFadeOutStep = 0.1D;
            dtpDate.CalendarFormHeight = 460;
            dtpDate.CalendarFormShadowColor = Color.FromArgb(50, 0, 0, 0);
            dtpDate.CalendarFormShadowDepth = 5;
            dtpDate.CalendarFormWidth = 535;
            dtpDate.CalendarGridMargin = new Padding(8);
            dtpDate.CalendarGridPadding = new Padding(5);
            dtpDate.CalendarLockedDateBackColor = Color.LightGray;
            dtpDate.CalendarLockedDateForeColor = Color.DarkGray;
            dtpDate.CalendarLockedDates = (List<DateTime>)resources.GetObject("dtpDate.CalendarLockedDates");
            dtpDate.CalendarMargin = 5;
            dtpDate.CalendarMaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDate.CalendarMaxYear = 2126;
            dtpDate.CalendarMinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDate.CalendarMinYear = 1926;
            dtpDate.CalendarRangeDateBackColor = Color.LightBlue;
            dtpDate.CalendarRangeEndDateBackColor = Color.DodgerBlue;
            dtpDate.CalendarRangeSelectedForeColor = Color.Black;
            dtpDate.CalendarRangeStartDateBackColor = Color.DodgerBlue;
            dtpDate.CalendarSelectedDateBackColor = Color.Black;
            dtpDate.CalendarSelectedDateForeColor = Color.White;
            dtpDate.CalendarSelectionMode = SiticoneNetCoreUI.SelectionMode.Single;
            dtpDate.CalendarTodayBackColor = Color.White;
            dtpDate.CalendarTodayForeColor = Color.Black;
            dtpDate.CalendarYearPickerHeight = 10;
            dtpDate.CanBeep = true;
            dtpDate.CanShake = true;
            dtpDate.ChevronColor = Color.Gray;
            dtpDate.ChevronHoverBackColor = Color.FromArgb(220, 225, 245);
            dtpDate.ChevronHoverColor = Color.Black;
            dtpDate.ChevronPanelBorderRadius = 0;
            dtpDate.ChevronPanelHeight = 32;
            dtpDate.ChevronPenThickness = 1.8F;
            dtpDate.ChevronRightMargin = 18;
            dtpDate.ChevronSize = new Size(9, 14);
            dtpDate.ChevronStep = 15F;
            dtpDate.ChevronTimerInterval = 15;
            dtpDate.ClearIconColor = Color.Gray;
            dtpDate.ClearIconHoverColor = Color.Red;
            dtpDate.ClearIconRightMargin = 48;
            dtpDate.ClearIconSize = 11;
            dtpDate.ContainerPanelMargin = new Padding(5);
            dtpDate.ContainerPanelPadding = new Padding(0);
            dtpDate.CustomDateFormat = "d";
            dtpDate.CustomDateFormatter = null;
            dtpDate.DateFormat = DateFormat.LongDate;
            dtpDate.DayButtonBorderRadius = 0;
            dtpDate.DayButtonClickBackColor = Color.FromArgb(220, 230, 250);
            dtpDate.DayButtonFont = new Font("Segoe UI", 10.5F);
            dtpDate.DayButtonHoverBackColor = Color.FromArgb(235, 240, 255);
            dtpDate.DayButtonHoverForeColor = Color.Black;
            dtpDate.DayButtonMargin = new Padding(3);
            dtpDate.DayButtonRowHeight = 16.66F;
            dtpDate.DayHeaderFont = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dtpDate.DayHeaderForeColor = Color.FromArgb(100, 100, 100);
            dtpDate.DayHeaderMargin = new Padding(1, 1, 1, 8);
            dtpDate.DayHeaderRowHeight = 30F;
            dtpDate.DisabledDayFont = new Font("Segoe UI", 10F, FontStyle.Italic);
            dtpDate.DropdownBackColor = Color.White;
            dtpDate.DropdownFont = new Font("Segoe UI", 11F);
            dtpDate.DropdownHeight = 250;
            dtpDate.FillColor = Color.White;
            dtpDate.FirstDayOfWeek = DayOfWeek.Sunday;
            dtpDate.Font = new Font("Segoe UI", 10F);
            dtpDate.ForeColor = Color.DimGray;
            dtpDate.GradientEndColor = Color.Gray;
            dtpDate.GradientStartColor = Color.White;
            dtpDate.HighlightWeekends = true;
            dtpDate.IconSize = 16;
            dtpDate.IsReadonly = false;
            dtpDate.Location = new Point(52, 439);
            dtpDate.LockedDates = (List<DateTime>)resources.GetObject("dtpDate.LockedDates");
            dtpDate.MakeRadial = false;
            dtpDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpDate.MaxFontScale = 1.8F;
            dtpDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpDate.MinFontScale = 0.4F;
            dtpDate.MinimumFormSize = new Size(150, 150);
            dtpDate.MonthChevronPanelMargin = new Padding(4, 17, 4, 0);
            dtpDate.MonthChevronSpacing = 5;
            dtpDate.MonthComboBoxMargin = new Padding(0, 17, 5, 0);
            dtpDate.MonthComboBoxSize = new Size(130, 30);
            dtpDate.Name = "dtpDate";
            dtpDate.NavigationFlowPadding = new Padding(12, 0, 12, 0);
            dtpDate.NavigationPanelBackColor = Color.FromArgb(245, 245, 250);
            dtpDate.NavigationPanelHeight = 65;
            dtpDate.NextMonthPanelWidth = 34;
            dtpDate.NextYearPanelWidth = 40;
            dtpDate.PlaceholderText = "Date";
            dtpDate.PrevMonthPanelWidth = 34;
            dtpDate.PrevYearPanelWidth = 40;
            dtpDate.RangeStartEndCornerRadius = 0;
            dtpDate.ReadonlyBorderColor = Color.Gray;
            dtpDate.ReadonlyFillColor = Color.LightGray;
            dtpDate.ReadOnlyForeColor = Color.DarkGray;
            dtpDate.ReadonlyPlaceHolderColor = Color.DarkGray;
            dtpDate.SelectedDate = null;
            dtpDate.SelectedDateBorderColor = Color.Black;
            dtpDate.SelectedDateBorderThickness = 1F;
            dtpDate.SelectedDates = (List<DateTime>)resources.GetObject("dtpDate.SelectedDates");
            dtpDate.SelectionMode = SiticoneNetCoreUI.SelectionMode.Single;
            dtpDate.ShakeAmplitude = 4;
            dtpDate.ShakeTimerInterval = 30;
            dtpDate.ShakeTotalShakes = 8;
            dtpDate.ShowClearButton = true;
            dtpDate.ShowMonthYearNavigation = true;
            dtpDate.ShowTodayButton = true;
            dtpDate.Size = new Size(420, 54);
            dtpDate.TabIndex = 30;
            dtpDate.Text = "siticoneDateTimePicker1";
            dtpDate.TodayBorderColor = Color.Black;
            dtpDate.TodayBorderThickness = 2F;
            dtpDate.TodayButtonBackColor = Color.Black;
            dtpDate.TodayButtonBorderRadius = 0;
            dtpDate.TodayButtonClickBackColor = Color.Black;
            dtpDate.TodayButtonFont = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dtpDate.TodayButtonForeColor = Color.White;
            dtpDate.TodayButtonHoverBackColor = Color.FromArgb(64, 64, 64);
            dtpDate.TodayButtonMargin = new Padding(0, 17, 15, 0);
            dtpDate.TodayButtonSize = new Size(70, 35);
            dtpDate.TodayButtonText = "Today";
            dtpDate.TodayTextColor = Color.Black;
            dtpDate.TodayTextFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            dtpDate.TopLeftBorderRadius = 8;
            dtpDate.TopRightBorderRadius = 8;
            dtpDate.UseCalendarFormAnimation = true;
            dtpDate.UseCalendarFormShadow = true;
            dtpDate.UseChevronAnimation = true;
            dtpDate.UseGradientFill = false;
            dtpDate.Value = null;
            dtpDate.WeekendDayBackColor = Color.FromArgb(250, 250, 250);
            dtpDate.WeekendDayForeColor = Color.FromArgb(180, 0, 0);
            dtpDate.YearChevronPanelMargin = new Padding(4, 17, 4, 0);
            dtpDate.YearChevronSpacing = 1;
            dtpDate.YearComboBoxMargin = new Padding(5, 17, 0, 0);
            dtpDate.YearComboBoxSize = new Size(90, 30);
            // 
            // flpSlots
            // 
            flpSlots.AutoScroll = true;
            flpSlots.Location = new Point(56, 563);
            flpSlots.Name = "flpSlots";
            flpSlots.Size = new Size(431, 162);
            flpSlots.TabIndex = 31;
            // 
            // lblNoSlots
            // 
            lblNoSlots.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoSlots.ForeColor = Color.Black;
            lblNoSlots.Location = new Point(52, 567);
            lblNoSlots.Name = "lblNoSlots";
            lblNoSlots.Size = new Size(420, 60);
            lblNoSlots.TabIndex = 34;
            lblNoSlots.Text = "No slots available.\r\nTry another date or facility\r\n.";
            lblNoSlots.TextAlign = ContentAlignment.MiddleCenter;
            lblNoSlots.Visible = false;
            // 
            // siticoneLabel1
            // 
            siticoneLabel1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel1.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel1.Location = new Point(56, 509);
            siticoneLabel1.Name = "siticoneLabel1";
            siticoneLabel1.Size = new Size(420, 41);
            siticoneLabel1.TabIndex = 35;
            siticoneLabel1.Text = "Slot ";
            siticoneLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRequest
            // 
            btnRequest.BackColor = Color.Transparent;
            btnRequest.BadgeBackColor = Color.Red;
            btnRequest.BadgeForeColor = Color.White;
            btnRequest.BadgeRadius = 8;
            btnRequest.BadgeRightMargin = 10;
            btnRequest.BadgeValue = 0;
            btnRequest.BorderColor = Color.FromArgb(150, 255, 255, 255);
            btnRequest.BorderColorEnd = Color.Gray;
            btnRequest.BorderColorStart = Color.White;
            btnRequest.BorderRadiusBottomLeft = 35;
            btnRequest.BorderRadiusBottomRight = 35;
            btnRequest.BorderRadiusTopLeft = 35;
            btnRequest.BorderRadiusTopRight = 35;
            btnRequest.BorderThickness = 1;
            btnRequest.ButtonColorEnd = Color.FromArgb(15, 76, 76);
            btnRequest.ButtonColorStart = Color.FromArgb(15, 76, 76);
            btnRequest.ButtonImage = null;
            btnRequest.CanBeep = false;
            btnRequest.CanShake = false;
            btnRequest.ClickSoundPath = null;
            btnRequest.DisabledOverlayOpacity = 0.5F;
            btnRequest.EnableBorderGradient = false;
            btnRequest.EnableClickSound = false;
            btnRequest.EnableFocusBorder = false;
            btnRequest.EnableHoverSound = false;
            btnRequest.EnablePressScale = false;
            btnRequest.EnableTextShadow = false;
            btnRequest.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btnRequest.FocusBorderThickness = 2;
            btnRequest.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRequest.ForeColor = Color.White;
            btnRequest.HoverColor = Color.FromArgb(78, 127, 122);
            btnRequest.HoverSoundPath = null;
            btnRequest.HoverTransitionSpeed = 0.08F;
            btnRequest.ImageAlign = ContentAlignment.MiddleLeft;
            btnRequest.ImageLeftMargin = 5;
            btnRequest.ImageRightMargin = 8;
            btnRequest.ImageSize = 24;
            btnRequest.IsReadOnly = false;
            btnRequest.Location = new Point(52, 755);
            btnRequest.MakeRadial = false;
            btnRequest.Name = "btnRequest";
            btnRequest.PressAnimationSpeed = 0.2F;
            btnRequest.PressDepth = 1;
            btnRequest.RippleColor = Color.FromArgb(231, 243, 239);
            btnRequest.RippleExpandSpeedFactor = 0.05F;
            btnRequest.RippleFadeSpeedFactor = 0.03F;
            btnRequest.ShadowBlurFactor = 0.85F;
            btnRequest.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btnRequest.ShadowOffsetX = 3;
            btnRequest.ShadowOffsetY = 3;
            btnRequest.Size = new Size(420, 71);
            btnRequest.TabIndex = 36;
            btnRequest.Text = "Confirm Booking";
            btnRequest.TextAlign = ContentAlignment.MiddleCenter;
            btnRequest.TextPaddingBottom = 0;
            btnRequest.TextPaddingLeft = 0;
            btnRequest.TextPaddingRight = 0;
            btnRequest.TextPaddingTop = 0;
            btnRequest.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btnRequest.TextShadowOffsetX = 1;
            btnRequest.TextShadowOffsetY = 1;
            btnRequest.Click += btnRequest_Click;
            // 
            // siticoneLabel10
            // 
            siticoneLabel10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel10.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel10.Location = new Point(56, 133);
            siticoneLabel10.Name = "siticoneLabel10";
            siticoneLabel10.Size = new Size(160, 26);
            siticoneLabel10.TabIndex = 89;
            siticoneLabel10.Text = "Health Facility";
            // 
            // siticoneLabel2
            // 
            siticoneLabel2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel2.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel2.Location = new Point(56, 225);
            siticoneLabel2.Name = "siticoneLabel2";
            siticoneLabel2.Size = new Size(160, 26);
            siticoneLabel2.TabIndex = 90;
            siticoneLabel2.Text = "Purpose";
            // 
            // siticoneLabel3
            // 
            siticoneLabel3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel3.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel3.Location = new Point(56, 317);
            siticoneLabel3.Name = "siticoneLabel3";
            siticoneLabel3.Size = new Size(160, 26);
            siticoneLabel3.TabIndex = 91;
            siticoneLabel3.Text = "Symptoms (if any)";
            // 
            // siticoneLabel5
            // 
            siticoneLabel5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            siticoneLabel5.ForeColor = Color.FromArgb(15, 76, 76);
            siticoneLabel5.Location = new Point(56, 412);
            siticoneLabel5.Name = "siticoneLabel5";
            siticoneLabel5.Size = new Size(160, 26);
            siticoneLabel5.TabIndex = 92;
            siticoneLabel5.Text = "Date";
            // 
            // lblFor
            // 
            lblFor.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFor.ForeColor = Color.Gray;
            lblFor.Location = new Point(56, 81);
            lblFor.Name = "lblFor";
            lblFor.Size = new Size(160, 26);
            lblFor.TabIndex = 93;
            lblFor.Text = "For child's name";
            // 
            // BookAppointmentScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblFor);
            Controls.Add(siticoneLabel5);
            Controls.Add(siticoneLabel3);
            Controls.Add(siticoneLabel2);
            Controls.Add(siticoneLabel10);
            Controls.Add(btnRequest);
            Controls.Add(siticoneLabel1);
            Controls.Add(lblNoSlots);
            Controls.Add(flpSlots);
            Controls.Add(dtpDate);
            Controls.Add(txtSymptoms);
            Controls.Add(cmbPurpose);
            Controls.Add(siticoneLabel4);
            Controls.Add(cmbFacility);
            Controls.Add(btnBack);
            Name = "BookAppointmentScreen";
            Size = new Size(540, 872);
            ResumeLayout(false);
        }

        #endregion

        private SiticoneNavBackButton btnBack;
        private SiticoneDropdown cmbFacility;
        private SiticoneLabel siticoneLabel4;
        private SiticoneDropdown cmbPurpose;
        private SiticoneTextArea siticoneTextArea1;
        private SiticoneTextBox txtSymptoms;
        private SiticoneDateTimePicker dtpDate;
        private FlowLayoutPanel flpSlots;
        private SiticoneLabel lblNoSlots;
        private SiticoneLabel siticoneLabel1;
        private SiticoneButtonAdvanced btnRequest;
        private SiticoneLabel siticoneLabel10;
        private SiticoneLabel siticoneLabel2;
        private SiticoneLabel siticoneLabel3;
        private SiticoneLabel siticoneLabel5;
        private SiticoneLabel lblFor;
    }
}
