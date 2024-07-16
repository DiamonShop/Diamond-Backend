using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
    public class Feedback
    {
        [Key]
        [Required]
        public int FeedbackId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Product")]
        public string ProductID { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }  // Add OrderId to the entity

        [StringLength(200)]
        public string? Description { get; set; }

        public DateTime? DateTime { get; set; }

        [Range(1, 5)]
        public int? Rating { get; set; }

        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }  // Add navigation property to Order
    }
}
