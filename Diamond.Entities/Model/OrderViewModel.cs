using DiamondShop.Data;
namespace DiamondShop.Model
{
	public class OrderViewModel
	{
		public int OrderId { get; set; }
        public string OrderDetailId { get; set; }
        public string UserName { get; set; } = null!;
		public int TotalPrice { get; set; }
		public string Status { get; set; } = null!;
		public DateTime OrderDate { get; set; }
        public List<CartItemModel> OrderDetails { get; set; } = new List<CartItemModel>();
    }


}
