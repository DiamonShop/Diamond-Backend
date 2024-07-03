namespace DiamondShop.Model
{
    public class ProductViewModel
    {
        public string ProductId { get; set; }
        public int CategoryId { get; set; }
        public int JewelrySettingID { get; set; }
        public string ProductName { get; set; }
        public string? Description { get; set; }
        public int Stock { get; set; }
        public decimal MarkupPrice { get; set; }
        public decimal MarkupRate { get; set; }
        public bool IsActive { get; set; }
    }
}
