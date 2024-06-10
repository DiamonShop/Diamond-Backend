using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiamondShop.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ShoppingCartController : ControllerBase
	{
		private readonly IShoppingCartRepository _shoppingCartRepository;

		public ShoppingCartController(IShoppingCartRepository shoppingCartRepository)
		{
			_shoppingCartRepository = shoppingCartRepository;
		}

		[HttpGet("GetAllShoppingCarts")]
		public async Task<IActionResult> GetAllShoppingCarts()
		{
			var cartList = await _shoppingCartRepository.GetAll();
			if (cartList != null)
			{
				return Ok(cartList);
			}
			return NotFound();
		}

		[HttpGet("GetShoppingCartById")]
		public async Task<IActionResult> GetShoppingCartById(int id)
		{
			var cartList = await _shoppingCartRepository.GetById(id);
			if (cartList != null)
			{
				return Ok(cartList);
			}
			return NotFound();
		}

		[HttpPost("CreateShoppingCart")]
		public async Task<IActionResult> CreateShoppingCart([FromBody] ShoppingCartViewModel cartModel)
		{
			if (ModelState.IsValid)
			{
				bool result = await _shoppingCartRepository.CreateCart(cartModel);
				if (result)
				{
					return Ok("Create Shopping Cart Successfully");
				}
			}
			return BadRequest("Failed To Create Shopping Cart");
		}

		[HttpPut("UpdateShoppingCart")]
		public async Task<IActionResult> UpdateShoppingCart(int id, [FromBody] ShoppingCart shoppingCart)
		{
			if (id != shoppingCart.CartId)
			{
				return BadRequest();
			}

			try
			{
				/*await _shoppingCartRepository.UpdateCart(shoppingCart);*/
			}
			catch (DbUpdateConcurrencyException)
			{
				if (await _shoppingCartRepository.GetById(id) == null)
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
	}
}



