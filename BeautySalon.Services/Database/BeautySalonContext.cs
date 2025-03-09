using Microsoft.EntityFrameworkCore;

namespace BeautySalon.Services.Database
{
    public partial class BeautySalonContext : DbContext
    {
        public BeautySalonContext() { }

        public BeautySalonContext(DbContextOptions<BeautySalonContext> options)
            : base(options)
        { }

        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<Coupon> Coupons { get; set; } = null!;
        public virtual DbSet<EmployeeSchedule> EmployeeSchedules { get; set; } = null!;
        public virtual DbSet<LoyaltyPoints> LoyaltyPoints { get; set; } = null!;
        public virtual DbSet<Membership> Memberships { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<ServiceCategory> ServiceCategories { get; set; } = null!;
        public virtual DbSet<ServicePackage> ServicePackages { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        public virtual DbSet<UserServiceRating> UserServiceRatings { get; set; } = null!;
        public virtual DbSet<UserServicePackage> UserServicePackages { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(e => e.AppointmentId)
                    .HasName("PK__Appointment");

                entity.ToTable("Appointment");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.AppointmentDate).HasColumnType("datetime");

                entity.Property(e => e.CouponId).HasColumnName("CouponID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.Status).HasColumnName("Status");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appointmet__User");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeAppointments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appointmet__Employee");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appointmet__Service");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appointment__Payment");

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.UsedInAppointments)
                    .HasForeignKey(d => d.CouponId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Appointment__Coupon");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.HasKey(e => e.CouponId)
                    .HasName("PK__Coupon");

                entity.ToTable("Coupon");

                entity.Property(e => e.CouponId).HasColumnName("CouponID");

                entity.Property(e => e.CouponCode).HasMaxLength(20);

                entity.Property(e => e.Discount).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeSchedule>(entity =>
            {
                entity.HasKey(e => e.EmployeeScheduleId)
                .HasName("PK__EmployeeSchedule");

                entity.ToTable("EmployeeSchedule");

                entity.Property(e => e.EmployeeScheduleId).HasColumnName("EmployeeScheduleID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
                
                entity.Property(e => e.StartTime).HasColumnType("datetime");
                
                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.IsAvailable)
                .IsRequired()
                .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeSchedules)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeSchedule__Employee");
            });

            modelBuilder.Entity<LoyaltyPoints>(entity =>
            {
                entity.HasKey(e => e.LoyaltyPointsId)
                .HasName("PK__LoyaltyPoints");

                entity.ToTable("LoyalPoints");

                entity.Property(e => e.LoyaltyPointsId).HasColumnName("LoyaltyPointsID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Points).HasColumnName("Points");

                entity.Property(e => e.LastUpdated).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LoyaltyPoints)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LoyaltyPoints__User");
            });

            modelBuilder.Entity<Membership>(entity =>
            {
                entity.HasKey(entity => entity.MembershipId)
                .HasName("PK__Membership");
           
                entity.ToTable("Membership");

                entity.Property(e => e.MembershipId).HasColumnName("MembershipID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Name).HasColumnName("Name");

                entity.Property(e => e.Price).HasColumnName("Price");

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Memberships)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Membership__User");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                .HasName("PK__Payment");

                entity.ToTable("Payment");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RoleId).HasName("PK_Role");

                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(255);
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                .HasName("PK__Service");

                entity.ToTable("Service");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.DurationInMinutes).HasColumnName("DurationInMinutes");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Service__Category");
            });


            modelBuilder.Entity<ServiceCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__ServiceCategory");

                entity.ToTable("ServiceCategory");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });


            modelBuilder.Entity<ServicePackage>(entity =>
            {
                entity.HasKey(e => e.ServicePackageId)
                    .HasName("PK__ServicePackage");

                entity.ToTable("ServicePackage");

                entity.Property(e => e.ServicePackageId).HasColumnName("ServicePackageID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__User");

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

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Gender).HasMaxLength(10);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => e.UserRoleId)
                .HasName("PK__UserRole");

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

            modelBuilder.Entity<UserServicePackage>(entity =>
            {
                entity.HasKey(e => e.UserServicePackageId)
                .HasName("PK__UserServicePackage");

                entity.ToTable("UserServicePackage");

                entity.Property(e => e.UserServicePackageId).HasColumnName("UserServicePackageID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ServicePackageId).HasColumnName("ServicePackageID");

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserServicePackages)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserServicePackage_User");

                entity.HasOne(d => d.ServicePackage)
                    .WithMany(p => p.UserServicePackages)
                    .HasForeignKey(d => d.ServicePackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserServicePackage_ServicePackage");
            });

            modelBuilder.Entity<UserServiceRating>(entity =>
            {
                entity.HasKey(e => e.UserServiceRatingId)
                .HasName("PK__UserServiceRating");

                entity.ToTable("UserServiceRating");

                entity.Property(e => e.UserServiceRatingId).HasColumnName("UserServiceRatingID");

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
