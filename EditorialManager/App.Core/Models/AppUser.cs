using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class AppUser:IdentityUser
    {
        public  bool IsActive { get; set; }
    }
}
