using App.Core.Models;
using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IEnumerable<Article> GetArticlesByUserId(string id)
        {
            return _context.Set<Article>().Where(p => p.UserId == id);
        }
    }
}
