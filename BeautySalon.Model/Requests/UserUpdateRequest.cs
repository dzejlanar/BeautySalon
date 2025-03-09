using System.ComponentModel.DataAnnotations;

namespace BeautySalon.Model.Requests
{
    public class UserUpdateRequest
    {
        public string? Password { get; set; }
        public string? PasswordConfirmation { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
        public int? AppointmentCount { get; set; }
        public List<int> RoleIds { get; set; } = new List<int> { };
    }
}
