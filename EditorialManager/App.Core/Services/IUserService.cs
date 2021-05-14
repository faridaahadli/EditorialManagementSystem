using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Services
{
    public interface IUserService:IService<AppUser>
    {
        AppUser GetUserByEmail(string email);
        List<AppUser> GetUsersByRole(string role);
        bool CheckUniqueEmail(string email);
    }
}
