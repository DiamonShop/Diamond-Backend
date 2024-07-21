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
                                .Include(w => w.Product)
                                .ToListAsync();
            var warrantyModel = warranties.Select(wm => new WarrantyModel
            {
                WarrantyId = wm.WarrantyId,
                StartDate = wm.StartDate,
                EndDate = wm.EndDate,
                ProductName = wm.Product.ProductName,
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
                StartDate = warranty.StartDate,
                EndDate = warranty.EndDate,
                ProductName = warranty.Product.ProductName,
                Username = warranty.User.Username
            };

            return warrantyModel;
        }

        public async Task<List<WarrantyModel>> GetWarrantyByUserId(int userId)
        {
            var today = DateOnly.FromDateTime(DateTime.Now);

            var warranties = await _context.Warranties
                            .Include(w => w.User)
                            .Include(W => W.Product)
                            .Where(wm => wm.UserId == userId && wm.EndDate > today)
                            .ToListAsync();

            var warrantyModels = warranties.Select(wm => new WarrantyModel
            {
                WarrantyId = wm.WarrantyId,
                StartDate = wm.StartDate,
                EndDate = wm.EndDate,
                ProductName = wm.Product.ProductName,
                Username = wm.User.Username
            }).ToList();

            return warrantyModels;
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
                warranty.StartDate = warrantyModel.StartDate;
                warranty.EndDate = warrantyModel.EndDate;

                _context.Warranties.Update(warranty);
                result = await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                return result;
            }
            return result;
        }

        public async Task<bool> CreateWarranty(int orderId, WarrantyCreateModel warrantyCreateModel)
        {
            bool result = false;
            var order = await _context.Orders
                        .Include(o => o.OrderDetails)
                        .ThenInclude(o => o.Product)
                        .SingleOrDefaultAsync(o => o.OrderId == orderId);

            if (order == null)
            {
                return result;
            }
            //User có Warranty khi completed
            var orderDetail = order.OrderDetails.ToList();
            foreach (var item in orderDetail)
            {
                if (item.Product.ProductType.Equals("Jewelry"))
                {
                    Warranty model = new Warranty();
                    model.StartDate = DateOnly.FromDateTime(order.OrderDate);
                    model.EndDate = DateOnly.FromDateTime(order.OrderDate.AddYears(1));
                    model.ProductId = item.ProductId;
                    model.UserId = order.UserID;

                    _context.Warranties.Add(model);
                    result = await _context.SaveChangesAsync() > 0;
                }
            }

            return result;
        }
    }
}
