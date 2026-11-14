namespace medicord_v1.Screens.Patient;

public class NearbyFacilitiesScreen : UserControl, IOwnScroll
{
    public event Action<int>? FacilityClicked;

    private readonly SiticoneTextBox txtSearch = new();
    private readonly FlowLayoutPanel flowList = new();
    private DataTable all = new();
    private const int Side = 28;

    public NearbyFacilitiesScreen()
    {
        Size = new Size(390, 780);
        BackColor = Theme.Page;

        var head = new Panel { Dock = DockStyle.Top, Height = 148, BackColor = Theme.Page };
        var lblTitle = DepUi.Text("Nearby facilities", 16, FontStyle.Bold, Theme.Ink, Side, 18, 300, 36, Theme.Page);
        var lblSub = DepUi.Text("Closest to your city first", 9.5f, FontStyle.Regular, Theme.Muted, Side, 60, 300, 22, Theme.Page);
        txtSearch.SetBounds(Side, 92, 300, 40);
        Theme.Field(txtSearch);
        txtSearch.PlaceholderText = "Search by name, city or state";
        head.Controls.AddRange(new Control[] { lblTitle, lblSub, txtSearch });

        head.Resize += (_, _) =>
        {
            int w = Math.Max(120, head.ClientSize.Width - Side * 2);
            lblTitle.Width = lblSub.Width = txtSearch.Width = w;
        };

        flowList.Dock = DockStyle.Fill;
        flowList.FlowDirection = FlowDirection.TopDown;
        flowList.WrapContents = false;
        flowList.AutoScroll = true;
        flowList.BackColor = Theme.Page;
        flowList.Padding = new Padding(Side, 4, 0, 16);

        Controls.Add(flowList);      // fill first, header last
        Controls.Add(head);

        txtSearch.TextChanged += (_, _) => Render();
        flowList.Resize += (_, _) => { int w = CardWidth(); foreach (Control c in flowList.Controls) c.Width = w; };

        try { all = FacilityDirectoryService.GetNearby(); }
        catch (SqlException ex) { Msg.Error("Could not load facilities.\n" + ex.Message); }
        Render();
    }

    private int CardWidth() => Math.Max(200, flowList.ClientSize.Width - Side * 2);

    private void Render()
    {
        var view = all.DefaultView;
        string q = txtSearch.Text.Trim();
        if (q != "")
        {
            string e = TableFilter.EscapeLike(q);
            view.RowFilter = $"[FacilityName] LIKE '%{e}%' OR [City] LIKE '%{e}%' OR [State] LIKE '%{e}%'";
        }
        else view.RowFilter = "";

        flowList.SuspendLayout();
        foreach (Control c in flowList.Controls.Cast<Control>().ToList()) { flowList.Controls.Remove(c); c.Dispose(); }

        if (view.Count == 0)
        {
            flowList.Controls.Add(new Label
            {
                Text = q == "" ? "No health facilities yet" : $"No facilities match \"{q}\"",
                Width = CardWidth(),
                Height = 80,
                Margin = new Padding(0, 40, 0, 0),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 11f),
                ForeColor = Theme.Muted,
                BackColor = Theme.Page
            });
        }
        else foreach (DataRowView rv in view) flowList.Controls.Add(MakeCard(rv.Row));
        flowList.ResumeLayout();
    }

    private static string T(object v) => v is TimeSpan ts ? DateTime.Today.Add(ts).ToString("h:mm tt") : "";

    private Control MakeCard(DataRow r)
    {
        int id = Convert.ToInt32(r["FacilityID"]);
        string name = r["FacilityName"].ToString() ?? "";
        int prox = Convert.ToInt32(r["Proximity"]);
        string where = $"{r["City"]}, {r["State"]}" + (prox == 0 ? " · Your city" : prox == 1 ? " · Your state" : "");
        string hours = r["OpenTime"] is DBNull ? "" : $" · {T(r["OpenTime"])} - {T(r["CloseTime"])}";

        var card = new SiticonePanel { Width = CardWidth(), Height = 96, Margin = new Padding(0, 0, 0, 12) };
        Theme.Card(card);

        var pic = new PictureBox
        {
            Left = 14,
            Top = 20,
            Width = 56,
            Height = 56,
            SizeMode = PictureBoxSizeMode.Zoom,
            BackColor = Color.White,
            Image = DepUi.Avatar(r["ProfilePhoto"] as byte[], name, 56)
        };

        Label L(string text, int top, float size, FontStyle style, Color color) => new Label
        {
            Text = text,
            Left = 82,
            Top = top,
            Width = card.Width - 82 - 40,
            Height = 22,
            AutoSize = false,
            AutoEllipsis = true,
            Font = new Font("Segoe UI", size, style),
            ForeColor = color,
            BackColor = Color.White,
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
        };
        var l1 = L(name, 14, 11f, FontStyle.Bold, Theme.Ink);
        var l2 = L(where, 40, 9.5f, FontStyle.Regular, Theme.Muted);
        var l3 = L(r["Category"] + hours, 64, 9.5f, FontStyle.Regular, Theme.Primary);

        var chev = new Label
        {
            Text = "\uE76C",
            Font = new Font("Segoe MDL2 Assets", 11f),
            ForeColor = Theme.Muted,
            BackColor = Color.White,
            Left = card.Width - 34,
            Top = 34,
            Width = 22,
            Height = 26,
            AutoSize = false,
            TextAlign = ContentAlignment.MiddleCenter,
            Anchor = AnchorStyles.Top | AnchorStyles.Right
        };

        card.Controls.AddRange(new Control[] { pic, l1, l2, l3, chev });
        foreach (Control c in new Control[] { card, pic, l1, l2, l3, chev })
        { c.Cursor = Cursors.Hand; c.Click += (_, _) => FacilityClicked?.Invoke(id); }
        return card;
    }
}