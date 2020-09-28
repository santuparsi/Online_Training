using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingModelPopUp.Models;
using Microsoft.AspNetCore.Http;

namespace HandsOnMVCUsingModelPopUp.Controllers
{
    public class ProductController : Controller
    {
        MyDbContext db = new MyDbContext();
        ManageProducts manage = new ManageProducts();
        public ProductController()
        {

        }
        public IActionResult Index()
        {
            manage.Products = db.Products.ToList();
            return View(manage);
        }
        
        public IActionResult AddProduct(ManageProducts manage)
        {
            //Products item = new Products()
            //{
            //    ProductName = form["Product.ProductName"],
            //    Category = form["Product.Category"],
            //    Description = form["Product.Description"],
            //    UnitPrice = decimal.Parse(form["Product.UnitPrice"]),
            //};
            db.Products.Add(manage.Product);
            db.SaveChanges();
           TempData["message"] = "Product " + manage.Product.ProductName + " added successfully";
            return RedirectToAction("Index");

        }
        public IActionResult UpdateProduct(IFormCollection form)
        {
            Products item = new Products()
            {
                ProductId = int.Parse(form["Product.ProductId"]),
                ProductName = form["Product.ProductName"],
                Category = form["Product.Category"],
                Description = form["Product.Description"],
                UnitPrice = decimal.Parse(form["Product.UnitPrice"]),
            };
            db.Products.Update(item);
            db.SaveChanges();
            TempData["message"] = "Product " + form["Product.ProductName"] + " updated successfully";
            return RedirectToAction("Index");

        }
        public IActionResult DeleteProduct(IFormCollection form)
        {
            int ProductId = int.Parse(form["ProductId"]);
            Products item = db.Products.Find(ProductId);
            db.Products.Remove(item);
            db.SaveChanges();
            TempData["message"] = "Product " + item.ProductName + " deleted successfully";
            return RedirectToAction("Index");

        }
        public IActionResult AjaxProductDetail(int productID)
        {
            Products item = db.Products.Find(productID);
            return Json(item);
        }
    }
}
