using Diamond.Entities.Data;
using Diamond.Entities.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiamondShop.Repositories.Interfaces
{
    public interface IDiamondsRepository
    {
        Task<List<DiamondModel>> GetAllDiamonds();
        Task<DiamondModel> GetDiamondById(int id);
        Task<List<DiamondModel>> GetDiamondByName(string productName);
        Task<List<DiamondModel>> GetDiamondByPriceDesc();
        Task<List<DiamondModel>> GetDiamondByPriceAsc();
        Task<bool> CreateDiamond(DiamondModel diamond);
        Task<bool> UpdateDiamond(int id, DiamondModel diamond);
        Task<bool> DeleteDiamond(int id);
    }
}
