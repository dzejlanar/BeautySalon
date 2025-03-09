namespace BeautySalon.Model.Requests
{
    public class AppointmentInsertRequest
    {
        public int UserId { get; set; }
        public int EmployeeId { get; set; }
        public int ServiceId { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
