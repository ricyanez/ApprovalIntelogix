using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class Workflow
    {
        public Workflow()
        {
            Request = new HashSet<Request>();
            Step = new HashSet<Step>();
        }

        public string IdWorkflow { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Business { get; set; }

        public virtual ICollection<Request> Request { get; set; }
        public virtual ICollection<Step> Step { get; set; }
    }
}
