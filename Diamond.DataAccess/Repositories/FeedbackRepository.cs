using Diamond.Entities.Model;
using DiamondShop.Data;
using DiamondShop.Model;
using Microsoft.EntityFrameworkCore;

public class FeedbackRepository : IFeedbackRepository
{
    private readonly DiamondDbContext _context;

    public FeedbackRepository(DiamondDbContext context)
    {
        _context = context;
    }

    public async Task<List<FeedbackModel>> GetAllFeedbacks()
    {
        var feedbackList = await _context.Feedbacks.ToListAsync();

        var feedbacks = feedbackList.Select(f => new FeedbackModel
        {
            UserId = f.UserId,
            ProductId = f.ProductID,
            Description = f.Description,
            DateTime = f.DateTime
        }).ToList();

        return feedbacks;
    }

    public async Task<FeedbackModel> GetFeedbackById(int id)
    {
        var feedback = await _context.Feedbacks.FirstOrDefaultAsync(f => f.FeedbackId == id);

        if (feedback == null)
        {
            return null!;
        }

        FeedbackModel feedbackModel = new FeedbackModel()
        {
            UserId = feedback.UserId,
            ProductId = feedback.ProductID,
            Description = feedback.Description,
            DateTime = feedback.DateTime
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

        // Check if the user has a completed order for the specified product
        var completedOrders = await _context.Orders
            .Include(o => o.OrderDetails)
            .Where(o => o.UserID == feedbackModel.UserId && o.Status == "Completed")
            .SelectMany(o => o.OrderDetails)
            .Where(od => od.ProductId == feedbackModel.ProductId)
            .ToListAsync();

        if (!completedOrders.Any())
        {
            return result;
        }

        try
        {
            var feedback = new Feedback()
            {
                UserId = feedbackModel.UserId,
                ProductID = feedbackModel.ProductId,
                Description = feedbackModel.Description,
                DateTime = DateTime.Now
            };
            await _context.Feedbacks.AddAsync(feedback);
            result = await _context.SaveChangesAsync() > 0;
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
            feedback.UserId = feedbackModel.UserId;
            feedback.DateTime = DateTime.Now;
            _context.Feedbacks.Update(feedback);
            result = await _context.SaveChangesAsync() > 0;
        }
        catch (Exception)
        {
            return false;
        }
        return result;
    }

    // Implementation of the new method
    public async Task<List<FeedbackWithDetailsModel>> GetFeedbackByProductId(string productId)
    {
        var feedbackList = await _context.Feedbacks
            .Where(f => f.ProductID == productId)
            .Include(f => f.User)
            .Include(f => f.Product)
            .ToListAsync();

        var feedbacks = feedbackList.Select(f => new FeedbackWithDetailsModel
        {
            UserId = f.UserId,
            ProductId = f.ProductID,
            Description = f.Description,
            DateTime = f.DateTime,
            UserName = f.User.FullName,
            ProductName = f.Product.ProductName
        }).ToList();

        return feedbacks;
    }
}


