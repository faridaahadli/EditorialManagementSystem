using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Repositories
{
    class UniRepository: Repository<University>, IUniRepository
    {

        private readonly AppDbContext _context;
        public UniRepository(AppDbContext context) 
            : base(context)
        {
            _context = context;
        }
    }
}
