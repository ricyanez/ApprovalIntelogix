using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class Licencing
    {
        public string Idlicence { get; set; }
        public string Idcustomer { get; set; }
        public string Idsoftware { get; set; }
        public string Licence { get; set; }
        public DateTime? StatDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public decimal? MaxUsers { get; set; }
    }
}
