using Diamond.Entities.Model;
using DiamondShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Repositories.Interfaces
{
    public interface IWarrantyRepository
    {
        public Task<List<WarrantyModel>> GetAllWarranties();
        public Task<WarrantyModel> GetWarrantyById(int warrantyId);
        public Task<List<WarrantyModel>> GetWarrantyByUserId(int userId);
        public Task<bool> CreateWarranty(int orderId, WarrantyCreateModel warrantyCreateModel);
        public Task<bool> UpdateWarranty(int warrantyId, WarrantyModel warrantyModel);
    }
}
