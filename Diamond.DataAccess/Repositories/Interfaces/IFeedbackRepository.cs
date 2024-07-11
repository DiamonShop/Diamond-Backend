using DiamondShop.Model;

public interface IFeedbackRepository
{
    Task<List<FeedbackModel>> GetAllFeedbacks();
    Task<FeedbackModel> GetFeedbackById(int id);
    Task<bool> CreateFeedback(FeedbackModel feedbackModel);
    Task<bool> DeleteFeedback(int id);
    Task<bool> UpdateFeedback(int id, FeedbackModel feedbackModel);
    Task<List<FeedbackModel>> GetFeedbackByProductId(string productId); 
}
