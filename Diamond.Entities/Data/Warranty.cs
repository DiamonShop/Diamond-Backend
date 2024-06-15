using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
	public class Warranty
	{
		[Key]
		[Required]
		public int WarrantyId { get; set; }
		[ForeignKey("Product")]
		public int ProductId { get; set; }
		[Required]
		public int WarrantyPeriod { get; set; }
        [Required]
        public string Username { get; set; }

		public virtual Product Product { get; set; } = null!;
	}
}