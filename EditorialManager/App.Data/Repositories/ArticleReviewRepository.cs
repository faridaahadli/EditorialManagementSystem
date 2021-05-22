using App.Core.Models;
using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data.Repositories
{
    class ArticleReviewRepository:Repository<ArticleReviewer>,IArticleReviewRepository
    {
        private readonly AppDbContext _context;
        public ArticleReviewRepository(AppDbContext context)
            : base(context)
        {
            _context = context;
        }

    }
}
