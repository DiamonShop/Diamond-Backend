namespace DiamondShop.Model
{
	public class FeedbackModel
	{
		public int FeedbackId { get; set; }
		public int UserId { get; set; }
		public string ProductId { get; set; }
		public string? Description { get; set; }
		public bool IsDeleted { get; set; }
	}
}
