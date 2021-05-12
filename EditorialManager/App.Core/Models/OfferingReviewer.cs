using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class OfferingReviewer
    {
        public int Id { get; set; }
        public virtual Article Article { get; set; }
        public int ArticleId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Type { get; set; }

    }
}
