using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class BusinessBoStaffManager
    {
        public string IdBo { get; set; }
        public string Idbusiness { get; set; }
        public string Idcity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }
        public string Address { get; set; }
    }
}
