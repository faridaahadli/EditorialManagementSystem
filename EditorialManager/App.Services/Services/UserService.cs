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
   public class UserService:Service<AppUser>,IUserService
    {
        public UserService(IUnitOfWork unitOfWork,IRepository<AppUser> repository)
         :base(unitOfWork,repository)
        { }

        public AppUser GetUserByEmail(string email)
        {
            return unitOfWork.Users.GetUserByEmail(email);
        }

        public List<AppUser> GetUsersByRole(string role)
        {
            return unitOfWork.Users.GetUsersByRole(role);
        }
    }
}
