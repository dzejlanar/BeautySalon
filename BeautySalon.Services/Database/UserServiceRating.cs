namespace BeautySalon.Services.Database
{
    public class UserServiceRating
    {
        public int UserServiceRatingId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual Service Service { get; set; } = null!;
    }
}
