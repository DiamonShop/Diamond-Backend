using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
	public class CartItem
	{
		[Key]
		[Required]
		public int CartItemId { get; set; }
		[ForeignKey("Order")]
		public int OrderId { get; set; }
		[ForeignKey("Product")]
		public int ProductId { get; set; }
		[ForeignKey("ShoppingCart")]
		public int CartId { get; set; }
		[Required]
		public decimal UnitPrice { get; set; }
		[Required]
		public int Quantity { get; set; }

        public virtual Order? Order { get; set; } // Order is optional
        public virtual Product Product { get; set; } = null!;
		public virtual ShoppingCart ShoppingCart { get; set; } = null!;
	}
}