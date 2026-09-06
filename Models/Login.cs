using System;
using System.Collections.Generic;

#nullable disable

namespace FinalProjectAPIs.Models
{
    public partial class Login
    {
        public int LoginId { get; set; }
        public string Email { get; set; }
        public string Passord { get; set; }
    }
}
