using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Model
{
    public class ProductViewModel
    {
        
        public int ProductId { get; set; }
		public int CategoryId { get; set; }
        public int JewelrySettingID { get; set; }
        public string ProductName { get; set; }
		public string? Description { get;set; }
		public int Stock { get; set; }
		public int BasePrice { get; set; }
        public decimal MarkupRate { get; set; } //tỉ lệ áp giá
        public bool IsActive { get; set; }
	}

}
