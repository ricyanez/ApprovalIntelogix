using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class SoftwareUsers
    {
        public string IdSoftwareUser { get; set; }
        public string IdSoftware { get; set; }
        public string IdUser { get; set; }
        public string IdRole { get; set; }
    }
}
