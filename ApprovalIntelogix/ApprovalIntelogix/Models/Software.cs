using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class Software
    {
        public Guid? Idsoftware { get; set; }
        public string Idcustomer { get; set; }
        public string Software1 { get; set; }
        public string Description { get; set; }
        public string IdBusiness { get; set; }
    }
}
