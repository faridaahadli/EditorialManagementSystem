using App.Core.Models;
using App.Core.Services;
using AutoMapper;
using EditorialManager.DTOs;
using EditorialManager.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorialManager.Controllers
{
    public class ArticleReviewController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly IArticleReviewService _articleReviewService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        public ArticleReviewController( IArticleService articleService,
            IArticleReviewService articleReviewService,
           UserManager<AppUser> userManager,IMapper mapper )
        {
            _articleService = articleService;
            _articleReviewService = articleReviewService;
            _userManager = userManager;
            _mapper = mapper;
        }
        public IActionResult Index(int id)
        {
            var model = _articleService.GetByIdWithAllElementsAsync(id);
            return View(model);
        }
        [HttpGet]
        public IActionResult ReviewedArticles(int id)
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddReview(ReviewInsDto reviewIns)
        {
            reviewIns.AppUserId = _userManager.GetUserId(HttpContext.User);
            
            var model = _mapper.Map<ArticleReviewer>(reviewIns);
            _articleReviewService.AddAsync(model);
            return View(model);
        }
    }
}
