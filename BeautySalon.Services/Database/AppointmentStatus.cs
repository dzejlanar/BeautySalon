using System;
using System.Collections.Generic;

namespace BeautySalon.Services.Database
{
    public partial class AppointmentStatus
    {
        public AppointmentStatus()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int StatusId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
