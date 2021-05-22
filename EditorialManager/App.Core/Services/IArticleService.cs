using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Services
{
   public interface IArticleService:IService<Article>
    {
        IEnumerable<Article> GetArticlesByUserId(string id);
        IEnumerable<Article> GetReviewAllowedArticles();
        Article GetByIdWithAllElementsAsync(int id);
    }
}
