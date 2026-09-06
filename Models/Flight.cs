using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectAPIs.Models
{
    public partial class Flight
    {
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public string BookingRefrence { get; set; }
        public string LeavesTime { get; set; }
        public string ArrivalTime { get; set; }
        public DateTime? LeavesDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public int TerminalLeaves { get; set; }
        public int? TerminalArrival { get; set; }

        public virtual Ticket Flight1 { get; set; }
        public virtual Reservation FlightNavigation { get; set; }
    }
}
