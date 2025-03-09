namespace BeautySalon.Services.Database
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string PasswordSalt { get; set; } = null!;
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Gender { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; } = null!;
        public virtual ICollection<Appointment> EmployeeAppointments { get; set; } = null!;
        public virtual ICollection<UserRole> UserRoles { get; set; } = null!;
        public virtual ICollection<UserServiceRating> UserServicesRatings { get; set; } = null!;
        public virtual ICollection<Membership>? Memberships { get; set; }
        public virtual ICollection<UserServicePackage>? UserServicePackages { get; set; }
        public virtual ICollection<EmployeeSchedule>? EmployeeSchedules { get; set; }
        public virtual ICollection<LoyaltyPoints>? LoyaltyPoints { get; set; }
    }
}
