
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
    public class GetLoginController : ControllerBase
    {
        ATRSystemContext _Context;
        public GetLoginController(ATRSystemContext context)
        {
            _Context = context;

            }
        [Route("getLoginTable")]
        [HttpGet]
        public ActionResult<List<Login>> getLoginTable()
        {
            var data = _Context.Logins.ToList();
            return data;
        }
    }
}
