using DiamondShop.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Diamond.Entities.Data
{
    public class Diamonds
    {
        [Key]
        [Required]
        public int DiamondID { get; set; }
        [ForeignKey("Product")]
        [StringLength(50)]
        public string ProductID { get; set; }
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
        public int BasePrice { get; set; }

        public virtual Certification Certification { get; set; }
        public virtual Product Product { get; set; } = null!;
    }
}