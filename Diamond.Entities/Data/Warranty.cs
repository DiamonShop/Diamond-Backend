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
        [StringLength(50)]
        public string ProductId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [Required]
        public DateOnly BuyDate { get; set; }
        [Required]
		public int WarrantyPeriod { get; set; }
        [Required]
        public bool IsAvailable { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
	}
}