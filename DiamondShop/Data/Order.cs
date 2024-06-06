using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
    public class Order
    {
        [Key]
        [Required]  
        public int OrderId { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
		[Required]
		public decimal TotalPrice { get; set; }
		[Required]
		public string Status { get; set; }
		[Required]
		public DateTime OrderDate { get; set; }

		public virtual User User { get; set; } = null!;
		public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
	}
}