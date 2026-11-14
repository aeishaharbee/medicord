using System;
using System.Collections.Generic;
using System.Text;

namespace medicord_v1.Services
{
    public enum BookResult { Success, SlotTaken, AlreadyBookedThatDay, FacilityClosed }

    public static class AppointmentService
    {
        // generate slotsfrom facilitys hours n slot length & remove slots that already full
        public static List<TimeSpan> GetAvailableSlots(int facilityId, DateTime date)
        {
            if (IsFacilityClosed(facilityId, date)) return new List<TimeSpan>();

            var fac = Database.GetTable(
                @"SELECT OpenTime, CloseTime, SlotDurationMin, MaxPerSlot
              FROM HealthFacilities WHERE FacilityID = @f",
                new SqlParameter("@f", facilityId));
            if (fac.Rows.Count == 0) return new List<TimeSpan>();

            var open = (TimeSpan)fac.Rows[0]["OpenTime"];
            var close = (TimeSpan)fac.Rows[0]["CloseTime"];
            var length = TimeSpan.FromMinutes((int)fac.Rows[0]["SlotDurationMin"]);
            int max = (int)fac.Rows[0]["MaxPerSlot"];

            var booked = Database.GetTable(
                @"SELECT ApptTime, COUNT(*) AS Cnt
              FROM Appointments
              WHERE FacilityID = @f AND ApptDate = @d AND Status IN ('Pending','Approved')
              GROUP BY ApptTime",
                new SqlParameter("@f", facilityId),
                new SqlParameter("@d", SqlDbType.Date) { Value = date.Date });

            var used = booked.AsEnumerable()
                             .ToDictionary(r => (TimeSpan)r["ApptTime"], r => (int)r["Cnt"]);

            var slots = new List<TimeSpan>();
            for (var t = open; t + length <= close; t += length)
            {
                used.TryGetValue(t, out int count);
                if (count < max) slots.Add(t);
            }

            if (date.Date == DateTime.Today) //hide slots already passed
                slots.RemoveAll(t => t <= DateTime.Now.TimeOfDay);

            return slots;
        }

        public static BookResult Book(int patientId, int facilityId, string purpose,
                                      string symptoms, DateTime date, TimeSpan time)
        {
            if (IsFacilityClosed(facilityId, date)) return BookResult.FacilityClosed;

            SqlParameter D() => new("@d", SqlDbType.Date) { Value = date.Date };
            SqlParameter T() => new("@t", SqlDbType.Time) { Value = time };

            // one active request per patient, per facility, per day
            int dup = Convert.ToInt32(Database.Scalar(
                @"SELECT COUNT(*) FROM Appointments
              WHERE PatientID = @p AND FacilityID = @f AND ApptDate = @d
                AND Status IN ('Pending','Approved')",
                new SqlParameter("@p", patientId), new SqlParameter("@f", facilityId), D()));
            if (dup > 0) return BookResult.AlreadyBookedThatDay;

            // capacity check inside INSERT so two people cant grab last slot together
            int rows = Database.Execute(
                @"INSERT INTO Appointments (PatientID, FacilityID, Purpose, Symptoms, ApptDate, ApptTime)
              SELECT @p, @f, @purpose, @sym, @d, @t
              WHERE (SELECT COUNT(*) FROM Appointments
                     WHERE FacilityID = @f AND ApptDate = @d AND ApptTime = @t
                       AND Status IN ('Pending','Approved'))
                    < (SELECT MaxPerSlot FROM HealthFacilities WHERE FacilityID = @f)",
                new SqlParameter("@p", patientId),
                new SqlParameter("@f", facilityId),
                new SqlParameter("@purpose", purpose),
                new SqlParameter("@sym", string.IsNullOrWhiteSpace(symptoms) ? DBNull.Value : symptoms),
                D(), T());

            return rows > 0 ? BookResult.Success : BookResult.SlotTaken;
        }

        public static DataTable GetMyAppointments() => Database.GetTable(
            @"SELECT a.AppointmentID, a.ApptDate, a.ApptTime, a.Purpose, a.Status,
                        f.FacilityName, ISNULL(w.FullName, '') AS Doctor
                FROM Appointments a
                JOIN HealthFacilities f ON f.FacilityID = a.FacilityID
                LEFT JOIN HealthWorkers w ON w.WorkerID = a.WorkerID
                WHERE a.PatientID=@p", new SqlParameter("@p", Session.PatientID));

        public static bool Cancel(int appointmentId) => Database.Execute(
            @"UPDATE Appointments SET Status='Cancelled'
            WHERE AppointmentID=@id AND PatientID=@p AND Status IN ('Pending','Approved')
            AND ApptDate >= CAST(GETDATE() AS DATE)",
            new SqlParameter("@id", appointmentId), new SqlParameter("@p", Session.UserID)) > 0;

        // upcoming appointment for patient homescreen
        public record NextAppointment(DateTime Date, TimeSpan Time, string Facility, string Purpose, string Status, string Doctor);

        public static NextAppointment? GetNextAppointment(int patientId)
        {
            var dt = Database.GetTable(
                @"SELECT TOP 1 a.ApptDate, a.ApptTime, f.FacilityName, a.Purpose, a.Status, ISNULL(w.FullName, '') AS Doctor
          FROM Appointments a
          JOIN HealthFacilities f ON f.FacilityID = a.FacilityID
          LEFT JOIN HealthWorkers w ON w.WorkerID = a.WorkerID
          WHERE a.PatientID = @p AND a.Status IN ('Pending','Approved')
            AND a.ApptDate >= CAST(GETDATE() AS DATE)
          ORDER BY a.ApptDate, a.ApptTime",
                new SqlParameter("@p", patientId));

            if (dt.Rows.Count == 0) return null;
            var r = dt.Rows[0];
            return new NextAppointment(((DateTime)r["ApptDate"]).Date, (TimeSpan)r["ApptTime"],
                r["FacilityName"].ToString() ?? "", r["Purpose"].ToString() ?? "",
                r["Status"].ToString() ?? "", r["Doctor"].ToString() ?? "");
        }

        //closed days
        public static bool IsFacilityClosed(int facilityId, DateTime date)
        {
            int dow = ((int)date.DayOfWeek + 6) % 7;            //Mon=0 ... Sun=6
            var v = Database.Scalar(
                @"SELECT CASE
              WHEN EXISTS (SELECT 1 FROM FacilityOpenDays WHERE FacilityID=@f)
               AND NOT EXISTS (SELECT 1 FROM FacilityOpenDays WHERE FacilityID=@f AND DayOfWeek=@w) THEN 1
              WHEN EXISTS (SELECT 1 FROM FacilityClosures WHERE FacilityID=@f AND @d BETWEEN StartDate AND EndDate) THEN 1
              ELSE 0 END",
                new SqlParameter("@f", facilityId), new SqlParameter("@w", dow),
                new SqlParameter("@d", SqlDbType.Date) { Value = date.Date });
            return Convert.ToInt32(v) == 1;
        }

        // every date in [from, to] the picker should lock
        public static List<DateTime> GetLockedDates(int facilityId, DateTime from, DateTime to)
        {
            var openDays = Database.GetTable("SELECT DayOfWeek FROM FacilityOpenDays WHERE FacilityID=@f",
                                             new SqlParameter("@f", facilityId))
                                   .Rows.Cast<DataRow>().Select(r => Convert.ToInt32(r[0])).ToHashSet();

            var closures = Database.GetTable(
                "SELECT StartDate, EndDate FROM FacilityClosures WHERE FacilityID=@f AND EndDate >= @a AND StartDate <= @b",
                new SqlParameter("@f", facilityId),
                new SqlParameter("@a", SqlDbType.Date) { Value = from.Date },
                new SqlParameter("@b", SqlDbType.Date) { Value = to.Date })
                .Rows.Cast<DataRow>().Select(r => (Start: ((DateTime)r[0]).Date, End: ((DateTime)r[1]).Date)).ToList();

            var locked = new List<DateTime>();
            for (var d = from.Date; d <= to.Date; d = d.AddDays(1))
            {
                int dow = ((int)d.DayOfWeek + 6) % 7 
                    ;
                bool closedWeekday = openDays.Count > 0 && !openDays.Contains(dow);
                bool inClosure = closures.Any(c => d >= c.Start && d <= c.End);
                if (closedWeekday || inClosure) locked.Add(d);
            }
            return locked;
        }
    }
}
