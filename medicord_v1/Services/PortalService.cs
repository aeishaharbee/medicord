using System;
using System.Collections.Generic;
using System.Text;

namespace medicord_v1.Services
{
    public static class PortalService
    {
        private static bool IsWorker => Session.Role == "HealthWorker";
        private static string WorkerScope => IsWorker ? " AND a.WorkerID = @w" : "";
        public static int DayOfWeekNumber(DateTime d) => ((int)d.DayOfWeek + 6) % 7; // Mon=0 ... Sun=6

        private static List<SqlParameter> Base(DateTime? day = null)
        {
            var l = new List<SqlParameter> { new SqlParameter("@f", Session.FacilityID), new SqlParameter("@w", Session.UserID) };
            if (day != null) l.Add(new SqlParameter("@d", SqlDbType.Date) { Value = day.Value.Date });
            return l;
        }
        private static int Count(string sql, List<SqlParameter> ps) => Convert.ToInt32(Database.Scalar(sql, ps.ToArray()));

        //dashboard
        public static (int Today, int Completed, int OnDuty, int Pending) DashboardCounts()
        {
            var today = DateTime.Today;
            int a = Count("SELECT COUNT(*) FROM Appointments a WHERE a.FacilityID=@f AND a.ApptDate=@d AND a.Status NOT IN ('Cancelled','Rejected')" + WorkerScope, Base(today));
            int b = Count("SELECT COUNT(*) FROM Appointments a WHERE a.FacilityID=@f AND a.ApptDate=@d AND a.Status='Completed'" + WorkerScope, Base(today));

            var pd = Base(today);
            pd.Add(new SqlParameter("@dow", DayOfWeekNumber(today)));
            int c = Count(@"SELECT COUNT(DISTINCT w.WorkerID) FROM HealthWorkers w
                        JOIN WorkerWorkDays d ON d.WorkerID = w.WorkerID
                        WHERE w.FacilityID=@f AND d.DayOfWeek=@dow" + (IsWorker ? " AND w.WorkerID=@w" : ""), pd);

            int e = Count("SELECT COUNT(*) FROM Appointments a WHERE a.FacilityID=@f AND a.ApptDate>=@d AND a.Status='Pending'" + WorkerScope, Base(today));
            return (a, b, c, e);
        }

        //appointments
        public static DataTable GetAppointments(DateTime day, string? status)
        {
            string sql = @"SELECT a.AppointmentID, a.PatientID, a.WorkerID,
                              CONVERT(VARCHAR(5), a.ApptTime, 108) AS [Time],
                              p.FullName AS [Patient], a.Purpose AS [Purpose],
                              ISNULL(NULLIF(a.Symptoms, ''), '-') AS [Symptoms],
                              ISNULL(w.FullName, '-') AS [Doctor], a.Status AS [Status]
                       FROM Appointments a
                       JOIN Patients p ON p.PatientID = a.PatientID
                       LEFT JOIN HealthWorkers w ON w.WorkerID = a.WorkerID
                       WHERE a.FacilityID=@f AND a.ApptDate=@d"
                         + (status != null ? " AND a.Status=@s" : "") + WorkerScope + " ORDER BY a.ApptTime";
            var ps = Base(day);
            if (status != null) ps.Add(new SqlParameter("@s", status));
            return Database.GetTable(sql, ps.ToArray());
        }

        public static DataTable GetAvailableWorkers(DateTime date, TimeSpan time) => Database.GetTable(
            @"SELECT w.WorkerID, w.FullName + ' (' + w.MedicalRole + ')' AS Display
              FROM HealthWorkers w
              WHERE w.FacilityID=@f
                AND EXISTS (SELECT 1 FROM WorkerWorkDays d WHERE d.WorkerID=w.WorkerID AND d.DayOfWeek=@dow)
                AND NOT EXISTS (SELECT 1 FROM Appointments a
                                WHERE a.WorkerID=w.WorkerID AND a.ApptDate=@d AND a.ApptTime=@t
                                  AND a.Status IN ('Approved','Completed'))
              ORDER BY w.FullName",
            new SqlParameter("@f", Session.FacilityID),
            new SqlParameter("@dow", DayOfWeekNumber(date)),
            new SqlParameter("@d", SqlDbType.Date) { Value = date.Date },
            new SqlParameter("@t", SqlDbType.Time) { Value = time });

        public enum ApproveResult { Approved, NotPending, SlotFull, DoctorUnavailable, FacilityClosed }

        // how many rooms are taken at this exact date and time, and how many the facility has
        public static (int Used, int Max) SlotUsage(DateTime date, TimeSpan time)
        {
            var ps = Base(date);
            ps.Add(new SqlParameter("@t", SqlDbType.Time) { Value = time });
            int used = Count(@"SELECT COUNT(*) FROM Appointments a
                       WHERE a.FacilityID=@f AND a.ApptDate=@d AND a.ApptTime=@t
                         AND a.Status IN ('Approved','Completed')", ps);
            int max = Convert.ToInt32(Database.Scalar(
                "SELECT MaxPerSlot FROM HealthFacilities WHERE FacilityID=@f",
                new SqlParameter("@f", Session.FacilityID)));
            return (used, max);
        }

        // approves a Pending appointment and assigns the doctor, after checking the slot and the doctor again
        public static ApproveResult ApproveAppointment(int appointmentId, int workerId)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction(IsolationLevel.Serializable);

            int Q(string sql, params SqlParameter[] ps)
            {
                using var c = new SqlCommand(sql, conn, tx);
                c.Parameters.AddRange(ps);
                return Convert.ToInt32(c.ExecuteScalar());
            }

            // 1. still Pending, and belongs to this facility?
            DateTime date; TimeSpan time;
            using (var cmd = new SqlCommand(
                "SELECT ApptDate, ApptTime FROM Appointments WHERE AppointmentID=@id AND FacilityID=@f AND Status='Pending'", conn, tx))
            {
                cmd.Parameters.AddWithValue("@id", appointmentId);
                cmd.Parameters.AddWithValue("@f", Session.FacilityID);
                using var rd = cmd.ExecuteReader();
                if (!rd.Read()) return ApproveResult.NotPending;
                date = rd.GetDateTime(0);
                time = rd.GetTimeSpan(1);
            }

            SqlParameter F() => new SqlParameter("@f", Session.FacilityID);
            SqlParameter D() => new SqlParameter("@d", SqlDbType.Date) { Value = date.Date };
            SqlParameter T() => new SqlParameter("@t", SqlDbType.Time) { Value = time };

            // facility open that weekday and not inside a closed period?
            int open = Q("SELECT COUNT(*) FROM FacilityOpenDays WHERE FacilityID=@f AND DayOfWeek=@dow",
                         F(), new SqlParameter("@dow", DayOfWeekNumber(date)));
            int closed = Q("SELECT COUNT(*) FROM FacilityClosures WHERE FacilityID=@f AND @d BETWEEN StartDate AND EndDate", F(), D());
            if (open == 0 || closed > 0) return ApproveResult.FacilityClosed;

            // 2. is the slot already full?
            int used = Q(@"SELECT COUNT(*) FROM Appointments WHERE FacilityID=@f AND ApptDate=@d AND ApptTime=@t
                   AND Status IN ('Approved','Completed')", F(), D(), T());
            int max = Q("SELECT MaxPerSlot FROM HealthFacilities WHERE FacilityID=@f", F());
            if (used >= max) return ApproveResult.SlotFull;

            // 3. does the doctor work that weekday and have no other appointment at that time?
            int ok = Q(@"SELECT COUNT(*) FROM HealthWorkers w
                 WHERE w.WorkerID=@w AND w.FacilityID=@f
                   AND EXISTS (SELECT 1 FROM WorkerWorkDays d WHERE d.WorkerID=w.WorkerID AND d.DayOfWeek=@dow)
                   AND NOT EXISTS (SELECT 1 FROM Appointments a
                                   WHERE a.WorkerID=w.WorkerID AND a.ApptDate=@d AND a.ApptTime=@t
                                     AND a.Status IN ('Approved','Completed'))",
                       new SqlParameter("@w", workerId), F(), D(), T(),
                       new SqlParameter("@dow", DayOfWeekNumber(date)));
            if (ok == 0) return ApproveResult.DoctorUnavailable;

            // 4. approve
            Q("UPDATE Appointments SET Status='Approved', WorkerID=@w WHERE AppointmentID=@id AND Status='Pending'; SELECT 1",
              new SqlParameter("@w", workerId), new SqlParameter("@id", appointmentId));
            tx.Commit();
            return ApproveResult.Approved;
        }

        public enum ReassignResult { Reassigned, NotEditable, DoctorUnavailable }

        public static ReassignResult ReassignWorker(int appointmentId, int newWorkerId)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction(IsolationLevel.Serializable);

            int Q(string sql, params SqlParameter[] ps)
            {
                using var c = new SqlCommand(sql, conn, tx);
                c.Parameters.AddRange(ps);
                return Convert.ToInt32(c.ExecuteScalar());
            }

            //1. still Approved, in this facility, and not in the past?
            DateTime date; TimeSpan time;
            using (var cmd = new SqlCommand(
                @"SELECT ApptDate, ApptTime FROM Appointments
          WHERE AppointmentID=@id AND FacilityID=@f AND Status='Approved' AND ApptDate >= CAST(GETDATE() AS DATE)", conn, tx))
            {
                cmd.Parameters.AddWithValue("@id", appointmentId);
                cmd.Parameters.AddWithValue("@f", Session.FacilityID);
                using var rd = cmd.ExecuteReader();
                if (!rd.Read()) return ReassignResult.NotEditable;
                date = rd.GetDateTime(0);
                time = rd.GetTimeSpan(1);
            }

            //2. new doctor work that weekday and have no other appointment at that time?
            int ok = Q(@"SELECT COUNT(*) FROM HealthWorkers w
                 WHERE w.WorkerID=@w AND w.FacilityID=@f
                   AND EXISTS (SELECT 1 FROM WorkerWorkDays d WHERE d.WorkerID=w.WorkerID AND d.DayOfWeek=@dow)
                   AND NOT EXISTS (SELECT 1 FROM Appointments a
                                   WHERE a.WorkerID=w.WorkerID AND a.ApptDate=@d AND a.ApptTime=@t
                                     AND a.AppointmentID<>@id AND a.Status IN ('Approved','Completed'))",
                       new SqlParameter("@w", newWorkerId), new SqlParameter("@f", Session.FacilityID),
                       new SqlParameter("@d", SqlDbType.Date) { Value = date.Date },
                       new SqlParameter("@t", SqlDbType.Time) { Value = time },
                       new SqlParameter("@dow", DayOfWeekNumber(date)), new SqlParameter("@id", appointmentId));
            if (ok == 0) return ReassignResult.DoctorUnavailable;

            //3. change doctor
            int rows = Q("UPDATE Appointments SET WorkerID=@w WHERE AppointmentID=@id AND Status='Approved'; SELECT @@ROWCOUNT",
                         new SqlParameter("@w", newWorkerId), new SqlParameter("@id", appointmentId));
            if (rows == 0) return ReassignResult.NotEditable;

            tx.Commit();
            return ReassignResult.Reassigned;
        }


        public static bool SetStatus(int appointmentId, string newStatus, params string[] allowedFrom)
        {
            var ps = new List<SqlParameter>
            {
                new SqlParameter("@n", newStatus), new SqlParameter("@id", appointmentId),
                new SqlParameter("@f", Session.FacilityID)
            };
            var names = new List<string>();
            for (int i = 0; i < allowedFrom.Length; i++)
            {
                names.Add("@s" + i);
                ps.Add(new SqlParameter("@s" + i, allowedFrom[i]));
            }
            return Database.Execute(
                $"UPDATE Appointments SET Status=@n WHERE AppointmentID=@id AND FacilityID=@f AND Status IN ({string.Join(",", names)})",
                ps.ToArray()) > 0;
        }

        //patients
        public static DataTable GetPatients(string search)
        {
            var ps = Base();
            ps.Add(new SqlParameter("@q", "%" + search + "%"));
            return Database.GetTable(
                @"SELECT p.PatientID, p.FullName AS [Name], p.IdType + ' - ' + p.IdNumber AS [ID], p.Phone AS [Phone],
                     ISNULL(CONVERT(VARCHAR(10), MAX(CASE WHEN a.Status='Completed' THEN a.ApptDate END), 23), '-') AS [Last visit]
              FROM Patients p JOIN Appointments a ON a.PatientID = p.PatientID
              WHERE a.FacilityID=@f AND (p.FullName LIKE @q OR p.IdNumber LIKE @q OR p.Phone LIKE @q)" + WorkerScope + @"
              GROUP BY p.PatientID, p.FullName, p.IdType, p.IdNumber, p.Phone
              ORDER BY p.FullName", ps.ToArray());
        }

        //health workers
        public static DataTable GetWorkers() => Database.GetTable(
            @"SELECT w.WorkerID, w.FullName AS [Name], w.MedicalRole AS [Role], w.Phone AS [Phone],
                 ISNULL(STUFF((SELECT ', ' + CASE d.DayOfWeek WHEN 0 THEN 'Mon' WHEN 1 THEN 'Tue' WHEN 2 THEN 'Wed'
                                    WHEN 3 THEN 'Thu' WHEN 4 THEN 'Fri' WHEN 5 THEN 'Sat' ELSE 'Sun' END
                               FROM WorkerWorkDays d WHERE d.WorkerID = w.WorkerID ORDER BY d.DayOfWeek
                               FOR XML PATH('')), 1, 2, ''), '-') AS [Working days]
          FROM HealthWorkers w WHERE w.FacilityID=@f ORDER BY w.FullName",
            new SqlParameter("@f", Session.FacilityID));

        public static List<int> GetWorkDays(int workerId) =>
            Database.GetTable("SELECT DayOfWeek FROM WorkerWorkDays WHERE WorkerID=@w",
                new SqlParameter("@w", workerId)).Rows.Cast<DataRow>().Select(r => Convert.ToInt32(r[0])).ToList();

        public static void SetWorkDays(int workerId, List<int> days)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                using (var chk = new SqlCommand("SELECT COUNT(*) FROM HealthWorkers WHERE WorkerID=@w AND FacilityID=@f", conn, tx))
                {
                    chk.Parameters.AddWithValue("@w", workerId);
                    chk.Parameters.AddWithValue("@f", Session.FacilityID);
                    if ((int)chk.ExecuteScalar()! == 0) throw new InvalidOperationException("That worker is not in your facility.");
                }
                using (var del = new SqlCommand("DELETE FROM WorkerWorkDays WHERE WorkerID=@w", conn, tx))
                {
                    del.Parameters.AddWithValue("@w", workerId);
                    del.ExecuteNonQuery();
                }
                foreach (int day in days)
                {
                    using var ins = new SqlCommand("INSERT INTO WorkerWorkDays (WorkerID, DayOfWeek) VALUES (@w,@d)", conn, tx);
                    ins.Parameters.AddWithValue("@w", workerId);
                    ins.Parameters.AddWithValue("@d", day);
                    ins.ExecuteNonQuery();
                }
                tx.Commit();
            }
            catch { tx.Rollback(); throw; }
        }

        public static int CountWorkerAppointmentsOnDays(int workerId, IEnumerable<int> weekdays)
        {
            var list = weekdays.Where(d => d >= 0 && d <= 6).Distinct().ToList();
            if (list.Count == 0) return 0;
            string inList = string.Join(",", list);  

            return Convert.ToInt32(Database.Scalar(
                $@"SELECT COUNT(*) FROM Appointments
           WHERE WorkerID=@w AND FacilityID=@f AND Status IN ('Pending','Approved')
             AND ApptDate >= CAST(GETDATE() AS DATE)
             AND (DATEDIFF(DAY, '19000101', ApptDate) % 7) IN ({inList})",
                new SqlParameter("@w", workerId), new SqlParameter("@f", Session.FacilityID)));
        }

        //facility settings
        public static DataRow GetFacility() => Database.GetTable(
            "SELECT * FROM HealthFacilities WHERE FacilityID=@f", new SqlParameter("@f", Session.FacilityID)).Rows[0];

        public static void UpdateFacility(FacilityRegData d)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                using (var cmd = new SqlCommand(
                    @"UPDATE HealthFacilities SET FacilityName=@n, AddressLine=@a, City=@c, Postcode=@pc, State=@s, Phone=@ph,
                     OpenTime=@o, CloseTime=@cl, SlotDurationMin=@sd, MaxPerSlot=@mp, WalkInAvailable=@w
              WHERE FacilityID=@f", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@n", d.Name);
                    cmd.Parameters.AddWithValue("@a", d.Address);
                    cmd.Parameters.AddWithValue("@c", d.City);
                    cmd.Parameters.AddWithValue("@pc", d.Postcode);
                    cmd.Parameters.AddWithValue("@s", d.State);
                    cmd.Parameters.AddWithValue("@ph", d.Phone);
                    cmd.Parameters.Add("@o", SqlDbType.Time).Value = d.OpenTime;
                    cmd.Parameters.Add("@cl", SqlDbType.Time).Value = d.CloseTime;
                    cmd.Parameters.AddWithValue("@sd", d.SlotMinutes);
                    cmd.Parameters.AddWithValue("@mp", d.MaxPerSlot);
                    cmd.Parameters.AddWithValue("@w", d.WalkInAvailable);
                    cmd.Parameters.AddWithValue("@f", Session.FacilityID);
                    cmd.ExecuteNonQuery();
                }

                if (d.LogoChanged)
                {
                    using var cmd = new SqlCommand("UPDATE HealthFacilities SET Logo=@l WHERE FacilityID=@f", conn, tx);
                    cmd.Parameters.Add("@l", SqlDbType.VarBinary, -1).Value = (object?)d.Logo ?? DBNull.Value;
                    cmd.Parameters.AddWithValue("@f", Session.FacilityID);
                    cmd.ExecuteNonQuery();
                }

                using (var del = new SqlCommand("DELETE FROM FacilityOpenDays WHERE FacilityID=@f", conn, tx))
                {
                    del.Parameters.AddWithValue("@f", Session.FacilityID);
                    del.ExecuteNonQuery();
                }
                foreach (int day in d.OpenDays)
                {
                    using var ins = new SqlCommand("INSERT INTO FacilityOpenDays (FacilityID, DayOfWeek) VALUES (@f,@d)", conn, tx);
                    ins.Parameters.AddWithValue("@f", Session.FacilityID);
                    ins.Parameters.AddWithValue("@d", day);
                    ins.ExecuteNonQuery();
                }
                tx.Commit();
            }
            catch { tx.Rollback(); throw; }
        }

        //facility view patient details
        public static DataRow? GetPatientDetails(int patientId)
        {
            var ps = Base(); ps.Add(new SqlParameter("@p", patientId));
            var dt = Database.GetTable(
                @"SELECT p.PatientID, p.FullName, p.Nationality, p.IdType, p.IdNumber, p.Phone, p.City, p.State, p.Postcode,
                 u.Email, CONVERT(VARCHAR(10), u.DateCreated, 23) AS Registered
          FROM Patients p JOIN Users u ON u.UserID = p.PatientID
          WHERE p.PatientID=@p
            AND EXISTS (SELECT 1 FROM Appointments a
                        WHERE a.PatientID = p.PatientID AND a.FacilityID=@f" + (IsWorker ? " AND a.WorkerID=@w" : "") + ")",
                ps.ToArray());
            return dt.Rows.Count == 0 ? null : dt.Rows[0];
        }

        public static DataTable GetPatientAppointments(int patientId)
        {
            var ps = Base(); ps.Add(new SqlParameter("@p", patientId));
            return Database.GetTable(
                @"SELECT CONVERT(VARCHAR(10), a.ApptDate, 23) AS [Date], CONVERT(VARCHAR(5), a.ApptTime, 108) AS [Time],
                 a.Purpose AS [Purpose], ISNULL(w.FullName, '-') AS [Doctor], a.Status AS [Status]
          FROM Appointments a LEFT JOIN HealthWorkers w ON w.WorkerID = a.WorkerID
          WHERE a.PatientID=@p AND a.FacilityID=@f" + WorkerScope + @"
          ORDER BY a.ApptDate DESC, a.ApptTime DESC", ps.ToArray());
        }

        //facility view workers details
        public static DataRow? GetWorkerDetails(int workerId)
        {
            var dt = Database.GetTable(
                @"SELECT w.WorkerID, w.FullName, w.MedicalRole, w.Nationality, w.IdType, w.IdNumber, w.Phone, u.Email,
                 CONVERT(VARCHAR(10), u.DateCreated, 23) AS Joined
          FROM HealthWorkers w JOIN Users u ON u.UserID = w.WorkerID
          WHERE w.WorkerID=@id AND w.FacilityID=@f",
                new SqlParameter("@id", workerId), new SqlParameter("@f", Session.FacilityID));
            return dt.Rows.Count == 0 ? null : dt.Rows[0];
        }

        public static DataTable GetWorkerAppointments(int workerId) => Database.GetTable(
            @"SELECT TOP 200 CONVERT(VARCHAR(10), a.ApptDate, 23) AS [Date], CONVERT(VARCHAR(5), a.ApptTime, 108) AS [Time],
             p.FullName AS [Patient], a.Purpose AS [Purpose], a.Status AS [Status]
      FROM Appointments a JOIN Patients p ON p.PatientID = a.PatientID
      WHERE a.WorkerID=@id AND a.FacilityID=@f
      ORDER BY a.ApptDate DESC, a.ApptTime DESC",
            new SqlParameter("@id", workerId), new SqlParameter("@f", Session.FacilityID));

        public static (int Upcoming, int Completed) WorkerCounts(int workerId)
        {
            var up = Base(DateTime.Today); up.Add(new SqlParameter("@id", workerId));
            int a = Count(@"SELECT COUNT(*) FROM Appointments a
                    WHERE a.WorkerID=@id AND a.FacilityID=@f AND a.Status='Approved' AND a.ApptDate>=@d", up);
            var cp = Base(); cp.Add(new SqlParameter("@id", workerId));
            int b = Count("SELECT COUNT(*) FROM Appointments a WHERE a.WorkerID=@id AND a.FacilityID=@f AND a.Status='Completed'", cp);
            return (a, b);
        }

        //facility open/closed days
        public static List<int> GetOpenDays() =>
            Database.GetTable("SELECT DayOfWeek FROM FacilityOpenDays WHERE FacilityID=@f", new SqlParameter("@f", Session.FacilityID))
                    .Rows.Cast<DataRow>().Select(r => Convert.ToInt32(r[0])).ToList();

        public static DataTable GetClosures() => Database.GetTable(
            @"SELECT ClosureID,
             CASE WHEN StartDate = EndDate THEN CONVERT(VARCHAR(11), StartDate, 106)
                  ELSE CONVERT(VARCHAR(11), StartDate, 106) + ' - ' + CONVERT(VARCHAR(11), EndDate, 106) END AS [Dates],
             ISNULL(Reason, '-') AS [Reason]
      FROM FacilityClosures
      WHERE FacilityID=@f AND EndDate >= CAST(GETDATE() AS DATE)
      ORDER BY StartDate", new SqlParameter("@f", Session.FacilityID));

        public static int CountAffectedAppointments(DateTime start, DateTime end) => Convert.ToInt32(Database.Scalar(
            "SELECT COUNT(*) FROM Appointments WHERE FacilityID=@f AND ApptDate BETWEEN @s AND @e AND Status IN ('Pending','Approved')",
            new SqlParameter("@f", Session.FacilityID),
            new SqlParameter("@s", SqlDbType.Date) { Value = start.Date },
            new SqlParameter("@e", SqlDbType.Date) { Value = end.Date }));

        public static void AddClosure(DateTime start, DateTime end, string reason) => Database.Execute(
            "INSERT INTO FacilityClosures (FacilityID, StartDate, EndDate, Reason) VALUES (@f,@s,@e,@r)",
            new SqlParameter("@f", Session.FacilityID),
            new SqlParameter("@s", SqlDbType.Date) { Value = start.Date },
            new SqlParameter("@e", SqlDbType.Date) { Value = end.Date },
            new SqlParameter("@r", reason == "" ? (object)DBNull.Value : reason));

        public static void RemoveClosure(int closureId) => Database.Execute(
            "DELETE FROM FacilityClosures WHERE ClosureID=@id AND FacilityID=@f",
            new SqlParameter("@id", closureId), new SqlParameter("@f", Session.FacilityID));

        public static string? ClosedReason(DateTime date)
        {
            var ps = Base(date);
            ps.Add(new SqlParameter("@dow", DayOfWeekNumber(date)));
            if (Count("SELECT COUNT(*) FROM FacilityOpenDays WHERE FacilityID=@f AND DayOfWeek=@dow", ps) == 0)
                return $"The facility is not open on {date:dddd}s.";

            var cs = Database.GetTable(
                "SELECT TOP 1 ISNULL(Reason, '') AS Reason FROM FacilityClosures WHERE FacilityID=@f AND @d BETWEEN StartDate AND EndDate",
                Base(date).ToArray());
            if (cs.Rows.Count == 0) return null;
            string r = cs.Rows[0]["Reason"].ToString() ?? "";
            return r == "" ? "The facility is closed on this date." : $"The facility is closed on this date ({r}).";
        }
    }
}
