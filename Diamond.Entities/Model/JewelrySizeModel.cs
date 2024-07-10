using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Entities.Model
{
    public class JewelrySizeModel
    {
        public int JewelrySizeID { get; set; }
        public int JewelryID { get; set; }
        public int Size { get; set; }
        public int Quantity { get; set; }
    }
}
