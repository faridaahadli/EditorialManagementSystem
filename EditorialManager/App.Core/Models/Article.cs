using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class Article
    {
        public int Id { get; set; }
        public int ArticleTypeId { get; set; }
        public virtual ArticleType ArticleType { get; set; }
        public string FilePath { get; set; }
        public virtual AppUser User { get; set; }
        public string UserId { get; set; }
        public DateTime SubmitDate { get; set; }
    }
}
