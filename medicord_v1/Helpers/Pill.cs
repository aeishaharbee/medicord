
using System.ComponentModel;

namespace medicord_v1.Helpers
{
    public class Pill : Control
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color PillBack { get; set; } = Theme.Tint;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color PillFore { get; set; } = Theme.Primary;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color Surface { get; set; } = Color.White;   //colour behind pill 

        public Pill()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw, true);
            Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            Height = 24;
        }

        public void FitToText()
        {
            Width = TextRenderer.MeasureText(Text, Font).Width + 26;
            Invalidate();
        }

        public static Pill ForStatus(string status, Color surface)
        {
            var (back, fore) = status switch
            {
                "Pending" => (Color.FromArgb(251, 235, 203), Color.FromArgb(107, 74, 0)),
                "Approved" => (Color.FromArgb(221, 240, 238), Color.FromArgb(11, 74, 74)),
                "Completed" => (Color.FromArgb(220, 231, 245), Color.FromArgb(11, 45, 82)),
                "Rejected" => (Color.FromArgb(248, 220, 220), Color.FromArgb(138, 31, 31)),
                _ => (Color.FromArgb(228, 228, 228), Color.FromArgb(90, 107, 106))   //Cancelled
            };
            var p = new Pill { Text = status, PillBack = back, PillFore = fore, Surface = surface };
            p.FitToText();
            return p;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Surface);
            using var path = Shapes.Rounded(new Rectangle(0, 0, Width - 1, Height - 1), Height / 2);
            using (var br = new SolidBrush(PillBack)) g.FillPath(br, path);
            TextRenderer.DrawText(g, Text, Font, ClientRectangle, PillFore,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
        }
    }
}