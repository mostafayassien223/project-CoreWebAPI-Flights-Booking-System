using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectAPIs.Models
{
    public partial class Registration
    {
        public int RegistId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
