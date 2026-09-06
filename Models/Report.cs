using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectAPIs.Models
{
    public partial class Report
    {
        public int ReportId { get; set; }
        public int? TransactionId { get; set; }
        public int? ReservationId { get; set; }
        public DateTime? ReportDate { get; set; }

        public virtual Reservation Reservation { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
