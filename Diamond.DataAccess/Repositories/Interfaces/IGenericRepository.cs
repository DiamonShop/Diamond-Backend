
namespace DiamondShop.Repositories.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(string id);
        Task<bool> Insert(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(string id);
    }
}
