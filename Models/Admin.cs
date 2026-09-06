using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectAPIs.Models
{
    public partial class Admin
    {
        public Admin()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int AdminId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public bool? Gender { get; set; }
        public int? Age { get; set; }
        public string ContactAdd { get; set; }
        public string AEmail { get; set; }
        public string APassword { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
