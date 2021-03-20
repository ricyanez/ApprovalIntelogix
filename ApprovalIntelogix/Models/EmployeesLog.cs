using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class EmployeesLog
    {
        public string IdEntry { get; set; }
        public string IdEmployee { get; set; }
        public string IdPosition { get; set; }
        public string IdPayRoll { get; set; }
        public string NoEmp { get; set; }
        public string Name { get; set; }
        public string PLastName { get; set; }
        public string MLastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Cellphone { get; set; }
        public string Ad { get; set; }
        public string Pic { get; set; }
        public decimal? PayRollRate { get; set; }
        public bool? Status { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string IdDepartment { get; set; }
        public string IdManager { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Birthplace { get; set; }
        public string Nss { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public string Infonavit { get; set; }
        public string CtaBbva { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public string IdGender { get; set; }
        public string Address { get; set; }
        public string IdCity { get; set; }
        public string IdState { get; set; }
        public string ZipCode { get; set; }
        public string AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
