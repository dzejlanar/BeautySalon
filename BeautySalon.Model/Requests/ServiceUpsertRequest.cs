using System.ComponentModel.DataAnnotations;

namespace BeautySalon.Model.Requests
{
    public class ServiceUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; } = null!;

        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public double Duration { get; set; }
    }
}
