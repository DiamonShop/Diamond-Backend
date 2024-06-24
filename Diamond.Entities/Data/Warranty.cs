using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
	public class Warranty
	{
		[Key]
		[Required]
		public string WarrantyId { get; set; }
		[ForeignKey("Product")]
        [StringLength(50)]
        public string ProductId { get; set; }
		[Required]
		public int WarrantyPeriod { get; set; }
        [Required]
        public string Username { get; set; }

		public virtual Product Product { get; set; } = null!;
	}
}