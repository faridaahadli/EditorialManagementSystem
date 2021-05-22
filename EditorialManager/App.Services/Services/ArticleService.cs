using App.Core.IUnitOfWorks;
using App.Core.Models;
using App.Core.Repositories;
using App.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Services.Services
{
    public class ArticleService:Service<Article>,IArticleService
    {
        public ArticleService(IUnitOfWork unitOfWork,IRepository<Article> repository)
            :base(unitOfWork,repository)
        {

        }

        public IEnumerable<Article> GetArticlesByUserId(string id)
        {
            return unitOfWork.Articles.GetArticlesByUserId(id);
        }

        public Article GetByIdWithAllElementsAsync(int id)
        {
            return  unitOfWork.Articles.GetByIdWithAllElementsAsync(id);
        }

        public IEnumerable<Article> GetReviewAllowedArticles()
        {
            return unitOfWork.Articles.GetReviewAllowedArticles();
        }
    }
}
