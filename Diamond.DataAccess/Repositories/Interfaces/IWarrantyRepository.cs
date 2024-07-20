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
        public Task<WarrantyModel> GetWarrantyByUsername(string username);
        public Task<bool> CreateWarranty(WarrantyModel categoryModel);
        public Task<bool> UpdateWarranty(int warrantyId, WarrantyModel warrantyModel);
        public Task<bool> DeleteWarranty(int warrantyId);
    }
}
