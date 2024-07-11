using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Entities.Data
{
    public class MainDiamond
    {
        [Key]
        [Required]
        public int MainDiamondID { get; set; }
        [StringLength(50)]
        public string MainDiamondName { get; set; }
        [Required]
        public int Price { get; set; }

        public virtual ICollection<Jewelry> JewelrySizes { get; set; } = new List<Jewelry>();
    }
}
