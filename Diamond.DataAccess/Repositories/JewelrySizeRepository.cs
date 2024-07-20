using Diamond.DataAccess.Repositories.Interfaces;
using Diamond.Entities.Data;
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
    public class JewelrySizeRepository : IJewelrySizeRepository
    {

        private readonly DiamondDbContext _context;

        public JewelrySizeRepository(DiamondDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateJewelrySize(JewelrySizeModel jewelrySizeModel)
        {
            if (jewelrySizeModel != null)
            {
                var jewelrySize = new JewelrySize()
                {
                    JewelryID = jewelrySizeModel.JewelryID,
                    Quantity = jewelrySizeModel.Quantity,
                    Size = jewelrySizeModel.Size,
                    JewelrySizeID = jewelrySizeModel.JewelrySizeID,
                };

                _context.JewelrySizes.Add(jewelrySize);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<JewelrySizeModel>> GetAllJewelrySize()
        {
            var jewelrySize = await _context.JewelrySizes.ToListAsync();

            if (jewelrySize == null)
            {
                return null;
            }

            // Chuyển đổi danh sách người dùng sang UserViewModel để trả về
            var jewelrySizeModel = jewelrySize.Select(j => new JewelrySizeModel
            {
                JewelryID = j.JewelryID,
                JewelrySizeID = j.JewelrySizeID,
                Quantity = j.Quantity,
                Size = j.Size
            }).ToList();

            return jewelrySizeModel;
        }

        public async Task<JewelrySizeModel> GetJewelrySizeById(int id)
        {
            var jewelry = await _context.JewelrySizes.FirstOrDefaultAsync(j => j.JewelryID == id);

            if (jewelry == null)
            {
                return null;
            }

            JewelrySizeModel jewelryModel = new JewelrySizeModel()
            {
                JewelryID = jewelry.JewelryID,
                JewelrySizeID = jewelry.JewelrySizeID,
                Size = jewelry.Size,
                Quantity = jewelry.Quantity
            };

            return jewelryModel;

        }

        public async Task<bool> UpdateJewelrySize(int id, JewelrySizeModel jewelrySizeModel)
        {
            var jewelry = await _context.JewelrySizes.FirstOrDefaultAsync(j => j.JewelrySizeID == id);
            bool result = false;
            if (jewelry == null) // If category is null
            {
                return result;
            }

            try
            {
                jewelry.Size = jewelrySizeModel.Size;
                jewelry.JewelrySizeID = jewelry.JewelrySizeID;
                jewelry.Quantity = jewelrySizeModel.Quantity;
                jewelry.JewelryID = jewelry.JewelryID;

                _context.JewelrySizes.Update(jewelry);
                // Save the changes to the database
                result = await _context.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            return result; // Update succeeded
        }

		public async Task<bool> UpdateJewelrySizeQuantity(int userId)
		{
			var latestOrder = await _context.Orders
				.Include(o => o.User) // Ensure User is included
				.Include(o => o.OrderDetails)
				.ThenInclude(od => od.Product) // Include Product in OrderDetails
				.ThenInclude(p => p.Jewelry) // Include Jewelry in Product
				.Where(o => o.UserID == userId)
				.OrderByDescending(o => o.OrderDate)
				.FirstOrDefaultAsync(); // Get the latest order

			if (latestOrder == null) // If no order found
			{
				return false;
			}

			bool result = false;

			try
			{
				foreach (var orderDetail in latestOrder.OrderDetails)
				{
					var jewelry = orderDetail.Product.Jewelry; // Access related Jewelry object

					if (jewelry != null)
					{
						var jewelrySize = await _context.JewelrySizes
							.FirstOrDefaultAsync(js => js.JewelryID == jewelry.JewelryID);

						if (jewelrySize != null)
						{
							jewelrySize.Quantity -= orderDetail.Quantity;

							_context.JewelrySizes.Update(jewelrySize);
						}
					}
				}

				// Save the changes to the database
				result = await _context.SaveChangesAsync() > 0;
			}
			catch (Exception ex)
			{
				// Log the exception (not shown here)
				return false;
			}

			return result; // Update succeeded
		}
	}
}
