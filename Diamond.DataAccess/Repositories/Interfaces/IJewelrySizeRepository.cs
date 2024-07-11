using Diamond.Entities.Model;
using DiamondShop.Model;

namespace Diamond.DataAccess.Repositories.Interfaces
{
    public interface IJewelrySizeRepository
    {
        public Task<List<JewelrySizeModel>> GetAllJewelrySize();
        public Task<JewelrySizeModel> GetJewelrySizeById(int id);
        public Task<bool> CreateJewelrySize(JewelrySizeModel jewelrySizeModel);
        public Task<bool> UpdateJewelrySize(int id, JewelrySizeModel jewelrySizeModel);
    }
}
