using DiamondShop.Data;
using DiamondShop.Repositories.Interfaces;
using FAMS.Entities.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiamondShop.Repositories
{
    public class CartItemRepository : ICartItemRepository
    {
        private readonly DiamondDbContext _context;

        public CartItemRepository(DiamondDbContext context)
        {
            _context = context;
        }

        public async Task<List<CartItem>> GetAll()
        {
            return await _context.CartItems.ToListAsync();
        }

        public async Task<CartItem> GetById(int id)
        {
            return await _context.CartItems.FindAsync(id);
        }

        public async Task<bool> Insert(CartItem entity)
        {
            await _context.CartItems.AddAsync(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(CartItem entity)
        {
            _context.CartItems.Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await GetById(id);
            if (entity == null)
                return false;

            _context.CartItems.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
