using DiamondShop.Data;
namespace DiamondShop.Model
{

	public class CartItemModel
    {
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
        public Product Product { get; set; }
        public ProductDetail ProductDetail { get; set; }
        public Certificate Certificate { get; set; }
        public Warranty Warranty { get; set; }
    }
}
