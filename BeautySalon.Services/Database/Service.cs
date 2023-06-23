namespace BeautySalon.Services.Database
{
    public partial class Service
    {
        public Service()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int ServiceId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public long Duration { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ServiceCategory Category { get; set; } = null!;
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
