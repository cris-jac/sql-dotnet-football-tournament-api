using Security;
using System.Security.Cryptography;
using System.Text;

namespace LaboratorioAws.Services
{
    public class RegisterService
    {
        public static User RegisterUser(string email, string username, string password)
        {
            using var hmac = new HMACSHA256();

            var user = new User
            {
                Email = email,
                UserName = username,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
                PasswordSalt = hmac.Key
            };

            return user;
        }
    }
}
