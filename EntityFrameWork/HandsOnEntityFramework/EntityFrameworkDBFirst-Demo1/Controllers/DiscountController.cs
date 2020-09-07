using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EntityFrameworkDBFirst_Demo1.Entities;
namespace EntityFrameworkDBFirst_Demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
       [Route("GetAll")]
        public IActionResult Get()
        {
            try
            {
                using(DiscountPricingContext db=new DiscountPricingContext())
                {
                    return Ok(db.TblExclusions.ToList());
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [Route("GetById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                using (DiscountPricingContext db = new DiscountPricingContext())
                {
                    return Ok(db.TblExclusions.Find(id));
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
