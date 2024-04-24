using Security;
using System.Security.Cryptography;
using System.Text;

namespace LaboratorioAws.Services
{
    public class LoginService
    {
        public static bool LoginUser(User user, string passwordToCheck)
        {
            using var hmac = new HMACSHA256(user.PasswordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(passwordToCheck));

            for (int i = 1; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash[i]) return false;
            }

            return true;
        }
    }
}
