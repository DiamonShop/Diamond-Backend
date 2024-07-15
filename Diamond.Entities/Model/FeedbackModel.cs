namespace DiamondShop.Model
{
    public class FeedbackModel
    {
        public int UserId { get; set; }
        public string ProductId { get; set; }
        public int OrderId { get; set; }  // Add OrderId to the model
        public string Description { get; set; }
        public int? Rating { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
