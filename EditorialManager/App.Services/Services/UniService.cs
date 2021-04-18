using App.Core.IUnitOfWorks;
using App.Core.Models;
using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Services.Services
{
   public class UniService:Service<University>
    {
        public UniService(IUnitOfWork unitOfWork, IRepository<University> repository)
            :base(unitOfWork,repository)
        {

        }
    }
}
