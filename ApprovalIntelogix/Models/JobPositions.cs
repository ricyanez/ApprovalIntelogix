using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class JobPositions
    {
        public JobPositions()
        {
            Employees = new HashSet<Employees>();
        }

        public string IdPosition { get; set; }
        public string IdDepartment { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
