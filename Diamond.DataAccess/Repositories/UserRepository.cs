using Diamond.Entities.DTO;
using Diamond.Entities.Model;
using DiamondShop.Controllers;
using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
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


        public UserRepository(DiamondDbContext context, IOptions<Jwt> jwtSettings)
        {
            _jwtSettings = jwtSettings.Value;
            _context = context;
        }

        public async Task<UserProfileViewModel> GetUserProfile(int userId)
        {
            var user = await _context.Users
                .Include(u => u.Role)

                .FirstOrDefaultAsync(u => u.UserId == userId);

            if (user == null)
            {
                return null;
            }

            // Map User entity to UserProfileViewModel
            var userProfile = new UserProfileViewModel
            {
                UserId = user.UserId,
                Username = user.Username,
                FullName = user.FullName,
                Email = user.Email,
                NumberPhone = user.NumberPhone,
                Address = user.Address,
                LoyaltyPoints = user.LoyaltyPoints,
                IsActive = user.IsActive,
                RoleName = user.Role?.RoleName // Optional chaining for RoleName
            };

            return userProfile;
        }


        public async Task<User> FindByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
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
                NumberPhone = user.NumberPhone,
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
                NumberPhone = user.NumberPhone,
                Address = user.Address,
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
                NumberPhone = user.NumberPhone,
                Address = user.Address,
                LoyaltyPoints = user.LoyaltyPoints,
                IsActive = user.IsActive,
                RoleName = user.Role.RoleName
            }).ToList();

            return userList;
        }

        public async Task<List<UserViewModel>> GetAllUsersAsync()
        {
            var users = await _context.Users
                .Include(user => user.Role)

                .ToListAsync();

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
                NumberPhone = user.NumberPhone,
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
                    RoleId = userDTO.RoleId,
                    NumberPhone = userDTO.NumberPhone,
                    Address = userDTO.Address,


                };
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
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

        public async Task<bool> UpdateUserProfile(UpdateUserModel userModel)
        {
            bool result = false;
            try
            {
                var user = await _context.Users
                    .Include(r => r.Role)
                    .SingleOrDefaultAsync(u => u.UserId == userModel.UserId);

                if (user == null)
                {
                    return result; // Không tìm thấy người dùng để cập nhật
                }

                // Cập nhật thông tin người dùng từ userModel

                user.FullName = userModel.FullName;
                user.Email = userModel.Email;
                user.NumberPhone = userModel.NumberPhone;
                user.Address = userModel.Address;


                _context.Users.Update(user);
                result = await _context.SaveChangesAsync() > 0;
            }
            catch (DbUpdateException ex)
            {
                Console.WriteLine($"An error occurred while updating the user profile: {ex.Message}");
                return result;
            }
            return result;
        }

        public async Task<bool> SignUpUser(UserSignUpModel userSignUpModel)
        {
            if (userSignUpModel == null)
            {
                return false;
            }

            // Check if username or email already exists
            var existingUser = await _context.Users.FirstOrDefaultAsync(u => u.Username == userSignUpModel.Username || u.Email == userSignUpModel.Email);
            if (existingUser != null)
            {
                return false; // Username or email already exists
            }

            try
            {
                var user = new User()
                {
                    Username = userSignUpModel.Username,
                    Email = userSignUpModel.Email,
                    Password = userSignUpModel.Password,
                    FullName = "",
                    NumberPhone = "",
                    Address = "",
                    LoyaltyPoints = 0,
                    IsActive = true,
                    RoleId = 3 // Member
                };

                await _context.AddAsync(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<ApiResponse> Login(LoginModel loginModel)
        {
            if (loginModel == null || string.IsNullOrEmpty(loginModel.UserName) || string.IsNullOrEmpty(loginModel.Password))
            {
                return new ApiResponse { Success = false, Message = "Invalid login attempt" };
            }

            try
            {
                var user = await _context.Users
                    .Include(u => u.Role)
                    .FirstOrDefaultAsync(u => u.Username == loginModel.UserName && u.Password == loginModel.Password);

                if (user == null)
                {
                    return new ApiResponse { Success = false, Message = "Invalid login attempt" };
                }

                if (!user.IsActive)
                {
                    return new ApiResponse { Success = false, Message = "Account is not active" };
                }

                var token = await GenerateJwtToken(user);

                return new ApiResponse
                {
                    Success = true,
                    Message = "Login successful",
                    Data = new
                    {
                        user.UserId,
                        user.Username,
                        user.FullName,
                        user.Email,
                        user.Role.RoleName,
                        user.NumberPhone,
                        user.Address,
                        Token = token
                    }
                };
            }
            catch (Exception ex)
            {
                return new ApiResponse { Success = false, Message = "An error occurred while processing your request" };
            }
        }


        public async Task<string> GenerateJwtToken(User user)
        {
            if (user == null) throw new ArgumentNullException(nameof(user));

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sid, user.UserId.ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, user.Username),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, user.Role.RoleName)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
                claims: claims,
                expires: DateTime.UtcNow.AddHours(_jwtSettings.ExpirationMinutes),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<bool> UpdateUserLoyalPoint(int userId)
        {
            bool result = false;

            var user = await _context.Users
                .SingleOrDefaultAsync(x => x.UserId == userId);
			var latestOrder = await _context.Orders
								   .Include(o => o.OrderDetails)
								   .Include(o => o.User) // Ensure User is included
								   .Where(o => o.UserID == userId)
								   .OrderByDescending(o => o.OrderDate)
								   .FirstOrDefaultAsync(); // Get the latest order
            int loyalPoint = (int)(latestOrder.TotalPrice/1000);

            if(user == null || latestOrder == null) 
            {
                return result;
            }

            var updateUser = new User
            {
                UserId = user.UserId,
                RoleId = user.RoleId,
                Email = user.Email,
                FullName = user.FullName,
                NumberPhone = user.NumberPhone,
                Username = user.Username,
                Password = user.Password,
                Address = user.Address,
                IsActive = user.IsActive,
                LoyaltyPoints = user.LoyaltyPoints + loyalPoint,
            };

			_context.Users.Update(updateUser);
			result = await _context.SaveChangesAsync() > 0;

			return result;
        } 

    }
}
