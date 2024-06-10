using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Data
{
	public class Certificate
	{
		[Key]
		[Required]
		public int CertificateId { get; set; }
		[ForeignKey("Product")]
		public int ProductId { get; set; }

		[Required]
		public decimal CaratWeight { get; set; }
		[Required]
		[StringLength(30)]
		public string? Color { get; set; }
		[Required]
		[StringLength(30)]
		public string? Clarity { get; set; }
		[Required]
		[StringLength(30)]
		public string? Cut { get; set; }

		public virtual Product Product { get; set; } = null!;
	}
}