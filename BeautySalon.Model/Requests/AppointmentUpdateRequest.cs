
namespace BeautySalon.Model.Requests
{
    public class AppointmentUpdateRequest
    {
        public DateTime AppointmentDate { get; set; }
        public int? PaymentId { get; set; }
        public int? CouponId { get; set; }
    }
}
