using DiamondShop.Data;
using DiamondShop.Model;

namespace DiamondShop.Repositories.Interfaces
{
	public interface IUserRepository
	{
		public Task<User> GetByUserID(int userId);
		public Task<User> GetByUserName(string userName);
		public Task<User> GetByUserEmail(string email);
		public Task<bool> CreateAnNewUser(User user);
		public Task<List<User>> GetAllUsersAsync();
	}
}
