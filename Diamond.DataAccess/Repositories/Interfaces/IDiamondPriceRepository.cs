using Diamond.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diamond.Entities.Data;

namespace DiamondShop.Repositories.Interfaces
{
    public interface IDiamondPriceRepository
    {
        Task<IEnumerable<DiamondPrice>> GetAllDiamondPrices();
        Task<DiamondPrice> GetDiamondPriceById(int id);
        Task<bool> CreateDiamondPrice(DiamondPrice diamondPrice);
        Task<bool> UpdateDiamondPrice(DiamondPrice diamondPrice);
        Task<bool> DeleteDiamondPrice(int id);
        Task<IEnumerable<IGrouping<decimal, DiamondPrice>>> GetDiamondsGroupedByDiameter();
        Task<DiamondPrice> GetDiamondPrice(decimal carat, string clarity, string color, string cut);

    }

}
