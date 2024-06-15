using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DiamondShop.Repositories
{
	public class FeedbackRepository : IFeedbackRepository
	{
		public readonly DiamondDbContext _context;

		public FeedbackRepository(DiamondDbContext context)
		{
			_context = context;
		}

		public async Task<List<FeedbackModel>> GetAllFeedbacks()
		{
			var feedbackList = await _context.Feedbacks.ToListAsync();

			var feedback = feedbackList.Select(f => new FeedbackModel
			{
				FeedbackId = f.FeedbackId,
				UserId = f.UserId,
				ProductId = f.ProductID,
				Description = f.Description
			}).ToList();

			return feedback;
		}

		public async Task<FeedbackModel> GetFeedbackById(int id)
		{
			var feedback = await _context.Feedbacks.FirstOrDefaultAsync(f => f.FeedbackId.Equals(id));

			if (feedback == null)
			{
				return null!;
			}

			FeedbackModel feedbackModel = new FeedbackModel()
			{
				FeedbackId = feedback.FeedbackId,
				UserId = feedback.UserId,
				ProductId = feedback.ProductID,
				Description = feedback.Description
			};

			return feedbackModel;
		}

		public async Task<bool> CreateFeedback(FeedbackModel feedbackModel)
		{
			bool result = false;
			if (feedbackModel == null)
			{
				return result;
			}
					
			try
			{
				var feedback = new Feedback()
				{
					UserId = feedbackModel.UserId,
					ProductID = feedbackModel.ProductId,
					Description = feedbackModel.Description
				};
				await _context.Feedbacks.AddAsync(feedback);
				result = _context.SaveChanges() > 0;
			}
			catch (Exception)
			{
				return false;
			}
			return result;
		}

		public async Task<bool> DeleteFeedback(int id)
		{
			var feedback = await _context.Feedbacks.FirstOrDefaultAsync(f => f.FeedbackId == id);
			bool result = false;


			if (feedback == null)
			{
				return result;
			}

			if (feedback.FeedbackId == id)
			{
				_context.Feedbacks.Remove(feedback);
				result = await _context.SaveChangesAsync() > 0;
			}

			return result;
		}

		public async Task<bool> UpdateFeedback(int id, FeedbackModel feedbackModel)
		{
			var feedback = await _context.Feedbacks.FirstOrDefaultAsync(f => f.FeedbackId == id);
			bool result = false;

			if (feedback == null)
			{
				return result;
			}

			try
			{
				feedback.ProductID = feedbackModel.ProductId;
				feedback.Description = feedbackModel.Description;
				feedback.UserId = feedback.UserId;
				feedback.FeedbackId = feedback.FeedbackId;
				_context.Feedbacks.Update(feedback);
				result = await _context.SaveChangesAsync() > 0;
			}
			catch (Exception)
			{
				return false;
			}
			return result;
		}
	}
}
