using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
    public class OrderDetail
    {
        [Key]
        [Required]
        public int OrderDetailId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
		[Required]
		public decimal Price { get; set; }
		[Required]
		public int Quantity { get; set; }

		public virtual Order Order { get; set; } = null!;
		public virtual Product Product { get; set; } = null!;
	}
}