using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectAPIs.Models
{
    public partial class Transaction
    {
        public Transaction()
        {
            Reports = new HashSet<Report>();
        }

        public int TransactionId { get; set; }
        public string TransactionName { get; set; }
        public DateTime? TransactionDate { get; set; }

        public virtual ICollection<Report> Reports { get; set; }
    }
}
