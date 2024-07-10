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

        [Required]
        [StringLength(300)]
        public string? Description { get; set; }

        public int MarkupRate { get; set; }

        public int MarkupPrice { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public Jewelry Jewelry { get; set; } = null!;
        public Diamonds Diamond { get; set; } = null!;
        public Warranty Warranty { get; set; } = null!;
        public ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
        public ICollection<Feedback> Feedbacks { get; } = new List<Feedback>();

        public void UpdateDiamondsAndJewelryPrice()
        {
            if (ProductType == "Jewelry" && Jewelry != null)
            {
                // Tính MarkupPrice dựa trên giá gốc của Jewelry và MarkupRate
                MarkupPrice = Jewelry.BasePrice * MarkupRate;
            }
            else if (ProductType == "Diamond" && Diamond != null)
            {
                // Tính MarkupPrice dựa trên giá gốc của Diamond và MarkupRate
                MarkupPrice = Diamond.BasePrice * MarkupRate;
            }
        }
    }
}
