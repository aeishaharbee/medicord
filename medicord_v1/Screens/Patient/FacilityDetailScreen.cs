namespace medicord_v1.Screens.Patient;

public class FacilityDetailScreen : DepPage
{
    public event Action<int>? BookClicked;

    private static readonly string[] DayNames = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    private readonly int facilityId;

    public FacilityDetailScreen(int facilityId) : base("Facility")
    {
        this.facilityId = facilityId;
        DataRow? r = null; HashSet<int> days = new();
        try { r = FacilityDirectoryService.GetDetail(facilityId); days = FacilityDirectoryService.GetOpenDays(facilityId); }
        catch (SqlException ex) { Msg.Error("Could not load this facility.\n" + ex.Message); }
        if (r == null) { OnBack(); return; }
        Build(r, days);
    }

    private static string T(TimeSpan? ts) => ts == null ? "" : DateTime.Today.Add(ts.Value).ToString("h:mm tt");
    private static TimeSpan? Ts(object v) => v is TimeSpan t ? t : null;
    private static string S(object v) => v is DBNull ? "" : Convert.ToString(v) ?? "";

    private SiticonePanel NewCard(int height)
    {
        var c = new SiticonePanel { Height = height };
        Theme.Card(c);
        return c;
    }

    private SiticonePanel TextCard(string text)
    {
        var font = new Font("Segoe UI", 10.5f);
        int h = TextRenderer.MeasureText(text, font, new Size(290, 0), TextFormatFlags.WordBreak).Height + 32;
        var card = NewCard(h);
        var l = new Label
        {
            Text = text,
            Left = 16,
            Top = 16,
            Width = 290,
            Height = h - 32,
            AutoSize = false,
            Font = font,
            ForeColor = Theme.Ink,
            BackColor = Color.White
        };
        card.Controls.Add(l);
        card.SizeChanged += (_, _) => l.Width = Math.Max(40, card.Width - 32);
        return card;
    
    }

    private void Build(DataRow r, HashSet<int> days)
    {
        string name = S(r["FacilityName"]), category = S(r["Category"]);
        TimeSpan? open = Ts(r["OpenTime"]), close = Ts(r["CloseTime"]);
        int today = ((int)DateTime.Today.DayOfWeek + 6) % 7 + 1;        // Mon = 1 ... Sun = 7
        bool openNow = days.Contains(today) && open != null && close != null
                       && DateTime.Now.TimeOfDay >= open && DateTime.Now.TimeOfDay < close;

        Add(new Panel { Height = 4, BackColor = Color.Transparent }, 0);
        AddCentered(new PictureBox
        {
            Width = 112,
            Height = 112,
            SizeMode = PictureBoxSizeMode.Zoom,
            Image = DepUi.Avatar(r["ProfilePhoto"] as byte[], name, 112),
            BackColor = Color.Transparent
        }, 12);
        AddLabel(name, 16, FontStyle.Bold, Theme.Ink, 30, ContentAlignment.MiddleCenter, 4);
        if (category != "") AddCentered(DepUi.Tag(category, 0, 0), 6);
        AddLabel($"{S(r["City"])}, {S(r["State"])}", 10, FontStyle.Regular, Theme.Muted, 22, ContentAlignment.MiddleCenter, 2);
        var status = AddLabel(openNow ? $"Open now · closes {T(close)}" : "Closed now", 10, FontStyle.Bold,
                              openNow ? Theme.Primary : DepUi.Danger, 22, ContentAlignment.MiddleCenter, 16);

        var book = new SiticoneButton { Text = "Book an appointment", Height = 50 };
        Theme.PrimaryBtn(book);
        book.Click += (_, _) => BookClicked?.Invoke(facilityId);
        Add(book, 20);

        //about 
        string desc = S(r["Description"]);
        if (desc != "")
        {
            AddLabel("ABOUT", 8.5f, FontStyle.Bold, Theme.Muted, 18, after: 6);
            Add(TextCard(desc), 16);
        }

        //opening hours
        AddLabel("OPENING HOURS", 8.5f, FontStyle.Bold, Theme.Muted, 18, after: 6);
        const int rowH = 46;
        var hours = NewCard(7 * rowH + 8);
        var hourValues = new List<Label>();
        for (int i = 0; i < 7; i++)
        {
            int dayNo = i + 1; bool isToday = dayNo == today, isOpen = days.Contains(dayNo);
            int y = 4 + i * rowH;
            var style = isToday ? FontStyle.Bold : FontStyle.Regular;

            var dayLbl = DepUi.Text(DayNames[i], 10.5f, style, isToday ? Theme.Primary : Theme.Ink, 16, 0, 140, 0, Color.White);
            dayLbl.Top = y + (rowH - dayLbl.Height) / 2;

            var v = DepUi.Text(isOpen ? $"{T(open)} - {T(close)}" : "Closed", 10.5f, style,
                               isOpen ? (isToday ? Theme.Primary : Theme.Ink) : Theme.Muted, 160, 0, 100, 0, Color.White);
            v.TextAlign = ContentAlignment.MiddleRight;
            v.Top = y + (rowH - v.Height) / 2;

            hours.Controls.Add(dayLbl); hours.Controls.Add(v); hourValues.Add(v);
        }
        hours.SizeChanged += (_, _) => { foreach (var v in hourValues) v.Width = Math.Max(20, hours.Width - v.Left - 16); };
        Add(hours, 16);
        foreach (var v in hourValues) v.Width = Math.Max(20, hours.Width - v.Left - 16);

        //location 
        AddLabel("LOCATION", 8.5f, FontStyle.Bold, Theme.Muted, 18, after: 6);
        string addr = string.Join("\n", new[] { S(r["AddressLine"]), $"{S(r["Postcode"])} {S(r["City"])}, {S(r["State"])}".Trim() }.Where(s => s.Trim() != ""));
        Add(TextCard(addr == "" ? "Address not provided" : addr), 16);

        //details
        AddLabel("DETAILS", 8.5f, FontStyle.Bold, Theme.Muted, 18, after: 6);
        bool walkIn = r["WalkInAvailable"] is not DBNull && Convert.ToBoolean(r["WalkInAvailable"]);
        string slot = r["SlotDurationMin"] is DBNull ? "" : $"{r["SlotDurationMin"]} minutes";
        AddInfoCard(("Category", category), ("Phone", S(r["Phone"])), ("Walk-ins", walkIn ? "Welcome" : "Appointment only"),
            ("Appointment length", slot), ("Doctors", Convert.ToString(r["Doctors"]) ?? ""));
    }
}