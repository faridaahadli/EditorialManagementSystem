using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class AppUser:IdentityUser
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public  bool IsActive { get; set; }
        public int UniversityId { get; set; }
        public virtual University University { get; set; }
        public int DegreeId { get; set; }
        public string Title { get; set; }
    }
}
