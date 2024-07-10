using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Entities.Data
{
    public class JewelrySize
    {
        [Key]
        public int JewelrySizeID { get; set; }

        [ForeignKey("Jewelry")]
        public int JewelryID { get; set; }

        public int Size { get; set; }
        public int Quantity { get; set; }

        public virtual Jewelry Jewelry { get; set; }
    }
}
