namespace DiamondShop.Model
{
    public class UserModel
    {
        public string UserId { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string RoleName { get; set; } = null!;
    }
}
