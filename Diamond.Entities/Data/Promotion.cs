using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Data
{
	public class Promotion
	{
		[Key]
		[Required]
		public string PromotionID { get; set; }
		[ForeignKey("User")]
		public int UserID { get; set; }
        [Required]
        public int DiscountPercentage { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public bool IsActive { get; set; }
		[Required]
        [StringLength(100)]
        public string Condition { get; set; }

        public virtual User User { get; set; }
	}
}
