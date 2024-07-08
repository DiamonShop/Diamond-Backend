using Diamond.Entities.DTO;
using DiamondShop.Data;
using DiamondShop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<BillDTO> CreateBill(BillCreateDTO billCreateDTO)
        {
            var bill = new Bill
            {
                UserId = billCreateDTO.UserId,
                FullName = billCreateDTO.FullName,
                NumberPhone = billCreateDTO.NumberPhone,
                Email = billCreateDTO.Email,
                Address = billCreateDTO.Address,
                OrderNote = billCreateDTO.OrderNote,
                IsActive = billCreateDTO.IsActive
            };

            await _context.Bills.AddAsync(bill);
            await _context.SaveChangesAsync();

            return new BillDTO
            {
                BillId = bill.BillId,
                UserId = bill.UserId,
                FullName = bill.FullName,
                NumberPhone = bill.NumberPhone,
                Email = bill.Email,
                Address = bill.Address,
                OrderNote = bill.OrderNote,
                IsActive = bill.IsActive
            };
        }

        public async Task<BillDTO> GetBillById(int billId)
        {
            var bill = await _context.Bills
                .Include(b => b.User)
                .FirstOrDefaultAsync(b => b.BillId == billId);

            if (bill == null) return null;

            return new BillDTO
            {
                BillId = bill.BillId,
                UserId = bill.UserId,
                FullName = bill.FullName,
                NumberPhone = bill.NumberPhone,
                Email = bill.Email,
                Address = bill.Address,
                OrderNote = bill.OrderNote,
                IsActive = bill.IsActive
            };
        }

        public async Task<List<BillDTO>> GetAllBills()
        {
            var bills = await _context.Bills
                .Include(b => b.User)
                .ToListAsync();

            return bills.Select(b => new BillDTO
            {
                BillId = b.BillId,
                UserId = b.UserId,
                FullName = b.FullName,
                NumberPhone = b.NumberPhone,
                Email = b.Email,
                Address = b.Address,
                OrderNote = b.OrderNote,
                IsActive = b.IsActive
            }).ToList();
        }

        public async Task<bool> UpdateBillIsActive(int billId, bool isActive)
        {
            var bill = await _context.Bills.FirstOrDefaultAsync(b => b.BillId == billId);

            if (bill == null)
            {
                return false;
            }

            try
            {
                bill.IsActive = isActive;
                _context.Bills.Update(bill);
                return await _context.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
