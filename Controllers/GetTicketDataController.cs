
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
    public class GetTicketDataController : ControllerBase
    {
        ATRSystemContext _Context;

        public GetTicketDataController(ATRSystemContext context)
        {
            _Context = context;

        }
        [Route("getTicketDataController")]
        [HttpGet]
        public ActionResult<List<Ticket>> getTicketDataController()
        {
            return _Context.Tickets.ToList();
        }


        [Route("getTicketDataControllerid")]
        [HttpGet]
        public ActionResult<Ticket> getTicketDataController(int id)
        {
            var elemnt = _Context.Tickets.SingleOrDefault(e => e.TicketId == id);
            return elemnt;
        }


        [HttpPost("saveticket")]
        public IActionResult savelogins([FromBody] Ticket ticket)
        {
            _Context.Tickets.Add(ticket);
            _Context.SaveChanges();
            return Ok();



        }


        [HttpPut("updateticket")]
        public IActionResult updateticket([FromBody] Ticket ticket, int id)
        {
            var old = _Context.Tickets.FirstOrDefault(d => d.TicketId == id);
            try
            {
                old.TicketNum = ticket.TicketNum;
                old.DateAvailable = ticket.DateAvailable;
                old.DateFlight = ticket.DateFlight;
                old.TimeDeparture = ticket.TimeDeparture;
                old.Destination = ticket.Destination;
                old.PriceTicket = ticket.PriceTicket;
                old.TypeTicket = ticket.TypeTicket;
                old.DetailsTicket = ticket.DetailsTicket;

                _Context.SaveChanges();
                return Ok();

            }



            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }


        [HttpPut("updateticketcheckbox")]
        public IActionResult updateticketcheckbox([FromBody] Boolean  change, int id)
        {
            var old = _Context.Tickets.FirstOrDefault(d => d.TicketId == id);
            try
            {

                old.Isshow =change;

                _Context.SaveChanges();
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }
    }




}

    


