using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
	public class OrderDetail
	{
		[Key]
        [StringLength(10)]
        public string OrderDetailId { get; set; }
		[ForeignKey("Order")]
		public int OrderId { get; set; }
		[ForeignKey("Product")]
		public string ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
		public int UnitPrice { get; set; }
		[Required]
		public int Quantity { get; set; }

        public virtual Order? Order { get; set; } 
        public virtual Product Product { get; set; } = null!;
	}
}