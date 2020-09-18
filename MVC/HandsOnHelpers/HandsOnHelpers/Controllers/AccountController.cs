using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnHelpers.Models;
using HandsOnHelpers.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsOnHelpers.Controllers
{
    public class AccountController : Controller
    {
        private CredentialsRepository _repo;
        private UserRepository _Urepo;
        public AccountController()
        {
            _repo = new CredentialsRepository();
            _Urepo = new UserRepository();
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["country"] = new List<SelectListItem>()
            {
                new SelectListItem(){Text="",Value=""},
                new SelectListItem(){Text="India",Value="India"},
                new SelectListItem(){Text="US",Value="US"},
                new SelectListItem(){Text="UK",Value="UK"},
            };
            return View();
        }
        
        public IActionResult Add(User item)
        {
            item.UserId = "U0001";
            _Urepo.Add(item);
            return RedirectToAction("Login");

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Credentials credentials)
        {
            Credentials item = _repo.Validate(credentials);
            if(item!=null)
            {
                ViewBag.Error = "Valid User";
                return RedirectToAction("Details");
            }
            else
            {
                ViewBag.Error = "Invalid User Credentials";
            }
            return View();
        }
    }
}
