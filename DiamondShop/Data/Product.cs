using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Data
{
	public class Product
	{
		[Key]
		[Required]
		public int ProductId { get; set; }

		[ForeignKey("Category")]
		public int CategoryId { get; set; }

		[StringLength(100)]
		public string Name { get; internal set; }
		public decimal Price { get; internal set; }
		[StringLength(300)]
		public string? Description { get; internal set; }
		public int? Stock { get; set; }

		[StringLength(50)]
		public string Status { get; set; } = null!;

		public Category Category { get; set; } = null!;
		public ProductDetail ProductDetail { get; set; } = null!;
		public Certificate Certificate { get; set; } = null!;
		public Warranty Warranty { get; set; } = null!;

		public ICollection<CartItem> CartItems { get; } = new List<CartItem>();
		public ICollection<Feedback> Feedbacks { get; } = new List<Feedback>();
	}
}
