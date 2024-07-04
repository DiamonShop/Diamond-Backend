using Diamond.Entities.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Required]
        public int Stock { get; set; }
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
            int jewelryBasePrice = Jewelry?.BasePrice ?? 0;
            int diamondBasePrice = Diamond?.BasePrice ?? 0;
            MarkupPrice = (jewelryBasePrice + diamondBasePrice) * MarkupRate;

            // Update Diamonds BasePrice based on MarkupPrice
            if (Diamond != null)
            {
                Diamond.BasePrice = diamondBasePrice * MarkupPrice;
            }

            // Update Jewelry BasePrice based on MarkupPrice
            if (Jewelry != null)
            {
                Jewelry.BasePrice = jewelryBasePrice * MarkupPrice;
            }
        }

    }
}
