using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingModel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpGet]
        [Route("Div/{a}/{b}")]
        public IActionResult Div(int a,int b)
        {
            try
            {
                int c = a / b;
                return Ok("Div: " + c);
            }
            catch(Exception ex)
            {
                //return BadRequest(ex.Message);
                return BadRequest("b value should not be zero");
            }
        }
    }
}
