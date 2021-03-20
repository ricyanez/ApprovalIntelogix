using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class ApprovalUser
    {
        public ApprovalUser()
        {
            UserStep = new HashSet<UserStep>();
        }

        public string PkId { get; set; }
        public string IdUser { get; set; }
        public string IdRole { get; set; }

        public virtual Role IdRoleNavigation { get; set; }
        public virtual ICollection<UserStep> UserStep { get; set; }
    }
}
