namespace Diamond.Entities.Model
{
    public class WarrantyCreateModel
    {
        public int WarrantyId { get; set; }
        public int UserId { get; set; }
        public string ProductId { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}
