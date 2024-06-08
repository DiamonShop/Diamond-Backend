namespace DiamondShop.Data
{
	public class UserDTO
	{
		public string Fullname { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
        public bool IsActive { get; set; }
        public int RoleId { get; set; }
	}
}
