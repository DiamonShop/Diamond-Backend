namespace DiamondShop.Model
{
    public class UpdateUserModel
	{
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string NumberPhone { get; set; }

    }
}
