using Diamond.Entities.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiamondShop.Repositories.Interfaces
{
    public interface IDiamondsRepository
    {
        Task<List<Diamonds>> GetAllDiamonds();
        Task<Diamonds> CreateDiamond(Diamonds diamond);
        Task<Diamonds> UpdateDiamond(Diamonds diamond);
    }
}
