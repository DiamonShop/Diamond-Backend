using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiamondShop.Repositories
{
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
                BillId = f.BillId,
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
                BillId = feedback.BillId,
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

            var bill = await _context.Bills.FirstOrDefaultAsync(b => b.BillId == feedbackModel.BillId && b.IsActive == false);

            if (bill == null)
            {
                return result; // Bill không tồn tại hoặc chưa hoàn thành (IsActive != 0)
            }

            try
            {
                var feedback = new Feedback()
                {
                    UserId = feedbackModel.UserId,
                    BillId = feedbackModel.BillId,
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
                feedback.BillId = feedbackModel.BillId;
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
    }
}
