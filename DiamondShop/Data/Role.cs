using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
	public class Role
	{
		[Key]
		public int RoleId { get; set; }

		[Required]
		[StringLength(50)]
		public string RoleName { get; set; }

		public virtual ICollection<User> Users { get; set; } = new List<User>();
	}
}