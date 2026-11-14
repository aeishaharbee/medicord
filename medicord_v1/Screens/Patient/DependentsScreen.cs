namespace medicord_v1.Screens.Patient;

public class DependentsScreen : DepPage
{
    public event EventHandler? AddClicked;
    public event Action<int>? OpenClicked;

    public DependentsScreen() : base("Dependents") => LoadList();

    private void LoadList()
    {
        ClearBody();
        List<DependentInfo> list;
        try { list = DependentService.GetMine(); }
        catch (SqlException ex) { Msg.Error("Could not load dependents.\n" + ex.Message); list = new(); }

        if (list.Count == 0)
        {
            var (back, fore) = DepUi.TagColors("Self");
            var ring = new Label
            {
                Text = "+",
                Width = 84,
                Height = 84,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = DepUi.F(26, FontStyle.Bold),
                ForeColor = fore,
                BackColor = back
            };
            DepUi.Round(ring, 42);
            Add(new Panel { Height = 40, BackColor = Color.Transparent }, 0);
            AddCentered(ring, 16);
            AddLabel("No dependents yet", 14, FontStyle.Bold, Theme.Ink, 28, ContentAlignment.MiddleCenter, 4);
            AddLabel("Add a child, parent or family member to book appointments and view their records for them.",
                     10, FontStyle.Regular, Theme.Muted, 60, ContentAlignment.TopCenter, 20);
        }
        else
        {
            AddLabel(list.Count == 1 ? "1 dependent" : $"{list.Count} dependents", 10, FontStyle.Regular, Theme.Muted, 20, after: 8);
            foreach (var d in list) Add(MakeCard(d), 12);
        }

        AddButton("+  Add dependent", true, 0).Click += (_, _) => AddClicked?.Invoke(this, EventArgs.Empty);
    }

    private SiticonePanel MakeCard(DependentInfo d)
    {
        var card = CardPanel(100);
        var name = DepUi.Text(d.Name, 11.5f, FontStyle.Bold, Theme.Ink, 84, 14, 200, 0, Color.White);
        var tag = DepUi.Tag(d.Type, 84, name.Bottom + 8);
        var age = DepUi.Text(DepUi.Age(d.DateOfBirth), 9, FontStyle.Regular, Theme.Muted, 84 + tag.Width + 12, 0, 100, 0, Color.White);
        age.Top = tag.Top + (tag.Height - age.Height) / 2;

        int h = Math.Max(tag.Bottom + 16, 96);
        card.Height = h;

        var pic = new PictureBox
        {
            Left = 14,
            Top = (h - 56) / 2,
            Width = 56,
            Height = 56,
            SizeMode = PictureBoxSizeMode.Zoom,
            Image = DepUi.Avatar(d.Photo, d.Name, 56),
            BackColor = Color.White
        };
        var chev = new Label
        {
            Text = "\uE76C",
            Font = new Font("Segoe MDL2 Assets", 11f),
            ForeColor = Theme.Muted,
            BackColor = Color.White,
            Top = (h - 26) / 2,
            Width = 22,
            Height = 26,
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter
        };
        card.Controls.AddRange(new Control[] { pic, name, tag, age, chev });
        card.SizeChanged += (_, _) => { chev.Left = card.Width - 34; name.Width = Math.Max(40, card.Width - 84 - 44); };

        int id = d.ID;
        DepUi.Tap(card, () => OpenClicked?.Invoke(id));
        return card;
    }
}