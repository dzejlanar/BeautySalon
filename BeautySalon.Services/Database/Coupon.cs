namespace BeautySalon.Services.Database
{
    public partial class Coupon
    {
        public int CouponId { get; set; }
        public string CouponCode { get; set; } = null!;
        public decimal Discount { get; set; }
        public DateTime ExpiryDate { get; set; }
        public virtual ICollection<Appointment> UsedInAppointments { get; set; } = new List<Appointment>();
    }
}
