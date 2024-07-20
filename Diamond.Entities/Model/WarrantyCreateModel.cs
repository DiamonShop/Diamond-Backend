namespace Diamond.Entities.Model
{
    public class WarrantyCreateModel
    {
        public int WarrantyId { get; set; }
        public int UserId { get; set; }
        public string ProductId { get; set; }
        public DateOnly BuyDate { get; set; }
        public int WarrantyPeriod { get; set; }
        public bool IsAvailable { get; set; }
    }
}
