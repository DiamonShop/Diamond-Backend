namespace DiamondShop.Model
{
    public class ProductViewModel
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
		public string? Description { get;set; }
		public int Stock { get; set; }
		public int MarkupPrice { get; set; }
        public int MarkupRate { get; set; } //tỉ lệ áp giá
        public string ProductType { get; set; }
        public bool IsActive { get; set; }
    }
}
