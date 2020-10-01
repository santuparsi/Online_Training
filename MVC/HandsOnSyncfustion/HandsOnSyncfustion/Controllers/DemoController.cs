using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnSyncfustion.Models;
namespace HandsOnSyncfustion.Controllers
{
    public class DemoController : Controller
    {
        ProductDBContext db = new ProductDBContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
        public IActionResult SetColumns()
        {
            return View(db.Products.ToList());
        }
        public IActionResult SetPagingAndSorting()
        {
            return View(db.Products.ToList());
        }
        public IActionResult SetFilteringAndGrouping()
        {
            return View(db.Products.ToList());
        }
        public IActionResult ExportPDF()
        {
            return View(db.Products.ToList());
        }
    }
}
