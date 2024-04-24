using Microsoft.EntityFrameworkCore;
using Security.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public class UserRepository
    {
        private readonly AuthDbContext _authDbContext;

        public UserRepository(AuthDbContext authDbContext)
        {
            _authDbContext = authDbContext;
        }

        public async Task AddUser(User user)
        {
            await _authDbContext.Users.AddAsync(user);
            //await _authDbContext.SaveChangesAsync();
        }

        public async Task<User?> GetUserByUsername(string username)
        {
            return await _authDbContext.Users.FirstOrDefaultAsync(x => x.UserName.ToLower() == username.ToLower());
        }

        public async Task<User?> GetUserByEmail(string email)
        {
            return await _authDbContext.Users.FirstOrDefaultAsync(x => x.Email.ToLower() == email.ToLower());
        }

        public async Task SaveChangesAsync()
        {
            await _authDbContext.SaveChangesAsync();
        }
    }
}
