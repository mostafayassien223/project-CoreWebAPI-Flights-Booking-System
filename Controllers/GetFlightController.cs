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
    public class GetFlightController : ControllerBase
    {
        ATRSystemContext _Context;
        public GetFlightController(ATRSystemContext context)
        {
            _Context = context;
        }
        [HttpGet("GetFlightsData")]
        public ActionResult<List<Flight>> GetFlightsData()
        {
            return _Context.Flights.ToList();
        }


    }
}

