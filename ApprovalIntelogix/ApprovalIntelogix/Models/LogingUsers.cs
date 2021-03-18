using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class LogingUsers
    {
        public string Idcustomer { get; set; }
        public string Idsoftware { get; set; }
        public string Idlicence { get; set; }
        public string IdcustomerUser { get; set; }
        public string IdaccessRights { get; set; }
        public string Customer { get; set; }
        public string Software { get; set; }
        public string Licence { get; set; }
        public DateTime? EndDate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string AccessName { get; set; }
        public bool? Modify { get; set; }
        public bool? Editing { get; set; }
        public bool? ReadOnly { get; set; }
    }
}
