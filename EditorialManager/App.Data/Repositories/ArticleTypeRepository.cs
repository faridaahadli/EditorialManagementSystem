using App.Core.Models;
using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Repositories
{
    class ArticleTypeRepository: Repository<ArticleType>, IArticleTypeRepository
    {
        private readonly AppDbContext _context;
        public ArticleTypeRepository(AppDbContext context)
            :base(context)
        {
            _context = context;
        }
    }
}
