using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BeautySalon.Services.Database
{
    public partial class BeautySalonContext : DbContext
    {
        public BeautySalonContext()
        {
        }

        public BeautySalonContext(DbContextOptions<BeautySalonContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<AppointmentStatus> AppointmentStatuses { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        public virtual DbSet<Coupon> Coupons { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<ServiceCategory> ServiceCategories { get; set; } = null!;
        public virtual DbSet<UserServiceRating> UserServiceRatings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost, 1433; Initial Catalog=BeautySalonDB; user=sa; Password=aA1111111!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.AppointmentDate).HasColumnType("datetime");

                entity.Property(e => e.CouponCode).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.RescheduleReason).HasMaxLength(100);

                entity.Property(e => e.RescheduleRequest).HasColumnType("datetime");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appointme__Custo__3A81B327");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appointme__Servi__3B75D760");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appointme__Statu__3C69FB99");
            });

            modelBuilder.Entity<AppointmentStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__Appointm__C8EE2043ACF86CF1");

                entity.ToTable("AppointmentStatus");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__User__1788CCAC974B022B");

                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.PasswordHash).HasMaxLength(200);

                entity.Property(e => e.PasswordSalt).HasMaxLength(200);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.AppointmentCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Gender).HasMaxLength(10);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleId");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserId");

                entity.Property(e => e.RoleId).HasColumnName("RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_User");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_Role");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.ToTable("Coupon");

                entity.Property(e => e.CouponId).HasColumnName("CouponID");

                entity.Property(e => e.CouponCode).HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Coupons)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Coupon__UserID__403A8C7D");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .HasColumnName("TransactionID");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Payments__Appoin__4316F928");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Service__Categor__35BCFE0A");
            });

            modelBuilder.Entity<ServiceCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__ServiceC__19093A2B4620EB35");

                entity.ToTable("ServiceCategory");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<UserServiceRating>(entity =>
            {
                entity.ToTable("UserServiceRating");

                entity.Property(e => e.UserServiceRatingId).HasColumnName("UserServiceRatingId");

                entity.Property(e => e.Rating).HasColumnName("Rating");

                entity.Property(e => e.Comment).HasColumnName("Comment");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserId");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserServicesRatings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserServiceRating_User");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.UserServiceRatings)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserServiceRating_Service");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
