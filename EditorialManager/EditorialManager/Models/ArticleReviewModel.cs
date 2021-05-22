using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorialManager.Models
{
    public class ArticleReviewModel
    {
        public int Id { get; set; }
        public ArticleType ArticleType { get; set; }
        public string FilePath { get; set; }
        public AppUser User { get; set; }
        public DateTime SubmitDate { get; set; }
    }
}
