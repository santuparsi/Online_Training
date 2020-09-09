using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EntityFrameworkDBFirst_Demo1.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDBFirst_Demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
       [Route("Get")]
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
        [Route("GetAll/{value}")]
        public IActionResult GetAll(string value)
        {
            try
            {
                using (DiscountPricingContext db = new DiscountPricingContext())
                {
                    return Ok(db.TblExclusions.FromSqlRaw("prcSelExclusions @value",parameters:new[] { value}).ToList());
                    
                }
            }
            catch (Exception ex)
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
        [Route("Add")]
        public IActionResult Add(TblExclusions item)
        {
            try
            {
                using (DiscountPricingContext db = new DiscountPricingContext())
                {
                    db.TblExclusions.Add(item);//addig new record
                    db.SaveChanges();
                    return Ok();
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [Route("AddMany")]
        public IActionResult AddMany(List<TblExclusions> list)
        {
            try
            {
                using (DiscountPricingContext db = new DiscountPricingContext())
                {
                    db.TblExclusions.AddRange(list);
                    db.SaveChanges();
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [Route("Remove/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                using (DiscountPricingContext db = new DiscountPricingContext())
                {
                    TblExclusions tbl = db.TblExclusions.Find(id);
                    db.TblExclusions.Remove(tbl);
                    db.SaveChanges();
                    return Ok();
                        }
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [Route("Delete")]
        public IActionResult Remove(TblExclusions item)
        {
            try
            {
                using (DiscountPricingContext db = new DiscountPricingContext())
                {
                    //TblExclusions tbl = db.TblExclusions.Find(id);
                    db.TblExclusions.Remove(item);
                    db.SaveChanges();
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [Route("Remove1")]
        public IActionResult Remove1(string strDrugNdc)
        {
            try
            {
                using (DiscountPricingContext db = new DiscountPricingContext())
                {
                    TblExclusions tbl = db.TblExclusions.SingleOrDefault(i=>i.StrDrugNdc==strDrugNdc);
                    db.TblExclusions.Remove(tbl);
                    db.SaveChanges();
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [Route("Removeall")]
        public IActionResult Removeall(string strContractCode)
        {
            try
            {
                using (DiscountPricingContext db = new DiscountPricingContext())
                {
                    List<TblExclusions> list = db.TblExclusions.Where(i => i.StrContractCode == strContractCode).ToList();
                    db.TblExclusions.RemoveRange(list);
                    db.SaveChanges();
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [Route("Edit1")]
        public IActionResult Update1(TblExclusions uitem)
        {
            //update few columns in a row
            try
            {
                using (DiscountPricingContext db = new DiscountPricingContext())
                {

                    //db.TblExclusions.Update(uitem); //updates entire row
                    //db.SaveChanges();
                    //return Ok();
                    TblExclusions nItem = db.TblExclusions.Find(uitem.IntExclusionsId);
                    nItem.StrContractCode = uitem.StrContractCode;
                    nItem.StrDrugNdc = uitem.StrDrugNdc;
                    db.SaveChanges();
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
