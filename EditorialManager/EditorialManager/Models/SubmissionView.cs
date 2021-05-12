using App.Core.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorialManager.Models
{
    public class SubmissionView
    {
        public IFormFile ArticleFile { get; set; }
        public List<ArticleType> ArticleTypes { get; set; } = new List<ArticleType>();
        public List<AppUser> Editors { get; set; } = new List<AppUser>();
    }
}
