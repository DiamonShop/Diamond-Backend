using System.Collections.Generic;
using System.Threading.Tasks;
using DiamondShop.Data;

namespace DiamondShop.Repositories.Interfaces
{
    public interface ICartItemRepository
    {
        Task<List<OrderDetail>> GetAll();
        Task<OrderDetail> GetById(int id);
        Task<bool> Insert(OrderDetail entity);
        Task<bool> Update(OrderDetail entity);
        Task<bool> Delete(int id);
    }
}
