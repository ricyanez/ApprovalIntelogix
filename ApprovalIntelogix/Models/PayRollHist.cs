using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class PayRollHist
    {
        public Guid? IdpayRollHist { get; set; }
        public string IdpayRoll { get; set; }
        public string Idemployee { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Rate { get; set; }
        public string Description { get; set; }
        public bool? Status { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
