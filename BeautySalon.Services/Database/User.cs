namespace BeautySalon.Services.Database
{
    public partial class User
    {
        public User()
        {
            Coupons = new HashSet<Coupon>();
            UserRoles = new HashSet<UserRole>();
            Appointments = new HashSet<Appointment>();
            UserServicesRatings = new HashSet<UserServiceRating>();
        }

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
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
        public int? AppointmentCount { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<UserServiceRating> UserServicesRatings { get; set; }
    }
}
