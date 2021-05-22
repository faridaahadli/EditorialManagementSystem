using App.Core.Models;
using App.Core.Repositories;
using Microsoft.EntityFrameworkCore;
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
            return _context.Set<Article>().Include(prop=>prop.ArticleType)
                .Where(p => p.UserId == id);
        }

        public Article GetByIdWithAllElementsAsync(int id)
        {
            return  _context.Set<Article>().Include(prop => prop.ArticleType).Include(p=>p.User)
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Article> GetReviewAllowedArticles()
        {
            var list = _context.Set<Article>().Include(p => p.ArticleType)
                .Where(p => p.IsAllowed).OrderByDescending(p=>p.SubmitDate);
            
            return list;
        }
    }
}
