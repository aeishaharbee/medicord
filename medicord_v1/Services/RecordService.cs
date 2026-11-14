using System;
using System.Collections.Generic;
using System.Text;

namespace medicord_v1.Services
{
    public class RecordInput
    {
        public int? RecordID;
        public int PatientID;
        public int? WorkerID;
        public string Title = "", Category = "Other", Notes = "";
        public DateTime CheckupDate = DateTime.Today;
        public byte[]? FileData;  
        public string? FileName;
    }

    public static class RecordService
    {
        private static bool IsDoctor => Session.Role == "HealthWorker";

        
        private const string DoctorReadScope =
            " AND (r.WorkerID=@w OR r.PatientID IN (SELECT PatientID FROM Appointments WHERE WorkerID=@w AND FacilityID=@f))";
        private static string ReadScope => IsDoctor ? DoctorReadScope : "";
        
        private static string WriteScope => IsDoctor ? " AND r.UploadedBy=@u" : "";

        private static List<SqlParameter> P() => new()
    {
        new SqlParameter("@f", Session.FacilityID),
        new SqlParameter("@w", Session.UserID),
        new SqlParameter("@u", Session.UserID)
    };

        //patient side (read only) 
        public static DataTable GetForPatient() => Database.GetTable(
            @"SELECT r.RecordID, r.Title, ISNULL(r.Category, 'Other') AS Category,
                 CONVERT(VARCHAR(10), r.CheckupDate, 23) AS CheckupDate,
                 f.FacilityName, ISNULL(w.FullName, '') AS Doctor,
                 CASE WHEN r.FileSize IS NULL THEN 0 ELSE 1 END AS HasFile
          FROM MedicalRecords r
          JOIN HealthFacilities f ON f.FacilityID = r.FacilityID
          LEFT JOIN HealthWorkers w ON w.WorkerID = r.WorkerID
          WHERE r.PatientID=@p AND r.IsDeleted=0
          ORDER BY r.CheckupDate DESC, r.RecordID DESC",
            new SqlParameter("@p", Session.PatientID));

        public static (byte[] Data, string Name)? GetFileForPatient(int recordId) => ReadFile(
            "WHERE r.RecordID=@id AND r.PatientID=@p AND r.IsDeleted=0 AND r.FileData IS NOT NULL",
            new SqlParameter("@id", recordId), new SqlParameter("@p", Session.PatientID));

        //staff side 
        public static DataTable GetForStaff(int? patientId)
        {
            var ps = P();
            string pf = "";
            if (patientId != null) { pf = " AND r.PatientID=@p"; ps.Add(new SqlParameter("@p", patientId.Value)); }
            return Database.GetTable(
                @"SELECT r.RecordID, r.PatientID, r.WorkerID, r.UploadedBy,
                     CONVERT(VARCHAR(10), r.CheckupDate, 23) AS [Date], p.FullName AS [Patient],
                     ISNULL(r.Title, '-') AS [Title], ISNULL(r.Category, 'Other') AS [Category],
                     ISNULL(w.FullName, '-') AS [Doctor],
                     CASE WHEN r.FileSize IS NULL THEN 'No file'
                          ELSE CAST((r.FileSize + 1023) / 1024 AS VARCHAR(12)) + ' KB' END AS [File]
              FROM MedicalRecords r
              JOIN Patients p ON p.PatientID = r.PatientID
              LEFT JOIN HealthWorkers w ON w.WorkerID = r.WorkerID
              WHERE r.FacilityID=@f AND r.IsDeleted=0" + ReadScope + pf + @"
              ORDER BY r.CheckupDate DESC, r.RecordID DESC", ps.ToArray());
        }

        public static DataRow? GetOne(int id)
        {
            var ps = P(); ps.Add(new SqlParameter("@id", id));
            var dt = Database.GetTable(
                @"SELECT r.RecordID, r.PatientID, p.FullName AS PatientName, r.WorkerID, ISNULL(r.Title, '') AS Title,
                     ISNULL(r.Category, 'Other') AS Category, r.CheckupDate, ISNULL(r.DoctorRemarks, '') AS Notes, r.FileName
              FROM MedicalRecords r JOIN Patients p ON p.PatientID = r.PatientID
              WHERE r.RecordID=@id AND r.FacilityID=@f AND r.IsDeleted=0" + ReadScope, ps.ToArray());
            return dt.Rows.Count == 0 ? null : dt.Rows[0];
        }

        public static (byte[] Data, string Name)? GetFileForStaff(int recordId)
        {
            var ps = P(); ps.Add(new SqlParameter("@id", recordId));
            return ReadFile("WHERE r.RecordID=@id AND r.FacilityID=@f AND r.IsDeleted=0 AND r.FileData IS NOT NULL" + ReadScope, ps.ToArray());
        }

        //patients doct can upload for
        public static DataTable GetPatientChoices() => Database.GetTable(
            @"SELECT DISTINCT p.PatientID, p.FullName, p.FullName + ' (' + p.IdNumber + ')' AS Display
          FROM Patients p JOIN Appointments a ON a.PatientID = p.PatientID
          WHERE a.FacilityID=@f" + (IsDoctor ? " AND a.WorkerID=@w" : "") + " ORDER BY p.FullName",
            P().ToArray());

        public static DataTable GetDoctorChoices() => Database.GetTable(
            "SELECT WorkerID, FullName FROM HealthWorkers WHERE FacilityID=@f ORDER BY FullName",
            new SqlParameter("@f", Session.FacilityID));

        //return false if this doc cant upload for the patient
        public static bool Add(RecordInput r)
        {
            var ps = P();
            ps.Add(new SqlParameter("@p", r.PatientID));
            ps.Add(new SqlParameter("@wk", SqlDbType.Int) { Value = (object?)r.WorkerID ?? DBNull.Value });
            ps.Add(new SqlParameter("@d", SqlDbType.Date) { Value = r.CheckupDate.Date });
            ps.Add(new SqlParameter("@n", r.Notes));
            ps.Add(new SqlParameter("@t", r.Title));
            ps.Add(new SqlParameter("@c", r.Category));
            ps.Add(new SqlParameter("@fn", (object?)r.FileName ?? DBNull.Value));
            ps.Add(new SqlParameter("@fs", SqlDbType.Int) { Value = (object?)r.FileData?.Length ?? DBNull.Value });
            ps.Add(new SqlParameter("@fd", SqlDbType.VarBinary, -1) { Value = (object?)r.FileData ?? DBNull.Value });

            return Database.Execute(
                @"INSERT INTO MedicalRecords
                (PatientID, WorkerID, FacilityID, CheckupDate, Diagnosis, TestResults, Prescription, DoctorRemarks,
                 DateUploaded, Title, Category, FileName, FileSize, FileData, UploadedBy, IsDeleted)
              SELECT @p, @wk, @f, @d, '', '', '', @n, GETDATE(), @t, @c, @fn, @fs, @fd, @u, 0
              WHERE EXISTS (SELECT 1 FROM Appointments WHERE PatientID=@p AND FacilityID=@f"
                  + (IsDoctor ? " AND WorkerID=@w" : "") + ")", ps.ToArray()) > 0;
        }

        public static bool Update(RecordInput r)
        {
            var ps = P();
            ps.Add(new SqlParameter("@id", r.RecordID!.Value));
            ps.Add(new SqlParameter("@t", r.Title));
            ps.Add(new SqlParameter("@c", r.Category));
            ps.Add(new SqlParameter("@d", SqlDbType.Date) { Value = r.CheckupDate.Date });
            ps.Add(new SqlParameter("@n", r.Notes));

            var set = new List<string> { "r.Title=@t", "r.Category=@c", "r.CheckupDate=@d", "r.DoctorRemarks=@n" };
            if (!IsDoctor)                       //only admins reassign the attending doctor
            {
                set.Add("r.WorkerID=@wk");
                ps.Add(new SqlParameter("@wk", SqlDbType.Int) { Value = (object?)r.WorkerID ?? DBNull.Value });
            }
            if (r.FileData != null)              //new PDF replace old one
            {
                set.Add("r.FileName=@fn"); set.Add("r.FileSize=@fs"); set.Add("r.FileData=@fd");
                ps.Add(new SqlParameter("@fn", (object?)r.FileName ?? DBNull.Value));
                ps.Add(new SqlParameter("@fs", SqlDbType.Int) { Value = r.FileData.Length });
                ps.Add(new SqlParameter("@fd", SqlDbType.VarBinary, -1) { Value = r.FileData });
            }

            return Database.Execute(
                $"UPDATE r SET {string.Join(", ", set)} FROM MedicalRecords r " +
                "WHERE r.RecordID=@id AND r.FacilityID=@f AND r.IsDeleted=0" + WriteScope, ps.ToArray()) > 0;
        }

        //soft delete: hidden from everyone, kept in the database
        public static bool Delete(int recordId)
        {
            var ps = P(); ps.Add(new SqlParameter("@id", recordId));
            return Database.Execute(
                "UPDATE r SET r.IsDeleted=1 FROM MedicalRecords r WHERE r.RecordID=@id AND r.FacilityID=@f AND r.IsDeleted=0" + WriteScope,
                ps.ToArray()) > 0;
        }

        private static (byte[] Data, string Name)? ReadFile(string where, params SqlParameter[] ps)
        {
            var dt = Database.GetTable(
                "SELECT r.FileData, ISNULL(r.FileName, 'record.pdf') AS FileName FROM MedicalRecords r " + where, ps);
            if (dt.Rows.Count == 0) return null;
            return ((byte[])dt.Rows[0]["FileData"], dt.Rows[0]["FileName"].ToString() ?? "record.pdf");
        }
    }
}
