namespace BeautySalon.Services.Database
{
    public class Membership
    {
        public int MembershipId { get; set; }
        public string? Name { get; set; } // e.g., Silver, Gold
        public decimal Price { get; set; }
        public decimal DiscountPercentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
    }

}
