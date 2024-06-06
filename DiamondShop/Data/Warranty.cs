using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
	public class Warranty
	{
		[Key]
		[Required]
		public int WarrantyId { get; set; }

		[ForeignKey("User")]
		public int UserId { get; set; }

		[ForeignKey("Product")]
		public int ProductId { get; set; }
		[Required]
		public int WarrantyPeriod { get; set; }

		public virtual User User { get; set; } = null!;
		public virtual Product Product { get; set; } = null!;
	}
}