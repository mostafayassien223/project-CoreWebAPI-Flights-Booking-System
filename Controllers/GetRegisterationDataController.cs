
using FinalProjectAPIs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAPIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetRegisterationDataController : ControllerBase
    {
        ATRSystemContext _Context;
        public GetRegisterationDataController(ATRSystemContext context)
        {
            _Context = context;

        }

        [Route("getRegisterationTable")]
        [HttpGet]
        public ActionResult<List<Registration>> getRegisterationTable()
        {
            return _Context.Registrations.ToList();
        }

        [HttpGet("GetEmailandpass")]
        public ActionResult GetEmailandpass()
        {


            var myList = from s in _Context.Registrations
                         select new { s.Email, s.Password };
            return Ok(myList);
                           
         
        }
    

        [HttpPost("SaveClientData")]
        public IActionResult SaveClientData([FromBody] Registration registration)
        {
            if (registration != null)
            {
                _Context.Registrations.Add(registration);
                _Context.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }

    }
}
