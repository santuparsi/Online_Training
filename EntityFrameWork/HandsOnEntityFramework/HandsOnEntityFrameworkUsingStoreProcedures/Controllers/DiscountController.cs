using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnEntityFrameworkUsingStoreProcedures.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace HandsOnEntityFrameworkUsingStoreProcedures.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        [Route("Get/{cCode}")]
        public IActionResult Get(string cCode)
        {
            
            using(DiscountPricingContext db=new DiscountPricingContext())
            {
                //List<TblExclusions> list = db.TblExclusions.FromSqlRaw("prcSelExclusions @p0", new[] { cCode }).ToList();
                List<TblExclusions> list = db.TblExclusions.FromSqlRaw("prcSelExclusions @strContractCode", 
                    new[] {
                    new SqlParameter("@strContractCode", cCode),
                    //new SqlParameter("@",cCode) 
                    }).ToList();

                return Ok(list);
            }
        }
    }
}
