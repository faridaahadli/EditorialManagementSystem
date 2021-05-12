using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class ArticleReviewer
    {
        public int Id { get; set; }
        public Article Article { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
