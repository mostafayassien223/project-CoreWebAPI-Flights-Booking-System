using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectAPIs.Models
{
    public partial class Client
    {
        public Client()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int ClientId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public bool? Gender { get; set; }
        public int? Age { get; set; }
        public string ContactAddress { get; set; }
        public string CEmail { get; set; }
        public string CPassword { get; set; }
        public string Phone { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? IssuingDate { get; set; }
        public DateTime? ExpirtyDate { get; set; }
        public int? IssuingCountry { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
