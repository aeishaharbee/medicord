namespace medicord_v1.Data
{
    public static class Session
    {
        public static int UserID { get; set; }
        public static string FullName { get; set; } = "";
        public static string Role { get; set; } = "";

        public static int FacilityID { get; set; }
        public static string FirstName =>
            FullName.Split(' ', StringSplitOptions.RemoveEmptyEntries).FirstOrDefault() ?? "";
        public static void Clear() { UserID = 0; FacilityID = 0; FullName = ""; Role = ""; ActAsSelf(); }

        private static int? _actId; private static string? _actName, _actType;

        public static int PatientID => _actId ?? UserID;      //whose health data patient screens show
        public static bool IsDependentMode => _actId != null;
        public static string PatientName => _actName ?? FullName;
        public static string ActingType => _actType ?? "";

        public static void ActAs(int id, string name, string type) { _actId = id; _actName = name; _actType = type; }
        public static void ActAsSelf() { _actId = null; _actName = null; _actType = null; }
    }
}
