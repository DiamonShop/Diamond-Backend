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
        public string ProductID { get; set; }

        [ForeignKey("MainDiamond")]
        public int MainDiamondID { get; set; }
        public int MainDiamondQuantity { get; set; }

        [ForeignKey("SideDiamond")]
        public int SideDiamondID { get; set; }
        public int SideDiamondQuantity { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public int BasePrice { get; set; }

        public Category Category { get; set; } = null!;
        public JewelrySettings JewelrySetting { get; set; } = null!;
        public Product Product { get; set; } = null!;
        public MainDiamond MainDiamond { get; set; } = null!;
        public SideDiamond SideDiamond { get; set; } = null!;

        public virtual ICollection<JewelrySize> JewelrySizes { get; set; } = new List<JewelrySize>();
    }
}
