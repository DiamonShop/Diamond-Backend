using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Threading.Tasks;
using NuGet.Common;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace DiamondShop.Controllers
{
    [Route("api/Register")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DiamondDbContext _context;
        private readonly Jwt _jwtSettings;
        private readonly IUserRepository _userRepository;
        private readonly ILogger<LoginController> _logger; // Thêm ILogger vào đây

        public LoginController(DiamondDbContext context,
            IOptions<Jwt> jwtSettings, IUserRepository userRepository,
            ILogger<LoginController> logger) // Thêm ILogger vào đây
        {
            _context = context;
            _jwtSettings = jwtSettings.Value;
            _userRepository = userRepository;
            _logger = logger; // Gán logger cho trường _logger
        }


        [HttpPost("Login")]
        [AllowAnonymous] // Cho phép truy cập mà không cần xác thực
        public async Task<IActionResult> Login(LoginModel model)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (model == null || string.IsNullOrEmpty(model.UserName) || string.IsNullOrEmpty(model.Password))
                {
                    return BadRequest("Invalid input data");
                }

                // Tìm kiếm người dùng trong cơ sở dữ liệu
                var user = await _context.Users.Include(u => u.Role)
                    .FirstOrDefaultAsync(u =>
                        u.Username == model.UserName &&
                        u.Password == model.Password);

                if (user == null)
                {
                    // Không tìm thấy người dùng, trả về lỗi
                    return BadRequest(new ApiResponse
                    {
                        Success = false,
                        Message = "Invalid login attempt"
                    });
                }

                // Người dùng được tìm thấy, sinh token
                var token = GenerateToken(user);

                // Trả về thông tin người dùng cùng với token
                return Ok(new ApiResponse
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
                });
            }
            catch (Exception ex)
            {
                // Ghi log lỗi nếu có lỗi xảy ra
                _logger.LogError($"Exception occurred in Login method: {ex}");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }

        [Authorize]
        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            try
            {
                return Ok(new ApiResponse
                {
                    Success = true,
                    Message = "Logout successful"
                });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception occurred in Logout method: {ex}");
                return StatusCode(500, "An error occurred while processing your request");
            }
        }



        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(UserSignUpModel userSignUpModel)
        {
            bool result = await _userRepository.SignUpUser(userSignUpModel);
            if (result)
            {
                return Ok("Sign Up User Successfully");
            }
            return BadRequest("Failed To Create User");
        }

        [HttpPost("GoogleLogin")]
        public IActionResult GoogleLogin()
        {
            var props = new AuthenticationProperties { RedirectUri = "/api/Login/GoogleLoginCallback" };
            return Challenge(props, GoogleDefaults.AuthenticationScheme);
        }

        [HttpGet("GoogleLoginCallback")]
        public async Task<IActionResult> GoogleLoginCallback()
        {
            var result = await HttpContext.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);
            if (!result.Succeeded)
            {
                return BadRequest("Failed to authenticate with Google.");
            }

            var name = result.Principal.FindFirstValue(ClaimTypes.Name);
            var givenName = result.Principal.FindFirstValue(ClaimTypes.GivenName);
            var email = result.Principal.FindFirstValue(ClaimTypes.Email);

            var userViewModel = new UserViewModel()
            {
                Username = name,
                FullName = givenName,
                Email = email,
            };

            return Ok(userViewModel);
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
                // Log the specific error message for debugging purposes
                Console.WriteLine($"ArgumentNullException occurred in GenerateToken method: {ex.Message}");
                throw; // Rethrow the exception to handle it in the calling method
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

        private void ValidateToken(string token)
        {
            var key = Encoding.UTF8.GetBytes(_jwtSettings.SecretKey);
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };

            try
            {
                var principal = tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);
                Console.WriteLine("Token is valid");
                Console.WriteLine("Decoded JWT:");
                foreach (var claim in principal.Claims)
                {
                    Console.WriteLine($"{claim.Type}: {claim.Value}");
                }
            }
            catch (SecurityTokenException ex)
            {
                Console.WriteLine($"Invalid token: {ex.Message}");
            }
        }
    }
}
