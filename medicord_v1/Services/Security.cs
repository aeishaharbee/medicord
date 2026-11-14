using System.Security.Cryptography;
using System.Text;

namespace medicord_v1.Services
{
    public static class Security
    {
        public static string Hash(string password) =>
            Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(password)));
    }
}
