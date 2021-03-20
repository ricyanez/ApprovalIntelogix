using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class BussinessAccess
    {
        public Guid IdAccess { get; set; }
        public string IdUser { get; set; }
        public string IdBusiness { get; set; }
    }
}
