using App.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) {}

        DbSet<AppUser> Users { get; set;}
        DbSet<University> Universities { get; set; }
        DbSet<ArticleType> ArticleTypes { get; set; }
        DbSet<Article> Articles { get; set; }
        DbSet<OfferingReviewer> OfferingReviewers { get; set; }
        DbSet<EditorToArticle> EditorToArticles { get; set; }
    }
}
