using DiamondShop.Data;
using FAMS.Entities.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiamondShop.Controllers
{
	[Route("api/shoppingCarts")]
	[ApiController]
	public class ShoppingCartController : ControllerBase
	{
		private readonly DiamondDbContext _context;

		public ShoppingCartController(DiamondDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllShoppingCarts()
		{
			var shoppingcarts = await _context.ShoppingCarts
				.Include(s => s.User)
				.ToListAsync();
			return Ok(shoppingcarts);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetShoppingCartById(int id)
		{
			var shoppingcart = await _context.ShoppingCarts
				.Include(s => s.User)
				.FirstOrDefaultAsync(s => s.CartId == id);

			if (shoppingcart == null)
			{
				return NotFound();
			}
			return Ok(shoppingcart);
		}

		[HttpPost]
		public async Task<IActionResult> CreateShoppingCart([FromBody] ShoppingCart shoppingcart)
		{
			if (ModelState.IsValid)
			{
				_context.ShoppingCarts.Add(shoppingcart);
				await _context.SaveChangesAsync();
				return CreatedAtAction(nameof(GetShoppingCartById), new { id = shoppingcart.CartId }, shoppingcart);
			}
			return BadRequest();
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateShoppingCart(int id, [FromBody] ShoppingCart shoppingcart)
		{
			if (id != shoppingcart.CartId)
			{
				return BadRequest();
			}

			_context.Entry(shoppingcart).State = EntityState.Modified;
			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!_context.ShoppingCarts.Any(s => s.CartId == id))
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
		public async Task<IActionResult> DeleteShoppingCart(int id)
		{
			var shoppingcart = await _context.ShoppingCarts.FindAsync(id);
			if (shoppingcart == null)
			{
				return NotFound();
			}

			_context.ShoppingCarts.Remove(shoppingcart);
			await _context.SaveChangesAsync();

			return NoContent();
		}
	}
}
