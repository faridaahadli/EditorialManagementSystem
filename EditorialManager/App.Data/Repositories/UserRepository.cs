using App.Core.Models;
using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repositories
{
    public class UserRepository: Repository<AppUser>,IUserRepository
    {

        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context):base(context)
        {
            _context=context;
        }

        public AppUser GetUserByEmail(string email)
        {
           AppUser user= (AppUser)_context.Users.SingleOrDefault(p => p.Email == email);
            return user;
        }
    }
}
