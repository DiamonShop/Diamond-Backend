using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Data
{
    public class Feedback
    {
        [Key]
        [Required]
        public int FeedbackId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Bill")]
        public int BillId { get; set; }

        [ForeignKey("Product")]
        public string ProductID { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }

        public DateTime? DateTime { get; set; }

        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
        
    }
}
