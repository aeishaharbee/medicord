using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace medicord_v1.Helpers
{
    public class KpiCard : Control
    {
        private string _glyph = "\uE787", _value = "0", _caption = "", _trend = "";
        private Color _chipBack = Theme.Tint, _chipFore = Theme.Primary;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Glyph { get => _glyph; set { _glyph = value; Invalidate(); } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Value { get => _value; set { _value = value; Invalidate(); } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Caption { get => _caption; set { _caption = value; Invalidate(); } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Trend { get => _trend; set { _trend = value; Invalidate(); } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]   
        public Color ChipBack { get => _chipBack; set { _chipBack = value; Invalidate(); } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color ChipFore { get => _chipFore; set { _chipFore = value; Invalidate(); } }
        private bool _trendWarn;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool TrendWarn { get => _trendWarn; set { _trendWarn = value; Invalidate(); } }

        public KpiCard()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            Size = new Size(230, 140);
            BackColor = Theme.Page;
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
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Parent?.BackColor ?? Theme.Page);

            var r = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var p = Round(r, 18))
            using (var br = new SolidBrush(Color.White))
            using (var pen = new Pen(Theme.CardLine))
            { g.FillPath(br, p); g.DrawPath(pen, p); }

            var chip = new Rectangle(20, 18, 40, 40);
            using (var p = Round(chip, 12)) using (var br = new SolidBrush(_chipBack)) g.FillPath(br, p);
            using (var f = new Font("Segoe MDL2 Assets", 13f))
                TextRenderer.DrawText(g, _glyph, f, chip, _chipFore,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);

            if (_trend != "")
            {
                using var f = new Font("Segoe UI Semibold", 8.5f);
                var sz = TextRenderer.MeasureText(_trend, f);
                var pill = new Rectangle(Width - sz.Width - 36, 27, sz.Width + 16, 22);
                Color pb = _trendWarn ? Theme.AmberBack : Theme.Tint;
                Color pf = _trendWarn ? Theme.AmberFore : Theme.Primary;
                using (var p = Round(pill, 11)) using (var br = new SolidBrush(pb)) g.FillPath(br, p);
                TextRenderer.DrawText(g, _trend, f, pill, pf,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
            }

            using (var f = new Font("Segoe UI Semibold", 24f))
                TextRenderer.DrawText(g, _value, f, new Point(18, 66), Theme.Ink);
            using (var f = new Font("Segoe UI", 10.5f))
                TextRenderer.DrawText(g, _caption, f, new Point(21, 121), Theme.Muted);
        }
    }
}