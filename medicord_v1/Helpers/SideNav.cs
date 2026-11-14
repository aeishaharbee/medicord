using System.ComponentModel;

namespace medicord_v1.Helpers
{
    public class SideNav : Control
    {
        private class Item
        {
            public string Key = "", Text = "", Glyph = "";
            public bool Header, Footer;
            public int Badge;
            public Rectangle Bounds;
        }

        private const int Pad = 20;         
        private const int ItemH = 54;      
        private const int HeaderH = 40;   
        private const int Gap = 3;
        private const int LogoY = 34;
        private const int LogoSize = 56;   // was 50
        private const int ChipH = 76;

        private readonly Image _logo = Properties.Resources.logo_primary;
        private readonly List<Item> _items = new();
        private string _selected = "";
        private Item? _hover;
        private Image? _avatar;

        private readonly Font _fText = new("Segoe UI Semibold", 12.5f);
        private readonly Font _fSection = new("Segoe UI", 9.5f, FontStyle.Bold);
        private readonly Font _fIcon = new("Segoe MDL2 Assets", 14.5f);
        private readonly Font _fBadge = new("Segoe UI", 10f, FontStyle.Bold);
        private readonly Font _fTitle = new("Segoe UI", 18f, FontStyle.Bold);
        private readonly Font _fSub = new("Segoe UI", 10f);
        private readonly Font _fAvatar = new("Segoe UI", 12f, FontStyle.Bold);
        private readonly Font _fUser = new("Segoe UI Semibold", 11.5f);
        private readonly Font _fRole = new("Segoe UI", 10f);

        public event Action<string>? ItemClicked;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Subtitle { get; set; } = "Facility portal";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string UserName { get; set; } = "";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string UserRole { get; set; } = "";
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image? Avatar { get => _avatar; set { _avatar = value; Invalidate(); } }

        public SideNav()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            BackColor = Theme.Primary;
            Width = 320;
        }

        public void AddSection(string text) => _items.Add(new Item { Text = text, Header = true });
        public void AddItem(string key, string text, string glyph) => _items.Add(new Item { Key = key, Text = text, Glyph = glyph });
        public void AddFooter(string key, string text, string glyph) => _items.Add(new Item { Key = key, Text = text, Glyph = glyph, Footer = true });

        public void Select(string key) { _selected = key; Invalidate(); }

        public void SetBadge(string key, int count)
        {
            var it = _items.FirstOrDefault(i => i.Key == key);
            if (it != null) { it.Badge = count; Invalidate(); }
        }

        private void LayoutItems()
        {
            int y = LogoY + LogoSize + 14;
            foreach (var it in _items.Where(i => !i.Footer))
            {
                int h = it.Header ? HeaderH : ItemH;
                if (it.Header) y += 8;
                it.Bounds = new Rectangle(Pad, y, Width - Pad * 2, h);
                y += h + Gap;
            }
            int fy = Height - 32 - ItemH;
            foreach (var it in _items.Where(i => i.Footer).Reverse())
            { it.Bounds = new Rectangle(Pad, fy, Width - Pad * 2, ItemH); fy -= ItemH + 2; }
        }

        private static GraphicsPath Round(Rectangle r, int radius)
        {
            int d = radius * 2;
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LayoutItems();
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Theme.Primary);

            //logo
            var tile = new Rectangle(Pad + 4, LogoY, LogoSize, LogoSize);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            using (var p = Round(tile, 14))
            {
                g.SetClip(p);
                g.DrawImage(_logo, tile);
                g.ResetClip();
            }

            //title + subtitle
            const TextFormatFlags tf = TextFormatFlags.NoPadding;
            var tSize = TextRenderer.MeasureText(g, "Medicord", _fTitle, Size.Empty, tf);
            var sSize = TextRenderer.MeasureText(g, Subtitle, _fSub, Size.Empty, tf);
            int gap = 4;
            int blockH = tSize.Height + gap + sSize.Height;
            int tx = tile.Right + 14;
            int ty = tile.Y + (tile.Height - blockH) / 2;

            TextRenderer.DrawText(g, "Medicord", _fTitle, new Point(tx, ty), Color.White, tf);
            TextRenderer.DrawText(g, Subtitle, _fSub, new Point(tx, ty + tSize.Height + 2), Theme.OnDark, tf);

            foreach (var it in _items)
            {
                if (it.Header)
                {
                    TextRenderer.DrawText(g, it.Text, _fSection, new Point(it.Bounds.X + 16, it.Bounds.Y + 14),
                                          Color.FromArgb(143, 197, 193));
                    continue;
                }

                bool on = it.Key == _selected, hov = it == _hover;
                if (on || hov)
                {
                    using var p = Round(it.Bounds, 14);
                    using var br = new SolidBrush(Color.FromArgb(on ? 40 : 20, 255, 255, 255));
                    g.FillPath(br, p);
                }
                Color fg = on ? Color.White : Color.FromArgb(214, 234, 232);
                var iconRect = new Rectangle(it.Bounds.X + 12, it.Bounds.Y, 34, it.Bounds.Height);
                TextRenderer.DrawText(g, it.Glyph, _fIcon, iconRect, fg,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
                TextRenderer.DrawText(g, it.Text, _fText,
                    new Rectangle(it.Bounds.X + 58, it.Bounds.Y, it.Bounds.Width - 120, it.Bounds.Height), fg,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding | TextFormatFlags.EndEllipsis);

                if (it.Badge > 0)
                {
                    string t = it.Badge > 99 ? "99+" : it.Badge.ToString();
                    var sz = TextRenderer.MeasureText(t, _fBadge);
                    var br = new Rectangle(it.Bounds.Right - sz.Width - 32, it.Bounds.Y + (ItemH - 24) / 2, sz.Width + 12, 24);
                    using var p = Round(br, 12);
                    using var bb = new SolidBrush(Theme.AmberBack);
                    g.FillPath(bb, p);
                    TextRenderer.DrawText(g, t, _fBadge, br, Theme.AmberFore,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
                }
            }

            // user chip above the footer items
            var firstFooter = _items.Where(i => i.Footer).OrderBy(i => i.Bounds.Y).FirstOrDefault();
            if (UserName != "" && firstFooter != null)
            {
                var chip = new Rectangle(Pad, firstFooter.Bounds.Y - 8 - ChipH, Width - Pad * 2, ChipH);
                using (var p = Round(chip, 16)) using (var br = new SolidBrush(Color.FromArgb(22, 255, 255, 255)))
                    g.FillPath(br, p);
                var av = new Rectangle(chip.X + 14, chip.Y + (ChipH - 46) / 2, 46, 46);

                if (_avatar != null)
                {
                    g.DrawImage(_avatar, av);
                }
                else
                {
                    g.FillEllipse(Brushes.White, av);
                    string ini = string.Concat(UserName.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                                        .Take(2).Select(s => char.ToUpper(s[0])));
                    TextRenderer.DrawText(g, ini == "" ? "?" : ini, _fAvatar, av, Theme.Primary,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
                }

                TextRenderer.DrawText(g, UserName, _fUser,
                    new Rectangle(chip.X + 72, chip.Y + 14, chip.Width - 84, 24), Color.White,
                    TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding);
                TextRenderer.DrawText(g, UserRole, _fRole,
                    new Rectangle(chip.X + 72, chip.Y + 40, chip.Width - 84, 20), Theme.OnDark,
                    TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding);
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            var it = _items.FirstOrDefault(i => !i.Header && i.Bounds.Contains(e.Location));
            if (it != _hover) { _hover = it; Cursor = it != null ? Cursors.Hand : Cursors.Default; Invalidate(); }
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e) { _hover = null; Invalidate(); base.OnMouseLeave(e); }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            var it = _items.FirstOrDefault(i => !i.Header && i.Bounds.Contains(e.Location));
            if (it == null) return;
            if (!it.Footer) _selected = it.Key;
            Invalidate();
            ItemClicked?.Invoke(it.Key);
            base.OnMouseClick(e);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _fText.Dispose(); _fSection.Dispose(); _fIcon.Dispose(); _fBadge.Dispose();
                _fTitle.Dispose(); _fSub.Dispose(); _fAvatar.Dispose(); _fUser.Dispose(); _fRole.Dispose();
                _logo.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}