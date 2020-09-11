using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnEnityFrameworkUsingDtos.Services;
using HandsOnEnityFrameworkUsingDtos.DTOs;
namespace HandsOnEnityFrameworkUsingDtos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        ItemService service;
        public ItemController()
        {
            service = new ItemService();
        }
        [HttpPost]
        public IActionResult AddItem(ItemDTO item)
        {
            try
            {
                service.Add(item);
                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
