namespace BeautySalon.Services.Database
{
    public class ServicePackage
    {
        public int ServicePackageId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<Service> Services { get; set; } = null!;
        public virtual ICollection<UserServicePackage> UserServicePackages { get; set; } = null!;
    }

}
