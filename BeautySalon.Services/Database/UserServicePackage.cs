namespace BeautySalon.Services.Database
{
    public class UserServicePackage
    {
        public int UserServicePackageId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int ServicePackageId { get; set; }
        public virtual ServicePackage ServicePackage { get; set; } = null!;

        public DateTime PurchaseDate { get; set; }
    }

}
