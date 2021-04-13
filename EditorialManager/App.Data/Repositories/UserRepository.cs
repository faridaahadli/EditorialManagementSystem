using App.Core.Models;
using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Repositories
{
    public class UserRepository: Repository<AppUser>,IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context):base(context)
        {
            _context=context;
        }
    }
}
