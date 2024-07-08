namespace DiamondShop.Model
{
    public class FeedbackModel
    {
        public int UserId { get; set; }
        public int BillId { get; set; }
        public string ProductId { get; set; }
        public string Description { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
