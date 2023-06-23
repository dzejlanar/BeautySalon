using System.ComponentModel.DataAnnotations;

namespace BeautySalon.Model.Requests
{
    public class UserInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        [EmailAddress()]
        public string Email { get; set; } = null!;

        [Required(AllowEmptyStrings = false)]
        [MinLength(4)]
        public string Username { get; set; } = null!;

        [MinLength(8)]
        public string Password { get; set; } = null!;

        [Required]
        public string PasswordConfirmation { get; set; } = null!;

        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; } = null!;

        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; } = null!;

        public List<int> RoleIds { get; set; } = new List<int> { };
        public bool IsActive { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
    }
}
