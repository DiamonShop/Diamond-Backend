using Diamond.Entities.Data;
using DiamondShop.Data;
using DiamondShop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiamondShop.Repositories
{
    public class DiamondsRepository : IDiamondsRepository
    {
        private readonly DiamondDbContext _context;

        public DiamondsRepository(DiamondDbContext context)
        {
            _context = context;
        }

        public async Task<List<Diamonds>> GetAllDiamonds()
        {
            return await _context.Diamonds
                .Include(d => d.Product)
                .ToListAsync();
        }

        public async Task<Diamonds> CreateDiamond(Diamonds diamond)
        {
            await _context.Diamonds.AddAsync(diamond);
            await _context.SaveChangesAsync();
            return diamond;
        }

        public async Task<Diamonds> UpdateDiamond(Diamonds diamond)
        {
            var existingDiamond = await _context.Diamonds.FindAsync(diamond.DiamondID);
            if (existingDiamond == null)
            {
                return null;
            }

            existingDiamond.ProductID = diamond.ProductID;
            existingDiamond.Carat = diamond.Carat;
            existingDiamond.Clarity = diamond.Clarity;
            existingDiamond.Cut = diamond.Cut;
            existingDiamond.Color = diamond.Color;
            existingDiamond.BasePrice = diamond.BasePrice;

            _context.Diamonds.Update(existingDiamond);
            await _context.SaveChangesAsync();

            return existingDiamond;
        }
    }
}
