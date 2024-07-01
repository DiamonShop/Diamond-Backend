using DiamondShop.Data;
namespace DiamondShop.Model
{
	public class CartItemModel
    {
        public string OrderDetailId { get; set; }
        public string ProductId { get; set; }
		public string ProductName { get; set; }
		public int UnitPrice { get; set; }
		public int Quantity { get; set; }
        public Product? Product { get; set; }
    }
}
