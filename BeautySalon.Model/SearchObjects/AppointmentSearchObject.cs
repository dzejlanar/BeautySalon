namespace BeautySalon.Model.SearchObjects
{
    public class AppointmentSearchObject : BaseSearchObject
    {
        public DateTime? AppointmentDateGT { get; set; }
        public int? UserId { get; set; }
        public int? EmployeeId { get; set; }
        public string? ServiceNameGT { get; set; }
    }
}
