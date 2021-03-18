using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class UserStep
    {
        public string IdUserStep { get; set; }
        public string PkId { get; set; }
        public string IdStep { get; set; }

        public virtual Step IdStepNavigation { get; set; }
        public virtual ApprovalUser Pk { get; set; }
    }
}
