using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnEnityFrameworkUsingDtos.Services;
using HandsOnEnityFrameworkUsingDtos.DTOs;
using AutoMapper;

namespace HandsOnEnityFrameworkUsingDtos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        ItemService service;
        public ItemController(IMapper mapper)
        {
            service = new ItemService(mapper);
        }
     
        [HttpPost]
        [Route("Add")]
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
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            return Ok(service.GetAll());
        }
        [HttpGet]
        [Route("Get/{Id}")]
        public IActionResult Get(string Id)
        {
            try
            {
                ItemDTO item = service.GetById(Id);
                if (item != null)
                    return Ok(item);
                else
                    return NotFound("Inviad Id");
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPut]
        [Route("Edit")]
        public IActionResult Update(ItemDTO uItem)
        {
            try
            {
                service.Update(uItem);
                return Ok("Record Updated");
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("Remove/{Id}")]
        public IActionResult Delete(string Id)
        {
            try
            {
                service.Delete(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
