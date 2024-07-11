using Microsoft.AspNetCore.Mvc;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace DiamondShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        [HttpGet("GetAllFeedbacks")]
        public async Task<IActionResult> GetAllFeedbacks()
        {
            return Ok(await _feedbackRepository.GetAllFeedbacks());
        }

        [HttpPost("CreateFeedback")]
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> CreateFeedback(FeedbackModel feedbackModel)
        {
            bool result = await _feedbackRepository.CreateFeedback(feedbackModel);
            if (result)
            {
                return Ok("Create Feedback Successfully");
            }
            return BadRequest("Failed To Create Feedback");
        }

        [HttpPut("UpdateFeedback")]
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> UpdateFeedback(int id, [FromBody] FeedbackModel feedbackModel)
        {
            bool result = await _feedbackRepository.UpdateFeedback(id, feedbackModel);
            if (result)
            {
                return Ok("Update User Successfully");
            }
            return BadRequest("Failed To Create User");
        }

        [HttpDelete("DeleteFeedback")]
        [Authorize(Roles = "Member,Admin")]
        public async Task<IActionResult> DeleteFeedback(int id)
        {
            bool result = await _feedbackRepository.DeleteFeedback(id);
            if (result)
            {
                return Ok("Delete User Successfully");
            }
            return BadRequest("Failed To Delete User");
        }
        [HttpGet("GetFeedbackByProductId")]
        public async Task<IActionResult> GetFeedbackByProductId(string productId)
        {
            var feedbacks = await _feedbackRepository.GetFeedbackByProductId(productId);
            if (feedbacks == null || !feedbacks.Any())
            {
                return NotFound("No feedback found for this product.");
            }
            return Ok(feedbacks);
        }

    }
}
