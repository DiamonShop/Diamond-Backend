using DiamondShop.Data;
using DiamondShop.Model;

namespace DiamondShop.Repositories.Interfaces
{
	public interface IUserRepository
	{
		public Task<UserViewModel> GetByUserID(int userId);
		public Task<List<UserViewModel>> GetByUserName(string userName);
		public Task<List<UserViewModel>> GetByUserEmail(string email);
		public Task<bool> CreateAnNewUser(UserDTO userDTO);
		public Task<List<UserViewModel>> GetAllUsersAsync();
		public Task<bool> DeleteUserAsync(int userId);
		public Task<bool> UpdateUserProfile(int userId, UpdateUserModel userModel);
		public Task<bool> SignUpUser(UserSignUpModel userSignUpModel);
	}
}
