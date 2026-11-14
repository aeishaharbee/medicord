namespace medicord_v1.Screens.Patient;

public class SwitchProfileForm : Form
{
    public int SelectedID { get; private set; } = -1;     //0= own account
    public bool Manage { get; private set; }

    public SwitchProfileForm()
    {
        FormBorderStyle = FormBorderStyle.None; StartPosition = FormStartPosition.CenterParent;
        ShowInTaskbar = false; KeyPreview = true; BackColor = Color.White; Width = 350;
        KeyDown += (_, e) => { if (e.KeyCode == Keys.Escape) DialogResult = DialogResult.Cancel; };

        List<DependentInfo> deps;
        try { deps = DependentService.GetMine(); } catch (SqlException) { deps = new(); }

        Controls.Add(DepUi.Text("Switch profile", 13, FontStyle.Bold, Theme.Ink, 20, 16, 240, 30, Color.White));
        var x = DepUi.LinkBtn("✕", 350 - 56, 14, 40, Theme.Muted);
        x.Click += (_, _) => DialogResult = DialogResult.Cancel;
        Controls.Add(x);

        int y = 70;
        AddRow(0, DepUi.Avatar(DependentService.GetGuardianPhoto(), Session.FullName, 44), Session.FullName, "You", "Self", !Session.IsDependentMode, ref y);

        foreach (var d in deps)
            AddRow(d.ID, DepUi.Avatar(d.Photo, d.Name, 44), d.Name, DepUi.TypeLabel(d.Type), d.Type, Session.IsDependentMode && Session.PatientID == d.ID, ref y);

        var manage = DepUi.LinkBtn("Manage dependents", 16, y + 6, 318, Theme.Primary);
        manage.Click += (_, _) => { Manage = true; DialogResult = DialogResult.OK; };
        Controls.Add(manage);

        Height = y + 56;
        DepUi.Round(this, 18);
    }

    private void AddRow(int id, Image avatar, string name, string sub, string type, bool current, ref int y)
    {
        var nameLbl = DepUi.Text(name, 11, FontStyle.Bold, Theme.Ink, 60, 8, 210, 0, Color.White);
        var subLbl = DepUi.Text(sub, 9, FontStyle.Regular, Theme.Muted, 60, nameLbl.Bottom + 2, 210, 0, Color.White);
        int h = Math.Max(subLbl.Bottom + 8, 60);

        var row = new Panel { Left = 12, Top = y, Width = 326, Height = h, BackColor = Color.White };
        row.Controls.Add(new PictureBox
        {
            Left = 6,
            Top = (h - 44) / 2,
            Width = 44,
            Height = 44,
            Image = avatar,
            SizeMode = PictureBoxSizeMode.Zoom,
            BackColor = Color.White
        });
        row.Controls.Add(nameLbl);
        row.Controls.Add(subLbl);
        if (current)
            row.Controls.Add(DepUi.Text("✓", 13, FontStyle.Bold, Theme.Primary, 290, 0, 26, 0, Color.White));
        if (current) row.Controls[row.Controls.Count - 1].Top = (h - row.Controls[row.Controls.Count - 1].Height) / 2;

        DepUi.Tap(row, () => { SelectedID = id; DialogResult = DialogResult.OK; });
        Controls.Add(row);
        y += h + 4;
    }

    private void InitializeComponent()
    {

    }
}