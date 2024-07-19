using Diamond.Entities.Model;
using DiamondShop.Data;
using DiamondShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            DateTime = f.DateTime,
            Rating = f.Rating
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
            DateTime = feedback.DateTime,
            Rating = feedback.Rating
        };

        return feedbackModel;
    }

    public async Task<bool> CreateFeedback(FeedbackModel feedbackModel)
    {
        if (feedbackModel == null)
        {
            return false;
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
            return false;
        }

        // Check if the user has already commented on the product in any completed order
        var existingFeedback = await _context.Feedbacks
            .Where(f => f.UserId == feedbackModel.UserId && f.ProductID == feedbackModel.ProductId && f.OrderId == feedbackModel.OrderId)
            .FirstOrDefaultAsync();

        if (existingFeedback != null)
        {
            // If feedback already exists, do not allow another feedback for the same order
            return false;
        }

        // Create a new feedback
        var feedback = new Feedback()
        {
            UserId = feedbackModel.UserId,
            ProductID = feedbackModel.ProductId,
            OrderId = feedbackModel.OrderId,
            Description = feedbackModel.Description,
            DateTime = DateTime.Now,
            Rating = feedbackModel.Rating
        };

        await _context.Feedbacks.AddAsync(feedback);
        return await _context.SaveChangesAsync() > 0;
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
            feedback.Rating = feedbackModel.Rating;
            _context.Feedbacks.Update(feedback);
            result = await _context.SaveChangesAsync() > 0;
        }
        catch (Exception)
        {
            return false;
        }
        return result;
    }

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
            Rating = f.Rating,
            UserName = f.User.FullName,
            ProductName = f.Product.ProductName
        }).ToList();

        return feedbacks;
    }
    public async Task<bool> CreateFeedbackByUserIdOrderId(FeedbackModel feedbackModel)
    {
        if (feedbackModel == null)
        {
            return false;
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
            return false;
        }

        // Check if the user has already commented on the product in the specific completed order
        var existingFeedback = await _context.Feedbacks
            .Where(f => f.UserId == feedbackModel.UserId && f.ProductID == feedbackModel.ProductId && f.OrderId == feedbackModel.OrderId)
            .FirstOrDefaultAsync();

        if (existingFeedback != null)
        {
            // If feedback already exists, do not allow another feedback for the same order
            return false;
        }

        // Create a new feedback
        var feedback = new Feedback()
        {
            UserId = feedbackModel.UserId,
            ProductID = feedbackModel.ProductId,
            OrderId = feedbackModel.OrderId,
            Description = feedbackModel.Description,
            DateTime = DateTime.Now,
            Rating = feedbackModel.Rating
        };

        await _context.Feedbacks.AddAsync(feedback);
        return await _context.SaveChangesAsync() > 0;
    }
}
