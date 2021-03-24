using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApprovalIntelogix.Models
{
    public partial class ApprovalIntelogixContext : DbContext
    {
        public ApprovalIntelogixContext()
        {
        }

        public ApprovalIntelogixContext(DbContextOptions<ApprovalIntelogixContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ApprovalUser> ApprovalUser { get; set; }
        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Step> Step { get; set; }
        public virtual DbSet<UserStep> UserStep { get; set; }
        public virtual DbSet<Workflow> Workflow { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-IQ0SK8A;Database=ApprovalIntelogix;User Id=sa;Password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApprovalUser>(entity =>
            {
                entity.HasKey(e => e.PkId);

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .HasMaxLength(40);

                entity.Property(e => e.IdRole)
                    .HasColumnName("ID_Role")
                    .HasMaxLength(40);

                entity.Property(e => e.IdUser)
                    .HasColumnName("ID_User")
                    .HasMaxLength(40);

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.ApprovalUser)
                    .HasForeignKey(d => d.IdRole)
                    .HasConstraintName("FK_ApprovalUser_Role");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasKey(e => e.IdRequest);

                entity.Property(e => e.IdRequest)
                    .HasColumnName("ID_Request")
                    .HasMaxLength(40);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Description).HasMaxLength(120);

                entity.Property(e => e.IdWorkflow)
                    .HasColumnName("ID_Workflow")
                    .HasMaxLength(40);

                entity.Property(e => e.Utilities)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdWorkflowNavigation)
                    .WithMany(p => p.Request)
                    .HasForeignKey(d => d.IdWorkflow)
                    .HasConstraintName("FK_Request_Workflow");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole);

                entity.Property(e => e.IdRole)
                    .HasColumnName("ID_Role")
                    .HasMaxLength(40);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Step>(entity =>
            {
                entity.HasKey(e => e.IdStep);

                entity.Property(e => e.IdStep)
                    .HasColumnName("ID_Step")
                    .HasMaxLength(40);

                entity.Property(e => e.Description).HasMaxLength(120);

                entity.Property(e => e.IdWorkflow)
                    .HasColumnName("ID_Workflow")
                    .HasMaxLength(40);

                entity.Property(e => e.Namestep)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.HasOne(d => d.IdWorkflowNavigation)
                    .WithMany(p => p.Step)
                    .HasForeignKey(d => d.IdWorkflow)
                    .HasConstraintName("FK_Step_Workflow");
            });

            modelBuilder.Entity<UserStep>(entity =>
            {
                entity.HasKey(e => e.IdUserStep);

                entity.Property(e => e.IdUserStep)
                    .HasColumnName("ID_UserStep")
                    .HasMaxLength(40);

                entity.Property(e => e.IdStep)
                    .HasColumnName("ID_Step")
                    .HasMaxLength(40);

                entity.Property(e => e.PkId)
                    .HasColumnName("PK_ID")
                    .HasMaxLength(40);

                entity.HasOne(d => d.IdStepNavigation)
                    .WithMany(p => p.UserStep)
                    .HasForeignKey(d => d.IdStep)
                    .HasConstraintName("FK_UserStep_Step");

                entity.HasOne(d => d.Pk)
                    .WithMany(p => p.UserStep)
                    .HasForeignKey(d => d.PkId)
                    .HasConstraintName("FK_UserStep_ApprovalUser");
            });

            modelBuilder.Entity<Workflow>(entity =>
            {
                entity.HasKey(e => e.IdWorkflow);

                entity.Property(e => e.IdWorkflow)
                    .HasColumnName("ID_Workflow")
                    .HasMaxLength(40);

                entity.Property(e => e.Business).HasMaxLength(40);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
