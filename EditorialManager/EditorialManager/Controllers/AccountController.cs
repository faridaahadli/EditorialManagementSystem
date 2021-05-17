using App.Core.Models;
using App.Core.Services;
using App.Services.Services;
using AutoMapper;
using CryptoHelper;
using EditorialManager.DTOs;
using EditorialManager.Models;
using EditorialManager.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorialManager.Controllers
{
    public class AccountController : Controller
    {
        //private readonly IUserService _userService;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IUniService _uniService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public AccountController(IUserService userService, IUniService uniService,
            UserManager<AppUser> userManager,SignInManager<AppUser> signInManager,
            IMapper mapper)
        {
            _mapper = mapper;
            _userService = userService;
            _uniService = uniService;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        // GET: AccountController
        [HttpGet]
        public async Task<IActionResult> Register()
        {
            ViewData["Uni"] = await _uniService.GetAllAsync();
            

            return View("Register");
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserInsertDto user)
        {
            UserValidator validator = new UserValidator();
            var result=validator.Validate(user);
            if (!result.IsValid)
            {
                ViewData["Uni"] = await _uniService.GetAllAsync();
                return View("Register",user);
            }
            if (!_userService.CheckUniqueEmail(user.Email))
            {
                ModelState.AddModelError("Email", "This mail address already exists");
                ViewData["Uni"] = await _uniService.GetAllAsync();
                return View("Register", user);
            }
            user.PasswordHash = Crypto.HashPassword(user.PasswordHash);
            var dbUser = _mapper.Map<AppUser>(user);
            dbUser.UserName = dbUser.Email;
            await _userService.AddAsync(dbUser);
            //await _userManager.CreateAsync(dbUser,dbUser.PasswordHash);
            var test=await _userManager.AddToRoleAsync(dbUser, "author");
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(dbUser);
            var confLink = Url.Action("ConfEmail", "Account",
            new { userId = dbUser.Id, tok = token }, Request.Scheme);
            EmailSender email = new EmailSender();
            try
            {
                await email.SendEmailAsync(user.Email, "Confirmation Email", confLink);
            }
            catch (Exception err)
            {


            }
            return RedirectToAction("Index","Home");
        
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View("Login");
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var user =  _userService.GetUserByEmail(model.Email);
            if (!ModelState.IsValid)
            {
                return RedirectToAction("register");
            }
            if (user == null)
                return RedirectToAction("register");
            var result = await _signInManager.PasswordSignInAsync(user.Email, model.Password,true,false);

            if (!result.Succeeded)
            {
                return RedirectToAction("register");
            }
            return RedirectToAction("index", "home");

        }
        [HttpGet]
        public async Task<IActionResult> ConfEmail(string userId, string tok)
        {
            if (userId == null || tok == null)
            {
                return RedirectToAction("Home", "Index");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return RedirectToAction("Home", "Index");
            }
            var result = await _userManager.ConfirmEmailAsync(user, tok);
            if (result.Succeeded)
            {
                user.IsActive = true;
                await _userService.Update(user);
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index"); 
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Account");
        }


    }
}
