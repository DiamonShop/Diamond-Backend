using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diamond.Entities.Data
{
    public class DiamondPrice
    {
        [Key]
        public int Id { get; set; }

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

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal DiameterMM { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public int Price { get; set; }
    }
}
