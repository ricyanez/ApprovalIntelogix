using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class Step
    {
        public Step()
        {
            UserStep = new HashSet<UserStep>();
        }

        public string IdStep { get; set; }
        public string Namestep { get; set; }
        public string Description { get; set; }
        public int? ApprovalCondition { get; set; }
        public DateTime? Time { get; set; }
        public string IdWorkflow { get; set; }

        public virtual Workflow IdWorkflowNavigation { get; set; }
        public virtual ICollection<UserStep> UserStep { get; set; }
    }
}
