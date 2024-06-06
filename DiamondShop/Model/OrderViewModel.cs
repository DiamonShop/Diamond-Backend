using DiamondShop.Data;
namespace DiamondShop.Model
{
	public class OrderViewModel
	{
		public int OrderId { get; set; }
		public string UserName { get; set; } = null!;
		public decimal TotalPrice { get; set; }
		public string Status { get; set; } = null!;
		public DateTime OrderDate { get; set; }
		public List<OrderDetailViewModel> OrderDetails { get; set; } = new List<OrderDetailViewModel>();
	}

	public class OrderDetailViewModel
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; } = null!;
		public decimal Price { get; set; }
		public int Quantity { get; set; }
	}
}
