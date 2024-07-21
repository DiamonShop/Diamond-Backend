namespace Diamond.Entities.Model
{
    public class WarrantyModel
    {
        public int WarrantyId { get; set; }
        public string ProductName { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string Username { get; set; }

    }
}
