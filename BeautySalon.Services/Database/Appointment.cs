using System;
using System.Collections.Generic;

namespace BeautySalon.Services.Database
{
    public partial class Appointment
    {
        public Appointment()
        {
            Payments = new HashSet<Payment>();
        }

        public int AppointmentId { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string? CouponCode { get; set; }
        public int StatusId { get; set; }
        public string? RescheduleReason { get; set; }
        public DateTime? RescheduleRequest { get; set; }
        public int? PaymentId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Service Service { get; set; } = null!;
        public virtual AppointmentStatus Status { get; set; } = null!;
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
