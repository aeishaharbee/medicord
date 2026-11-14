using System;
using System.Collections.Generic;
using System.Text;

namespace medicord_v1.Services
{
    public static class WorkerService
    {
        public static bool IdNumberExists(string idNumber) =>
            Convert.ToInt32(Database.Scalar(
                "SELECT COUNT(*) FROM HealthWorkers WHERE IdNumber = @i",
                new SqlParameter("@i", idNumber))) > 0;

        public static void RegisterWorker(WorkerRegData d)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                int id;
                using (var cmd = new SqlCommand(
                    @"INSERT INTO Users (Email, PasswordHash, Role)
                  OUTPUT INSERTED.UserID VALUES (@e, @p, 'HealthWorker')", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@e", d.Email.Trim().ToLower());
                    cmd.Parameters.AddWithValue("@p", Security.Hash(d.Password));
                    id = (int)cmd.ExecuteScalar()!;
                }

                using (var cmd = new SqlCommand(
                    @"INSERT INTO HealthWorkers
                  (WorkerID, FacilityID, Nationality, IdType, IdNumber, FullName, MedicalRole, Phone)
                  VALUES (@id,@f,@nat,@it,@in,@fn,@mr,@ph)", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@f", d.FacilityID);
                    cmd.Parameters.AddWithValue("@nat", d.Nationality);
                    cmd.Parameters.AddWithValue("@it", d.IdType);
                    cmd.Parameters.AddWithValue("@in", d.IdNumber);
                    cmd.Parameters.AddWithValue("@fn", d.FullName);
                    cmd.Parameters.AddWithValue("@mr", d.MedicalRole);
                    cmd.Parameters.AddWithValue("@ph", d.Phone);
                    cmd.ExecuteNonQuery();
                }

                foreach (int day in d.Days)
                {
                    using var cmd = new SqlCommand(
                        "INSERT INTO WorkerWorkDays (WorkerID, DayOfWeek) VALUES (@id,@d)", conn, tx);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@d", day);
                    cmd.ExecuteNonQuery();
                }
                tx.Commit();
            }
            catch { tx.Rollback(); throw; }
        }
    }
}
