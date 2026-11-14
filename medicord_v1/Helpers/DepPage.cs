using System.ComponentModel;

namespace medicord_v1.Helpers;

public class Segmented : Panel
{
    private readonly SiticoneButton[] btns;
    private int sel;
    public event EventHandler? Changed;
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int SelectedIndex { get => sel; set { sel = value; Restyle(); } }

    public Segmented(params string[] items)
    {
        Height = 46;
        BackColor = Color.Transparent;
        btns = new SiticoneButton[items.Length];
        for (int i = 0; i < items.Length; i++)
        {
            var b = new SiticoneButton { Text = items[i] };
            int idx = i;
            b.Click += (_, _) => { sel = idx; Restyle(); Changed?.Invoke(this, EventArgs.Empty); };
            btns[i] = b;
            Controls.Add(b);
        }
        Restyle();
        OnSizeChanged(EventArgs.Empty);
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        if (btns is null || btns.Length == 0) return;
        int gap = 8, w = (Width - gap * (btns.Length - 1)) / btns.Length;
        for (int i = 0; i < btns.Length; i++) btns[i].SetBounds(i * (w + gap), 0, w, Height);
    }

    private void Restyle() { for (int i = 0; i < btns.Length; i++) Theme.Tab(btns[i], i == sel); }
}

public class DepPage : UserControl, IOwnScroll
{
    public event EventHandler? BackClicked;
    protected readonly FlowLayoutPanel Flow = new()
    {
        Dock = DockStyle.Fill,
        FlowDirection = FlowDirection.TopDown,
        WrapContents = false,
        AutoScroll = true,
        BackColor = Theme.Page,
        Padding = new Padding(0, 0, 0, 24)
    };
    private readonly Label title;

    protected DepPage(string heading)
    {
        BackColor = Theme.Page;
        Size = new Size(390, 780);
        var head = new Panel { Dock = DockStyle.Top, Height = 60, BackColor = Theme.Page };

        var back = new Button
        {
            Text = "\uE72B",
            Font = new Font("Segoe MDL2 Assets", 12f),
            TextAlign = ContentAlignment.MiddleCenter,
            Left = 8,
            Top = 8,
            Width = 44,
            Height = 44,
            FlatStyle = FlatStyle.Flat,
            ForeColor = Theme.Ink,
            BackColor = Theme.Page,
            Cursor = Cursors.Hand
        };
        back.FlatAppearance.BorderSize = 0;
        back.Click += (_, _) => OnBack();
        title = new Label
        {
            Text = heading,
            AutoSize = false,
            Left = 56,
            Top = 8,
            Width = 290,
            Height = 44,
            Font = DepUi.F(15, FontStyle.Bold),
            ForeColor = Theme.Ink,
            BackColor = Theme.Page,
            TextAlign = ContentAlignment.MiddleLeft
        };

        head.Controls.Add(back);
        head.Controls.Add(title);
        Controls.Add(Flow);       //fill first, header last
        Controls.Add(head);
        Flow.SizeChanged += (_, _) => FitWidths();
    }

    private void FitWidths()
    {
        int w = Math.Max(120, Flow.ClientSize.Width - 48);
        foreach (Control c in Flow.Controls) if (c.Width != w) c.Width = w;
    }

    protected void SetTitle(string t) => title.Text = t;
    protected virtual void OnBack() => BackClicked?.Invoke(this, EventArgs.Empty);

    protected void ClearBody()
    {
        Flow.SuspendLayout();
        foreach (Control c in Flow.Controls.Cast<Control>().ToList()) { Flow.Controls.Remove(c); c.Dispose(); }
        Flow.ResumeLayout();
    }

    protected T Add<T>(T c, int after = 12) where T : Control
    {
        c.Margin = new Padding(24, 0, 24, after);
        c.Width = Math.Max(120, Flow.ClientSize.Width - 48);
        Flow.Controls.Add(c);
        return c;
    }

    protected SiticonePanel CardPanel(int height)
    {
        var p = new SiticonePanel { Height = height };
        Theme.Card(p);
        return p;
    }

    protected Label AddLabel(string text, float size, FontStyle style, Color fore, int height,
                         ContentAlignment align = ContentAlignment.TopLeft, int after = 6)
    {
        var font = DepUi.F(size, style);
        return Add(new Label
        {
            Text = text,
            AutoSize = false,
            Height = Math.Max(height, font.Height + 4),
            Font = font,
            ForeColor = fore,
            BackColor = Color.Transparent,
            TextAlign = align
        }, after);
    }

    protected Panel AddCentered(Control c, int after = 8)
    {
        var p = new Panel { Height = c.Height, BackColor = Color.Transparent };
        p.Controls.Add(c);
        p.SizeChanged += (_, _) => c.Left = (p.Width - c.Width) / 2;
        Add(p, after);
        c.Left = (p.Width - c.Width) / 2;
        return p;
    }

    protected SiticoneTextBox AddField(string label, string text = "")
    {
        AddLabel(label, 9.5f, FontStyle.Regular, Theme.Muted, 18, after: 6);
        var tb = new SiticoneTextBox { Height = 46, Text = text };
        Theme.Field(tb);
        return Add(tb, 16);
    }

    protected TextBox AddNotes(string label, string text = "")
    {
        AddLabel(label, 9.5f, FontStyle.Regular, Theme.Muted, 18, after: 6);
        var card = CardPanel(96);
        var tb = new TextBox
        {
            Multiline = true,
            BorderStyle = BorderStyle.None,
            Font = DepUi.F(11),
            Text = text,
            ForeColor = Theme.Ink,
            BackColor = Color.White
        };
        card.Controls.Add(tb);
        void Lay() => tb.SetBounds(14, 12, Math.Max(20, card.Width - 28), card.Height - 24);
        card.SizeChanged += (_, _) => Lay();
        card.Click += (_, _) => tb.Focus();
        Add(card, 16);
        Lay();
        return tb;
    }

    protected SiticoneDropdown AddCombo(string label, params string[] items)
    {
        AddLabel(label, 9.5f, FontStyle.Regular, Theme.Muted, 18, after: 6);
        var d = new SiticoneDropdown { Height = 46 };
        Theme.Drop(d);
        d.Items.AddRange(items);
        d.SelectedIndex = 0;
        return Add(d, 16);
    }

    protected SiticoneDateTimePicker AddDob(DateTime value)
    {
        AddLabel("Date of birth", 9.5f, FontStyle.Regular, Theme.Muted, 18, after: 6);
        if (value > DateTime.Today) value = DateTime.Today;
        var d = new SiticoneDateTimePicker { Height = 46 };
        d.Date = value;
        return Add(d, 16);
    }

    protected Segmented AddSegment(string label, params string[] items)
    {
        AddLabel(label, 9.5f, FontStyle.Regular, Theme.Muted, 18, after: 6);
        return Add(new Segmented(items), 16);
    }

    protected SiticoneButton AddButton(string text, bool primary = true, int after = 10)
    {
        var b = new SiticoneButton { Text = text, Height = 50 };
        if (primary) Theme.PrimaryBtn(b); else Theme.Outline(b);
        return Add(b, after);
    }

    protected Button AddLink(string text, Color fore)
    {
        var b = DepUi.LinkBtn(text, 0, 0, 100, fore);
        b.Height = 40;
        return Add(b, 8);
    }

    protected SiticonePanel AddInfoCard(params (string Label, string Value)[] rows)
    {
        const int rowH = 52;
        var card = CardPanel(rows.Length * rowH);
        var keyFont = DepUi.F(10);
        int keyW = rows.Max(r => TextRenderer.MeasureText(r.Label, keyFont).Width) + 8;
        var values = new List<Label>(); var lines = new List<Panel>();

        for (int i = 0; i < rows.Length; i++)
        {
            int y = i * rowH;
            var k = DepUi.Text(rows[i].Label, 10, FontStyle.Regular, Theme.Muted, 16, 0, keyW, 0, Color.White);
            k.Top = y + (rowH - k.Height) / 2;
            var v = DepUi.Text(rows[i].Value == "" ? "-" : rows[i].Value, 10.5f, FontStyle.Regular, Theme.Ink, 16 + keyW + 8, 0, 100, 0, Color.White);
            v.TextAlign = ContentAlignment.MiddleRight;
            v.Top = y + (rowH - v.Height) / 2;
            card.Controls.Add(k); card.Controls.Add(v); values.Add(v);
            if (i > 0)
            {
                var line = new Panel { Left = 16, Top = y, Height = 1, BackColor = Theme.Line };
                card.Controls.Add(line); lines.Add(line);
            }
        }
        void Fit()
        {
            foreach (var v in values) v.Width = Math.Max(20, card.Width - v.Left - 16);
            foreach (var l in lines) l.Width = Math.Max(20, card.Width - 32);
        }
        card.SizeChanged += (_, _) => Fit();
        Add(card, 16);
        Fit();
        return card;
    }
}