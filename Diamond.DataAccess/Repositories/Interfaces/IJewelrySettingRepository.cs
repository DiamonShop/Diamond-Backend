using Diamond.Entities.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiamondShop.Repositories.Interfaces
{
    public interface IJewelrySettingRepository
    {
        Task<IEnumerable<JewelrySettings>> GetAllJewelrySettings();
        Task<JewelrySettings> GetJewelrySettingById(int id);
        Task<IEnumerable<JewelrySettings>> GetJewelrySettingsByName(string name);
        Task<bool> CreateJewelrySetting(JewelrySettings jewelrySetting);
        Task<bool> UpdateJewelrySetting(int id, JewelrySettings jewelrySetting);
        Task<bool> DeleteJewelrySetting(int id);
    }
}
