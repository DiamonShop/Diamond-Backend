using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
    public class ShoppingCart
    {
        [Key]
        [Required] 
        public int CartId { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        
		public virtual Product Product { get; set; } = null!;
		public virtual User User { get; set; } = null!;
    }
}