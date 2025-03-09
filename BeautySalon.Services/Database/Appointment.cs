namespace BeautySalon.Services.Database
{
    public partial class Appointment
    {
        public int AppointmentId { get; set; }
        public int UserId { get; set; }
        public int EmployeeId { get; set; }
        public int ServiceId { get; set; }
        public int? PaymentId { get; set; }
        public int? CouponId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string? Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual User Employee { get; set; } = null!;
        public virtual Service Service { get; set; } = null!;
        public virtual Payment? Payment { get; set; } = null;
        public virtual Coupon? Coupon { get; set; } = null;
    }
}
