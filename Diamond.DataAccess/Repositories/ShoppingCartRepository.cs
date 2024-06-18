/*using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiamondShop.Repositories
{
	public class ShoppingCartRepository : IShoppingCartRepository
	{
		private readonly DiamondDbContext _context;

		public ShoppingCartRepository(DiamondDbContext context)
		{
			_context = context;
		}

		public async Task<List<ShoppingCartViewModel>> GetAll()
		{
			var shoppingCarts = await _context.ShoppingCarts
												.Include(sc => sc.CartItems!)
												.ThenInclude(ci => ci.Product) // Ensure Product is included
												.ToListAsync();

			var shoppingCartViewModels = shoppingCarts.Select(cart => new ShoppingCartViewModel
			{
				CartId = cart.CartId,
				UserId = cart.UserId,
				CartItems = cart.CartItems!.Select(ci => new CartItemModel
				{
					ProductId = ci.ProductId,
					ProductName = ci.Product.ProductName,
					Price = ci.UnitPrice,
					Quantity = ci.Quantity
				}).ToList()
			}).ToList();

			return shoppingCartViewModels;
		}

		public async Task<ShoppingCartViewModel> GetById(int id)
		{
			var shoppingCart = await _context.ShoppingCarts
											  .Include(sc => sc.CartItems!)
											  .ThenInclude(ci => ci.Product) // Ensure Product is included
											  .FirstOrDefaultAsync(sc => sc.CartId == id);
			if (shoppingCart == null)
			{
				return null;
			}

			var shoppingCartViewModel = new ShoppingCartViewModel
			{
				CartId = shoppingCart.CartId,
				UserId = shoppingCart.UserId,
				CartItems = shoppingCart.CartItems!.Select(ci => new CartItemModel
				{
					ProductId = ci.ProductId,
					ProductName = ci.Product.ProductName,
					Price = ci.UnitPrice,
					Quantity = ci.Quantity
				}).ToList()
			};

			return shoppingCartViewModel;
		}

		public async Task<bool> CreateCart(ShoppingCartViewModel cartModel)
		{
			bool result = false;
			if (cartModel == null) { return result; }
			try
			{
				var cart = new ShoppingCart()
				{
					UserId = cartModel.UserId,
				};
				await _context.ShoppingCarts.AddAsync(cart);
				result = _context.SaveChanges() > 0;
			}
			catch (Exception)
			{
				return false;
			}

			return result;
		}

		public async Task<bool> UpdateCart(ShoppingCartViewModel cartModel)
		{
			*//*_context.ShoppingCarts.Update(cartModel);*//*
			return await _context.SaveChangesAsync() > 0;
		}

		public async Task<bool> DeleteCart(int id)
		{
			var entity = await _context.ShoppingCarts.Include(sc => sc.CartItems)
													 .FirstOrDefaultAsync(sc => sc.CartId == id);
			if (entity == null)
				return false;

			_context.ShoppingCarts.Remove(entity);
			return await _context.SaveChangesAsync() > 0;
		}
	}
}
*/