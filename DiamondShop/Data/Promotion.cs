	using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Data
{
	public class Promotion
	{
		[Key]
		[Required]
		public string PromotionId { get; set; }
		[ForeignKey("User")]
		public string UserId { get; set; }
		public string UserName { get; set; }
		public int DiscountPercentage { get; set; }
		[Required]
		public DateTime StartDate { get; set; }
		[Required]
		public DateTime EndDate { get; set; }
		public bool Status { get; set; }
		public string Conditions { get; set; }

		public virtual User User { get; set; }
        public bool IsActive { get; set; }
    }
}
