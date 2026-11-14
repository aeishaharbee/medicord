namespace medicord_v1.Helpers;

public class ActingBanner : Panel
{
    public event EventHandler? MyAccountClicked;

    private readonly Label lbl;
    private readonly Button btn;

    public ActingBanner()
    {
        Dock = DockStyle.Top;
        Height = 46;
        BackColor = DepUi.Navy;
        Visible = false;

        lbl = new Label
        {
            AutoSize = false,
            AutoEllipsis = true,
            Left = 16,
            Top = 13,
            Height = 20,
            Font = new Font("Segoe UI", 9.5f),
            ForeColor = Color.White,
            BackColor = DepUi.Navy,
            TextAlign = ContentAlignment.MiddleLeft
        };

        btn = new Button
        {
            Text = "My account",
            Width = 102,
            Height = 28,
            Top = 9,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 9f, FontStyle.Bold),
            ForeColor = DepUi.Navy,
            BackColor = Color.White,
            Cursor = Cursors.Hand,
            UseVisualStyleBackColor = false
        };
        btn.FlatAppearance.BorderSize = 0;
        DepUi.Round(btn, 14);
        btn.Click += (_, _) => MyAccountClicked?.Invoke(this, EventArgs.Empty);

        Controls.Add(lbl);
        Controls.Add(btn);

        Resize += (_, _) => LayoutItems();  
        LayoutItems();
    }

    private void LayoutItems()
    {
        btn.Left = Width - btn.Width - 12;
        lbl.Width = Math.Max(40, btn.Left - 8 - lbl.Left);
    }

    public void Sync()
    {
        Visible = Session.IsDependentMode;
        lbl.Text = Session.IsDependentMode ? $"Acting as {Session.PatientName} · {Session.ActingType}" : "";
    }
}