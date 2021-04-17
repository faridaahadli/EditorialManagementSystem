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
        // GET: AccountController
        public ActionResult Index()
        {
            return View("Register");
        }

        //[HttpPost]
        //public ActionResult Register()
        //{

        //}

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

     
    }
}
