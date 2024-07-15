namespace DiamondShop.Model
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public string OrderDetailId { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Address { get; set; }
        public string NumberPhone { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = null!;
        public DateTime OrderDate { get; set; }
        public string OrderNote { get; set; } = null!;
        public string CancelReason { get; set; } = null!;

        public List<CartItemModel> OrderDetails { get; set; } = new List<CartItemModel>();
    }
}
