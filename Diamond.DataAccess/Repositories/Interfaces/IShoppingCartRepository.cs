using System.Collections.Generic;
using System.Threading.Tasks;
using DiamondShop.Data;

namespace DiamondShop.Repositories.Interfaces
{
    public interface IShoppingCartRepository
    {
        Task<List<ShoppingCartViewModel>> GetAll();
        Task<ShoppingCartViewModel> GetById(int id);
        Task<bool> Insert(ShoppingCart entity);
        Task<bool> Update(ShoppingCart entity);
        Task<bool> Delete(int id);
    }
}
