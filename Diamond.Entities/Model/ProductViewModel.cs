using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Model
{
    public class ProductViewModel
    {
		public int ProductId { get; set; }
		public int CategoryId { get; set; }
		public string ProductName { get; set; }
		public string? Description { get;set; }
		public int? Stock { get; set; }
		public int BasePrice { get; set; }
		public bool IsActive { get; set; }
	}

}
