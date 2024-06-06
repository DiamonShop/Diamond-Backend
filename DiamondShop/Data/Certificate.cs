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
		public string? Color { get; set; }
		[Required]
		public string? Clarity { get; set; }
		[Required]
		public string? Cut { get; set; }

        public virtual Product Product { get; set; } = null!;
    }
}