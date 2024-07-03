using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DiamondShop.Data;

namespace Diamond.Entities.Data
{
    public class Jewelry
    {
        [Key]
        public int JewelryID { get; set; }
        [ForeignKey("JewelrySetting")]
        public int JewelrySettingID { get; set; }
        [ForeignKey("Product")]
        [StringLength(50)]
        public string ProductID { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public decimal BasePrice { get; set; }

        public Category Category { get; set; } = null!;
        public JewelrySettings JewelrySetting { get; set; } = null!;
        public Product Product { get; set; } = null!;
    }
}
