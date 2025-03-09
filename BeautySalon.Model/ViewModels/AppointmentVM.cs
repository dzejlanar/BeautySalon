namespace BeautySalon.Model.ViewModels
{
    public class AppointmentVM
    {
        public int AppointmentId { get; set; }
        public int Duration { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string? Status { get; set; }
    }
}
