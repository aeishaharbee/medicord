namespace medicord_v1.Services;

public static class FacilityDirectoryService
{
    public static DataTable GetNearby() => Database.GetTable(
        @"SELECT f.FacilityID, f.FacilityName, f.Category, f.City, f.State, f.OpenTime, f.CloseTime,
                 u.ProfilePhoto,
                 CASE WHEN f.City = p.City THEN 0 WHEN f.State = p.State THEN 1 ELSE 2 END AS Proximity
          FROM HealthFacilities f
          JOIN Users u ON u.UserID = f.FacilityID
          OUTER APPLY (SELECT City, State FROM Patients WHERE PatientID = @p) p
          ORDER BY CASE WHEN f.City = p.City THEN 0 WHEN f.State = p.State THEN 1 ELSE 2 END,
                   f.State, f.City, f.FacilityName",
        new SqlParameter("@p", Session.PatientID));

    public static DataRow? GetDetail(int facilityId)
    {
        var t = Database.GetTable(
            @"SELECT f.FacilityID, f.FacilityName, f.Category, f.Description, f.AddressLine, f.City, f.Postcode, f.State,
                     f.Phone, f.OpenTime, f.CloseTime, f.SlotDurationMin, f.WalkInAvailable, u.ProfilePhoto,
                     (SELECT COUNT(*) FROM HealthWorkers w WHERE w.FacilityID = f.FacilityID) AS Doctors
              FROM HealthFacilities f JOIN Users u ON u.UserID = f.FacilityID
              WHERE f.FacilityID = @f", new SqlParameter("@f", facilityId));
        return t.Rows.Count == 0 ? null : t.Rows[0];
    }

    
    public static HashSet<int> GetOpenDays(int facilityId) => Database.GetTable(
            "SELECT [DayOfWeek] FROM FacilityOpenDays WHERE FacilityID=@f", new SqlParameter("@f", facilityId))
        .Rows.Cast<DataRow>().Select(r => Convert.ToInt32(r["DayOfWeek"])).ToHashSet();
}