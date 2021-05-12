using App.Core.Models;
using App.Core.Services;
using AutoMapper;
using EditorialManager.DTOs;
using EditorialManager.Helpers;
using EditorialManager.Models;
using EditorialManager.Validators;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EditorialManager.Controllers
{
    public class SubmissionController : Controller
    {
        private readonly IUniService _uniService;
        private readonly IUserService _userService;
        private readonly IArticleTypeService _articleTypeService;
        private readonly IArticleService _articleService;
        private readonly IEditorToArticleService _editorToArticleService;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public SubmissionController(IUniService uniService,IUserService userService,
            IArticleService articleService, UserManager<AppUser> userManager,
            IEditorToArticleService editorToArticleService,
            IArticleTypeService articleTypeService, IHostingEnvironment hostingEnvironment,
            IMapper mapper)
        {
            _userService = userService;
            _uniService = uniService;
            _articleTypeService = articleTypeService;
            _articleService = articleService;
            _editorToArticleService = editorToArticleService;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
           
            ViewData["editors"] = _userService.GetUsersByRole("editor");
            ViewData["types"] = (List<ArticleType>) await _articleTypeService.GetAllAsync();              
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Insert(ArticleInsDto submission,bool radioSelectYes)
        {
            ViewData["editors"] = _userService.GetUsersByRole("editor");
            ViewData["types"] = (List<ArticleType>)await _articleTypeService.GetAllAsync();
            UploadArticleValidator validator = new UploadArticleValidator();
            var result = validator.Validate(submission);
            if (!result.IsValid)
            {
                return View("Index", submission);
            }
            var filename = await FileUpload.SaveFile(Path.
                Combine(_hostingEnvironment.WebRootPath, "files"), submission.ArticleFile);

            var article=_mapper.Map<Article>(submission);
            article.FilePath = filename;
            article.SubmitDate = DateTime.UtcNow;
            article.UserId = _userManager.GetUserId(HttpContext.User);
            await _articleService.AddAsync(article);
            var editorToArticle = _mapper.Map<EditorToArticle>(submission);
            editorToArticle.ArticleId = article.Id;
            editorToArticle.StatusId = 1;
            await _editorToArticleService.AddAsync(editorToArticle);
            return View("Index",submission);
        }

        //[HttpPost]
        //public JsonResult TableDataIns([FromBody] List<ReviewerViewModel> reviewers)
        //{
        //    //ViewData["editors"] = _userService.GetUsersByRole("editor");
        //    //ViewData["types"] = (List<ArticleType>)await _articleTypeService.GetAllAsync();

        //    return Json("Index");
        //}
    }
}
