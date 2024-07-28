using Diamond.Entities.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Data
{
    public class Product
    {
        [Key]
        [StringLength(50)]
        public string ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductType { get; set; }

        [StringLength(700)]
        public string? Description { get; set; }

        public decimal MarkupRate { get; set; }

        public int MarkupPrice { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public virtual Jewelry Jewelry { get; set; } = null!;
        public virtual Diamonds Diamond { get; set; } = null!;

        public virtual ICollection<Warranty> Warranties { get; set; } = new List<Warranty>();
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
        public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();
    }
}
