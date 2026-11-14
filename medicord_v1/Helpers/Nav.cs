namespace medicord_v1.Helpers
{
    public interface IOwnScroll { }

    public static class Nav
    {
        public static void Show(Control host, UserControl page)
        {
            host.SuspendLayout();
            foreach (Control old in host.Controls.Cast<Control>().ToList())
            {
                host.Controls.Remove(old);
                old.Dispose();
            }

            if (page is not IOwnScroll)
            {
                page.AutoScroll = true;
                page.AutoScrollMinSize = new Size(0, page.Height);

                page.MouseEnter += (_, _) => { if (!page.ContainsFocus) page.Focus(); };
            }

            page.Dock = DockStyle.Fill;
            host.Controls.Add(page);
            host.ResumeLayout();
        }
    }
}
