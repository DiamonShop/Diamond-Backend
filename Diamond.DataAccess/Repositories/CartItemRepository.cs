using DiamondShop.Data;
using DiamondShop.Repositories.Interfaces;
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

        public async Task<List<OrderDetail>> GetAll()
        {
            return await _context.OrderDetails.ToListAsync();
        }

        public async Task<OrderDetail> GetById(int id)
        {
            return await _context.OrderDetails.FindAsync(id);
        }

        public async Task<bool> Insert(OrderDetail entity)
        {
            await _context.OrderDetails.AddAsync(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(OrderDetail entity)
        {
            _context.OrderDetails.Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await GetById(id);
            if (entity == null)
                return false;

            _context.OrderDetails.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
