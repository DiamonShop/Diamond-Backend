using Diamond.Entities.DTO;
using Diamond.Entities.Model;
using DiamondShop.Controllers;
using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DiamondShop.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DiamondDbContext _context;
        private readonly Jwt _jwtSettings;
        private readonly ILogger<UserRepository> _logger;
        public UserRepository(DiamondDbContext context, IOptions<Jwt> jwtSettings, ILogger<UserRepository> logger)
        {
            _jwtSettings = jwtSettings.Value;
            _context = context;
        }

        public async Task<UserViewModel> GetByUserID(int userId)
        {
            var user = await _context.Users
                        .Include(user => user.Role)
                        .FirstOrDefaultAsync(user => user.UserId.Equals(userId));

            if (user == null)
            {
                return null!;
            }

            UserViewModel userModel = new UserViewModel()
            {
                UserId = user.UserId,
                Username = user.Username,
                FullName = user.FullName!,
                Email = user.Email!,
                Address = user.Address,
                LoyaltyPoints = user.LoyaltyPoints,
                IsActive = user.IsActive,
                RoleName = user.Role.RoleName
            };

            return userModel;
        }

        public async Task<List<UserViewModel>> GetByUserEmail(string email)
        {
            var users = await _context.Users
                .Include(user => user.Role)
                .Where(user => user.Email.Contains(email)) //Tìm gần đúng
                .ToListAsync();

            if (users == null)
            {
                return null!;
            }

            var userList = users.Select(user => new UserViewModel
            {
                UserId = user.UserId,
                Username = user.Username,
                FullName = user.FullName,
                Email = user.Email,
                Address = user.Address,
                LoyaltyPoints = user.LoyaltyPoints,
                IsActive = user.IsActive,
                RoleName = user.Role.RoleName
            }).ToList();

            return userList;
        }

        public async Task<List<UserViewModel>> GetByUserName(string userName)
        {
            var users = await _context.Users
                .Include(user => user.Role)
                .Where(user => user.Username.Contains(userName)) //Tìm gần đúng
                .ToListAsync();

            if (users == null)
            {
                return null!;
            }

            var userList = users.Select(user => new UserViewModel
            {
                UserId = user.UserId,
                Username = user.Username,
                FullName = user.FullName,
                Email = user.Email,
                Address = user.Address,
                LoyaltyPoints = user.LoyaltyPoints,
                IsActive = user.IsActive,
                RoleName = user.Role.RoleName
            }).ToList();

            return userList;

        }

        public async Task<List<UserViewModel>> GetAllUsersAsync()
        {
            var users = await _context.Users.Include(user => user.Role).ToListAsync();

            if (users == null)
            {
                return null!;
            }

            // Chuyển đổi danh sách người dùng sang UserViewModel để trả về
            var userList = users.Select(user => new UserViewModel
            {
                UserId = user.UserId,
                Username = user.Username,
                FullName = user.FullName,
                Email = user.Email,
                Address = user.Address,
                LoyaltyPoints = user.LoyaltyPoints,
                IsActive = user.IsActive,
                RoleName = user.Role.RoleName // Lấy tên role của người dùng nếu có
            }).ToList();

            return userList;
        }

        public async Task<bool> CreateAnNewUser(UserDTO userDTO)
        {
            if (userDTO == null)
            {
                return false;
            }

            try
            {
                var user = new User()
                {
                    FullName = userDTO.Fullname,
                    Username = userDTO.Username,
                    Password = userDTO.Password,
                    Email = userDTO.Email,
                    IsActive = true,
                    Address = userDTO.Address,
                    RoleId = userDTO.RoleId
                };
                await _context.Users.AddAsync(user);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> DeleteUserAsync(int userId)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserId == userId);

            if (user == null)
            {
                return false;
            }

            if (user.UserId == userId)
            {
                user.IsActive = false;
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
            }

            return true;
        }

        public async Task<bool> UpdateUserProfile(int userId, UpdateUserModel userModel)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserId == userId);

            if (user == null)
            {
                return false;
            }

            try
            {
                user.Username = userModel.Username;
                user.Password = userModel.Password;
                user.FullName = userModel.FullName;
                user.Email = userModel.Email;
                user.Address = userModel.Address;

                _context.Users.Update(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> SignUpUser(UserSignUpModel userSignUpModel)
        {
            bool result = false;
            if (userSignUpModel == null)
            {
                return false;
            }

            try
            {
                var user = new User()
                {
                    Username = userSignUpModel.Username,
                    Email = userSignUpModel.Email,
                    Password = userSignUpModel.Password,
                    FullName = "",
                    Address = "",
                    LoyaltyPoints = 0,
                    IsActive = true,
                    RoleId = 3 //Member
                };

                await _context.AddAsync(user);
                result = _context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
            return result;
        }

        public Task<bool> Logout(UserSignUpModel userSignUpModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResponse> Login(LoginModel loginModel)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (loginModel == null || string.IsNullOrEmpty(loginModel.UserName) || string.IsNullOrEmpty(loginModel.Password))
                {
                    return null;
                }

                // Tìm kiếm người dùng trong cơ sở dữ liệu
                var user = await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u =>
                    u.Username == loginModel.UserName &&
                    u.Password == loginModel.Password);

                if (user == null)
                {
                    // Không tìm thấy người dùng, trả về lỗi
                    return new ApiResponse
                    {
                        Success = false,
                        Message = "Invalid login attempt"
                    };
                }
                else
                {
                    // Người dùng được tìm thấy, sinh token
                    var token = GenerateToken(user);

                    return new ApiResponse
                    {
                        Success = true,
                        Message = "Login successful",
                        Data = new
                        {
                            user.Username,
                            user.FullName,
                            user.Email,
                            user.Role.RoleName,
                            Token = token
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi nếu có lỗi xảy ra
                _logger.LogError($"Exception occurred in Login method: {ex}");
                return null;
            }

        }

        private string GenerateToken(User user)
        {
            try
            {
                if (user == null)
                {
                    throw new ArgumentNullException(nameof(user), "User cannot be null");
                }

                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.UTF8.GetBytes(_jwtSettings.SecretKey);

                // Check if the JWT Secret Key is null or empty
                if (string.IsNullOrEmpty(_jwtSettings.SecretKey))
                {
                    throw new ArgumentException("JWT Secret Key is null or empty", nameof(_jwtSettings.SecretKey));
                }

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                        new Claim(ClaimTypes.Name, user.Username),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role, user.Role.RoleName)
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(_jwtSettings.ExpirationMinutes),
                    Issuer = _jwtSettings.Issuer,
                    Audience = _jwtSettings.Audience,
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"ArgumentNullException occurred in GenerateToken method: {ex.Message}");
                throw; 
            }
            catch (ArgumentException ex)
            {
                // Log the specific error message for debugging purposes
                Console.WriteLine($"ArgumentException occurred in GenerateToken method: {ex.Message}");
                throw; // Rethrow the exception to handle it in the calling method
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                Console.WriteLine($"Exception occurred in GenerateToken method: {ex}");
                return null; // Return null or handle the error as appropriate for your application
            }
        }
    }
}
