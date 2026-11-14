using System.Text.RegularExpressions;

namespace medicord_v1.Helpers
{
    public static class Validators
    {
        public static bool IsEmail(string s)
        {
            try { return new System.Net.Mail.MailAddress(s).Address == s; }
            catch { return false; }
        }
        public static bool IsPhone(string s) => Regex.IsMatch(s, @"^\+?[0-9]{9,15}$");
        public static bool IsPostcode(string s) => Regex.IsMatch(s, @"^\d{5}$");
        public static bool IsIdNumber(string type, string s) =>
            type == "Passport" ?  Regex.IsMatch(s, @"^[A-Za-z0-9]{6,15}$")
                           : Regex.IsMatch(s, @"^\d{12}$");

        public static bool TryTime(string s, out TimeSpan t)
    => TimeSpan.TryParseExact(s.Trim(), @"hh\:mm", null, out t);

        public static int WordCount(string s)
            => s.Split((char[]?)null, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
