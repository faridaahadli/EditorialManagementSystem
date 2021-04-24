using App.Core.IUnitOfWorks;
using App.Core.Repositories;
using App.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.UnitOfWorks
{
    public class UnitOfWork:IUnitOfWork
    {

        private UserRepository _userRepository;
        public IUserRepository Users =>_userRepository=_userRepository
            ??new UserRepository(_context);

        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
