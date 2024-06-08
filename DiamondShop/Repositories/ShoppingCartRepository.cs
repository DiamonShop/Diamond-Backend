using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using FAMS.Entities.Data;
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
                                                .Include(sc => sc.CartItems)
                                                .ToListAsync();

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

            return shoppingCartViewModels;
        }


        public async Task<bool> Insert(ShoppingCart entity)
        {
            // Chuyển đổi từ ShoppingCart sang ShoppingCartViewModel
            var viewModel = new ShoppingCartViewModel
            {
                CartId = entity.CartId,
                UserId = entity.UserId,
                CartItems = entity.CartItems.Select(ci => new CartItemModel
                {
                    ProductId = ci.ProductId,
                    ProductName = ci.Product.ProductName,
                    Price = ci.Price,
                    Quantity = ci.Quantity
                }).ToList()
            };

            await _context.ShoppingCarts.AddAsync(viewModel); // Thêm viewModel thay vì entity
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(ShoppingCart entity)
        {
            // Chuyển đổi từ ShoppingCart sang ShoppingCartViewModel
            var viewModel = new ShoppingCartViewModel
            {
                CartId = entity.CartId,
                UserId = entity.UserId,
                CartItems = entity.CartItems.Select(ci => new CartItemModel
                {
                    ProductId = ci.ProductId,
                    ProductName = ci.Product.ProductName,
                    Price = ci.Price,
                    Quantity = ci.Quantity
                }).ToList()
            };

            _context.ShoppingCarts.Update(viewModel); // Cập nhật viewModel thay vì entity
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await GetById(id);
            if (entity == null)
                return false;

            _context.ShoppingCarts.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<ShoppingCartViewModel> GetById(int id)
        {
            var shoppingCart = await _context.ShoppingCarts
                                              .Include(sc => sc.CartItems)
                                              .FirstOrDefaultAsync(sc => sc.CartId == id);

            if (shoppingCart == null)
            {
                return null;
            }

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                CartId = shoppingCart.CartId,
                UserId = shoppingCart.UserId,
                CartItems = shoppingCart.CartItems.Select(ci => new CartItemModel
                {
                    ProductId = ci.ProductId,
                    ProductName = ci.Product.ProductName,
                    Price = ci.Price,
                    Quantity = ci.Quantity
                }).ToList()
            };

            return shoppingCartViewModel;
        }


    }
}
