using App.Core.Models;
using App.Core.Services;
using App.Services.Services;
using AutoMapper;
using EditorialManager.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorialManager.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly IUniService _uniService;
        private readonly IMapper _mapper;
        public AccountController(IUserService userService, IUniService uniService,
            IMapper mapper)
        {
            _mapper = mapper;
            _userService = userService;
            _uniService = uniService;
        }
        // GET: AccountController
        public ActionResult Index()
        {
            //ViewData["Uni"]=
            return View("Register");
        }

        [HttpPost]
        public ActionResult Register(UserInsertDto user)
        {
            var dbUser = _mapper.Map<AppUser>(user);
            _userService.AddAsync(dbUser);

            return RedirectToAction();
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

     
    }
}
