namespace medicord_v1.Services;

public class DependentInfo
{
    public int ID { get; set; }
    public string Name { get; set; } = "";
    public string Type { get; set; } = "";
    public DateTime? DateOfBirth { get; set; }
    public string Gender { get; set; } = "";
    public string Phone { get; set; } = "";
    public string IdType { get; set; } = "";
    public string IdNumber { get; set; } = "";
    public string OkuCardNo { get; set; } = "";
    public string CareNotes { get; set; } = "";
    public byte[]? Photo { get; set; }
}

public static class DependentService
{
    private const string SelectSql =
    @"SELECT g.DependentID, g.DependentType, p.FullName, p.DateOfBirth, p.Gender, p.Phone,
             p.IdType, p.IdNumber, p.OkuCardNo, p.CareNotes, u.ProfilePhoto
      FROM Guardianships g
      JOIN Patients p ON p.PatientID = g.DependentID
      JOIN Users u    ON u.UserID    = g.DependentID
      WHERE g.GuardianID=@g AND g.Status='Active' ";

    private static DependentInfo FromRow(DataRow r) => new()
    {
        ID = Convert.ToInt32(r["DependentID"]),
        Name = Convert.ToString(r["FullName"]) ?? "",
        Type = Convert.ToString(r["DependentType"]) ?? "",
        DateOfBirth = r["DateOfBirth"] is DBNull ? null : Convert.ToDateTime(r["DateOfBirth"]),
        Gender = Convert.ToString(r["Gender"]) ?? "",
        Phone = Convert.ToString(r["Phone"]) ?? "",
        IdType = Convert.ToString(r["IdType"]) ?? "",
        IdNumber = Convert.ToString(r["IdNumber"]) ?? "",
        OkuCardNo = Convert.ToString(r["OkuCardNo"]) ?? "",
        CareNotes = Convert.ToString(r["CareNotes"]) ?? "",
        Photo = r["ProfilePhoto"] as byte[],
    };

    //guardian always Session.UserID
    public static List<DependentInfo> GetMine() =>
        Database.GetTable(SelectSql + "ORDER BY g.DateCreated, g.DependentID",
            new SqlParameter("@g", Session.UserID)).Rows.Cast<DataRow>().Select(FromRow).ToList();

    public static DependentInfo? GetOne(int dependentId)
    {
        var t = Database.GetTable(SelectSql + "AND g.DependentID=@d",
            new SqlParameter("@g", Session.UserID), new SqlParameter("@d", dependentId));
        return t.Rows.Count == 0 ? null : FromRow(t.Rows[0]);
    }

    public static int Count() => Convert.ToInt32(Database.Scalar(
        "SELECT COUNT(*) FROM Guardianships WHERE GuardianID=@g AND Status='Active'",
        new SqlParameter("@g", Session.UserID)));

    public static bool IdNumberExists(string idNumber) => Convert.ToInt32(Database.Scalar(
        "SELECT COUNT(*) FROM Patients WHERE REPLACE(IdNumber,'-','')=@i",
        new SqlParameter("@i", idNumber.Replace("-", "")))) > 0;

    public static int Add(string name, string type, DateTime dob, string gender, string idType, string idNumber,
                          string okuCardNo, string careNotes)
    {
        if (Session.IsDependentMode) throw new InvalidOperationException("Switch back to your own account first.");

        using var conn = Database.GetConnection();
        conn.Open();
        using var tx = conn.BeginTransaction();
        try
        {
            int id;
            using (var cmd = new SqlCommand(
                "INSERT INTO Users (Email, PasswordHash, Role) OUTPUT INSERTED.UserID VALUES (NULL, NULL, 'Dependent')", conn, tx))
                id = Convert.ToInt32(cmd.ExecuteScalar());

            //nationality comes from the guardian, phone n address automatically   
            using (var cmd = new SqlCommand(
                @"INSERT INTO Patients (PatientID, Nationality, IdType, IdNumber, FullName, Phone, City, State, Postcode,
                                        DateOfBirth, Gender, OkuCardNo, CareNotes)
                  SELECT @id, g.Nationality, @it, @in, @fn,
                         CASE WHEN @copy=1 THEN g.Phone ELSE '' END,
                         CASE WHEN @copy=1 THEN g.City ELSE '' END,
                         CASE WHEN @copy=1 THEN g.State ELSE '' END,
                         CASE WHEN @copy=1 THEN g.Postcode ELSE '' END,
                         @dob, @gd, @oku, @cn
                  FROM Patients g WHERE g.PatientID=@guardian", conn, tx))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@it", idType);
                cmd.Parameters.AddWithValue("@in", idNumber);
                cmd.Parameters.AddWithValue("@fn", name);
                cmd.Parameters.AddWithValue("@copy", 1);
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = dob.Date;
                cmd.Parameters.AddWithValue("@gd", gender);
                cmd.Parameters.AddWithValue("@oku", okuCardNo == "" ? DBNull.Value : okuCardNo);
                cmd.Parameters.AddWithValue("@cn", careNotes == "" ? DBNull.Value : careNotes);
                cmd.Parameters.AddWithValue("@guardian", Session.UserID);
                cmd.ExecuteNonQuery();
            }
            using (var cmd = new SqlCommand(
                "INSERT INTO Guardianships (GuardianID, DependentID, DependentType, Status) VALUES (@g, @d, @t, 'Active')", conn, tx))
            {
                cmd.Parameters.AddWithValue("@g", Session.UserID);
                cmd.Parameters.AddWithValue("@d", id);
                cmd.Parameters.AddWithValue("@t", type);
                cmd.ExecuteNonQuery();
            }
            tx.Commit();
            return id;
        }
        catch { tx.Rollback(); throw; }
    }

    public static bool Update(int id, string name, DateTime dob, string gender, string phone, string okuCardNo, string careNotes) =>
        Database.Execute(
            @"UPDATE p SET FullName=@n, DateOfBirth=@dob, Gender=@gd, Phone=@ph, OkuCardNo=@oku, CareNotes=@cn
              FROM Patients p
              WHERE p.PatientID=@d AND EXISTS (SELECT 1 FROM Guardianships
                    WHERE GuardianID=@g AND DependentID=@d AND Status='Active')",
            new SqlParameter("@n", name), new SqlParameter("@dob", SqlDbType.Date) { Value = dob.Date },
            new SqlParameter("@gd", gender), new SqlParameter("@ph", phone),
            new SqlParameter("@oku", okuCardNo == "" ? DBNull.Value : okuCardNo),
            new SqlParameter("@cn", careNotes == "" ? DBNull.Value : careNotes),
            new SqlParameter("@d", id), new SqlParameter("@g", Session.UserID)) > 0;

    //soft delete: appointments and records stay with the clinics
    public static bool Remove(int id) => Database.Execute(
        "UPDATE Guardianships SET Status='Removed' WHERE GuardianID=@g AND DependentID=@d AND Status='Active'",
        new SqlParameter("@g", Session.UserID), new SqlParameter("@d", id)) > 0;

    public static bool SwitchTo(int id)
    {
        var d = GetOne(id);
        if (d == null) return false;
        Session.ActAs(d.ID, d.Name, d.Type);
        return true;
    }

    //pfp
    public static byte[]? GetGuardianPhoto()
    {
        try { return Database.Scalar("SELECT ProfilePhoto FROM Users WHERE UserID=@u", new SqlParameter("@u", Session.UserID)) as byte[]; }
        catch (SqlException) { return null; }
    }

    public static bool VerifyGuardianPassword(string password) => Convert.ToInt32(Database.Scalar(
        "SELECT COUNT(*) FROM Users WHERE UserID=@u AND PasswordHash=@h",
        new SqlParameter("@u", Session.UserID), new SqlParameter("@h", Security.Hash(password)))) > 0;

    public static bool IdNumberTakenByOther(string idNumber) => Convert.ToInt32(Database.Scalar(
        "SELECT COUNT(*) FROM Patients WHERE REPLACE(IdNumber,'-','')=@i AND PatientID<>@p",
        new SqlParameter("@i", idNumber.Replace("-", "")), new SqlParameter("@p", Session.PatientID))) > 0;

    public static void UpdateIdentity(string fullName, string nationality, string idType, string idNumber) =>
        Database.Execute(
            @"UPDATE p SET FullName=@n, Nationality=@na, IdType=@it, IdNumber=@in
          FROM Patients p
          WHERE p.PatientID=@d AND EXISTS (SELECT 1 FROM Guardianships
                WHERE GuardianID=@g AND DependentID=@d AND Status='Active')",
            new SqlParameter("@n", fullName), new SqlParameter("@na", nationality),
            new SqlParameter("@it", idType), new SqlParameter("@in", idNumber),
            new SqlParameter("@d", Session.PatientID), new SqlParameter("@g", Session.UserID));
}