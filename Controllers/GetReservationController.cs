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
    public class GetReservationController : ControllerBase
    {
        ATRSystemContext _Context;
        public GetReservationController(ATRSystemContext context)
        {
            _Context = context;

        }
        [Route("getListOfReservation")]
        [HttpGet]
        public ActionResult<List<Reservation>> getListOfReservation()
        {
            return _Context.Reservations.ToList();
        }

        [Route("getbooking")]
        [HttpGet]
        public ActionResult<List<Booking>> getListOfbooking()
        {
            return _Context.Bookings.ToList();
        }


        [HttpPost("Reservation")]
        public IActionResult savelogins([FromBody] Booking booking)
        {

            if (booking != null)
            {
                _Context.Bookings.Add(booking);
                _Context.SaveChanges();
                return Ok();
            }
            return BadRequest();

        }
    }
}
