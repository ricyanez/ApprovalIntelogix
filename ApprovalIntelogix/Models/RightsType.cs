using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class RightsType
    {
        public string IdRight { get; set; }
        public string RightType { get; set; }
        public bool? Editing { get; set; }
        public bool? Modify { get; set; }
        public bool? OnlyRead { get; set; }
    }
}
