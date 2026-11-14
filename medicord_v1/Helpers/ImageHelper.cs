namespace medicord_v1.Helpers
{
    

    public static class ImageHelper
    {
        public static byte[] ToAvatarBytes(string path)
        {
            using var img = Image.FromFile(path);   
            const int size = 256;
            int side = Math.Min(img.Width, img.Height);
            var crop = new Rectangle((img.Width - side) / 2, (img.Height - side) / 2, side, side);

            using var bmp = new Bitmap(size, size);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(img, new Rectangle(0, 0, size, size), crop, GraphicsUnit.Pixel);
            }

            var jpeg = ImageCodecInfo.GetImageEncoders().First(e => e.FormatID == ImageFormat.Jpeg.Guid);
            using var ps = new EncoderParameters(1);
            ps.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 85L);
            using var ms = new MemoryStream();
            bmp.Save(ms, jpeg, ps);
            return ms.ToArray();
        }

        public static Bitmap Circle(Image src, int size)
        {
            var bmp = new Bitmap(size, size);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            using var path = new GraphicsPath();
            path.AddEllipse(0, 0, size - 1, size - 1);
            g.SetClip(path);
            int side = Math.Min(src.Width, src.Height);
            var crop = new Rectangle((src.Width - side) / 2, (src.Height - side) / 2, side, side);
            g.DrawImage(src, new Rectangle(0, 0, size, size), crop, GraphicsUnit.Pixel);
            return bmp;
        }

        public static Bitmap CircleFromBytes(byte[] data, int size)
        {
            using var ms = new MemoryStream(data);
            using var img = Image.FromStream(ms);
            return Circle(img, size);
        }

        //circle with initials when there is no photo
        public static Bitmap Initials(string name, int size)
        {
            var bmp = new Bitmap(size, size);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            using (var b = new SolidBrush(Theme.Primary)) g.FillEllipse(b, 0, 0, size - 1, size - 1);

            string initials = string.Concat(name.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                                .Take(2).Select(p => char.ToUpper(p[0])));
            if (initials == "") initials = "?";
            using var f = new Font("Segoe UI", size * 0.36f, FontStyle.Bold, GraphicsUnit.Pixel);
            using var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            g.DrawString(initials, f, Brushes.White, new RectangleF(0, 0, size, size), sf);
            return bmp;
        }

        //facility logo
        public static byte[] ToLogoBytes(string path)
        {
            using var img = Image.FromFile(path);  
            const int max = 512;
            double scale = Math.Min(1.0, (double)max / Math.Max(img.Width, img.Height));
            int w = Math.Max(1, (int)(img.Width * scale)), h = Math.Max(1, (int)(img.Height * scale));
            using var bmp = new Bitmap(w, h);
            using (var g = Graphics.FromImage(bmp))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.DrawImage(img, new Rectangle(0, 0, w, h));
            }
            using var ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }

        public static Bitmap LogoTile(byte[]? data, string name, int size)
        {
            var bmp = new Bitmap(size, size);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            using var tile = RoundRect(new Rectangle(0, 0, size - 1, size - 1), size / 6);

            if (data != null && data.Length > 0)
            {
                try
                {
                    using var ms = new MemoryStream(data);
                    using var img = Image.FromStream(ms);
                    g.FillPath(Brushes.White, tile);
                    g.SetClip(tile);
                    double scale = Math.Min((size - 12.0) / img.Width, (size - 12.0) / img.Height);
                    int w = (int)(img.Width * scale), h = (int)(img.Height * scale);
                    g.DrawImage(img, (size - w) / 2, (size - h) / 2, w, h);
                    g.ResetClip();
                    using var pen = new Pen(Color.FromArgb(221, 229, 228), 1);
                    g.DrawPath(pen, tile);
                    return bmp;
                }
                catch { /* fall to initials tile */ }
            }

            using (var b = new SolidBrush(Theme.Primary)) g.FillPath(b, tile);
            string initials = string.Concat(name.Split(' ', StringSplitOptions.RemoveEmptyEntries).Take(2).Select(p => char.ToUpper(p[0])));
            if (initials == "") initials = "?";
            using var f = new Font("Segoe UI", size * 0.32f, FontStyle.Bold, GraphicsUnit.Pixel);
            using var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            g.DrawString(initials, f, Brushes.White, new RectangleF(0, 0, size, size), sf);
            return bmp;
        }

        private static GraphicsPath RoundRect(Rectangle r, int radius)
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
    }
}
