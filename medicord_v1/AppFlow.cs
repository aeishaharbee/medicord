using System;
using System.Collections.Generic;
using System.Text;

namespace medicord_v1
{
    public class AppFlow : ApplicationContext
    {
        public static AppFlow Instance { get; private set; } = null!;
        private Form? current;

        public AppFlow() { Instance = this; ShowDesktop(); }

        public void ShowMobile() => Swap(new MobileShell());
        public void ShowDesktop() => Swap(new FacilityShell());

        private void Swap(Form next)
        {
            Session.Clear();
            var old = current;
            current = next;
            next.StartPosition = FormStartPosition.CenterScreen;
            next.FormClosed += (_, _) => { if (current == next) ExitThread(); }; 
            next.Show();
            if (old != null)
            {
                old.Hide();
                old.BeginInvoke(new Action(old.Close));   
            }
        }
    }
}
