using Diamond.DataAccess.Repositories.Interfaces;
using Diamond.Entities.Model;
using DiamondShop.Data;
using DiamondShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Repositories
{
    public class WarrantyRepository : IWarrantyRepository
    {
        private readonly DiamondDbContext _context;

        public WarrantyRepository(DiamondDbContext context)
        {
            _context = context;
        }

        public async Task<List<WarrantyModel>> GetAllWarranties()
        {
            var warranties = await _context.Warranties
                                .Include(w => w.User)
                                .ToListAsync();
            var warrantyModel = warranties.Select(wm => new WarrantyModel
            {
                WarrantyId = wm.WarrantyId,
                BuyDate = wm.BuyDate,
                ProductId = wm.ProductId,
                WarrantyPeriod = wm.WarrantyPeriod,
                IsAvailable = wm.IsAvailable,
                Username = wm.User.Username
            }).ToList();
            return warrantyModel;
        }

        public async Task<WarrantyModel> GetWarrantyById(int warrantyId)
        {
            var warranty = await _context.Warranties
                .Include(w => w.User)
                .SingleOrDefaultAsync(wm => wm.WarrantyId == warrantyId);
            if (warranty == null) { return null; }
            var warrantyModel = new WarrantyModel()
            {
                WarrantyId = warranty.WarrantyId,
                BuyDate = warranty.BuyDate,
                ProductId = warranty.ProductId,
                WarrantyPeriod = warranty.WarrantyPeriod,
                IsAvailable = warranty.IsAvailable,
                Username = warranty.User.Username
            };

            return warrantyModel;
        }

        public async Task<List<WarrantyModel>> GetWarrantyByUserId(int userId)
        {
            var warranties = await _context.Warranties
                            .Include(w => w.User)
                            .Where(wm => wm.UserId == userId)
                            .ToListAsync();

            if (warranties == null) { return null; }

            var warrantyModel = warranties.Select(wm => new WarrantyModel
            {
                WarrantyId = wm.WarrantyId,
                BuyDate = wm.BuyDate,
                ProductId = wm.ProductId,
                IsAvailable = wm.IsAvailable,
                WarrantyPeriod = wm.WarrantyPeriod,
                Username = wm.User.Username
            }).ToList();

            return warrantyModel;
        }

        public async Task<bool> UpdateWarranty(int warrantyId, WarrantyModel warrantyModel)
        {
            var warranty = await _context.Warranties.FirstOrDefaultAsync(c => c.WarrantyId == warrantyId);
            bool result = false;

            if (warranty == null) // If category is null
            {
                return result;
            }

            try
            {
                warranty.BuyDate = warrantyModel.BuyDate;
                warranty.WarrantyPeriod = warrantyModel.WarrantyPeriod;
                warranty.IsAvailable = warrantyModel.IsAvailable;
                                
                _context.Warranties.Update(warranty);
                result = await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                return result;
            }
            return result;
        }

        public async Task<bool> CreateWarranty(WarrantyCreateModel warrantyCreateModel)
        {
            bool result = false;
            if (warrantyCreateModel != null)
            {
                var warranty = new Warranty()
                {
                    BuyDate = warrantyCreateModel.BuyDate,
                    ProductId = warrantyCreateModel.ProductId,
                    WarrantyPeriod = warrantyCreateModel.WarrantyPeriod,
                    IsAvailable = warrantyCreateModel.IsAvailable,
                    UserId = warrantyCreateModel.UserId
                };

                _context.Warranties.Add(warranty);
                await _context.SaveChangesAsync();
                return result;
            }
            return result;
        }

        public async Task<bool> DeleteWarranty(int warrantyId)
        {
            bool result = false;
            var warranty = await _context.Warranties.SingleOrDefaultAsync(w => w.WarrantyId == warrantyId);

            if (warranty != null) { return result; }
            try
            {
                warranty.IsAvailable = false;
                _context.Warranties.Update(warranty);
                result = await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                return result;
            }

            return result;
        }


    }
}
