using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class Role
    {
        public Role()
        {
            ApprovalUser = new HashSet<ApprovalUser>();
        }

        public string IdRole { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApprovalUser> ApprovalUser { get; set; }
    }
}
