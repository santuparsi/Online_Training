using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIUsingModel.Models;
using HandsOnAPIUsingModel.Repositrories;
namespace HandsOnAPIUsingModel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopController : ControllerBase
    {
        ProductRepository repo = new ProductRepository();
        [Route("GetProducts")]
        //public List<Product> Get()
        //{
        //    return repo.GetAll();
        //}
        public IActionResult Get()
        {
            List<Product> list = repo.GetAll();
            return Ok(list);
        }
        [Route("GetById/{id}")]
        [HttpGet]
        public IActionResult FetchProductById(int id)
        {
            Product p = repo.Get(id);
            if (p != null)
                return Ok(p);
            else
                return Content("Invalid Id");
        }
        [HttpPost]
        public IActionResult AddProduct(Product item)
        {
            try
            {
                repo.Add(item);
                return Ok("Record Added");
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
