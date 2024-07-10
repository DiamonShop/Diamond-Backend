using Diamond.DataAccess.Repositories.Interfaces;
using Diamond.Entities.Model;
using DiamondShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Repositories
{
    public class JewelrySizeRepository : IJewelrySize
    {

        private readonly DiamondDbContext _context;

        public JewelrySizeRepository(DiamondDbContext context)
        {
            _context = context;
        }

        public Task<bool> CreateJewelrySize(JewelrySizeModel jewelrySizeModel)
        {
            throw new NotImplementedException();
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
    }
}
