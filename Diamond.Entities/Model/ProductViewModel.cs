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
        public int MarkupPrice { get; set; }
        public int MarkupRate { get; set; }
        public bool IsActive { get; set; }
    }
}
