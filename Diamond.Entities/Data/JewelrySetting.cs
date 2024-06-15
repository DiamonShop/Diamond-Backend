using DiamondShop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Entities.Data
{
    public class JewelrySetting
    {
        [Key]
        [Required]
        public int JewelrySettingID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Material { get; set; }
        [Required]
        public decimal BasePrice { get; set; }
        [StringLength(200)]
        public string Description { get; set; }

        public ICollection<Product> Products { get; } = new List<Product>();
    }
}
