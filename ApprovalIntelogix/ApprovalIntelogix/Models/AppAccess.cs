using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class AppAccess
    {
        public string IdappAccess { get; set; }
        public string Idsoftware { get; set; }
        public string Idmodule { get; set; }
        public string Idemployee { get; set; }
        public string IdcustomerUser { get; set; }
        public string IdaccessRights { get; set; }
        public string Idcustomer { get; set; }
    }
}
