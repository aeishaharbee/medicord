using medicord_v1.Screens;
using medicord_v1.Screens.Desktop;
using medicord_v1.Screens.Facility;
using medicord_v1.Screens.Worker;

namespace medicord_v1.Forms
{
    public partial class FacilityShell : Form
    {
        private SideNav? nav;

        public FacilityShell()
        {
            InitializeComponent();
            BackColor = Theme.Page;
            ShowLogin();
        }

        private void EnterApp()
        {
            pnlContent.Visible = false; pnlApp.Visible = true;
            BuildNav();
            AppEvents.RaiseProfileChanged();
            ShowPage("dash");
        }

        private void BuildNav()
        {
            if (nav != null) { pnlApp.Controls.Remove(nav); nav.Dispose(); }

            bool admin = Session.Role == "FacilityAdmin";
            nav = new SideNav
            {
                Dock = DockStyle.Left,
                Width = 320,
                Subtitle = admin ? "Facility portal" : "Health worker portal",
                UserName = Session.FullName,
                UserRole = admin ? "Administrator" : "Health worker"
            };

            nav.AddSection("OVERVIEW");
            nav.AddItem("dash", "Dashboard", "\uE80F");
            nav.AddItem("appt", "Appointments", "\uE787");
            nav.AddSection("MANAGE");
            nav.AddItem("pat", "Patients", "\uE716");
            nav.AddItem("rec", "Records", "\uE8A5");
            if (admin)
            {
                nav.AddItem("wk", "Health workers", "\uE95E");
                nav.AddItem("set", "Facility settings", "\uE713");
            }
            else
            {
                nav.AddItem("prof", "My profile", "\uE77B");
            }
            nav.AddFooter("out", "Log out", "\uE7E8");

            nav.ItemClicked += key =>
            {
                if (key == "out") 
                {
                    if (!Msg.Confirm("Are you sure you want to log out?", "Log out")) return;
                    Session.Clear(); ShowLogin(); 
                }
                else ShowPage(key);
            };

            pnlApp.Controls.Add(nav);
            pnlPage.BringToFront(); 

            RefreshBadge();
            AppEvents.DataChanged -= RefreshBadge; 
            AppEvents.DataChanged += RefreshBadge;
            Disposed += (s, e) => AppEvents.DataChanged -= RefreshBadge;

            AppEvents.ProfileChanged += RefreshNavUser;
            Disposed += (s, e) => AppEvents.ProfileChanged -= RefreshNavUser;
        }

        public void RefreshBadge() => nav?.SetBadge("appt", DashboardService.GetPendingCount());
        private void RefreshNavUser()
        {
            var id = NavIdentity.Load(76);
            nav?.UserName = id.Name;
            nav?.UserRole = id.Role;
            var old = nav?.Avatar;
            nav?.Avatar = id.Avatar;
            old?.Dispose();
        }

        private void ShowLogin()
        {
            pnlApp.Visible = false; pnlContent.Visible = true;
            var s = new DesktopLoginScreen();
            s.LoginSucceeded += (_, _) => EnterApp();
            s.CreateAccountClicked += (_, _) => ShowChooser();
            s.MobileClicked += (_, _) => AppFlow.Instance.ShowMobile();
            Nav.Show(pnlContent, s);
        }

        private void ShowPage(string key)
        {
            nav!.Select(key);

            UserControl page;
            switch (key)
            {
                case "appt":
                    page = new Screens.Desktop.AppointmentsScreen();
                    break;
                case "pat":
                    var p = new PatientsScreen();
                    p.ViewDetailsClicked += (_, id) =>
                    {
                        var d = new PatientDetailsScreen(id);
                        d.BackClicked += (_, _) => ShowPage("pat");
                        ShowDetails("pat", d);
                    };
                    page = p;
                    break;
                case "rec":
                    page = new Screens.Desktop.RecordsScreen();
                    break;
                case "wk":
                    var w = new WorkersScreen();
                    w.ViewDetailsClicked += (_, id) =>
                    {
                        var d = new WorkerDetailsScreen(id);
                        d.BackClicked += (_, _) => ShowPage("wk");
                        ShowDetails("wk", d);
                    };
                    page = w;
                    break;
                case "set":
                    page = new FacilitySettingsScreen();
                    break;
                case "prof":
                    page = new WorkerProfileScreen();
                    break;
                default: // "dash"
                    var dash = new DashboardScreen();
                    dash.ViewAllClicked += (_, _) => ShowPage("appt");
                    page = dash;
                    break;
            }
            Nav.Show(pnlPage, page);
            RefreshBadge(); 
        }

        private void ShowDetails(string key, UserControl page)
        {
            nav!.Select(key);
            Nav.Show(pnlPage, page);
        }

        private void ShowChooser()
        {
            var s = new RoleChooserScreen();
            s.FacilityChosen += (_, _) => ShowStep1(new FacilityRegData());
            s.WorkerChosen += (_, _) => ShowWorkerReg();
            s.BackClicked += (_, _) => ShowLogin();
            Nav.Show(pnlContent, s);
        }

        private void ShowStep1(FacilityRegData d)
        {
            var s = new FacilityStep1(d);
            s.BackClicked += (_, _) => ShowChooser();
            s.NextClicked += (_, _) => ShowStep2(d);
            Nav.Show(pnlContent, s);
        }
        private void ShowStep2(FacilityRegData d)
        {
            var s = new FacilityStep2(d);
            s.BackClicked += (_, _) => ShowStep1(d);
            s.NextClicked += (_, _) => ShowStep3(d);
            Nav.Show(pnlContent, s);
        }
        private void ShowStep3(FacilityRegData d)
        {
            var s = new FacilityStep3(d);
            s.BackClicked += (_, _) => ShowStep2(d);
            s.NextClicked += (_, _) => ShowStep4(d);
            Nav.Show(pnlContent, s);
        }
        private void ShowStep4(FacilityRegData d)
        {
            var s = new FacilityStep4(d);
            s.BackClicked += (_, _) => ShowStep3(d);
            s.RegisterSucceeded += (_, code) => ShowDone(code);
            Nav.Show(pnlContent, s);
        }

        private void ShowWorkerReg()
        {
            var s = new WorkerRegisterScreen();
            s.BackClicked += (_, _) => ShowChooser();
            s.RegisterSucceeded += (_, _) => ShowDone();
            Nav.Show(pnlContent, s);
        }

        private void ShowDone(string? facilityCode = null)
        {
            var s = new DesktopDoneScreen(facilityCode);
            s.LoginClicked += (_, _) => ShowLogin();
            Nav.Show(pnlContent, s);
        }
    }
}
