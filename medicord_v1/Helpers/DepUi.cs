using System.ComponentModel;
using System.Drawing.Drawing2D;
namespace medicord_v1.Helpers;





public static class DepUi
{
    public static readonly Color Navy = Color.FromArgb(11, 45, 82);
    public static readonly Color Danger = Color.FromArgb(178, 48, 48);

    public static Font F(float size, FontStyle style = FontStyle.Regular) => new("Segoe UI", size, style);

    public static (Color Back, Color Fore) TagColors(string type) => type switch
    {
        "Child" => (Color.FromArgb(220, 231, 245), Color.FromArgb(11, 45, 82)),
        "Senior" => (Color.FromArgb(232, 244, 227), Color.FromArgb(44, 94, 26)),
        "OKU" => (Color.FromArgb(237, 226, 244), Color.FromArgb(80, 40, 122)),
        "Other" => (Color.FromArgb(228, 228, 228), Color.FromArgb(74, 86, 85)),
        _ => (Color.FromArgb(227, 241, 240), Color.FromArgb(14, 79, 77))
    };

    public static string TypeLabel(string t) => t switch { "Senior" => "Parent or senior", "OKU" => "OKU family member", _ => t };

    public static string Age(DateTime? dob)
    {
        if (dob is null) return "";
        var d = dob.Value.Date; var t = DateTime.Today;
        int months = (t.Year - d.Year) * 12 + t.Month - d.Month - (t.Day < d.Day ? 1 : 0);
        return months < 24 ? $"{Math.Max(months, 0)} months" : $"{months / 12} years";
    }

    public static Image Avatar(byte[]? photo, string name, int size)
    {
        if (photo is { Length: > 0 })
        {
            try { return ImageHelper.CircleFromBytes(photo, size); } catch { /* fall through to initials */ }
        }
        return ImageHelper.Initials(name, size);
    }

    public static GraphicsPath RoundPath(Rectangle r, int radius)
    {
        radius = Math.Max(1, radius);
        int d = radius * 2;
        var p = new GraphicsPath();
        p.AddArc(r.X, r.Y, d, d, 180, 90);
        p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
        p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
        p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
        p.CloseFigure();
        return p;
    }

    public static void Round(Control c, int radius)
    {
        if (c.Width < 2 || c.Height < 2) return;
        radius = Math.Min(radius, Math.Min(c.Width, c.Height) / 2);
        using var p = RoundPath(new Rectangle(0, 0, c.Width, c.Height), radius);
        var old = c.Region;
        c.Region = new Region(p);
        old?.Dispose();
    }

    public static Label Text(string text, float size, FontStyle style, Color fore, int left, int top, int w, int h, Color? back = null)
    {
        var font = F(size, style);
        return new Label
        {
            Text = text,
            AutoSize = false,
            AutoEllipsis = true,
            Left = left,
            Top = top,
            Width = w,
            Height = Math.Max(h, font.Height + 4),               
            Font = font,
            ForeColor = fore,
            BackColor = back ?? Color.Transparent
        };
    }

    public static Label Tag(string type, int left, int top)
    {
        var (back, fore) = TagColors(type);
        var font = F(8.5f, FontStyle.Bold);
        int w = TextRenderer.MeasureText(type, font).Width + 20;
        int h = font.Height + 6;
        var l = new Label
        {
            Text = type,
            AutoSize = false,
            Left = left,
            Top = top,
            Width = w,
            Height = h,
            Font = font,
            ForeColor = fore,
            BackColor = back,
            TextAlign = ContentAlignment.MiddleCenter
        };
        Round(l, h / 2);
        return l;
    }

    public static Button LinkBtn(string text, int left, int top, int w, Color fore)
    {
        var b = new Button
        {
            Text = text,
            Left = left,
            Top = top,
            Width = w,
            Height = 36,
            FlatStyle = FlatStyle.Flat,
            Font = F(10.5f, FontStyle.Bold),
            Cursor = Cursors.Hand,
            ForeColor = fore,
            BackColor = Color.Transparent,
            UseVisualStyleBackColor = false
        };
        b.FlatAppearance.BorderSize = 0;
        b.FlatAppearance.MouseOverBackColor = Color.FromArgb(226, 236, 235);    
        b.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 227, 225);
        Round(b, 12);
        b.SizeChanged += (_, _) => Round(b, 12);                                   
        return b;
    }

    public static void Tap(Control c, Action a)
    {
        c.Cursor = Cursors.Hand;
        c.Click += (_, _) => a();
        foreach (Control k in c.Controls) Tap(k, a);
    }
}

