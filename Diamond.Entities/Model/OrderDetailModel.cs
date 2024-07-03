namespace Diamond.Entities.Model
{
    public class OrderDetailModel
    {
        public string OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
