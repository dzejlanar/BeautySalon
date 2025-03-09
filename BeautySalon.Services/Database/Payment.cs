namespace BeautySalon.Services.Database
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string? Status { get; set; } = null;

        public virtual ICollection<Appointment> Appointments { get; set; } = null!;
    }
}
