namespace BeautySalon.Services.Database
{
    public class LoyaltyPoints
    {
        public int LoyaltyPointsId { get; set; }
        public int UserId { get; set; }
        public int Points { get; set; } = 0;
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;

        public virtual User User { get; set; } = null!;
    }

}
