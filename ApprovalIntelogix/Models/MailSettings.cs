using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class MailSettings
    {
        public Guid IdMailSettings { get; set; }
        public string IdEmployee { get; set; }
        public string EmployeeEmail { get; set; }
        public string MailTo { get; set; }
        public string Password { get; set; }
        public bool Extern { get; set; }
        public string IdEmpMail { get; set; }
    }
}
