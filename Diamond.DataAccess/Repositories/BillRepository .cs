using DiamondShop.Data;
using DiamondShop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiamondShop.Repositories
{
    public class BillRepository : IBillRepository
    {
        private readonly DiamondDbContext _context;

        public BillRepository(DiamondDbContext context)
        {
            _context = context;
        }

        public async Task<Bill> CreateBill(Bill bill)
        {
            await _context.Bills.AddAsync(bill);
            await _context.SaveChangesAsync();
            return bill;
        }

        public async Task<Bill> GetBillById(int billId)
        {
            return await _context.Bills
                .Include(b => b.User)
                .FirstOrDefaultAsync(b => b.BillId == billId);
        }

        public async Task<List<Bill>> GetAllBills()
        {
            return await _context.Bills
                .Include(b => b.User)
                .ToListAsync();
        }
    }
}
