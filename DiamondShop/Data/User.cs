using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace DiamondShop.Data
{
	public class User
	{
		[Key]
		[Required]
		public int UserId { get; set; }
		[ForeignKey("Role")]
		public int RoleId { get; set; }
		[Required]
		[StringLength(200)]
		public string? Email { get; set; }
		[Required]
		[StringLength(30)]
		public string? Status { get; set; }
		[Required]
		[StringLength(50)]
		public string? FullName { get; set; }
		[Required]
		[StringLength(30)]
		public string Username { get; set; }
		[Required]
		[StringLength(50)]
		public string Password { get; set; }
		public bool IsActive { get; set; }

		public virtual Role Role { get; set; }
		public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
		public virtual ICollection<Warranty> Warranties { get; set; } = new List<Warranty>();
		public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
		public virtual ICollection<Certificate> Certificates { get; set; } = new List<Certificate>();
		public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
	}
}
