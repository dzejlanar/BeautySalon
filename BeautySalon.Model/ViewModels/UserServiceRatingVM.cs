namespace BeautySalon.Model.ViewModels
{
    public class UserServiceRatingVM
    {
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ServiceId { get; set; }
        public ServiceVM Service { get; set; }
        public int UserId { get; set; }
        public UserVM User { get; set; }
    }
}
