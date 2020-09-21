using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HandsOnHelpers.Repositories;
using HandsOnHelpers.Models;
namespace HandsOnHelpers.Controllers
{
    public class UserController : Controller
    {
        private UserRepository _Urepo;
        public UserController()
        {
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

            if (ModelState.IsValid)
            {
                
                _Urepo.Add(item);
                return RedirectToAction("Login");
            }
            else
            {
                ViewData["country"] = new List<SelectListItem>()
            {
                
                new SelectListItem(){Text="India",Value="India"},
                new SelectListItem(){Text="US",Value="US"},
                new SelectListItem(){Text="UK",Value="UK"},
            };
                return View("Create");
            }

        }
    }
}
