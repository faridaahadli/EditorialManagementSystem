using App.Core.IUnitOfWorks;
using App.Core.Models;
using App.Core.Repositories;
using App.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Services
{
    public class ArticleReviewService:Service<ArticleReviewer>,IArticleReviewService
    {
        public ArticleReviewService(IUnitOfWork unitOfWork, IRepository<ArticleReviewer> repository)
            :base(unitOfWork,repository)
        {

        }
    }
}
