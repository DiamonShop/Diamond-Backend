using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
	public class ShoppingCart
    {
		[Key]
		[Required]
		public int CartId { get; set; }
		[ForeignKey("User")]
		public int UserId { get; set; }

		public virtual User User { get; set; } = null!;
		public virtual ICollection<CartItem>? CartItems { get; set; }
	}
}