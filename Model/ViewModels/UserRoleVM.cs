namespace BeautySalon.Model.ViewModels
{
    public class UserRoleVM
    {
        public int BaseUserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime UpdatedDate { get; set; }
        public virtual RoleVM Role { get; set; } = null!;
    }
}
