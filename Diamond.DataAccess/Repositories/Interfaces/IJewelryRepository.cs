using Diamond.Entities.Model;
using DiamondShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Repositories.Interfaces
{
    public interface IJewelryRepository
    {
        Task<List<JewelryModel>> GetAllJewelry();
        Task<JewelryModel> GetJewelryById(int id);
        Task<JewelryModel> GetJewelryByProductId(string id);
        Task<List<JewelryModel>> GetJewelryByCategoryName(string categoryName);
        Task<List<JewelryModel>> GetJewelryByName(string productName);
        Task<List<JewelryModel>> GetJewelryByPriceDesc();
        Task<List<JewelryModel>> GetJewelryByPriceAsc();
        Task<int> GetJewelryCountByCategoryId(int categoryId);
        Task<bool> CreateJewelry(JewelryCreateModel productModel);
        Task<bool> UpdateJewelry(JewelryModel productModel);
        Task<bool> DeleteJewelry(int id);

    }
}
