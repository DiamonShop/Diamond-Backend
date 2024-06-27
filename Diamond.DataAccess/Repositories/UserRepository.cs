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
using Microsoft.Extensions.Configuration;

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
                .Include(u => u.ShipAddresses) // Include ShipAddresses
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
                Address = user.ShipAddresses.FirstOrDefault()?.Address, // Get the first address
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
                        .Include(user => user.ShipAddresses) // Include ShipAddresses
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
                Address = user.ShipAddresses.FirstOrDefault()?.Address, // Get the first address
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
                .Include(user => user.ShipAddresses) // Include ShipAddresses
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
                Address = user.ShipAddresses.FirstOrDefault()?.Address, // Get the first address
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
                .Include(user => user.ShipAddresses) // Include ShipAddresses
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
                Address = user.ShipAddresses.FirstOrDefault()?.Address, // Get the first address
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
                .Include(user => user.ShipAddresses) // Include ShipAddresses
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
                Address = user.ShipAddresses.FirstOrDefault()?.Address, // Get the first address
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
                    ShipAddresses = new List<ShipAddress>
            {
                new ShipAddress
                {
                    Address = userDTO.Address,
                    IsActive = true
                }
            }
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

        public async Task<bool> UpdateUserProfile(int userId, UpdateUserModel userModel)
        {
            try
            {
                var user = await _context.Users
                    .Include(u => u.ShipAddresses) // Include ShipAddresses
                    .FirstOrDefaultAsync(u => u.UserId == userId);

                if (user == null)
                {
                    return false; // Không tìm thấy người dùng để cập nhật
                }

                // Cập nhật thông tin người dùng từ userModel
                if (!string.IsNullOrEmpty(userModel.Username))
                {
                    user.Username = userModel.Username;
                }

                // Mã hóa mật khẩu nếu có thay đổi
                if (!string.IsNullOrEmpty(userModel.Password))
                {
                    // Mã hóa mật khẩu ở đây (ví dụ: hash mật khẩu trước khi lưu)
                    user.Password = userModel.Password;
                }

                if (!string.IsNullOrEmpty(userModel.FullName))
                {
                    user.FullName = userModel.FullName;
                }

                if (!string.IsNullOrEmpty(userModel.Email))
                {
                    user.Email = userModel.Email;
                }

                if (!string.IsNullOrEmpty(userModel.Address))
                {
                    var shipAddress = user.ShipAddresses.FirstOrDefault();
                    if (shipAddress != null)
                    {
                        shipAddress.Address = userModel.Address;
                    }
                    else
                    {
                        user.ShipAddresses.Add(new ShipAddress
                        {
                            Address = userModel.Address,
                            IsActive = true
                        });
                    }
                }

                _context.Users.Update(user);
                await _context.SaveChangesAsync();

                return true; // Cập nhật thành công
            }
            catch (DbUpdateException ex)
            {
                // Xử lý ngoại lệ khi cập nhật vào cơ sở dữ liệu không thành công
                // Log lỗi ex.Message để xem lỗi chi tiết
                return false;
            }
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
                  
                    LoyaltyPoints = 0,
                    IsActive = true,
                    RoleId = 3 // Member
                };

                await _context.AddAsync(user);
                await _context.SaveChangesAsync();
                return true; // User created successfully
            }
            catch (Exception)
            {
                return false; // Failed to create user
            }
        }


        public Task<bool> Logout(UserSignUpModel userSignUpModel)
        {
            throw new NotImplementedException();
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
                      .Include(u => u.ShipAddresses)
                    .FirstOrDefaultAsync(u => u.Username == loginModel.UserName && u.Password == loginModel.Password);

                if (user == null)
                {
                    return new ApiResponse { Success = false, Message = "Invalid login attempt" };
                }

                var shipAddressViewModels = user.ShipAddresses.Select(sa => new ShipAddressViewModel
                {
                    ShipAddressId = sa.ShipAddressId,
                    Address = sa.Address,
                    PhoneNumber = sa.PhoneNumber,
                    
                    IsActive = sa.IsActive
                }).ToList();

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
                        ShipAddresses = shipAddressViewModels,
                        Token = token
                    }
                };
            }
            catch (Exception ex)
            {
                
                return new ApiResponse { Success = false, Message = "An error occurred while processing your request" };
            }
        }
       

        public async Task<bool> UpdateShipAddressAsync(int shipAddressId, ShipAddress shipAddress)
        {
            try
            {
                var existingShipAddress = await _context.ShipAddresses.FirstOrDefaultAsync(sa => sa.ShipAddressId == shipAddressId);
                if (existingShipAddress != null)
                {
                    existingShipAddress.Address = shipAddress.Address;
                    existingShipAddress.PhoneNumber = shipAddress.PhoneNumber;
                    existingShipAddress.ReceiverName = shipAddress.ReceiverName;
                    existingShipAddress.IsActive = shipAddress.IsActive;

                    _context.ShipAddresses.Update(existingShipAddress);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false; // Ship address not found
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> DeleteShipAddressAsync(int shipAddressId)
        {
            try
            {
                var shipAddress = await _context.ShipAddresses.FirstOrDefaultAsync(sa => sa.ShipAddressId == shipAddressId);
                if (shipAddress != null)
                {
                    shipAddress.IsActive = false; // Soft delete by marking inactive
                    _context.ShipAddresses.Update(shipAddress);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false; // Ship address not found
            }
            catch (Exception)
            {
                return false;
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
                expires: DateTime.UtcNow.AddMinutes(_jwtSettings.ExpirationMinutes),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<bool> AddShipAddressAsync(int userId, ShipAddressViewModel shipAddressViewModel)
        {
            // Kiểm tra xem userId có tồn tại trong bảng Users hay không
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserId == userId);
            if (user == null)
            {
                return false; // Nếu không tìm thấy userId, trả về false hoặc xử lý thích hợp
            }

            var shipAddress = new ShipAddress
            {
                UserId = userId, // Gán UserId cho ShipAddress
                Address = shipAddressViewModel.Address,
                PhoneNumber = shipAddressViewModel.PhoneNumber,
                ReceiverName = shipAddressViewModel.RecipientName,
                IsActive = true // Set IsActive as needed
            };

            _context.ShipAddresses.Add(shipAddress);
            await _context.SaveChangesAsync();
            return true; // Thêm ShipAddress thành công
        }
        public async Task<List<ShipAddressViewModel>> GetAllShipAddresses(int userId)
        {
            var user = await _context.Users
                .Include(u => u.ShipAddresses)
                .FirstOrDefaultAsync(u => u.UserId == userId);

            if (user == null)
            {
                return null; // hoặc trả về danh sách trống tùy theo logic ứng dụng của bạn
            }

            var shipAddresses = user.ShipAddresses.Select(sa => new ShipAddressViewModel
            {
                ShipAddressId = sa.ShipAddressId,
                Address = sa.Address,
                PhoneNumber = sa.PhoneNumber,
                RecipientName = sa.ReceiverName,
                IsActive = sa.IsActive
            }).ToList();

            return shipAddresses;
        }







    }
}
