using Diamond.DataAccess.Repositories.Interfaces;
using Diamond.Entities.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Repositories
{
    public class DiamondPriceRepository :IDiamondPriceRepository
    {
        private readonly DiamondDbContext _context;

        public DiamondPriceRepository(DiamondDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DiamondPrice>> GetAllDiamondPrices()
        {
            return await _context.DiamondPrices.ToListAsync();
        }

        public async Task<DiamondPrice> GetDiamondPriceById(int id)
        {
            return await _context.DiamondPrices.FindAsync(id);
        }

        public async Task<bool> CreateDiamondPrice(DiamondPrice diamondPrice)
        {
            _context.DiamondPrices.Add(diamondPrice);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateDiamondPrice(DiamondPrice diamondPrice)
        {
            _context.Entry(diamondPrice).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteDiamondPrice(int id)
        {
            var diamondPrice = await _context.DiamondPrices.FindAsync(id);
            if (diamondPrice == null)
            {
                return false;
            }
            _context.DiamondPrices.Remove(diamondPrice);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<IGrouping<decimal, DiamondPrice>>> GetDiamondsGroupedByDiameter()
        {
            return await _context.DiamondPrices
                                 .GroupBy(dp => dp.DiameterMM)
                                 .ToListAsync();
        }
        public async Task<DiamondPrice> GetDiamondPrice(decimal carat, string clarity, string color, string cut)
        {
            return await _context.DiamondPrices
                .FirstOrDefaultAsync(dp => dp.Carat == carat && dp.Clarity == clarity && dp.Color == color && dp.Cut == cut);
        }

    }
}
