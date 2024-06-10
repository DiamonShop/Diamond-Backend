using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiamondShop.Controllers
{
	[Route("api/feedbacks")]
	[ApiController]
	public class FeedbackController : ControllerBase
	{
		private readonly IFeedbackRepository _feedbackRepository;

		public FeedbackController(IFeedbackRepository feedbackRepository)
		{
			_feedbackRepository = feedbackRepository;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllFeedbacks()
		{
			return Ok(await _feedbackRepository.GetAllFeedbacks());
		}

		[HttpGet("GetFeedbackById")]
		public async Task<IActionResult> GetFeedbackById(int id)
		{
			if (await _feedbackRepository.GetFeedbackById(id) == null)
			{
				return BadRequest("Feedback is not found");
			}
			return Ok(await _feedbackRepository.GetFeedbackById(id));
		}
	
		[HttpPost("CreateFeedback")]
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
		public async Task<IActionResult> DeleteFeedback(int id)
		{
			bool result = await _feedbackRepository.DeleteFeedback(id);
			if (result)
			{
				return Ok("Delete User Successfully");
			}
			return BadRequest("Failed To Delete User");
		}
	}
}
