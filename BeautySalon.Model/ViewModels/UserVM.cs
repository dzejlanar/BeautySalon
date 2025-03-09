namespace BeautySalon.Model.ViewModels
{
    public class UserVM
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; }
        public ICollection<UserRoleVM> UserRoles { get; set; } = new List<UserRoleVM>();
        public string RoleNames => string.Join(", ", UserRoles.Select(ur => ur.Role.RoleName).ToList());
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string FirstAndLastName => $"{FirstName} {LastName}";
    }
}
