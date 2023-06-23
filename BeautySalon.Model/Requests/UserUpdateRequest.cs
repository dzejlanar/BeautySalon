using System.ComponentModel.DataAnnotations;

namespace BeautySalon.Model.Requests
{
    public class UserUpdateRequest
    {
        [MinLength(8)]
        public string? Password { get; set; }

        public string? PasswordConfirmation { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; } = null!;

        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; } = null!;

        public bool IsActive { get; set; }

        [Required]
        public string Gender { get; set; } = null!;

        [Required]
        public DateTime DateOfBirth { get; set; }

        public string? Address { get; set; }
        public int? AppointmentCount { get; set; }
        public List<int> RoleIds { get; set; } = new List<int> { };
    }
}
