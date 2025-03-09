using System.ComponentModel.DataAnnotations;

namespace BeautySalon.Model.Requests
{
    public class UserInsertRequest
    {
        public string Email { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string PasswordConfirmation { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public List<int>? RoleIds { get; set; } = new List<int> { };
        public string Gender { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
    }
}
