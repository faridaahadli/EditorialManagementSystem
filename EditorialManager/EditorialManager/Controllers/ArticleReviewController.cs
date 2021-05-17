using App.Core.Models;
using App.Core.Services;
using AutoMapper;
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
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;
        public ArticleReviewController( IArticleService articleService,
           UserManager<AppUser> userManager,IMapper mapper )
        {
            _articleService = articleService;
            _userManager = userManager;
            _mapper = mapper;
        }
        public IActionResult Index(int id)
        {
            var model = _articleService.GetByIdAsync(id);
            return View(model);
        }
    }
}
