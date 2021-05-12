using App.Core.Models;
using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Repositories
{
    public class ArticleRepository:Repository<Article>,IArticleRepository
    {
        private readonly AppDbContext _context;
        public ArticleRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }
    }
}
