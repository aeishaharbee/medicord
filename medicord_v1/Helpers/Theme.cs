using System.Runtime.CompilerServices;

namespace medicord_v1.Helpers
{
    public static class Theme
    {
        public static readonly Color Primary = Color.FromArgb(14, 79, 77);
        public static readonly Color PrimaryHover = Color.FromArgb(11, 64, 62);
        public static readonly Color PrimaryDown = Color.FromArgb(8, 50, 48);
        public static readonly Color Page = Color.FromArgb(240, 240, 240);
        public static readonly Color Ink = Color.FromArgb(16, 32, 31);
        public static readonly Color Muted = Color.FromArgb(90, 107, 106);
        public static readonly Color Line = Color.FromArgb(157, 181, 179);
        public static readonly Color Tint = Color.FromArgb(227, 241, 240);
        public static readonly Color OnDark = Color.FromArgb(191, 224, 221);
        public static readonly Color Accent = Color.FromArgb(10, 147, 150); 
        public static readonly Color CardBack = Color.White;
        public static readonly Color CardLine = Color.FromArgb(226, 232, 231);
        public static readonly Color AmberBack = Color.FromArgb(251, 235, 203);
        public static readonly Color AmberFore = Color.FromArgb(107, 74, 0);
        public static readonly Color Danger = Color.FromArgb(192, 40, 40);
        public static readonly Color DangerHover = Color.FromArgb(253, 232, 232);
        public static readonly Color DangerDown = Color.FromArgb(248, 211, 211);
        public static readonly Color Warn = Color.FromArgb(200, 125, 0);
        public static readonly Color WarnText = Color.FromArgb(146, 90, 0);
        public static readonly Color WarnHover = Color.FromArgb(255, 244, 222);
        public static readonly Color WarnDown = AmberBack;

        static void Round(SiticoneButton b, int r)
            => b.CornerRadiusTopLeft = b.CornerRadiusTopRight = b.CornerRadiusBottomLeft = b.CornerRadiusBottomRight = r;

        //main button, dark green filled
        public static void PrimaryBtn(SiticoneButton b)
        {
            b.ButtonBackColor = Primary; b.HoverBackColor = PrimaryHover; b.PressedBackColor = PrimaryDown;
            b.TextColor = Color.White; b.HoverTextColor = Color.White; b.BorderWidth = 0;
            b.EnableRippleEffect = true; b.RippleColor = Color.White; b.RippleOpacity = 0.2f;
            b.CustomCursor = Cursors.Hand; Round(b, b.Height / 2);
        }

        //second button, white filled
        public static void Outline(SiticoneButton b)
        {
            b.ButtonBackColor = Color.White; b.HoverBackColor = Tint; b.PressedBackColor = Tint;
            b.TextColor = Primary; b.HoverTextColor = Primary;
            b.BorderColor = Primary; b.BorderWidth = 2;
            b.CustomCursor = Cursors.Hand; Round(b, b.Height / 2);
        }

        //third button, no fill
        public static void Link(SiticoneButton b, Color bg)
        {
            b.ButtonBackColor = bg; b.HoverBackColor = Tint; b.PressedBackColor = Tint;
            b.TextColor = Primary; b.HoverTextColor = Primary; b.BorderWidth = 0;
            b.CustomCursor = Cursors.Hand; Round(b, b.Height / 2);
        }

        //outline buttons
        static void OutlineWith(SiticoneButton b, Color border, Color text, Color hoverBack, Color downBack)
        {
            b.ButtonBackColor = Color.White; b.HoverBackColor = hoverBack; b.PressedBackColor = downBack;
            b.TextColor = text; b.HoverTextColor = text;
            b.BorderColor = border; b.BorderWidth = 2;
            b.CustomCursor = Cursors.Hand; Round(b, b.Height / 2);
        }

        public static void OutlineDanger(SiticoneButton b)
            => OutlineWith(b, Danger, Danger, DangerHover, DangerDown);

        public static void OutlineWarning(SiticoneButton b)
            => OutlineWith(b, Warn, WarnText, WarnHover, WarnDown);

        //tab button, dark green filled when active
        public static void Tab(SiticoneButton b, bool on)
        {
            b.ButtonBackColor = on ? Primary : Color.White;
            b.HoverBackColor = on ? Primary : Tint;
            b.TextColor = on ? Color.White : Primary;
            b.HoverTextColor = on ? Color.White : Primary;
            Round(b, b.Height / 2);
        }

        //day button, dark green filled when toggled
        public static void Day(SiticoneButton b) 
        {
            b.IsToggleButton = true;
            Paint(b);
            b.ToggleChanged += (_, _) => Paint(b);
            static void Paint(SiticoneButton x)
            {
                x.ButtonBackColor = x.IsToggled ? Primary : Color.White;
                x.HoverBackColor = x.IsToggled ? PrimaryHover : Tint;
                x.TextColor = x.IsToggled ? Color.White : Primary;
                x.HoverTextColor = x.IsToggled ? Color.White : Primary;
                x.BorderColor = Primary; x.BorderWidth = 2;
                Round(x, x.Height / 2);
            }
        }

        //read only day button
        public static void DayReadOnly(SiticoneButton b, bool on)
        {
            b.IsToggleButton = false;
            b.ButtonBackColor = on ? Primary : Color.White;
            b.HoverBackColor = b.ButtonBackColor;           // no hover feedback
            b.PressedBackColor = b.ButtonBackColor;
            b.TextColor = on ? Color.White : Primary;
            b.HoverTextColor = b.TextColor;
            b.BorderColor = Primary; b.BorderWidth = 2;
            b.EnableRippleEffect = false; b.EnablePressAnimation = false;
            b.CustomCursor = Cursors.Default;               // no hand cursor
            b.TabStop = false;                              // no focus outline
            Round(b, b.Height / 2);
        }

        //text field
        public static void Field(SiticoneTextBox t)
        {
            t.SolidFillColor = Color.White; t.ForeColor = Ink; t.PlaceholderColor = Muted;
            t.ShowBorder = true; t.BorderSize = 2;
            t.SolidBorderColor = Line; t.SolidBorderHoverColor = Muted; t.SolidBorderFocusColor = Primary;
            t.CornerRadiusTopLeft = t.CornerRadiusTopRight = t.CornerRadiusBottomLeft = t.CornerRadiusBottomRight = 8;
        }

        //dropdown field
        public static void Drop(SiticoneDropdown d)
        {
            d.BackColor = Color.White; d.BorderColor = Line; d.BorderSize = 1; d.CornerRadius = 8;
            d.DropdownBackColor = Color.White; d.DropdownCornerRadius = 8; d.DropShadowEnabled = true;
            d.SelectedItemBackColor = Primary; d.SelectedItemTextColor = Color.White;
            d.HoveredItemBackColor = Tint; d.HoveredItemTextColor = Ink; d.UnselectedItemTextColor = Ink;
            d.PlaceholderColor = Muted; d.ItemHeight = 38; d.MaxDropDownItems = 6;
        }

        //time field
        public static void TimeField(SiticoneTimePicker t)
        {
            t.TimePickerBackColor = Color.White; t.TextColor = Ink; t.SeparatorColor = Muted;
            t.Font = new Font("Segoe UI", 11, FontStyle.Bold); t.ActiveComponentColor = Color.LightSeaGreen; t.BorderColor = Line;
            t.ChevronColor = Color.LightSeaGreen; t.ChevronSize = 10;
            t.DropdownBackColor = Color.White; t.SelectedItemBackColor = Tint; t.SelectedTextColor = Primary;
            t.CornerRadiusTopLeft = t.CornerRadiusTopRight = t.CornerRadiusBottomLeft = t.CornerRadiusBottomRight = 8;
        }

        //left panel bgcolor
        public static void Side(SiticonePanel p) => p.FillColor = Primary;

        //card
        public static void Card(SiticonePanel p) { p.FillColor = Color.White; p.SetCornerRadius(16); }

        //left panel progress list
        public static void Steps(int active, params Label[] steps)
        {
            for (int i = 0; i < steps.Length; i++)
            {
                bool on = i + 1 == active;
                steps[i].ForeColor = on ? Color.White : OnDark;
                steps[i].Font = new Font(steps[i].Font, on ? FontStyle.Bold : FontStyle.Regular);
            }
        }

        //keep form center
        public static void Center(Control child, Control parent)
        {
            void Do()
            {
                child.Left = Math.Max(0, (parent.ClientSize.Width - child.Width) / 2);
                child.Top = Math.Max(0, (parent.ClientSize.Height - child.Height) / 2);
            }
            parent.Resize += (_, _) => Do();
            Do();
        }

        //desktop nav
        public static void Nav(SiticoneButton b, bool active)
        {
            b.ButtonBackColor = active ? Color.FromArgb(34, 102, 100) : Primary;
            b.HoverBackColor = Color.FromArgb(30, 92, 90);
            b.PressedBackColor = Color.FromArgb(34, 102, 100);
            b.TextColor = active ? Color.White : OnDark; b.HoverTextColor = Color.White;
            b.BorderWidth = 0; b.EnableRippleEffect = false; b.CustomCursor = Cursors.Hand;
            Round(b, 12);
        }

        //table grid
        public static void Grid(DataGridView g)
        {
            g.BackgroundColor = Color.White; g.BorderStyle = BorderStyle.None; g.EnableHeadersVisualStyles = false;
            g.RowHeadersVisible = false; g.AllowUserToAddRows = false; g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false; g.AllowUserToResizeColumns = false;
            g.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ReadOnly = true; g.MultiSelect = false; g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; g.GridColor = Color.FromArgb(238, 242, 241);
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 44;
            g.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Muted;
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.SelectionForeColor = Muted;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            g.DefaultCellStyle.BackColor = Color.White; g.DefaultCellStyle.ForeColor = Ink;
            g.DefaultCellStyle.SelectionBackColor = Tint; g.DefaultCellStyle.SelectionForeColor = Ink;
            g.DefaultCellStyle.Font = new Font("Segoe UI", 10.5f);
            g.RowTemplate.Height = 48;

            g.CellPainting += (s, e) =>
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.Value == null) return;
                var col = g.Columns[e.ColumnIndex];
                if (col.HeaderText != "Status" && col.HeaderText != "Category") return;

                string text = e.Value.ToString();
                var (bg, fg) = PillColors(text);

                e.PaintBackground(e.CellBounds, true);
                var gfx = e.Graphics;
                gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                var size = TextRenderer.MeasureText(gfx, text, g.Font);
                int w = size.Width + 24, h = 24;
                var r = new Rectangle(e.CellBounds.X + 8, e.CellBounds.Y + (e.CellBounds.Height - h) / 2, w, h);

                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                using (var br = new SolidBrush(bg))
                {
                    int d = h;
                    path.AddArc(r.X, r.Y, d, d, 90, 180);
                    path.AddArc(r.Right - d, r.Y, d, d, 270, 180);
                    path.CloseFigure();
                    gfx.FillPath(br, path);
                }
                TextRenderer.DrawText(gfx, text, g.Font, r, fg,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
                e.Handled = true;
            };

            g.RowTemplate.Height = 48;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            g.ColumnHeadersDefaultCellStyle.ForeColor = Muted;

            g.CellMouseEnter += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.RowIndex < g.Rows.Count)
                    g.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(244, 249, 248);
            };
            g.CellMouseLeave += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.RowIndex < g.Rows.Count)
                    g.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            };

            g.DataBindingComplete += (s, e) =>
            {
                if (_avatarMap.TryGetValue(g, out var m)) AvatarCache.PreloadFor(g, m);
            };

            g.CellPainting += (s, e) =>
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
                if (!_avatarMap.TryGetValue(g, out var map)) return;
                if (!map.TryGetValue(g.Columns[e.ColumnIndex].Name, out var idCol)) return;

                string name = e.Value?.ToString() ?? "";
                if (name == "" || name == "-") return;                   

                int id = 0;
                if (g.Columns.Contains(idCol))
                {
                    var v = g.Rows[e.RowIndex].Cells[idCol].Value;
                    if (v != null && v != DBNull.Value) id = Convert.ToInt32(v);
                }

                e.PaintBackground(e.CellBounds, true);
                var gfx = e.Graphics;
                gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                gfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                const int d = 32;
                var circle = new Rectangle(e.CellBounds.X + 10, e.CellBounds.Y + (e.CellBounds.Height - d) / 2, d, d);

                var photo = id > 0 ? AvatarCache.Get(id) : null;
                if (photo != null)
                {
                    gfx.DrawImage(photo, circle);
                }
                else
                {
                    int tone = name.Sum(c => c) % 4;
                    Color[] back = { Color.FromArgb(227, 241, 240), Color.FromArgb(220, 231, 245), Color.FromArgb(232, 244, 227), Color.FromArgb(236, 226, 244) };
                    Color[] fore = { Primary, Color.FromArgb(11, 45, 82), Color.FromArgb(44, 94, 26), Color.FromArgb(80, 40, 120) };
                    using (var br = new SolidBrush(back[tone])) gfx.FillEllipse(br, circle);

                    string ini = string.Concat(name.Split(' ', StringSplitOptions.RemoveEmptyEntries).Take(2).Select(p => char.ToUpper(p[0])));
                    using var f = new Font("Segoe UI", 9f, FontStyle.Bold);
                    TextRenderer.DrawText(gfx, ini == "" ? "?" : ini, f, circle, fore[tone],
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
                }

                var textRect = new Rectangle(circle.Right + 10, e.CellBounds.Y, e.CellBounds.Width - d - 24, e.CellBounds.Height);
                TextRenderer.DrawText(gfx, name, g.Font, textRect, Ink,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding);
                e.Handled = true;
            };
        }

        public static void Weights(DataGridView g, params (string col, float weight)[] map)
        {
            foreach (var (col, weight) in map)
                if (g.Columns.Contains(col))
                    g.Columns[col].FillWeight = weight;
        }

        public static void HideCols(DataGridView g, params string[] names)
        {
            foreach (var n in names)
                if (g.Columns.Contains(n)) g.Columns[n].Visible = false;
        }

        public static (Color bg, Color fg) PillColors(string v)
        {
            switch (v)
            {
                case "Pending": return (Color.FromArgb(255, 239, 204), Color.FromArgb(122, 77, 0));
                case "Approved": return (Color.FromArgb(209, 240, 220), Color.FromArgb(14, 94, 52));
                case "Rejected": return (Color.FromArgb(252, 217, 217), Color.FromArgb(150, 32, 32));
                case "Completed": return (Tint, Primary);
                case "Cancelled": return (Color.FromArgb(230, 232, 232), Color.FromArgb(70, 80, 80));
            }
            //facility categories 
            var pal = new[] {
                (Color.FromArgb(220,232,252), Color.FromArgb(24,64,140)),
                (Color.FromArgb(236,222,250), Color.FromArgb(88,40,140)),
                (Color.FromArgb(255,227,214), Color.FromArgb(140,60,20)),
                (Color.FromArgb(214,244,240), Color.FromArgb(10,90,84)) };
            int i = v.Sum(c => c) % pal.Length;
            return pal[i];
        }

        public static void EmptyState(DataGridView g, string text)
        {
            var l = new Label
            {
                Text = text,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Muted,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 11f),
                Visible = false
            };
            void Place()
            {
                l.Left = 0; l.Top = g.ColumnHeadersHeight; l.Width = g.ClientSize.Width;
                l.Height = Math.Max(40, g.ClientSize.Height - g.ColumnHeadersHeight);
            }
            g.Controls.Add(l);
            g.Tag = l;
            g.Resize += (_, _) => Place();
            Place();
        }

        public static void SetEmptyText(DataGridView g, string text)
        {
            if (g.Tag is Label l) l.Text = text;
        }

        public static void Fill(DataGridView g, DataTable dt, params string[] hide)
        {
            g.DataSource = dt;
            foreach (var h in hide) if (g.Columns.Contains(h)) g.Columns[h].Visible = false;
            if (g.Rows.Count > 0)
                g.CurrentCell = g.Rows[0].Cells.Cast<DataGridViewCell>().First(c => c.Visible);

            if (g.Tag is Label empty)        
            {
                empty.Visible = g.Rows.Count == 0;
                empty.BringToFront();
            }
        }

        //time picker
        public static void SetTime(SiticoneTimePicker p, TimeSpan t) { p.Hour = t.Hours; p.Minute = t.Minutes; p.Second = 0; }
        public static TimeSpan ReadTime(SiticoneTimePicker p) => new TimeSpan(p.Hour, p.Minute, 0);

        //date picker
        public static void DateField(SiticoneDateTimePicker d)
        {
            d.FillColor = Color.White; d.ForeColor = Ink;
            d.BorderColor = Line; d.BorderWidth = 2;

            d.CalendarBackgroundColor = Color.White;
            d.NavigationPanelBackColor = Tint;
            d.CalendarSelectedDateBackColor = Primary;
            d.CalendarSelectedDateForeColor = Color.White;
            d.ShowTodayButton = true;
        }

        //password eye icon
        public static void AddEye(Control box)
        {
            Color bg;
            switch (box)
            {
                case SiticoneTextBox tb:
                    tb.UseSystemPasswordChar = true;
                    bg = tb.SolidFillColor;
                    break;
                case SiticoneMaterialTextbox mtb:
                    mtb.UseSystemPasswordChar = true;
                    bg = Color.White; 
                    break;
                default:
                    throw new ArgumentException("Control must be SiticoneTextBox or SiticoneMaterialTextbox.", nameof(box));
            }

            var eye = new Label
            {
                Text = "\uE7B3",
                Font = new Font("Segoe MDL2 Assets", 12f),
                ForeColor = Muted,
                BackColor = bg,
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand,
                AutoSize = false,
                Size = new Size(34, Math.Max(20, box.Height - 14))
            };

            void Place()
            {
                eye.Location = new Point(box.Right - eye.Width - 6, box.Top + (box.Height - eye.Height) / 2);
                eye.BringToFront();
            }

            eye.Click += (s, e) =>
            {
                bool masked = box switch
                {
                    SiticoneTextBox tb => tb.UseSystemPasswordChar = !tb.UseSystemPasswordChar,
                    SiticoneMaterialTextbox mtb => mtb.UseSystemPasswordChar = !mtb.UseSystemPasswordChar,
                    _ => true
                };

                eye.Text = masked ? "\uE7B3" : "\uED1A";
                eye.ForeColor = masked ? Muted : Primary;
                box.Focus();
            };

            box.Parent!.Controls.Add(eye);
            box.LocationChanged += (s, e) => Place();
            box.SizeChanged += (s, e) => Place();
            Place();
        }

        //avatar
        private static readonly ConditionalWeakTable<DataGridView, Dictionary<string, string>> _avatarMap = new();

      
        public static void AvatarColumn(DataGridView g, string nameColumn, string idColumn)
        {
            _avatarMap.GetOrCreateValue(g)[nameColumn] = idColumn;
        }
    }
}
