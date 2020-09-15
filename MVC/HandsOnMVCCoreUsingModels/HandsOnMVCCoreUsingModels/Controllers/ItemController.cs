using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVCCoreUsingModels.Models;
using HandsOnMVCCoreUsingModels.Repositories;
namespace HandsOnMVCCoreUsingModels.Controllers
{
    [Route("[controller]")]
    public class ItemController : Controller
    {
        private ItemRepository _repo;
        public ItemController()
        {
            _repo = new ItemRepository();
        }
        [Route("GetAll")]
        public IActionResult Index()
        {
            List<Item> list = _repo.GetAll();
            return View(list);
        }
        [Route("GetItem/{Id}")]
        public IActionResult GetItem(int Id)
        {
            Item item = _repo.Get(Id);
            if (item != null)
            {
                return View(item);
            }
            else
                return NotFound("Invalid Id");
        }
    }
}
