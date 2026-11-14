using System;
using System.Data;
using Microsoft.Data.SqlClient;
using medicord_v1.Data;

namespace medicord_v1.Services
{
    public class KpiSet
    {
        public int Today, Completed, OnDuty, Pending, SlotsBooked, SlotsTotal;
        public string TodayTrend = "", CompletedTrend = "", DutyTrend = "", PendingTrend = "";
        public bool ClosedToday;
    }

    public static class DashboardService
    {
        private static int N(object? o) => o == null || o == DBNull.Value ? 0 : Convert.ToInt32(o);
        private static SqlParameter D(string name, DateTime d) => new(name, SqlDbType.Date) { Value = d.Date };

        public static int GetPendingCount() =>
            N(Database.Scalar("SELECT COUNT(*) FROM Appointments WHERE FacilityID=@f AND Status='Pending'",
                              new SqlParameter("@f", Session.FacilityID)));

        public static KpiSet GetKpis()
        {
            int f = Session.FacilityID;
            DateTime today = DateTime.Today, lastWeek = today.AddDays(-7);
            int dow = ((int)today.DayOfWeek + 6) % 7;          

            //appointment count today except rejected or cancelled
            const string live = "AND Status IN ('Pending','Approved','Completed')";

            int CountOn(DateTime day, string extra) => N(Database.Scalar(
                $"SELECT COUNT(*) FROM Appointments WHERE FacilityID=@f AND ApptDate=@d {extra}",
                new SqlParameter("@f", f), D("@d", day)));

            var k = new KpiSet();

            //is facility open today?
            int openRows = N(Database.Scalar("SELECT COUNT(*) FROM FacilityOpenDays WHERE FacilityID=@f",
                                             new SqlParameter("@f", f)));
            bool openDay = openRows == 0 || N(Database.Scalar(
                "SELECT COUNT(*) FROM FacilityOpenDays WHERE FacilityID=@f AND [DayOfWeek]=@dow",
                new SqlParameter("@f", f), new SqlParameter("@dow", dow))) > 0;
            bool closure = N(Database.Scalar(
                "SELECT COUNT(*) FROM FacilityClosures WHERE FacilityID=@f AND @d BETWEEN StartDate AND EndDate",
                new SqlParameter("@f", f), D("@d", today))) > 0;
            k.ClosedToday = !openDay || closure;

            //1. todays appointments, compared with same weekday last week
            k.Today = CountOn(today, live);
            int before = CountOn(lastWeek, live);
            string wd = lastWeek.ToString("ddd");
            k.TodayTrend = k.ClosedToday ? "Closed today"
                : k.Today > before ? $"+{k.Today - before} vs last {wd}"
                : k.Today < before ? $"-{before - k.Today} vs last {wd}"
                : $"Same as last {wd}";

            //2. completed, how many are still waiting
            k.Completed = CountOn(today, "AND Status='Completed'");
            int left = CountOn(today, "AND Status='Approved'");
            k.CompletedTrend = left > 0 ? $"{left} left" : k.Completed > 0 ? "All done" : "None yet";

            //3. health workers on duty today out of total staff
            int totalStaff = N(Database.Scalar("SELECT COUNT(*) FROM HealthWorkers WHERE FacilityID=@f",
                                               new SqlParameter("@f", f)));
            k.OnDuty = k.ClosedToday ? 0 : N(Database.Scalar(
                @"SELECT COUNT(*) FROM HealthWorkers w
                  JOIN WorkerWorkDays d ON d.WorkerID = w.WorkerID
                  WHERE w.FacilityID=@f AND d.[DayOfWeek]=@dow",
                new SqlParameter("@f", f), new SqlParameter("@dow", dow)));

            k.DutyTrend = k.ClosedToday ? "Closed today"
             : totalStaff == 0 ? "No staff"
             : k.OnDuty == totalStaff ? "All on duty"
             : $"{k.OnDuty} of {totalStaff} staff";

            //4. pending requests (all dates)
            k.Pending = GetPendingCount();
            k.PendingTrend = k.Pending > 0 ? "Needs action" : "All clear";

            return k;
        }
    }
}