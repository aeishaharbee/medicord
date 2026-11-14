namespace medicord_v1.Services
{
    public static class FacilityService
    {
        public static string RegisterFacility(FacilityRegData d)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                int id;
                using (var cmd = new SqlCommand(
                    @"INSERT INTO Users (Email, PasswordHash, Role)
                  OUTPUT INSERTED.UserID VALUES (@e, @p, 'FacilityAdmin')", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@e", d.Email.Trim().ToLower());
                    cmd.Parameters.AddWithValue("@p", Security.Hash(d.Password));
                    id = (int)cmd.ExecuteScalar()!;
                }

                string code = NewCode(conn, tx);

                using (var cmd = new SqlCommand(
                    @"INSERT INTO HealthFacilities
                  (FacilityID, FacilityName, Category, Description, Logo, AddressLine, City, Postcode, State, Phone,
                   OpenTime, CloseTime, SlotDurationMin, MaxPerSlot, WalkInAvailable, FacilityCode)
                  VALUES (@id,@n,@cat,@desc,@logo,@a,@c,@pc,@s,@ph,@o,@cl,@sd,@mp,@w,@code)", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@n", d.Name);
                    cmd.Parameters.AddWithValue("@cat", d.Category);
                    cmd.Parameters.AddWithValue("@desc", d.Description);
                    cmd.Parameters.Add("@logo", SqlDbType.VarBinary, -1).Value = (object?)d.Logo ?? DBNull.Value;
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
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.ExecuteNonQuery();
                }

                foreach (int day in d.OpenDays)
                {
                    using var cmd = new SqlCommand("INSERT INTO FacilityOpenDays (FacilityID, DayOfWeek) VALUES (@id,@d)", conn, tx);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@d", day);
                    cmd.ExecuteNonQuery();
                }

                tx.Commit();
                return code;
            }
            catch { tx.Rollback(); throw; }
        }

        //random 6 digits
        private static string NewCode(SqlConnection conn, SqlTransaction tx)
        {
            while (true)
            {
                string code = RandomNumberGenerator.GetInt32(100000, 1000000).ToString();
                using var cmd = new SqlCommand("SELECT COUNT(*) FROM HealthFacilities WHERE FacilityCode=@c", conn, tx);
                cmd.Parameters.AddWithValue("@c", code);
                if ((int)cmd.ExecuteScalar()! == 0) return code;
            }
        }

        public static (int Id, string Name)? FindByCode(string code)
        {
            var dt = Database.GetTable(
                "SELECT FacilityID, FacilityName FROM HealthFacilities WHERE FacilityCode=@c",
                new SqlParameter("@c", code));
            if (dt.Rows.Count == 0) return null;
            return (Convert.ToInt32(dt.Rows[0]["FacilityID"]), dt.Rows[0]["FacilityName"].ToString() ?? "");
        }

        public static DataTable GetAll()
            => Database.GetTable("SELECT FacilityID, FacilityName FROM HealthFacilities ORDER BY FacilityName");

        public static List<FacilityItem> GetFacilitiesForPatient(int patientId)
        {
            var dt = Database.GetTable(
                @"SELECT f.FacilityID,
                     f.FacilityName + ISNULL(' - ' + f.City, '') AS Display
              FROM HealthFacilities f
              CROSS JOIN (SELECT City, State FROM Patients WHERE PatientID = @p) p
              ORDER BY CASE WHEN f.City  = p.City  THEN 0
                            WHEN f.State = p.State THEN 1 ELSE 2 END,
                       f.FacilityName",
                new SqlParameter("@p", patientId));

            return dt.AsEnumerable()
                     .Select(r => new FacilityItem((int)r["FacilityID"], r["Display"].ToString()!))
                     .ToList();
        }
    }
}
