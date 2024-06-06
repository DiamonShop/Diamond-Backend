using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Data
{
    public class Category
    {
        [Key]
		[Required]
		public int CategoryId { get; set; }
        [Required]
        public string? CategoryName { get; set; }

        public ICollection<Product> Products { get;} = new List<Product>();
    }
}