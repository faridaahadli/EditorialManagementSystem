using App.Core.IUnitOfWorks;
using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.UnitOfWorks
{
    public class UnitOfWork:IUnitOfWork
    {
        public IUserRepository Users => throw new NotImplementedException();

        IUserRepository IUnitOfWork.Users => throw new NotImplementedException();

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
