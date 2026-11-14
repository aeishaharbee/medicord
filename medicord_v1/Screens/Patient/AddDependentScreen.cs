namespace medicord_v1.Screens.Patient;

public class AddDependentScreen : DepPage
{
    public event Action<int>? SwitchRequested;
    public event EventHandler? DoneClicked;

    private int step = 1;
    private string type = "";
    private SiticoneTextBox txtName = null!, txtId = null!;
    private SiticoneTextBox? txtOku;
    private TextBox? txtNotes;
    private SiticoneDateTimePicker dtp = null!;
    private Segmented segGender = null!;
    private SiticoneDropdown cmbIdType = null!;

    public AddDependentScreen() : base("Add a dependent") => ShowStep1();

    protected override void OnBack()
    {
        if (step == 2) ShowStep1();
        else if (step == 3) DoneClicked?.Invoke(this, EventArgs.Empty);
        else base.OnBack();
    }

    private void ShowStep1()
    {
        step = 1; type = ""; SetTitle("Add a dependent"); ClearBody();
        AddLabel("STEP 1 OF 2", 8.5f, FontStyle.Bold, Theme.Primary, 18, after: 2);
        AddLabel("Who are you adding?", 15, FontStyle.Bold, Theme.Ink, 30, after: 2);
        AddLabel("Choose the one that fits best.", 10, FontStyle.Regular, Theme.Muted, 22, after: 18);

        var opts = new[]
        {
            ("Child", "C", "Child", "Under 18 years old"),
            ("Senior", "S", "Parent or senior", "Warga emas"),
            ("OKU", "O", "OKU family member", "Person with a disability"),
            ("Other", "+", "Other", "Someone else you care for")
        };
        foreach (var (t, letter, title, sub) in opts)
        {
            var (back, fore) = DepUi.TagColors(t);
            var card = CardPanel(84);
            var tl = DepUi.Text(title, 11.5f, FontStyle.Bold, Theme.Ink, 76, 12, 200, 0, Color.White);
            var sl = DepUi.Text(sub, 9, FontStyle.Regular, Theme.Muted, 76, tl.Bottom + 2, 200, 0, Color.White);
            int h = Math.Max(sl.Bottom + 14, 84);
            card.Height = h;

            var ic = new Label
            {
                Text = letter,
                Left = 16,
                Top = (h - 44) / 2,
                Width = 44,
                Height = 44,
                BackColor = back,
                ForeColor = fore,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = DepUi.F(13, FontStyle.Bold)
            };
            DepUi.Round(ic, 22);
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
            foreach (Control c in new Control[] { ic, tl, sl, chev }) card.Controls.Add(c);
            card.SizeChanged += (_, _) => { chev.Left = card.Width - 34; tl.Width = sl.Width = Math.Max(40, card.Width - 76 - 44); };
            string chosen = t;
            DepUi.Tap(card, () => ShowStep2(chosen));
            Add(card, 12);
        }
    }

    private void ShowStep2(string t)
    {
        step = 2; type = t; SetTitle(DepUi.TypeLabel(t)); ClearBody();
        AddLabel("STEP 2 OF 2", 8.5f, FontStyle.Bold, Theme.Primary, 18, after: 2);
        AddLabel("Their details", 15, FontStyle.Bold, Theme.Ink, 30, after: 16);

        txtName = AddField("Full name (as on ID)");
        segGender = AddSegment("Gender", "Female", "Male");
        DateTime start = t == "Child" ? DateTime.Today.AddYears(-5) : t == "Senior" ? DateTime.Today.AddYears(-65) : DateTime.Today.AddYears(-30);
        dtp = AddDob(start);
        cmbIdType = AddCombo("ID type", "MyKid", "NRIC", "Passport");
        cmbIdType.SelectedIndex = t == "Child" ? 0 : 1;          // MyKid for a child, otherwise NRIC
        txtId = AddField("ID number");
        txtId.PlaceholderText = "e.g. 150312-14-0456";

        txtOku = null; txtNotes = null;
        if (t == "OKU")
        {
            txtOku = AddField("OKU card number (optional)");
            txtNotes = AddNotes("Care notes (optional)");
        }

        AddLabel("Your phone number and address are used for them automatically. You can change these later in their profile.",
                 9.5f, FontStyle.Regular, Theme.Muted, 40, after: 14);
        AddButton("Add dependent", true, 0).Click += (_, _) => Create();
    }

    private void Create()
    {
        string name = txtName.Text.Trim(), idNo = txtId.Text.Trim();
        string idType = cmbIdType.SelectedItem?.ToString() ?? "NRIC";
        DateTime dob = (dtp.Date ?? DateTime.Today).Date;

        if (name.Length < 2) { Msg.Warn("Enter the dependent's full name."); return; }
        if (dob > DateTime.Today) { Msg.Warn("The date of birth cannot be in the future."); return; }
        if (idNo == "") { Msg.Warn("Enter the ID number."); return; }
        if (idType is "NRIC" or "MyKid")
        {
            string digits = idNo.Replace("-", "").Replace(" ", "");
            if (digits.Length != 12 || !digits.All(char.IsDigit)) { Msg.Warn("An NRIC or MyKid number has 12 digits."); return; }
            idNo = digits;
        }
        if (type == "Child" && dob.AddYears(18) <= DateTime.Today) { Msg.Warn("A child must be under 18. Choose another type for an adult."); return; }

        int id;
        try
        {
            if (DependentService.IdNumberExists(idNo)) { Msg.Warn("Someone with this ID number is already in MediCord."); return; }
            id = DependentService.Add(name, type, dob, segGender.SelectedIndex == 0 ? "F" : "M", idType, idNo,
                                      txtOku?.Text.Trim() ?? "", txtNotes?.Text.Trim() ?? "");
        }
        catch (SqlException ex) { Msg.Error("Could not add the dependent.\n" + ex.Message); return; }

        ShowDone(id, name);
    }

    private void ShowDone(int id, string name)
    {
        step = 3; SetTitle("Added"); ClearBody();
        var ok = new Label
        {
            Text = "✓",
            Width = 84,
            Height = 84,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = DepUi.F(30, FontStyle.Bold),
            ForeColor = Color.White,
            BackColor = Theme.Primary
        };
        DepUi.Round(ok, 42);
        Add(new Panel { Height = 40, BackColor = Color.Transparent }, 0);
        AddCentered(ok, 16);
        AddLabel($"{name} added", 15, FontStyle.Bold, Theme.Ink, 30, ContentAlignment.MiddleCenter, 4);
        AddLabel("You can now book appointments and see records for them.", 10, FontStyle.Regular, Theme.Muted, 44, ContentAlignment.TopCenter, 24);

        string first = name.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
        AddButton($"Switch to {first}").Click += (_, _) => SwitchRequested?.Invoke(id);
        AddButton("Back to dependents", false, 0).Click += (_, _) => DoneClicked?.Invoke(this, EventArgs.Empty);
    }
}