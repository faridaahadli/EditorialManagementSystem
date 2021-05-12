using App.Core.IUnitOfWorks;
using App.Core.Models;
using App.Core.Repositories;
using App.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Services
{
    public class ArticleTypeService:Service<ArticleType>, IArticleTypeService
    {
        public ArticleTypeService(IUnitOfWork unitOfWork, IRepository<ArticleType> repository)
            : base(unitOfWork, repository)
        {

        }
    }
}
