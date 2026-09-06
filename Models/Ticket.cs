using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectAPIs.Models
{
    public partial class Ticket
    {
        public Ticket()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int TicketId { get; set; }
        public string TicketNum { get; set; }
        public DateTime? DateAvailable { get; set; }
        public DateTime? DateFlight { get; set; }
        public string TimeDeparture { get; set; }
        public string TimeLand { get; set; }
        public string Destination { get; set; }
        public string PriceTicket { get; set; }
        public string TypeTicket { get; set; }
        public string DetailsTicket { get; set; }
        public string AirPort { get; set; }
        public string Terminal { get; set; }
        public bool? Isshow { get; set; }

        public virtual Flight Flight { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
