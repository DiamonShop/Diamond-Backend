using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Entities.Data
{
    public class SideDiamond
    {
        [Key]
        [Required]
        public int SideDiamondID { get; set; }

        [StringLength(50)]
        public string SideDiamondName { get; set; }
        [Required]
        public int Price { get; set; }

        public virtual ICollection<Jewelry> Jewelry { get; set; } = new List<Jewelry>();
    }
}
