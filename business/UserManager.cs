using RaskhodApp.Models2;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaskhodApp.business
{
    internal class UserManager
    {
        private readonly MyDbContext2 _dbContext;

        public UserManager(MyDbContext2 dbContext)
        {
            _dbContext = dbContext;
        }

        public User? GetByEmail(string email)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Email == email);
        }
    }
}
