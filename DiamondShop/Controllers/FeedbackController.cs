using DiamondShop.Data;
using FAMS.Entities.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiamondShop.Controllers
{
	[Route("api/feedbacks")]
	[ApiController]
	public class FeedbackController : ControllerBase
	{
		private readonly DiamondDbContext _context;

		[HttpGet]
		public async Task<IActionResult> GetAllFeedbacks()
		{
			var feedbacks = await _context.Feedbacks
				.Include(f => f.User)
				.Include(f=>f.Product)
				.ToListAsync();
			return Ok(feedbacks);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetFeedbackById(int id)
		{
			var feedback = await _context.Feedbacks
				.Include(f => f.User)
				.Include(f => f.Product)
				.FirstOrDefaultAsync(f => f.FeedbackId == id);

			if(feedback == null)
			{
				return NotFound();
			}

			return Ok(feedback);
		}

		[HttpPost]
		public async Task<IActionResult> CreateFeedback([FromBody]Feedback feedback)
		{
			if(ModelState.IsValid)
			{
				_context.Feedbacks.Add(feedback);
				await _context.SaveChangesAsync();
				return CreatedAtAction(nameof(GetFeedbackById), new {id=feedback.FeedbackId}, feedback);
			}
			return BadRequest();
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateFeedback(int id, [FromBody]Feedback feedback)
		{
			if(id != feedback.FeedbackId)
			{
				return BadRequest();
			}

			_context.Entry(feedback).State=EntityState.Modified;
			try
			{
				await _context.SaveChangesAsync();
			}
			catch(DbUpdateConcurrencyException)
			{
				if(!_context.Feedbacks.Any(f => f.FeedbackId == id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}
			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteFeedback(int id)
		{
			var feedback = await _context.Feedbacks.FindAsync(id);
			if(feedback == null)
			{
				return NotFound();
			}

			_context.Feedbacks.Remove(feedback);
			await _context.SaveChangesAsync();

			return NoContent();
		}
	}
}
