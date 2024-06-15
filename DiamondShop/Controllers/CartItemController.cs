using DiamondShop.Data;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DiamondShop.Controllers
{
    public class CartItemController : Controller
    {
        private readonly ICartItemRepository _cartItemRepository;

        public CartItemController(ICartItemRepository cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }

        [HttpGet("GetAllCartItem")]
		[Authorize(Roles = "Manager,Staff,Member")]
		public async Task<ActionResult<List<CartItem>>> GetAll()
        {
            var items = await _cartItemRepository.GetAll();
            return Ok(items);
        }

        [HttpGet("GetCartItemById")]
		[Authorize(Roles = "Manager,Staff,Member")]
		public async Task<ActionResult<CartItem>> GetById(int id)
        {
            var item = await _cartItemRepository.GetById(id);
            if (item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost]
		[Authorize(Roles = "Member")]
		public async Task<ActionResult> Insert([FromBody] CartItem cartItem)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var success = await _cartItemRepository.Insert(cartItem);
            if (!success)
                return StatusCode(500, "A problem happened while handling your request.");

            return CreatedAtAction(nameof(GetById), new { id = cartItem.CartItemId }, cartItem);
        }

        [HttpPut("UpdateCartItem")]
		[Authorize(Roles = "Member")]
		public async Task<ActionResult> Update(int id, [FromBody] CartItem cartItem)
        {
            if (id != cartItem.CartItemId)
                return BadRequest("CartItem ID mismatch");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingItem = await _cartItemRepository.GetById(id);
            if (existingItem == null)
                return NotFound();

            var success = await _cartItemRepository.Update(cartItem);
            if (!success)
                return StatusCode(500, "A problem happened while handling your request.");

            return NoContent();
        }

        [HttpDelete("DeleteCartItem")]
		[Authorize(Roles = "Member")]
		public async Task<ActionResult> Delete(int id)
        {
            var existingItem = await _cartItemRepository.GetById(id);
            if (existingItem == null)
                return NotFound();

            var success = await _cartItemRepository.Delete(id);
            if (!success)
                return StatusCode(500, "A problem happened while handling your request.");

            return NoContent();
        }
    }
}
