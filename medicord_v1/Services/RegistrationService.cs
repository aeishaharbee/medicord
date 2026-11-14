namespace medicord_v1.Services
{
    public static class RegistrationService
    {
        public static bool EmailExists(string email) =>
            Convert.ToInt32(Database.Scalar(
                "SELECT COUNT(*) FROM Users WHERE Email = @e",
                new SqlParameter("@e", email.Trim().ToLower()))) > 0;

        public static bool IdNumberExists(string idNumber) =>
            Convert.ToInt32(Database.Scalar(
                "SELECT COUNT(*) FROM Patients WHERE IdNumber = @i",
                new SqlParameter("@i", idNumber))) > 0;

        public static void RegisterPatient(PatientRegData d)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            using var tx = conn.BeginTransaction();
            try
            {
                int userId;
                using (var cmd = new SqlCommand(
                    @"INSERT INTO Users (Email, PasswordHash, Role)
                  OUTPUT INSERTED.UserID
                  VALUES (@e, @p, 'Patient')", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@e", d.Email.Trim().ToLower());
                    cmd.Parameters.AddWithValue("@p", Security.Hash(d.Password));
                    userId = (int)cmd.ExecuteScalar()!;
                }

                using (var cmd = new SqlCommand(
                    @"INSERT INTO Patients
                  (PatientID, Nationality, IdType, IdNumber, FullName, Phone, City, State, Postcode)
                  VALUES (@id,@nat,@it,@in,@fn,@ph,@c,@s,@pc)", conn, tx))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.Parameters.AddWithValue("@nat", d.Nationality);
                    cmd.Parameters.AddWithValue("@it", d.IdType);
                    cmd.Parameters.AddWithValue("@in", d.IdNumber);
                    cmd.Parameters.AddWithValue("@fn", d.FullName);
                    cmd.Parameters.AddWithValue("@ph", d.Phone);
                    cmd.Parameters.AddWithValue("@c", d.City);
                    cmd.Parameters.AddWithValue("@s", d.State);
                    cmd.Parameters.AddWithValue("@pc", d.Postcode);
                    cmd.ExecuteNonQuery();
                }
                tx.Commit();
            }
            catch { tx.Rollback(); throw; }
        }
    }
}
