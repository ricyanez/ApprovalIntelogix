using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class GeneralContext : DbContext
    {
        public GeneralContext()
        {
        }

        public GeneralContext(DbContextOptions<GeneralContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppAccess> AppAccess { get; set; }
        public virtual DbSet<Areas> Areas { get; set; }
        public virtual DbSet<Business> Business { get; set; }
        public virtual DbSet<BusinessBoStaffManager> BusinessBoStaffManager { get; set; }
        public virtual DbSet<BusinessBostaff> BusinessBostaff { get; set; }
        public virtual DbSet<BusinessLocation> BusinessLocation { get; set; }
        public virtual DbSet<BussinessAccess> BussinessAccess { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<CustomerBarns> CustomerBarns { get; set; }
        public virtual DbSet<CustomerDairies> CustomerDairies { get; set; }
        public virtual DbSet<CustomerDairiesTable> CustomerDairiesTable { get; set; }
        public virtual DbSet<CustomerSilo> CustomerSilo { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<CustomersUsers> CustomersUsers { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Drivers> Drivers { get; set; }
        public virtual DbSet<Dummy> Dummy { get; set; }
        public virtual DbSet<EmployeePosition> EmployeePosition { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EmployeesLog> EmployeesLog { get; set; }
        public virtual DbSet<EmployeesManager> EmployeesManager { get; set; }
        public virtual DbSet<EmployeesViewStaffManager> EmployeesViewStaffManager { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<JobPositions> JobPositions { get; set; }
        public virtual DbSet<Licencing> Licencing { get; set; }
        public virtual DbSet<LienholderInfo> LienholderInfo { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<LocationsView> LocationsView { get; set; }
        public virtual DbSet<LogingUsers> LogingUsers { get; set; }
        public virtual DbSet<MailSettings> MailSettings { get; set; }
        public virtual DbSet<Managers> Managers { get; set; }
        public virtual DbSet<PayRollHist> PayRollHist { get; set; }
        public virtual DbSet<PayRollStaffManager> PayRollStaffManager { get; set; }
        public virtual DbSet<Positions> Positions { get; set; }
        public virtual DbSet<RightsType> RightsType { get; set; }
        public virtual DbSet<Sample> Sample { get; set; }
        public virtual DbSet<Software> Software { get; set; }
        public virtual DbSet<SoftwareAccessRights> SoftwareAccessRights { get; set; }
        public virtual DbSet<SoftwareModule> SoftwareModule { get; set; }
        public virtual DbSet<SoftwareRoles> SoftwareRoles { get; set; }
        public virtual DbSet<SoftwareUsers> SoftwareUsers { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<TrailerView> TrailerView { get; set; }
        public virtual DbSet<Trailers> Trailers { get; set; }
        public virtual DbSet<TruckView> TruckView { get; set; }
        public virtual DbSet<Trucks> Trucks { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-IQ0SK8A;Database=General;User Id=sa;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppAccess>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdaccessRights)
                    .HasColumnName("IDAccessRights")
                    .HasMaxLength(40);

                entity.Property(e => e.IdappAccess)
                    .HasColumnName("IDAppAccess")
                    .HasMaxLength(40);

                entity.Property(e => e.Idcustomer)
                    .HasColumnName("IDCustomer")
                    .HasMaxLength(40);

                entity.Property(e => e.IdcustomerUser)
                    .HasColumnName("IDCustomerUser")
                    .HasMaxLength(40);

                entity.Property(e => e.Idemployee)
                    .HasColumnName("IDEmployee")
                    .HasMaxLength(40);

                entity.Property(e => e.Idmodule)
                    .HasColumnName("IDModule")
                    .HasMaxLength(40);

                entity.Property(e => e.Idsoftware)
                    .HasColumnName("IDSoftware")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Areas>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.Property(e => e.PkId)
                    .HasColumnName("pk_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Business>(entity =>
            {
                entity.HasKey(e => e.IdBusiness);

                entity.Property(e => e.IdBusiness)
                    .HasColumnName("ID_Business")
                    .HasMaxLength(40);

                entity.Property(e => e.Business1).HasColumnName("Business");

                entity.Property(e => e.IdLocation)
                    .HasColumnName("ID_Location")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<BusinessBoStaffManager>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Business_BO_StaffManager");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdBo)
                    .HasColumnName("ID_BO")
                    .HasMaxLength(40);

                entity.Property(e => e.Idbusiness)
                    .HasColumnName("IDBusiness")
                    .HasMaxLength(40);

                entity.Property(e => e.Idcity)
                    .HasColumnName("IDCity")
                    .HasMaxLength(40);

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<BusinessBostaff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Business_BOStaff");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IdBo)
                    .HasColumnName("ID_BO")
                    .HasMaxLength(40);

                entity.Property(e => e.Idemployee)
                    .HasColumnName("IDEmployee")
                    .HasMaxLength(40);

                entity.Property(e => e.Idposition)
                    .HasColumnName("IDPosition")
                    .HasMaxLength(40);

                entity.Property(e => e.Idstaff)
                    .HasColumnName("IDStaff")
                    .HasMaxLength(40);

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<BusinessLocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BusinessLocation");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(50);

                entity.Property(e => e.IdBusiness)
                    .IsRequired()
                    .HasColumnName("ID_Business")
                    .HasMaxLength(40);

                entity.Property(e => e.IdCountry)
                    .IsRequired()
                    .HasColumnName("ID_Country")
                    .HasMaxLength(50);

                entity.Property(e => e.IdLocation)
                    .HasColumnName("ID_Location")
                    .HasMaxLength(40);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BussinessAccess>(entity =>
            {
                entity.HasKey(e => e.IdAccess)
                    .HasName("PK__Bussines__4019562C3970A409");

                entity.ToTable("Bussiness_Access");

                entity.Property(e => e.IdAccess)
                    .HasColumnName("ID_Access")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdBusiness)
                    .IsRequired()
                    .HasColumnName("ID_Business")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser)
                    .IsRequired()
                    .HasColumnName("ID_User")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.Property(e => e.PkId)
                    .HasColumnName("pk_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.Property(e => e.PkId)
                    .HasColumnName("pk_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.IdCurrency)
                    .HasName("PK__Currency__87BF4C62E2ED98A0");

                entity.HasIndex(e => e.Currency1)
                    .HasName("UQ__Currency__AFC4E284E8EBB96C")
                    .IsUnique();

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("ID_Currency")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Currency1)
                    .IsRequired()
                    .HasColumnName("Currency")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerBarns>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Barns");

                entity.Property(e => e.Barn).HasMaxLength(50);

                entity.Property(e => e.Idbarn)
                    .HasColumnName("IDBarn")
                    .HasMaxLength(40);

                entity.Property(e => e.IdcustomerDairy)
                    .HasColumnName("IDCustomerDairy")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CustomerDairies>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Dairies");

                entity.Property(e => e.Dairy).HasMaxLength(50);

                entity.Property(e => e.Idcustomer)
                    .HasColumnName("IDCustomer")
                    .HasMaxLength(40);

                entity.Property(e => e.IdcustomerDairy)
                    .HasColumnName("IDCustomerDairy")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CustomerDairiesTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Customer_Dairies_Table");

                entity.Property(e => e.Barn).HasMaxLength(50);

                entity.Property(e => e.Capacity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Customer).HasMaxLength(50);

                entity.Property(e => e.Dairy).HasMaxLength(50);

                entity.Property(e => e.Idbarn)
                    .HasColumnName("IDBarn")
                    .HasMaxLength(40);

                entity.Property(e => e.Idcustomer)
                    .HasColumnName("IDCustomer")
                    .HasMaxLength(40);

                entity.Property(e => e.IdcustomerDairy)
                    .HasColumnName("IDCustomerDairy")
                    .HasMaxLength(40);

                entity.Property(e => e.Idsilo)
                    .HasColumnName("IDSilo")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CustomerSilo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_Silo");

                entity.Property(e => e.Capacity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Idbarn)
                    .HasColumnName("IDBarn")
                    .HasMaxLength(40);

                entity.Property(e => e.Idsilo)
                    .HasColumnName("IDSilo")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Customer).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Idcustomer)
                    .HasColumnName("IDCustomer")
                    .HasMaxLength(40);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<CustomersUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customers_Users");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.IdaccessRights)
                    .HasColumnName("IDAccessRights")
                    .HasMaxLength(40);

                entity.Property(e => e.Idcustomer)
                    .HasColumnName("IDCustomer")
                    .HasMaxLength(40);

                entity.Property(e => e.IdcustomerUser)
                    .HasColumnName("IDCustomer_User")
                    .HasMaxLength(40);

                entity.Property(e => e.Idlicence)
                    .HasColumnName("IDLicence")
                    .HasMaxLength(40);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.IdDepartment);

                entity.Property(e => e.IdDepartment)
                    .HasColumnName("ID_Department")
                    .HasMaxLength(40);

                entity.Property(e => e.Department1)
                    .HasColumnName("Department")
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.IdBusiness)
                    .HasColumnName("ID_Business")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Drivers>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.Property(e => e.PkId)
                    .HasColumnName("pk_id")
                    .HasMaxLength(50);

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50);

                entity.Property(e => e.Alias1)
                    .HasColumnName("alias1")
                    .HasMaxLength(50);

                entity.Property(e => e.Alias2)
                    .HasColumnName("alias2")
                    .HasMaxLength(50);

                entity.Property(e => e.Base)
                    .HasColumnName("base")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChatStatus).HasColumnName("chat_status");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50);

                entity.Property(e => e.ComdataEmpNumber)
                    .HasColumnName("Comdata_Emp_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.ComdataEmpNumber2)
                    .HasColumnName("Comdata_Emp_Number2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Commodity)
                    .HasColumnName("commodity")
                    .HasMaxLength(50);

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasMaxLength(50);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("date_of_birth")
                    .HasColumnType("date");

                entity.Property(e => e.Decomdate)
                    .HasColumnName("decomdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Decomissioned).HasColumnName("decomissioned");

                entity.Property(e => e.DriverName)
                    .HasColumnName("driverName")
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50);

                entity.Property(e => e.Ifta)
                    .HasColumnName("ifta")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IsInactive).HasColumnName("is_Inactive");

                entity.Property(e => e.LineBusiness)
                    .HasColumnName("line_business")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocalEmpNumber)
                    .HasColumnName("Local_Emp_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.MainDestinations)
                    .HasColumnName("main_destinations")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MatSurname)
                    .HasColumnName("mat_surname")
                    .HasMaxLength(50);

                entity.Property(e => e.NotDiscount).HasColumnName("not_discount");

                entity.Property(e => e.Origin)
                    .HasColumnName("origin")
                    .HasMaxLength(50);

                entity.Property(e => e.PatSurname)
                    .HasColumnName("pat_surname")
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(50);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasMaxLength(50);

                entity.Property(e => e.Sampler)
                    .HasColumnName("sampler")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50);

                entity.Property(e => e.Truck)
                    .HasColumnName("truck")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkStartDate)
                    .HasColumnName("work_Start_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ZipPostalCode)
                    .HasColumnName("zip_postal_code")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Dummy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dummy");

                entity.Property(e => e.Name2test)
                    .HasColumnName("name2test")
                    .HasMaxLength(50);

                entity.Property(e => e.Nametest)
                    .HasColumnName("nametest")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeePosition>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmployeePosition");

                entity.Property(e => e.IdDepartment)
                    .HasColumnName("ID_Department")
                    .HasMaxLength(40);

                entity.Property(e => e.IdEmployee)
                    .IsRequired()
                    .HasColumnName("ID_Employee")
                    .HasMaxLength(40);

                entity.Property(e => e.IdPosition)
                    .HasColumnName("ID_Position")
                    .HasMaxLength(40);

                entity.Property(e => e.Names).HasMaxLength(101);

                entity.Property(e => e.Position).HasMaxLength(50);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.IdEmployee);

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("ID_Employee")
                    .HasMaxLength(40);

                entity.Property(e => e.Ad)
                    .HasColumnName("AD")
                    .HasMaxLength(50);

                entity.Property(e => e.AddedBy).HasMaxLength(40);

                entity.Property(e => e.AddedDate).HasColumnType("date");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdmissionDate)
                    .HasColumnName("Admission_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.Birthplace).HasMaxLength(50);

                entity.Property(e => e.CellEm)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Cellphone).HasMaxLength(50);

                entity.Property(e => e.CtaBbva)
                    .HasColumnName("Cta_BBVA")
                    .HasMaxLength(50);

                entity.Property(e => e.Curp)
                    .HasColumnName("CURP")
                    .HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Email2).HasMaxLength(50);

                entity.Property(e => e.Email3).HasMaxLength(50);

                entity.Property(e => e.FatherName)
                    .HasColumnName("Father_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.Fonacot).HasMaxLength(200);

                entity.Property(e => e.IdBo)
                    .HasColumnName("ID_BO")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdCity)
                    .HasColumnName("ID_City")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdDepartment)
                    .HasColumnName("ID_Department")
                    .HasMaxLength(40);

                entity.Property(e => e.IdGender)
                    .HasColumnName("ID_Gender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdManager)
                    .HasColumnName("ID_Manager")
                    .HasMaxLength(40);

                entity.Property(e => e.IdPayRoll)
                    .HasColumnName("ID_PayRoll")
                    .HasMaxLength(40);

                entity.Property(e => e.IdPosition)
                    .HasColumnName("ID_Position")
                    .HasMaxLength(40);

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Infonavit).HasMaxLength(50);

                entity.Property(e => e.MLastName)
                    .HasColumnName("M_LastName")
                    .HasMaxLength(50);

                entity.Property(e => e.MotherName)
                    .HasColumnName("Mother_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NameEm)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NoEmp)
                    .HasColumnName("No_EMP")
                    .HasMaxLength(40);

                entity.Property(e => e.Nss)
                    .HasColumnName("NSS")
                    .HasMaxLength(50);

                entity.Property(e => e.PLastName)
                    .HasColumnName("P_LastName")
                    .HasMaxLength(50);

                entity.Property(e => e.PayRollRate)
                    .HasColumnName("PayRoll_Rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PhoneEm)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RelationEm)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(40);

                entity.Property(e => e.UpdatedDate).HasColumnType("date");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPositionNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdPosition)
                    .HasConstraintName("FK_Employees_Jobs");
            });

            modelBuilder.Entity<EmployeesLog>(entity =>
            {
                entity.HasKey(e => e.IdEntry)
                    .HasName("PK__Employee__9E8A2F3B38040E90");

                entity.Property(e => e.IdEntry)
                    .HasColumnName("ID_Entry")
                    .HasMaxLength(40);

                entity.Property(e => e.Ad)
                    .HasColumnName("AD")
                    .HasMaxLength(50);

                entity.Property(e => e.AddedBy).HasMaxLength(40);

                entity.Property(e => e.AddedDate).HasColumnType("date");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdmissionDate)
                    .HasColumnName("Admission_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.Birthplace).HasMaxLength(50);

                entity.Property(e => e.Cellphone).HasMaxLength(50);

                entity.Property(e => e.CtaBbva)
                    .HasColumnName("Cta_BBVA")
                    .HasMaxLength(50);

                entity.Property(e => e.Curp)
                    .HasColumnName("CURP")
                    .HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Email2).HasMaxLength(50);

                entity.Property(e => e.Email3).HasMaxLength(50);

                entity.Property(e => e.FatherName)
                    .HasColumnName("Father_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.IdCity)
                    .HasColumnName("ID_City")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdDepartment)
                    .HasColumnName("ID_Department")
                    .HasMaxLength(40);

                entity.Property(e => e.IdEmployee)
                    .IsRequired()
                    .HasColumnName("ID_Employee")
                    .HasMaxLength(40);

                entity.Property(e => e.IdGender)
                    .HasColumnName("ID_Gender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdManager)
                    .HasColumnName("ID_Manager")
                    .HasMaxLength(40);

                entity.Property(e => e.IdPayRoll)
                    .HasColumnName("ID_PayRoll")
                    .HasMaxLength(40);

                entity.Property(e => e.IdPosition)
                    .HasColumnName("ID_Position")
                    .HasMaxLength(40);

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Infonavit).HasMaxLength(50);

                entity.Property(e => e.MLastName)
                    .HasColumnName("M_LastName")
                    .HasMaxLength(50);

                entity.Property(e => e.MotherName)
                    .HasColumnName("Mother_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NoEmp)
                    .HasColumnName("No_EMP")
                    .HasMaxLength(40);

                entity.Property(e => e.Nss)
                    .HasColumnName("NSS")
                    .HasMaxLength(50);

                entity.Property(e => e.PLastName)
                    .HasColumnName("P_LastName")
                    .HasMaxLength(50);

                entity.Property(e => e.PayRollRate)
                    .HasColumnName("PayRoll_Rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(40);

                entity.Property(e => e.UpdatedDate).HasColumnType("date");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeesManager>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Employees_Manager");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(40);

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("ID_Employee")
                    .HasMaxLength(40);

                entity.Property(e => e.IdManager)
                    .HasColumnName("ID_Manager")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<EmployeesViewStaffManager>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmployeesView_StaffManager");

                entity.Property(e => e.Ad)
                    .HasColumnName("AD")
                    .HasMaxLength(50);

                entity.Property(e => e.AddedBy).HasMaxLength(40);

                entity.Property(e => e.AddedDate).HasColumnType("date");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Birthplace).HasMaxLength(50);

                entity.Property(e => e.CellEm)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Cellphone).HasMaxLength(50);

                entity.Property(e => e.CtaBbva)
                    .HasColumnName("Cta_BBVA")
                    .HasMaxLength(50);

                entity.Property(e => e.Curp)
                    .HasColumnName("CURP")
                    .HasMaxLength(50);

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Email2).HasMaxLength(50);

                entity.Property(e => e.Email3).HasMaxLength(50);

                entity.Property(e => e.FatherName)
                    .HasColumnName("Father_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.Fonacot).HasMaxLength(200);

                entity.Property(e => e.Gender)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.Property(e => e.IdBo)
                    .HasColumnName("ID_BO")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdBusiness)
                    .HasColumnName("ID_Business")
                    .HasMaxLength(40);

                entity.Property(e => e.IdCity)
                    .HasColumnName("ID_City")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdDepartment)
                    .HasColumnName("ID_Department")
                    .HasMaxLength(40);

                entity.Property(e => e.IdEmployee)
                    .IsRequired()
                    .HasColumnName("ID_Employee")
                    .HasMaxLength(40);

                entity.Property(e => e.IdGender)
                    .HasColumnName("ID_Gender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdManager)
                    .HasColumnName("ID_Manager")
                    .HasMaxLength(40);

                entity.Property(e => e.IdPayRoll)
                    .HasColumnName("ID_PayRoll")
                    .HasMaxLength(40);

                entity.Property(e => e.IdPosition)
                    .HasColumnName("ID_Position")
                    .HasMaxLength(40);

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_User")
                    .HasMaxLength(40);

                entity.Property(e => e.Infonavit).HasMaxLength(50);

                entity.Property(e => e.MLastName)
                    .HasColumnName("M_LastName")
                    .HasMaxLength(50);

                entity.Property(e => e.MotherName)
                    .HasColumnName("Mother_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.NameEm)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Names).HasMaxLength(101);

                entity.Property(e => e.NoEmp)
                    .HasColumnName("No_EMP")
                    .HasMaxLength(40);

                entity.Property(e => e.Nss)
                    .HasColumnName("NSS")
                    .HasMaxLength(50);

                entity.Property(e => e.PLastName)
                    .HasColumnName("P_LastName")
                    .HasMaxLength(50);

                entity.Property(e => e.PayRollRate)
                    .HasColumnName("PayRoll_Rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PhoneEm)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.RelationEm)
                    .HasColumnName("RelationEM")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Rfc)
                    .HasColumnName("RFC")
                    .HasMaxLength(50);

                entity.Property(e => e.Roll).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy).HasMaxLength(40);

                entity.Property(e => e.UpdatedDate).HasColumnType("date");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__Gender__1543595E5E3F25CF");

                entity.HasIndex(e => e.Gender1)
                    .HasName("UQ__Gender__8DCABCD6AA19044D")
                    .IsUnique();

                entity.Property(e => e.PkId)
                    .HasColumnName("pk_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Gender1)
                    .IsRequired()
                    .HasColumnName("Gender")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JobPositions>(entity =>
            {
                entity.HasKey(e => e.IdPosition);

                entity.ToTable("Job_Positions");

                entity.Property(e => e.IdPosition)
                    .HasColumnName("ID_Position")
                    .HasMaxLength(40);

                entity.Property(e => e.IdDepartment)
                    .HasColumnName("ID_Department")
                    .HasMaxLength(40);

                entity.Property(e => e.Position).HasMaxLength(50);
            });

            modelBuilder.Entity<Licencing>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Idcustomer)
                    .HasColumnName("IDCustomer")
                    .HasMaxLength(40);

                entity.Property(e => e.Idlicence)
                    .HasColumnName("IDLicence")
                    .HasMaxLength(40);

                entity.Property(e => e.Idsoftware)
                    .HasColumnName("IDSoftware")
                    .HasMaxLength(40);

                entity.Property(e => e.Licence).HasMaxLength(50);

                entity.Property(e => e.MaxUsers).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StatDate).HasColumnType("date");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<LienholderInfo>(entity =>
            {
                entity.HasKey(e => e.PkId)
                    .HasName("PK__Lienhold__1543595E6311BED0");

                entity.HasIndex(e => e.LienholderName)
                    .HasName("UQ__Lienhold__9F7D23354258AF82")
                    .IsUnique();

                entity.Property(e => e.PkId)
                    .HasColumnName("pk_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LienholderAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LienholderContact)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LienholderFax)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LienholderName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.IdLocation);

                entity.Property(e => e.IdLocation)
                    .HasColumnName("ID_Location")
                    .HasMaxLength(40);

                entity.Property(e => e.Address)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Idcitie)
                    .HasColumnName("IDCitie")
                    .HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);
            });

            modelBuilder.Entity<LocationsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LocationsView");

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.IdCountry)
                    .HasColumnName("ID_Country")
                    .HasMaxLength(50);

                entity.Property(e => e.IdLocation)
                    .IsRequired()
                    .HasColumnName("ID_Location")
                    .HasMaxLength(40);

                entity.Property(e => e.IdState)
                    .HasColumnName("ID_State")
                    .HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogingUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Loging_Users");

                entity.Property(e => e.AccessName).HasMaxLength(50);

                entity.Property(e => e.Customer).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IdaccessRights)
                    .HasColumnName("IDAccessRights")
                    .HasMaxLength(40);

                entity.Property(e => e.Idcustomer)
                    .HasColumnName("IDCustomer")
                    .HasMaxLength(40);

                entity.Property(e => e.IdcustomerUser)
                    .HasColumnName("IDCustomer_User")
                    .HasMaxLength(40);

                entity.Property(e => e.Idlicence)
                    .HasColumnName("IDLicence")
                    .HasMaxLength(40);

                entity.Property(e => e.Idsoftware)
                    .HasColumnName("IDSoftware")
                    .HasMaxLength(40);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Licence).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Software).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<MailSettings>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EmployeeEmail)
                    .IsRequired()
                    .HasColumnName("Employee_Email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmpMail)
                    .IsRequired()
                    .HasColumnName("ID_EmpMail")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmployee)
                    .IsRequired()
                    .HasColumnName("ID_Employee")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdMailSettings).HasColumnName("ID_MailSettings");

                entity.Property(e => e.MailTo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Managers>(entity =>
            {
                entity.HasKey(e => e.IdManager)
                    .HasName("PK__Managers__494B9F09E2447335");

                entity.HasIndex(e => e.IdEmployee)
                    .HasName("UQ__Managers__D9EE4F3767953952")
                    .IsUnique();

                entity.Property(e => e.IdManager)
                    .HasColumnName("ID_Manager")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdEmployee)
                    .HasColumnName("ID_Employee")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayRollHist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PayRoll_Hist");

                entity.Property(e => e.AddedBy).HasMaxLength(40);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(40);

                entity.Property(e => e.Idemployee)
                    .HasColumnName("IDEmployee")
                    .HasMaxLength(40);

                entity.Property(e => e.IdpayRoll)
                    .HasColumnName("IDPayRoll")
                    .HasMaxLength(40);

                entity.Property(e => e.IdpayRollHist).HasColumnName("IDPayRoll_Hist");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedBy).HasMaxLength(40);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PayRollStaffManager>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PayRoll_StaffManager");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("ID_Currency")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdPayRoll)
                    .HasColumnName("ID_PayRoll")
                    .HasMaxLength(40);

                entity.Property(e => e.PayRoll).HasMaxLength(40);
            });

            modelBuilder.Entity<Positions>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.Property(e => e.PkId)
                    .HasColumnName("pk_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RightsType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Rights_Type");

                entity.Property(e => e.IdRight)
                    .HasColumnName("ID_Right")
                    .HasMaxLength(40);

                entity.Property(e => e.RightType).HasMaxLength(50);
            });

            modelBuilder.Entity<Sample>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Idcustomer)
                    .HasColumnName("IDCustomer")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Software>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdBusiness)
                    .HasColumnName("ID_Business")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idcustomer)
                    .HasColumnName("IDCustomer")
                    .HasMaxLength(40);

                entity.Property(e => e.Idsoftware).HasColumnName("IDSoftware");

                entity.Property(e => e.Software1)
                    .HasColumnName("Software")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SoftwareAccessRights>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Software_AccessRights");

                entity.Property(e => e.AccessName).HasMaxLength(50);

                entity.Property(e => e.IdaccessRights)
                    .HasColumnName("IDAccessRights")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<SoftwareModule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Software_Module");

                entity.Property(e => e.Idmodule)
                    .HasColumnName("IDModule")
                    .HasMaxLength(40);

                entity.Property(e => e.Idsoftware)
                    .HasColumnName("IDSoftware")
                    .HasMaxLength(40);

                entity.Property(e => e.Module).HasMaxLength(50);
            });

            modelBuilder.Entity<SoftwareRoles>(entity =>
            {
                entity.HasKey(e => e.IdRole)
                    .HasName("PK__Software__43DCD32D47A9F4E5");

                entity.ToTable("Software_Roles");

                entity.HasIndex(e => e.Role)
                    .HasName("UQ__Software__DA15413EC0C860E9")
                    .IsUnique();

                entity.Property(e => e.IdRole)
                    .HasColumnName("ID_Role")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdSoftware)
                    .IsRequired()
                    .HasColumnName("ID_Software")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdaccessRights)
                    .IsRequired()
                    .HasColumnName("IDAccessRights")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Role)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SoftwareUsers>(entity =>
            {
                entity.HasKey(e => e.IdSoftwareUser)
                    .HasName("PK__Software__27602BF97DCCA448");

                entity.ToTable("Software_Users");

                entity.Property(e => e.IdSoftwareUser)
                    .HasColumnName("ID_SoftwareUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdRole)
                    .HasColumnName("ID_Role")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdSoftware)
                    .IsRequired()
                    .HasColumnName("ID_Software")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser)
                    .IsRequired()
                    .HasColumnName("ID_User")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<States>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.Property(e => e.PkId)
                    .HasColumnName("pk_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId)
                    .HasColumnName("countryID")
                    .HasMaxLength(50);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrailerView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TrailerView");

                entity.Property(e => e.Commodity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lienholder)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LienholderType)
                    .HasColumnName("Lienholder type")
                    .HasMaxLength(50);

                entity.Property(e => e.Make)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PkId)
                    .IsRequired()
                    .HasColumnName("pk_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Trailer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrailerType)
                    .HasColumnName("Trailer type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vin)
                    .HasColumnName("VIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Trailers>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.Property(e => e.PkId)
                    .HasColumnName("pk_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Commodity)
                    .HasColumnName("commodity")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LienholderType)
                    .HasColumnName("lienholder_type")
                    .HasMaxLength(50);

                entity.Property(e => e.Make)
                    .HasColumnName("make")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plate)
                    .HasColumnName("plate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50);

                entity.Property(e => e.Trailer)
                    .HasColumnName("trailer")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrailerLienholder)
                    .HasColumnName("trailer_lienholder")
                    .HasMaxLength(50);

                entity.Property(e => e.TrailerType)
                    .HasColumnName("trailer_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vin)
                    .HasColumnName("vin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TruckView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TruckView");

                entity.Property(e => e.Commodity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Engine).HasMaxLength(50);

                entity.Property(e => e.InsuranceType)
                    .HasColumnName("Insurance type")
                    .HasMaxLength(50);

                entity.Property(e => e.InsuranceValue)
                    .HasColumnName("Insurance value")
                    .HasColumnType("money");

                entity.Property(e => e.Lienholder)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Make)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PkId)
                    .IsRequired()
                    .HasColumnName("pk_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationType)
                    .HasColumnName("Registration type")
                    .HasMaxLength(5);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Truck)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TruckType)
                    .HasColumnName("Truck type")
                    .HasMaxLength(50);

                entity.Property(e => e.Vin)
                    .HasColumnName("VIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Trucks>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.Property(e => e.PkId)
                    .HasColumnName("pk_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Apportioned).HasColumnName("apportioned");

                entity.Property(e => e.Commodity)
                    .HasColumnName("commodity")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Engine)
                    .HasColumnName("engine")
                    .HasMaxLength(50);

                entity.Property(e => e.InsuranceType)
                    .HasColumnName("insurance_type")
                    .HasMaxLength(50);

                entity.Property(e => e.InsuranceValue)
                    .HasColumnName("insurance_value")
                    .HasColumnType("money");

                entity.Property(e => e.Lienholder)
                    .HasColumnName("lienholder")
                    .HasMaxLength(50);

                entity.Property(e => e.Make)
                    .HasColumnName("make")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plate)
                    .HasColumnName("plate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationType)
                    .HasColumnName("registration_type")
                    .HasMaxLength(5);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Truck)
                    .HasColumnName("truck")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TruckType)
                    .HasColumnName("truck_type")
                    .HasMaxLength(50);

                entity.Property(e => e.Vin)
                    .HasColumnName("vin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.IdUser);

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_User")
                    .HasMaxLength(40);

                entity.Property(e => e.IdEmployee)
                    .IsRequired()
                    .HasColumnName("ID_Employee")
                    .HasMaxLength(40);

                entity.Property(e => e.IdRight)
                    .HasColumnName("ID_Right")
                    .HasMaxLength(40);

                entity.Property(e => e.Roll).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
