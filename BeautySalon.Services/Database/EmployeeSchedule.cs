namespace BeautySalon.Services.Database
{
    public class EmployeeSchedule
    {
        public int EmployeeScheduleId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsAvailable { get; set; }

        public virtual User Employee { get; set; } = null!;
    }

}
