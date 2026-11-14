namespace medicord_v1.Screens.Patient;

public class DependentDetailScreen : DepPage
{
    public event Action<int>? SwitchRequested;
    public event Action<int>? EditRequested;
    public event EventHandler? Removed;

    private readonly int id;

    public DependentDetailScreen(int id) : base("Dependent")
    {
        this.id = id;
        DependentInfo? d = null;
        try { d = DependentService.GetOne(id); }
        catch (SqlException ex) { Msg.Error("Could not load this dependent.\n" + ex.Message); }
        if (d == null) { OnBack(); return; }
        Build(d);
    }

    private void Build(DependentInfo d)
    {
        ClearBody();
        Add(new Panel { Height = 4, BackColor = Color.Transparent }, 0);
        AddCentered(new PictureBox
        {
            Width = 96,
            Height = 96,
            SizeMode = PictureBoxSizeMode.Zoom,
            Image = DepUi.Avatar(d.Photo, d.Name, 96),
            BackColor = Color.Transparent
        }, 10);
        AddLabel(d.Name, 16, FontStyle.Bold, Theme.Ink, 32, ContentAlignment.MiddleCenter, 4);
        AddCentered(DepUi.Tag(d.Type, 0, 0), 6);
        string gender = d.Gender == "F" ? "Female" : d.Gender == "M" ? "Male" : "";
        string sub = string.Join("  ·  ", new[] { DepUi.Age(d.DateOfBirth), gender }.Where(s => s != ""));
        AddLabel(sub, 10, FontStyle.Regular, Theme.Muted, 22, ContentAlignment.MiddleCenter, 20);

        AddLabel("PERSONAL", 8.5f, FontStyle.Bold, Theme.Muted, 18, after: 6);
        AddInfoCard(("Date of birth", d.DateOfBirth == null ? "" : $"{d.DateOfBirth:d MMM yyyy}"),
                    ("Gender", gender),
                    (d.IdType == "" ? "ID" : d.IdType, d.IdNumber));

        AddLabel("CONTACT", 8.5f, FontStyle.Bold, Theme.Muted, 18, after: 6);
        AddInfoCard(("Phone", d.Phone));

        if (d.Type == "OKU")
        {
            AddLabel("OKU", 8.5f, FontStyle.Bold, Theme.Muted, 18, after: 6);
            AddInfoCard(("OKU card no.", d.OkuCardNo));
            if (d.CareNotes != "")
            {
                var font = DepUi.F(10.5f);
                int h = TextRenderer.MeasureText(d.CareNotes, font, new Size(290, 0), TextFormatFlags.WordBreak).Height + 52;
                var card = CardPanel(h);
                card.Controls.Add(DepUi.Text("Care notes", 10, FontStyle.Regular, Theme.Muted, 16, 12, 200, 20, Color.White));
                var t = DepUi.Text(d.CareNotes, 10.5f, FontStyle.Regular, Theme.Ink, 16, 34, 290, h - 44, Color.White);
                t.AutoEllipsis = false;
                card.Controls.Add(t);
                card.SizeChanged += (_, _) => t.Width = Math.Max(40, card.Width - 32);
                Add(card, 16);
            }
        }

        string first = d.Name.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
        AddButton($"Switch to {first}").Click += (_, _) => SwitchRequested?.Invoke(id);
        AddButton("Edit details", false).Click += (_, _) => EditRequested?.Invoke(id);
        AddLink("Remove dependent", DepUi.Danger).Click += (_, _) =>
        {
            if (!Msg.Confirm($"Remove {d.Name}?\nTheir past appointments and records stay with the clinics, but you will no longer manage this profile.", "Remove dependent")) return;
            try { DependentService.Remove(id); }
            catch (SqlException ex) { Msg.Error("Could not remove.\n" + ex.Message); return; }
            Removed?.Invoke(this, EventArgs.Empty);
        };
    }
}