using Diamond.Entities.DTO;
using Diamond.Entities.Model;
using DiamondShop.Controllers;
using DiamondShop.Data;
using DiamondShop.Model;

namespace DiamondShop.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<UserProfileViewModel> GetUserProfile(int id);
        Task<UserViewModel> GetByUserID(int userId);
        Task<List<UserViewModel>> GetByUserName(string userName);
        Task<List<UserViewModel>> GetByUserEmail(string email);
        Task<bool> CreateAnNewUser(UserDTO userDTO);
        Task<List<UserViewModel>> GetAllUsersAsync();
        Task<bool> DeleteUserAsync(int userId);
        Task<bool> UpdateUserProfile(int userId, UpdateUserModel userModel);
        Task<ApiResponse> Login(LoginModel loginModel);
        Task<bool> SignUpUser(UserSignUpModel userSignUpModel);
        Task<bool> Logout(UserSignUpModel userSignUpModel);
        Task<string> GenerateJwtToken(User user);
        Task<User> FindByEmailAsync(string email);
        Task AddAsync(User user);
        
    }
}
