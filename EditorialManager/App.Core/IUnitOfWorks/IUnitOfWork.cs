using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.IUnitOfWorks
{
   public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        IArticleRepository Articles { get; }
        IArticleTypeRepository ArticleTypes { get;}
        IArticleReviewRepository ArticleReviews { get; }
        Task CommitAsync();
        void Commit();

    }
}
