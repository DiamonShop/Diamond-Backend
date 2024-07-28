using Diamond.Entities.Data;
using Diamond.Entities.DTO;
using Diamond.Entities.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiamondShop.Repositories.Interfaces
{
    public interface IDiamondsRepository
    {
        Task<List<DiamondModel>> GetAllDiamonds();
        Task<DiamondModel> GetDiamondById(int id);
        Task<DiamondModel> GetDiamondByProductId(string productId); 
        Task<List<DiamondModel>> GetDiamondByName(string productName);
        Task<List<DiamondModel>> GetDiamondByPriceDesc();
        Task<List<DiamondModel>> GetDiamondByPriceAsc();
        Task<bool> CreateDiamond(DiamondModel diamondModel);
        Task<bool> UpdateDiamond(DiamondModel diamond);
        Task<bool> DeleteDiamond(int id);
        Task<int> GetDiamondCountByDiameter(decimal diameterMM);
        IEnumerable<MainDiamondDto> GetAllMainDiamonds();
        IEnumerable<SideDiamondDto> GetAllSideDiamonds();
        Task<bool> UpdateDiamondQuantity(int userId);
        Task<List<DiamondModel>> GetDiamondsBySize(decimal size);

        Task<bool> CreateDiamondWithPrice(DiamondModel diamondModel);
        Task<IEnumerable<Diamonds>> GetDiamondProductsByProperties(decimal carat, string clarity, string color, string cut);

        Task<bool> UpdateDiamonds(IEnumerable<Diamonds> diamonds);
    }
}
