namespace medicord_v1.Helpers
{
    public enum MsgKind { Info, Success, Warning, Error, Question }

    public static class Msg
    {
        public static void Info(string text, string title = "Information") => Run(text, title, MsgKind.Info, false);
        public static void Success(string text, string title = "Success") => Run(text, title, MsgKind.Success, false);
        public static void Warn(string text, string title = "Please check") => Run(text, title, MsgKind.Warning, false);
        public static void Error(string text, string title = "Something went wrong") => Run(text, title, MsgKind.Error, false);
        public static bool Confirm(string text, string title = "Please confirm") => Run(text, title, MsgKind.Question, true);

        public static DialogResult Show(string text, string title = "")
        {
            string t = text.ToLowerInvariant();
            MsgKind kind;
            if (Has(t, "could not", "cannot", "error", "incorrect", "invalid", "already", "do not match", "failed"))
                kind = MsgKind.Error;
            else if (Has(t, "enter ", "must ", "choose ", "select ", "please "))
                kind = MsgKind.Warning;
            else if (Has(t, "updated", "saved", "success", "added", "deleted", "created", "uploaded"))
                kind = MsgKind.Success;
            else kind = MsgKind.Info;

            if (title == "")
                title = kind switch
                {
                    MsgKind.Error => "Something went wrong",
                    MsgKind.Warning => "Please check",
                    MsgKind.Success => "Success",
                    _ => "Information"
                };
            Run(text, title, kind, false);
            return DialogResult.OK;
        }

        private static bool Has(string s, params string[] words)
        {
            foreach (var w in words) if (s.Contains(w)) return true;
            return false;
        }

        private static bool Run(string text, string title, MsgKind kind, bool confirm)
        {
            using var f = new MsgForm(text, title, kind, confirm);
            return f.ShowDialog(Form.ActiveForm) == DialogResult.OK;
        }
    }

    internal class MsgForm : Form
    {
        private Point _drag;

        public MsgForm(string text, string title, MsgKind kind, bool confirm)
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterParent;
            ShowInTaskbar = false;
            Padding = new Padding(1);                  

            Color accent = kind switch
            {
                MsgKind.Success => Color.FromArgb(34, 139, 94),
                MsgKind.Warning => Color.FromArgb(214, 129, 20),
                MsgKind.Error => Color.FromArgb(200, 55, 65),
                MsgKind.Question => Color.FromArgb(37, 99, 190),
                _ => Theme.Primary
            };
            string glyph = kind switch
            {
                MsgKind.Success => "\u2713",
                MsgKind.Warning => "!",
                MsgKind.Error => "\u2715",
                MsgKind.Question => "?",
                _ => "i"
            };
            BackColor = accent;

            //layout constants
            const int W = 440, HeaderH = 40, FooterH = 64;
            const int PadX = 28, PadY = 24, IconW = 48, Gap = 16;

            var bodyFont = new Font("Segoe UI", 10.5f);
            int textW = W - PadX * 2 - IconW - Gap;

            var lbl = new Label
            {
                Text = text,
                Font = bodyFont,
                ForeColor = Theme.Ink,
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                TextAlign = ContentAlignment.MiddleLeft
            };
            int textH = lbl.GetPreferredSize(new Size(textW, 0)).Height + 8;
            int bodyH = Math.Max(IconW, textH);
            ClientSize = new Size(W + 2, HeaderH + PadY * 2 + bodyH + FooterH + 2);

            var root = new Panel { Dock = DockStyle.Fill, BackColor = Color.White };
            Controls.Add(root);

            //BODY
            var body = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                Padding = new Padding(PadX, PadY, PadX, PadY),
                BackColor = Color.White
            };
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, IconW + Gap));
            body.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            body.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            var icon = new Panel
            {
                Size = new Size(IconW, IconW),
                Margin = Padding.Empty,
                Anchor = AnchorStyles.Left,               
                BackColor = Color.White
            };
            icon.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using var b = new SolidBrush(accent);
                e.Graphics.FillEllipse(b, 0, 0, IconW - 1, IconW - 1);
                using var f = new Font("Segoe UI", 18f, FontStyle.Bold);
                TextRenderer.DrawText(e.Graphics, glyph, f, new Rectangle(0, 0, IconW, IconW), Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
            };
            body.Controls.Add(icon, 0, 0);
            body.Controls.Add(lbl, 1, 0);

            //HEADER
            var header = new Panel { Dock = DockStyle.Top, Height = HeaderH, BackColor = accent };
            var lblTitle = new Label
            {
                Text = title,
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 10.5f),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(16, 0, 0, 0)
            };
            var lblClose = new Label
            {
                Text = "\u2715",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10f),
                Dock = DockStyle.Right,
                Width = 44,
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };
            lblClose.Click += (s, e) => DialogResult = DialogResult.Cancel;
            foreach (Control c in new Control[] { header, lblTitle })
            {
                c.MouseDown += (s, e) => _drag = e.Location;
                c.MouseMove += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                        Location = new Point(Left + e.X - _drag.X, Top + e.Y - _drag.Y);
                };
            }
            header.Controls.Add(lblTitle);
            header.Controls.Add(lblClose);

            //FOOTER
            var footer = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                Height = FooterH,
                FlowDirection = FlowDirection.RightToLeft,
                WrapContents = false,
                Padding = new Padding(PadX, 14, PadX, 0),
                BackColor = Color.FromArgb(244, 246, 246)
            };

            Button ok = MakeButton(confirm ? "Yes" : "OK", true);
            ok.DialogResult = DialogResult.OK;
            footer.Controls.Add(ok);
            AcceptButton = ok;
            CancelButton = ok;

            if (confirm)
            {
                Button no = MakeButton("No", false);
                no.DialogResult = DialogResult.Cancel;
                footer.Controls.Add(no);                    
                CancelButton = no;
            }

            root.Controls.Add(body);
            root.Controls.Add(footer);
            root.Controls.Add(header);
        }

        private static Button MakeButton(string text, bool primary)
        {
            var b = new Button
            {
                Text = text,
                Size = new Size(104, 36),
                Margin = new Padding(12, 0, 0, 0),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI Semibold", 10f),
                Cursor = Cursors.Hand,
                BackColor = primary ? Theme.Primary : Color.White,
                ForeColor = primary ? Color.White : Theme.Primary
            };
            b.FlatAppearance.BorderSize = primary ? 0 : 1;
            b.FlatAppearance.BorderColor = Theme.Primary;
            b.FlatAppearance.MouseOverBackColor = primary ? Theme.PrimaryHover : Theme.Tint;
            return b;
        }
    }
}
