using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class SoftwareRoles
    {
        public string IdRole { get; set; }
        public string IdSoftware { get; set; }
        public string Role { get; set; }
        public string IdaccessRights { get; set; }
        public bool? Status { get; set; }
        public string Description { get; set; }
    }
}
