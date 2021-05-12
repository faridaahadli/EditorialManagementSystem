using EditorialManager.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorialManager.DTOs
{
    public class ArticleInsDto
    {
        public int ArticleTypeId { get; set; }
        public IFormFile ArticleFile { get; set; }
        public List<ReviewerViewModel> OpposeReviewers { get; set; }
        public List<ReviewerViewModel> SuggestedReviewers { get; set; }
        public string EditorId { get; set; }
        public string Note { get; set; }

    }
}
