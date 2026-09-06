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
    public class SaveLoginsController : ControllerBase
    {

        public ATRSystemContext _Context;
        public SaveLoginsController(ATRSystemContext context)
        {
            _Context = context; 
        }

        [HttpPost("savelogins")]
        public IActionResult savelogins([FromBody]Login login )
        {
            
            if (login != null)
            {
             _Context.Logins.Add(login);
                _Context.SaveChanges();
                return Ok();
            }
            return BadRequest();
            
        }
    }
}
