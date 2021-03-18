using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class LienholderInfo
    {
        public string PkId { get; set; }
        public string LienholderName { get; set; }
        public string LienholderAddress { get; set; }
        public string LienholderFax { get; set; }
        public string LienholderContact { get; set; }
    }
}
