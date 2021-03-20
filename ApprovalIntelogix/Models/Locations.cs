using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class Locations
    {
        public string IdLocation { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Location { get; set; }
        public string Idcitie { get; set; }
        public string Address { get; set; }
    }
}
