using System;
using System.Collections.Generic;
using System.Text;

namespace medicord_v1.Services
{
    public static class ProfileService
    {
        //avatar (any role)
        public static Bitmap LoadAvatar(int size, int? userId = null, string? name = null)
        {
            int uid = userId ?? Session.PatientID;
            string nm = name ?? Session.PatientName;
            try
            {
                var v = Database.Scalar("SELECT ProfilePhoto FROM Users WHERE UserID=@u", new SqlParameter("@u", uid));
                if (v is byte[] b && b.Length > 0) return ImageHelper.CircleFromBytes(b, size);
            }
            catch { /*fall back to initials */ }
            return ImageHelper.Initials(nm, size);
        }

        //patient
        public static DataRow GetPatientProfile() => Database.GetTable(
            @"SELECT p.FullName, p.Phone, p.City, p.State, p.Postcode, p.Nationality, p.IdType, p.IdNumber, u.Email
          FROM Patients p JOIN Users u ON u.UserID = p.PatientID
          WHERE p.PatientID=@p", new SqlParameter("@p", Session.PatientID)).Rows[0];

        public static void UpdatePatient(string phone, string city, string state, string postcode, bool photoChanged, byte[]? photo)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                using (var cmd = new SqlCommand(
                    "UPDATE Patients SET Phone=@ph, City=@c, State=@s, Postcode=@pc WHERE PatientID=@id", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@ph", phone);
                    cmd.Parameters.AddWithValue("@c", city);
                    cmd.Parameters.AddWithValue("@s", state);
                    cmd.Parameters.AddWithValue("@pc", postcode);
                    cmd.Parameters.AddWithValue("@id", Session.PatientID);
                    cmd.ExecuteNonQuery();
                }
                if (photoChanged)                                 
                {
                    using var cmd = new SqlCommand("UPDATE Users SET ProfilePhoto=@p WHERE UserID=@id", conn, tx);
                    cmd.Parameters.Add("@p", SqlDbType.VarBinary, -1).Value = (object?)photo ?? DBNull.Value;
                    cmd.Parameters.AddWithValue("@id", Session.PatientID);
                    cmd.ExecuteNonQuery();
                }
                tx.Commit();
            }
            catch { tx.Rollback(); throw; }
        }

        //health worker 
        public static DataRow GetWorkerProfile() => Database.GetTable(
            @"SELECT w.FullName, w.MedicalRole, w.Nationality, w.IdType, w.IdNumber, w.Phone, u.Email, f.FacilityName,
                 ISNULL(STUFF((SELECT ', ' + CASE d.DayOfWeek WHEN 0 THEN 'Mon' WHEN 1 THEN 'Tue' WHEN 2 THEN 'Wed'
                                    WHEN 3 THEN 'Thu' WHEN 4 THEN 'Fri' WHEN 5 THEN 'Sat' ELSE 'Sun' END
                               FROM WorkerWorkDays d WHERE d.WorkerID = w.WorkerID ORDER BY d.DayOfWeek
                               FOR XML PATH('')), 1, 2, ''), '-') AS WorkingDays
          FROM HealthWorkers w
          JOIN Users u ON u.UserID = w.WorkerID
          JOIN HealthFacilities f ON f.FacilityID = w.FacilityID
          WHERE w.WorkerID=@w", new SqlParameter("@w", Session.UserID)).Rows[0];


        public static string GetWorkerEmail() =>
            Database.Scalar("SELECT Email FROM Users WHERE UserID=@u",
                new SqlParameter("@u", Session.UserID))?.ToString() ?? "";

        public static bool UpdateWorkerContact(string phone, bool photoChanged, byte[]? photo)
        {
            using var con = Database.GetConnection();
            con.Open();
            using var tx = con.BeginTransaction();
            try
            {
                using (var cmd = new SqlCommand("UPDATE HealthWorkers SET Phone=@p WHERE WorkerID=@w", con, tx))
                {
                    cmd.Parameters.AddWithValue("@p", phone);
                    cmd.Parameters.AddWithValue("@w", Session.UserID);
                    cmd.ExecuteNonQuery();
                }
                if (photoChanged)
                {
                    using var cmd = new SqlCommand("UPDATE Users SET ProfilePhoto=@img WHERE UserID=@u", con, tx);
                    cmd.Parameters.Add(new SqlParameter("@img", SqlDbType.VarBinary, -1)
                    { Value = (object?)photo ?? DBNull.Value });
                    cmd.Parameters.AddWithValue("@u", Session.UserID);
                    cmd.ExecuteNonQuery();
                }
                tx.Commit();
                return true;
            }
            catch { tx.Rollback(); throw; }
        }

        //false = the current password was wrong
        public static bool ChangePassword(string current, string next) => Database.Execute(
            "UPDATE Users SET PasswordHash=@n WHERE UserID=@u AND PasswordHash=@c",
            new SqlParameter("@n", Security.Hash(next)), new SqlParameter("@u", Session.UserID),
            new SqlParameter("@c", Security.Hash(current))) > 0;

        //edit sensitive info
        public enum AccountResult { Ok, WrongPassword, EmailTaken, IdTaken }

        private static int Q(SqlConnection conn, SqlTransaction tx, string sql, params SqlParameter[] ps)
        {
            using var cmd = new SqlCommand(sql, conn, tx);
            cmd.Parameters.AddRange(ps);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }
        private static SqlParameter U() => new SqlParameter("@u", Session.UserID);

        private static bool PasswordOk(SqlConnection c, SqlTransaction t, string pw) =>
            Q(c, t, "SELECT COUNT(*) FROM Users WHERE UserID=@u AND PasswordHash=@h", U(), new SqlParameter("@h", Security.Hash(pw))) > 0;

        private static bool EmailTaken(SqlConnection c, SqlTransaction t, string email) =>
            Q(c, t, "SELECT COUNT(*) FROM Users WHERE Email=@e AND UserID<>@u", new SqlParameter("@e", email), U()) > 0;

        private static void SaveUser(SqlConnection c, SqlTransaction t, string email, string? newPassword)
        {
            using var cmd = new SqlCommand(newPassword == null
                ? "UPDATE Users SET Email=@e WHERE UserID=@u"
                : "UPDATE Users SET Email=@e, PasswordHash=@n WHERE UserID=@u", c, t);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@u", Session.UserID);
            if (newPassword != null) cmd.Parameters.AddWithValue("@n", Security.Hash(newPassword));
            cmd.ExecuteNonQuery();
        }

        public static string GetEmail() =>
            Convert.ToString(Database.Scalar("SELECT Email FROM Users WHERE UserID=@u", U())) ?? "";

        //facility admin: email and password
        public static AccountResult UpdateAccount(string currentPassword, string newEmail, string? newPassword)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                if (!PasswordOk(conn, tx, currentPassword)) return AccountResult.WrongPassword;
                if (EmailTaken(conn, tx, newEmail)) return AccountResult.EmailTaken;
                SaveUser(conn, tx, newEmail, newPassword);
                tx.Commit();
                return AccountResult.Ok;
            }
            catch { tx.Rollback(); throw; }
        }

        //patient: name, ID, email, password 
        public static AccountResult UpdatePatientAccount(string currentPassword, string fullName, string nationality, string idType,
                                                         string idNumber, string newEmail, string? newPassword)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                if (!PasswordOk(conn, tx, currentPassword)) return AccountResult.WrongPassword;
                if (EmailTaken(conn, tx, newEmail)) return AccountResult.EmailTaken;
                if (Q(conn, tx, "SELECT COUNT(*) FROM Patients WHERE IdNumber=@i AND PatientID<>@u",
                      new SqlParameter("@i", idNumber), U()) > 0) return AccountResult.IdTaken;

                using (var cmd = new SqlCommand("UPDATE Patients SET FullName=@n, Nationality=@nat, IdType=@t, IdNumber=@i WHERE PatientID=@u", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@n", fullName);
                    cmd.Parameters.AddWithValue("@nat", nationality);
                    cmd.Parameters.AddWithValue("@t", idType);
                    cmd.Parameters.AddWithValue("@i", idNumber);
                    cmd.Parameters.AddWithValue("@u", Session.UserID);
                    cmd.ExecuteNonQuery();
                }
                SaveUser(conn, tx, newEmail, newPassword);
                tx.Commit();
                return AccountResult.Ok;
            }
            catch { tx.Rollback(); throw; }
        }

        //health worker: name, nationality, ID, medical role
        public static AccountResult UpdateWorkerIdentity(string currentPassword, string fullName, string nationality,
                                                         string idType, string idNumber, string email, string role)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                if (!PasswordOk(conn, tx, currentPassword)) return AccountResult.WrongPassword;
                if (Q(conn, tx, "SELECT COUNT(*) FROM HealthWorkers WHERE IdNumber=@i AND WorkerID<>@u",
                      new SqlParameter("@i", idNumber), U()) > 0) return AccountResult.IdTaken;
                email = email.Trim().ToLowerInvariant();
                if (Q(conn, tx, "SELECT COUNT(1) FROM Users WHERE Email=@e AND UserID<>@u",
                        new SqlParameter("@e", email), U()) > 0) return AccountResult.EmailTaken;

                using (var cmd = new SqlCommand(
                    "UPDATE HealthWorkers SET FullName=@n, Nationality=@na, IdType=@t, IdNumber=@i, MedicalRole=@r WHERE WorkerID=@u", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@n", fullName);
                    cmd.Parameters.AddWithValue("@na", nationality);
                    cmd.Parameters.AddWithValue("@t", idType);
                    cmd.Parameters.AddWithValue("@i", idNumber);
                    cmd.Parameters.AddWithValue("@r", role);
                    cmd.Parameters.AddWithValue("@u", Session.UserID);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new SqlCommand("UPDATE Users SET Email=@e WHERE UserID=@u", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@e", email);
                    cmd.Parameters.AddWithValue("@u", Session.UserID);
                    cmd.ExecuteNonQuery();
                }

                tx.Commit();
                return AccountResult.Ok;
            }
            catch { tx.Rollback(); throw; }
        }
    }
}
