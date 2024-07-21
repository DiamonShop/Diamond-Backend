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
        public int UserID { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        [Required]
        [StringLength(30)]
        public string Status { get; set; }

        [Required]
        public DateOnly OrderDate { get; set; }

        [StringLength(100)]
        public string OrderNote { get; set; }

        [StringLength(200)]
        public string? CancelReason { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}