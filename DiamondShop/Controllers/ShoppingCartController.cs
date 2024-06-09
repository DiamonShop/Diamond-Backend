using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiamondShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IUserRepository _userRepository;
        private readonly ICartItemRepository _cartItemRepository;

        public ShoppingCartController(
            IShoppingCartRepository shoppingCartRepository,
            IUserRepository userRepository,
            ICartItemRepository cartItemRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _userRepository = userRepository;
            _cartItemRepository = cartItemRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<ShoppingCartViewModel>>> GetAllShoppingCarts()
        {
            var shoppingCarts = await _shoppingCartRepository.GetAll();
            var shoppingCartViewModels = shoppingCarts.Select(cart => new ShoppingCartViewModel
            {
                CartId = cart.CartId,
                UserId = cart.UserId,
                CartItems = cart.CartItems.Select(ci => new CartItemModel
                {
                    ProductId = ci.ProductId,
                    ProductName = ci.Product.ProductName,
                    Price = ci.Price,
                    Quantity = ci.Quantity
                }).ToList()
            }).ToList();

            return Ok(shoppingCartViewModels);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetShoppingCartById(int id)
        {
            var cart = await _shoppingCartRepository.GetById(id);
            if (cart == null)
            {
                return NotFound();
            }

            var user = await _userRepository.GetByUserID(cart.UserId);
            if (user == null)
            {
                return NotFound($"User with ID {cart.UserId} not found.");
            }

            var cartItems = cart.CartItems.ToList();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                CartId = cart.CartId,
                UserId = cart.UserId,
                CartItems = cartItems.Select(ci => new CartItemModel
                {
                    ProductId = ci.ProductId,
                    ProductName = ci.Product.ProductName,
                    Price = ci.Price,
                    Quantity = ci.Quantity
                }).ToList()
            };

            return Ok(shoppingCartViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateShoppingCart([FromBody] ShoppingCart shoppingCart)
        {
            if (ModelState.IsValid)
            {
                await _shoppingCartRepository.Insert(shoppingCart);
                return CreatedAtAction(nameof(GetShoppingCartById), new { id = shoppingCart.CartId }, shoppingCart);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateShoppingCart(int id, [FromBody] ShoppingCart shoppingCart)
        {
            if (id != shoppingCart.CartId)
            {
                return BadRequest();
            }

            try
            {
                await _shoppingCartRepository.Update(shoppingCart);
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



