using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class TrailerView
    {
        public string PkId { get; set; }
        public string Trailer { get; set; }
        public string Vin { get; set; }
        public string Plate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Commodity { get; set; }
        public string Status { get; set; }
        public string LienholderType { get; set; }
        public string Lienholder { get; set; }
        public string TrailerType { get; set; }
    }
}
