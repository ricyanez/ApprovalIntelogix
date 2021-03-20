using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class TruckView
    {
        public string PkId { get; set; }
        public string Truck { get; set; }
        public string Vin { get; set; }
        public string Plate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Owner { get; set; }
        public string Commodity { get; set; }
        public bool? Apportioned { get; set; }
        public string Status { get; set; }
        public string Engine { get; set; }
        public string RegistrationType { get; set; }
        public string InsuranceType { get; set; }
        public decimal? InsuranceValue { get; set; }
        public string Lienholder { get; set; }
        public string TruckType { get; set; }
    }
}
