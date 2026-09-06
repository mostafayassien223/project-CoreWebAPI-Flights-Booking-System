using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectAPIs.Models
{
    public partial class Reservation
    {
        public Reservation()
        {
            Reports = new HashSet<Report>();
        }

        public int ReservationId { get; set; }
        public int TicketId { get; set; }
        public int AdminId { get; set; }
        public int ClientId { get; set; }
        public DateTime? DateResrvation { get; set; }
        public DateTime? DateAccommdation { get; set; }
        public string AccessTime { get; set; }
        public string TypeTicket { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Class { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string IssuingAirline { get; set; }
        public bool? Gender { get; set; }
        public int? Age { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? IssuingDate { get; set; }
        public DateTime? ExpirtyDate { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string County { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual Client Client { get; set; }
        public virtual Ticket Ticket { get; set; }
        public virtual Flight Flight { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
