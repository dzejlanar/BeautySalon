using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautySalon.Model.Requests
{
    public class UserServiceRatingInsertRequest
    {
        [Required]
        public int Rating { get; set; }

        public string? Comment { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int ServiceId { get; set; }
    }
}
