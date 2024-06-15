using Diamond.Entities.Data;
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
        [ForeignKey("JewelrySetting")]
        public int JewelrySettingID { get; set; }
        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }
        [Required]
        [StringLength(300)]
        public string? Description { get; set; }
        [Required]
        public int? Stock { get; set; }
        public decimal MarkupRate { get; set; } //tỉ lệ áp giá
        public int BasePrice { get; set; }
        [Required]
        public bool IsActive { get; set; }

        public Category Category { get; set; } = null!;
        public Diamonds Diamond { get; set; } = null!;
        public Warranty Warranty { get; set; } = null!;
        public JewelrySetting JewelrySetting { get; set; } = null!;
        public ICollection<CartItem> CartItems { get; } = new List<CartItem>();
        public ICollection<Feedback> Feedbacks { get; } = new List<Feedback>();
    }
}
