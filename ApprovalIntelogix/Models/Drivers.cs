using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class Drivers
    {
        public string PkId { get; set; }
        public string DriverName { get; set; }
        public string PatSurname { get; set; }
        public string MatSurname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipPostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool? IsInactive { get; set; }
        public bool? Decomissioned { get; set; }
        public DateTime? Decomdate { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Origin { get; set; }
        public bool? NotDiscount { get; set; }
        public string Alias1 { get; set; }
        public string Alias2 { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? ChatStatus { get; set; }
        public string Commodity { get; set; }
        public string ComdataEmpNumber { get; set; }
        public string LocalEmpNumber { get; set; }
        public string ComdataEmpNumber2 { get; set; }
        public string Truck { get; set; }
        public string MainDestinations { get; set; }
        public string Sampler { get; set; }
        public string Ifta { get; set; }
        public string Base { get; set; }
        public string LineBusiness { get; set; }
        public DateTime? WorkStartDate { get; set; }
    }
}
