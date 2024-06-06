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

		[StringLength(300)]
		public string? Description { get; internal set; }
		public int? Stock { get; set; }

		[StringLength(50)]
		public string? Status { get; set; } = null!;

		public Category Category { get; set; } = null!;
		public ProductDetail ProductDetail { get; set; } = null!;
		public Certificate Certificate { get; set; } = null!;

		public ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
        public ICollection<Warranty> Warranties { get; } = new List<Warranty>();
        public ICollection<Feedback> Feedbacks { get; } = new List<Feedback>();
    }
}
