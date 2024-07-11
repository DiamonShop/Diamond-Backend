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

        [ForeignKey("Jewelry")]
        public int JewelryID { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        public virtual Jewelry Jewelry { get; set; }
    }
}
