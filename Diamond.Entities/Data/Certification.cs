using Diamond.Entities.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Data
{
	public class Certification
	{
		[Key]
		[Required]
		public int CertificationID { get; set; }
		[ForeignKey("Diamonds")]
		public int DiamondID { get; set; }

		[Required]
		public DateTime CertificationDate { get; set; }
		[Required]
		[StringLength(100)]
        public string CertificationDetails { get; set; }

		public virtual Diamonds Diamond { get; set; } = null!;
	}
}