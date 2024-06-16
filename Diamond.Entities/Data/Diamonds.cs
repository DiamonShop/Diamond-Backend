using DiamondShop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Entities.Data
{
    public class Diamonds
    {
        [Key]
        public int DiamondID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        [StringLength(50)]
        [Required]
        public string Origin { get; set; }
        [Required]
        public decimal Carat { get; set; }
        [Required]
        [StringLength(50)]
        public string Clarity { get; set; }
        [Required]
        [StringLength(50)]
        public string Cut { get; set; }
        [Required]
        [StringLength(50)]
        public string Color { get; set; }
        public decimal BasePrice { get; set; }

        public virtual Certification Certification { get; set; }
        public virtual Product Product { get; set; }
    }
}