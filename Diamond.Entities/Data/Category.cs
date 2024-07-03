using Diamond.Entities.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Data
{
	public class Category
	{
		[Key]
		[Required]
		public int CategoryId { get; set; }
		[Required]
		[StringLength(50)]
		public string CategoryName { get; set; } 
        public ICollection<Jewelry> Jewelry { get; } = new List<Jewelry>();
	}
}