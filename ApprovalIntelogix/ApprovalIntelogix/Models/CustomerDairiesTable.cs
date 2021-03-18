using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class CustomerDairiesTable
    {
        public string Idcustomer { get; set; }
        public string IdcustomerDairy { get; set; }
        public string Idbarn { get; set; }
        public string Idsilo { get; set; }
        public string Customer { get; set; }
        public string Dairy { get; set; }
        public string Barn { get; set; }
        public short? Silo { get; set; }
        public decimal? Capacity { get; set; }
    }
}
