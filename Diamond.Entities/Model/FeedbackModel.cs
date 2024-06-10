namespace DiamondShop.Model
{
	public class FeedbackModel
	{
		public int FeedbackId { get; set; }
		public int UserId { get; set; }
		public int ProductId { get; set; }
		public string? Description { get; set; }
		public bool IsDeleted { get; set; }
	}
}
