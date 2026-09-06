using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectAPIs.Models
{
    public partial class Booking
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string County { get; set; }
        public string ExpirtyDate { get; set; }
        public string IssuingDate { get; set; }
        public string PassportNumber { get; set; }
        public string BirthDate { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string TicketNum { get; set; }
    }
}
