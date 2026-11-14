using System;
using System.Collections.Generic;
using System.Text;

namespace medicord_v1.Services
{
    public static class AuthService
    {
        // patients
        public static bool LoginPatient(string email, string password)
        {
            var dt = Database.GetTable(
                @"SELECT u.UserID, p.FullName
              FROM Users u JOIN Patients p ON p.PatientID = u.UserID
              WHERE u.Email = @e AND u.PasswordHash = @p AND u.Role = 'Patient'",
                new SqlParameter("@e", email.Trim().ToLower()),
                new SqlParameter("@p", Security.Hash(password)));

            if (dt.Rows.Count == 0) return false;

            Session.UserID = (int)dt.Rows[0]["UserID"];
            Session.FullName = dt.Rows[0]["FullName"].ToString() ?? "";
            Session.Role = "Patient";
            return true;
        }

        // staff (facility admin / health worker)
        public static bool LoginStaff(string email, string password, string role)  
        {
            string sql = role == "FacilityAdmin"
                ? @"SELECT u.UserID, f.FacilityName AS DisplayName, f.FacilityID AS FacID FROM Users u
                    JOIN HealthFacilities f ON f.FacilityID = u.UserID
                    WHERE u.Email=@e AND u.PasswordHash=@p AND u.Role='FacilityAdmin'"
                : @"SELECT u.UserID, w.FullName AS DisplayName, w.FacilityID AS FacID FROM Users u
                    JOIN HealthWorkers w ON w.WorkerID = u.UserID
                    WHERE u.Email=@e AND u.PasswordHash=@p AND u.Role='HealthWorker'";

            var dt = Database.GetTable(sql,
                new SqlParameter("@e", email.Trim().ToLower()),
                new SqlParameter("@p", Security.Hash(password)));
            if (dt.Rows.Count == 0) return false;

            Session.UserID = (int)dt.Rows[0]["UserID"];
            Session.FullName = dt.Rows[0]["DisplayName"].ToString() ?? "";
            Session.FacilityID = Convert.ToInt32(dt.Rows[0]["FacID"]);
            Session.Role = role;
            return true;
        }
    }
}
