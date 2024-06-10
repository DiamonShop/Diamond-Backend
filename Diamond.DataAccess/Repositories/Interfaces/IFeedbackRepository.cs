using DiamondShop.Data;
using DiamondShop.Model;


namespace DiamondShop.Repositories.Interfaces
{
	public interface IFeedbackRepository
	{
		public Task<List<FeedbackModel>> GetAllFeedbacks();
		public Task<FeedbackModel> GetFeedbackById(int id);
		public Task<bool> CreateFeedback(FeedbackModel feedbackModel);
		public Task<bool> UpdateFeedback(int id, FeedbackModel feedbackModel);
		public Task<bool> DeleteFeedback(int id);

	}
}
