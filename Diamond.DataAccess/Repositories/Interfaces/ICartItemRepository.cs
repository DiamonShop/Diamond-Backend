using System.Collections.Generic;
using System.Threading.Tasks;
using DiamondShop.Data;

namespace DiamondShop.Repositories.Interfaces
{
    public interface ICartItemRepository
    {
        Task<List<CartItem>> GetAll();
        Task<CartItem> GetById(int id);
        Task<bool> Insert(CartItem entity);
        Task<bool> Update(CartItem entity);
        Task<bool> Delete(int id);
    }
}
