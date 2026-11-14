

using System.ComponentModel;

namespace medicord_v1.Helpers
{
    public class SlotChip : Control
    {
        private bool _checked, _hover;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TimeSpan Slot { get; set; }
        public event EventHandler? CheckedChanged;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Checked
        {
            get => _checked;
            set
            {
                if (_checked == value) return;
                _checked = value;
                Invalidate();
                CheckedChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public SlotChip()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.Selectable, true);
            Size = new Size(96, 44);
            Cursor = Cursors.Hand;
            Font = new Font("Segoe UI Semibold", 10f);
        }

        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnClick(EventArgs e) { Checked = true; base.OnClick(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Parent?.BackColor ?? Theme.Page);

            var r = new Rectangle(1, 1, Width - 3, Height - 3);
            using var path = Shapes.Rounded(r, 12);

            Color fill = _checked ? Theme.Primary : (_hover ? Theme.Tint : Color.White);
            Color text = _checked ? Color.White : Theme.Primary;
            using (var br = new SolidBrush(fill)) g.FillPath(br, path);
            using (var pen = new Pen(Theme.Primary, 1.5f)) g.DrawPath(pen, path);

            TextRenderer.DrawText(g, Text, Font, ClientRectangle, text,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
        }
    }
}