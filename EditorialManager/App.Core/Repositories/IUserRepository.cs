using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Repositories
{
   public interface IUserRepository:IRepository<AppUser>
    {
        AppUser GetUserByEmail(string email);
    }
}
