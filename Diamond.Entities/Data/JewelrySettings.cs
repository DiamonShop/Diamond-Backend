using DiamondShop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Entities.Data
{
    public class JewelrySettings
    {
        [Key]
        [Required]
        public int JewelrySettingID { get; set; }
        [Required]
        [StringLength(100)]
        public string Material { get; set; }
        public int BasePrice { get; set; }

        public ICollection<Jewelry> Jewelry { get; } = new List<Jewelry>();
    }
}
