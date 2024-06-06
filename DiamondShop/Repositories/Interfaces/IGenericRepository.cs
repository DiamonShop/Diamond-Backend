namespace DiamondShop.Repositories.Interfaces
{
	public interface IGenericRepository<T>
	{
		public Task<List<T>> GetAll();
		public Task<T> GetById(string id);
		public Task<bool> Insert(T entity);
		public Task<bool> Update(T entity);
		public Task<bool> Delete(string id);
	}
}
