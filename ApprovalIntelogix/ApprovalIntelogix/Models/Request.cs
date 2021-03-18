using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class Request
    {
        public string IdRequest { get; set; }
        public string Utilities { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public byte[] Files1 { get; set; }
        public byte[] Files2 { get; set; }
        public string IdWorkflow { get; set; }

        public virtual Workflow IdWorkflowNavigation { get; set; }
    }
}
