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
            var warranties = await _context.Warranties.ToListAsync();
            var warrantyModel = warranties.Select(wm => new WarrantyModel
            {
                WarrantyId = wm.WarrantyId,
                BuyDate = wm.BuyDate,
                ProductId = wm.ProductId,
                Username = wm.Username,
                WarrantyPeriod = wm.WarrantyPeriod,
            }).ToList();
            return warrantyModel;
        }

        public async Task<WarrantyModel> GetWarrantyById(int warrantyId)
        {
            var warranty = await _context.Warranties.SingleOrDefaultAsync(wm => wm.WarrantyId == warrantyId);
            if (warranty == null) { return null; }
            var warrantyModel = new WarrantyModel()
            {
                WarrantyId = warranty.WarrantyId,
                BuyDate = warranty.BuyDate,
                ProductId = warranty.ProductId,
                Username = warranty.Username,
                WarrantyPeriod = warranty.WarrantyPeriod
            };

            return warrantyModel;
        }

        public async Task<WarrantyModel> GetWarrantyByUsername(string username)
        {
            var warranty = await _context.Warranties.SingleOrDefaultAsync(wm => wm.Username.Equals(username));
            if (warranty == null) { return null; }

            var warrantyModel = new WarrantyModel()
            {
                WarrantyId = warranty.WarrantyId,
                BuyDate = warranty.BuyDate,
                ProductId = warranty.ProductId,
                Username = warranty.Username,
                WarrantyPeriod = warranty.WarrantyPeriod
            };

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
                warranty.ProductId = warrantyModel.ProductId;
                warranty.BuyDate = warrantyModel.BuyDate;
                warranty.WarrantyPeriod = warrantyModel.WarrantyPeriod;
                warranty.Username = warranty.Username;

                _context.Warranties.Update(warranty);
                result = await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                return result;
            }
            return result;
        }

        public async Task<bool> CreateWarranty(WarrantyModel warrantyModel)
        {
            bool result = false;
            if (warrantyModel != null)
            {
                var warranty = new Warranty()
                {
                    BuyDate = warrantyModel.BuyDate,
                    ProductId = warrantyModel.ProductId,
                    Username = warrantyModel.Username,
                    WarrantyPeriod = warrantyModel.WarrantyPeriod
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
