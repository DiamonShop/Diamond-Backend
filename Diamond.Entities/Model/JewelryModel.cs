namespace Diamond.Entities.Model
{
    public class JewelryModel
    {
        public int JewelryID { get; set; }
        public int JewelrySettingID { get; set; }
        public string ProductID { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }
        public int Size { get; set; }
        public int BasePrice { get; set; }
        public bool IsActive { get; set; }
    }
}
