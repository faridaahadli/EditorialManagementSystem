using App.Core.IUnitOfWorks;
using App.Core.Models;
using App.Core.Repositories;
using App.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Services
{
   public class EditorToArticleService:Service<EditorToArticle>,IEditorToArticleService
    {
        public EditorToArticleService(IUnitOfWork unitOfWork,IRepository<EditorToArticle> repository)
            :base(unitOfWork,repository)
        {
        }
    }
}
