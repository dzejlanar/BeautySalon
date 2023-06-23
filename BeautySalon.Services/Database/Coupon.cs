using System;
using System.Collections.Generic;

namespace BeautySalon.Services.Database
{
    public partial class Coupon
    {
        public int CouponId { get; set; }
        public string CouponCode { get; set; } = null!;
        public decimal Discount { get; set; }
        public bool AppliesToAllUsers { get; set; }
        public int? UserId { get; set; }
        public int? AppliesToAppointmentNumber { get; set; }
        public int MaxUses { get; set; }
        public int UsesRemaining { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual User? User { get; set; }
    }
}
