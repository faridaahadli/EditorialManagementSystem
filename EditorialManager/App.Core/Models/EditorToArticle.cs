using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class EditorToArticle
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
        public string UserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public int StatusId { get; set; }
        public string Note { get; set; }
    }
}
