using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorialManager.DTOs
{
    public class UserInsertDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Title { get; set; }
        public int DegreeId { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }     
        public int UniversityId { get; set; }

    }
}
