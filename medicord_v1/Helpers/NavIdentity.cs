using System.Data;
using System.Drawing;
using Microsoft.Data.SqlClient;
using medicord_v1.Data;

namespace medicord_v1.Helpers
{
    public static class NavIdentity
    {
        public static (string Name, string Role, Image Avatar) Load(int size = 76)
        {
            if (Session.Role == "FacilityAdmin")
            {
                DataTable t = Database.GetTable(
                    "SELECT FacilityName, Logo FROM HealthFacilities WHERE FacilityID=@f",
                    new SqlParameter("@f", Session.FacilityID));

                string name = t.Rows.Count > 0 ? t.Rows[0]["FacilityName"].ToString() ?? "" : Session.FullName;
                byte[]? logo = t.Rows.Count > 0 ? t.Rows[0]["Logo"] as byte[] : null;
                return (name, "Administrator", ImageHelper.LogoTile(logo, name, size));
            }
            else
            {
                DataTable t = Database.GetTable(
                    @"SELECT w.FullName, w.MedicalRole, u.ProfilePhoto
                      FROM HealthWorkers w JOIN Users u ON u.UserID = w.WorkerID
                      WHERE w.WorkerID=@u",
                    new SqlParameter("@u", Session.UserID));

                string name = t.Rows.Count > 0 ? t.Rows[0]["FullName"].ToString() ?? "" : Session.FullName;
                string role = t.Rows.Count > 0 ? t.Rows[0]["MedicalRole"].ToString() ?? "Health worker" : "Health worker";
                byte[]? photo = t.Rows.Count > 0 ? t.Rows[0]["ProfilePhoto"] as byte[] : null;

                Image img;
                try { img = photo != null && photo.Length > 0 ? ImageHelper.CircleFromBytes(photo, size) : ImageHelper.Initials(name, size); }
                catch { img = ImageHelper.Initials(name, size); }
                return (name, role, img);
            }
        }
    }
}