using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace medicord_v1.Forms
{
    public partial class MobileShell : Form
    {
        private enum NavTab { Home, Appts, Records, Profile }
        private readonly ActingBanner banner = new();
        public MobileShell()
        {
            InitializeComponent();

            banner.MyAccountClicked += (_, _) => BackToMyAccount();
            pnlContent.Parent!.Controls.Add(banner);
            banner.SendToBack();           
            banner.Sync();

            btnNavHome.Click += (_, _) => ShowTab(NavTab.Home);
            btnNavAppts.Click += (_, _) => ShowTab(NavTab.Appts);
            btnNavRecords.Click += (_, _) => ShowTab(NavTab.Records);
            btnNavProfile.Click += (_, _) => ShowTab(NavTab.Profile);

            ShowStart();
        }

        // start screen
        private void ShowStart()
        {
            pnlNav.Visible = false;
            var screen = new StartScreen();
            screen.LoginClicked += (_, _) => ShowLogin();
            screen.CreateAccountClicked += (_, _) => ShowRegister1(new PatientRegData());
            screen.DesktopClicked += (_, _) => AppFlow.Instance.ShowDesktop();
            Nav.Show(pnlContent, screen);
        }

        // login screen
        private void ShowLogin()
        {
            pnlNav.Visible = false;
            var screen = new LoginScreen();
            screen.BackClicked += (_, _) => ShowStart();
            screen.RegisterClicked += (_, _) => ShowRegister1(new PatientRegData());
            screen.LoginSucceeded += (_, _) => ShowTab(NavTab.Home);
            Nav.Show(pnlContent, screen);
        }

        // register screens
        private void ShowRegister1(PatientRegData data)
        {
            var screen = new RegisterStep1(data);
            screen.BackClicked += (_, _) => ShowStart();
            screen.NextClicked += (_, _) => ShowRegister2(data);
            Nav.Show(pnlContent, screen);
        }

        private void ShowRegister2(PatientRegData data)
        {
            var screen = new RegisterStep2(data);
            screen.BackClicked += (_, _) => ShowRegister1(data);
            screen.NextClicked += (_, _) => ShowRegister3(data);
            Nav.Show(pnlContent, screen);
        }

        private void ShowRegister3(PatientRegData data)
        {
            var screen = new RegisterStep3(data);
            screen.BackClicked += (_, _) => ShowRegister2(data);
            screen.RegisterSucceeded += (_, _) => ShowRegisterSuccess(data);
            Nav.Show(pnlContent, screen);
        }

        private void ShowRegisterSuccess(PatientRegData data)
        {
            var screen = new RegisterSuccess(data.FullName);
            screen.LoginClicked += (_, _) => ShowLogin();
            Nav.Show(pnlContent, screen);
        }

        // home screen
        private void ShowTab(NavTab tab)
        {
            pnlNav.Visible = true;
            HighlightNav(tab);

            UserControl screen = tab switch
            {
                NavTab.Home => BuildHome(),
                NavTab.Appts => BuildAppointments(),
                NavTab.Records => new RecordsScreen(),
                NavTab.Profile => BuildProfile(),
                _ => throw new ArgumentOutOfRangeException(nameof(tab))
            };
            Nav.Show(pnlContent, screen);
        }

        // navbar
        private void HighlightNav(NavTab active)
        {
            var buttons = new Dictionary<NavTab, SiticoneButtonAdvanced>
            {
                [NavTab.Home] = btnNavHome,
                [NavTab.Appts] = btnNavAppts,
                [NavTab.Records] = btnNavRecords,
                [NavTab.Profile] = btnNavProfile,
            };

            foreach (var (tab, btn) in buttons)
            {
                btn.BorderColor = tab == active ? Color.FromArgb(15, 76, 76) : Color.Transparent;
                btn.Invalidate();
            }
        }

        // screens
        private UserControl BuildHome()
        {
            var s = new HomeScreen();
            s.BookClicked += (_, _) => ShowBook();
            s.RecordsClicked += (_, _) => ShowTab(NavTab.Records);
            s.FacilitiesClicked += (_, _) => ShowNearby();
            s.SwitchProfileClicked += (_, _) => ShowSwitcher();
            return s;
        }

        private UserControl BuildAppointments()
        {
            var s = new AppointmentsScreen();
            s.BookClicked += (_, _) => ShowBook();
            return s;
        }

        private UserControl BuildProfile()
        {
            var s = new ProfileScreen();
            s.LogoutClicked += (_, _) => { if (!Msg.Confirm("Are you sure you want to log out?", "Log out")) return; Session.Clear(); ShowStart(); };
            s.EditClicked += (_, _) => ShowEditProfile();
            s.DependentsClicked += (_, _) => ShowDependents(); s.BackToMineClicked += (_, _) => BackToMyAccount();
            return s;
        }

        //facility
        private void ShowNearby()
        {
            var s = new NearbyFacilitiesScreen();
            s.FacilityClicked += id => ShowFacility(id);
            Nav.Show(pnlContent, s);
        }
        private void ShowFacility(int id)
        {
            var s = new FacilityDetailScreen(id);
            s.BackClicked += (_, _) => ShowNearby();
            s.BookClicked += _ => ShowTab(NavTab.Appts);      
            Nav.Show(pnlContent, s);
        }

        // profile
        private void ShowEditProfile()
        {
            var s = new EditProfileScreen();
            s.BackClicked += (_, _) => ShowTab(NavTab.Profile);
            s.Saved += (_, _) => ShowTab(NavTab.Profile);
            s.AccountClicked += (_, _) => ShowAccountDetails();
            Nav.Show(pnlContent, s);
        }

        private void ShowAccountDetails()
        {
            var s = new AccountDetailsScreen();
            s.BackClicked += (_, _) => ShowEditProfile();
            s.Saved += (_, _) => ShowTab(NavTab.Profile);             
            Nav.Show(pnlContent, s);
        }

        // booking 
        private void ShowBook()
        {
            pnlNav.Visible = false;
            HighlightNav(NavTab.Appts);
            var s = new BookAppointmentScreen();
            s.BackClicked += (_, _) => ShowTab(NavTab.Appts);
            s.Booked += (_, _) => ShowBookingSuccess();
            Nav.Show(pnlContent, s);
        }

        private void ShowBookingSuccess()
        {
            var s = new BookingSuccessScreen();
            s.DoneClicked += (_, _) => ShowTab(NavTab.Appts);
            Nav.Show(pnlContent, s);
        }

        //dependents screen
        private void ShowSwitcher()
        {
            using var f = new SwitchProfileForm();
            if (f.ShowDialog(this) != DialogResult.OK) return;
            if (f.Manage) { ShowDependents(); return; }
            if (f.SelectedID == 0) BackToMyAccount(); else SwitchTo(f.SelectedID);
        }

        private void SwitchTo(int id)
        {
            if (!DependentService.SwitchTo(id)) { Msg.Error("This dependent is no longer available."); return; }
            banner.Sync(); AppEvents.RaiseProfileChanged(); ShowTab(NavTab.Home);
        }

        private void BackToMyAccount()
        {
            Session.ActAsSelf();
            banner.Sync(); AppEvents.RaiseProfileChanged(); ShowTab(NavTab.Home);
        }

        private void ShowDependents()
        {
            var s = new DependentsScreen();
            s.BackClicked += (_, _) => ShowTab(NavTab.Profile);
            s.AddClicked += (_, _) => ShowAddDependent();
            s.OpenClicked += id => ShowDependentDetail(id);
            Nav.Show(pnlContent, s);
        }

        private void ShowAddDependent()
        {
            var s = new AddDependentScreen();
            s.BackClicked += (_, _) => ShowDependents();
            s.DoneClicked += (_, _) => ShowDependents();
            s.SwitchRequested += id => SwitchTo(id);
            Nav.Show(pnlContent, s);
        }

        private void ShowDependentDetail(int id)
        {
            var s = new DependentDetailScreen(id);
            s.BackClicked += (_, _) => ShowDependents();
            s.SwitchRequested += i => SwitchTo(i);
            s.EditRequested += i => ShowEditDependent(i);
            s.Removed += (_, _) => ShowDependents();
            Nav.Show(pnlContent, s);
        }

        private void ShowEditDependent(int id)
        {
            var s = new EditDependentScreen(id);
            s.BackClicked += (_, _) => ShowDependentDetail(id);
            s.Saved += (_, _) => ShowDependentDetail(id);
            Nav.Show(pnlContent, s);
        }
    }
}
