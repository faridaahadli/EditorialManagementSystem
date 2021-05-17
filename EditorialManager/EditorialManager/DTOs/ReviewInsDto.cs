using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorialManager.DTOs
{
    public class ReviewInsDto
    {
        public int Id { get; set; }
        public int? ArticleId { get; set; }
        public string AppUserId { get; set; }
        public string Review { get; set; }
    }
}
