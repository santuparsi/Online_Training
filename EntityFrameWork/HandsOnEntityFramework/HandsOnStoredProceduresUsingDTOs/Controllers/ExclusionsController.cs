using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnStoredProceduresUsingDTOs.DTOs;
using HandsOnStoredProceduresUsingDTOs.Models;
using HandsOnStoredProceduresUsingDTOs.Repositories;
namespace HandsOnStoredProceduresUsingDTOs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExclusionsController : ControllerBase
    {
        TblExculsionRepository _repo = null;
        public ExclusionsController()
        {
            _repo = new TblExculsionRepository();
        }
        [HttpGet]
        [Route("GetAll/{CCode}")]
        public IActionResult Get(string CCode)
        {
            try
            {
                return Ok(_repo.GetExclusions(CCode));
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [Route("Add")]
        public IActionResult POST(TblExculsionsDTO item)
        {
            try
            {
                _repo.AddTblExclusions(item);
                return Ok("Record Added");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [Route("Update")]
        public IActionResult Update(TblExculsionsDTO item)
        {
            try
            {
                _repo.UpdatetblExclusions(item);
                return Ok("Record Updated");

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [Route("Remove")]
        public IActionResult Delete(TblExculsionsDTO item)
        {
            try
            {
                _repo.DeletetblExclusions(item);
                return Ok("Record Deleted");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
