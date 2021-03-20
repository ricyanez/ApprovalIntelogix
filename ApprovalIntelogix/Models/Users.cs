using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class Users
    {
        public string IdUser { get; set; }
        public string IdEmployee { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? FirstTime { get; set; }
        public bool? Status { get; set; }
        public string IdRight { get; set; }
        public string Roll { get; set; }

        [NotMapped]
        public string token { get; set; }
    }
}
