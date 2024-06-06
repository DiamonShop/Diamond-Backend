using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Data
{
    public class ProductDetail
    {
        [Key]
        [Required]
		public int ProductDetailId { get; set; }
		[ForeignKey("Product")]
		[Required]
		public int ProductId { get; set; }
		[StringLength(50)]
		[Required]
		public string? Origin { get; set; }
		[Required]
		public decimal Carat { get; set; }
		[Required]
		public string? Clarity { get; set; }
		[Required]
		public string? Cut { get; set; }
		[Required]
		public string? Color { get; set; }

		public virtual Product Product { get; set; } = null!;
    }
}