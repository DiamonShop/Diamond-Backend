using Microsoft.AspNetCore.Mvc;
using DiamondShop.Data;
using DiamondShop.Repositories.Interfaces;
using DiamondShop.Model;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Diamond.DataAccess.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DiamondShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DiamondDbContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly Jwt _jwtSettings;
        private readonly IUserRepository _userRepository;
        private readonly ILogger<LoginController> _logger;
        private readonly ITokenService _tokenService;

        public LoginController(DiamondDbContext context, SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager, IOptions<Jwt> jwtSettings, IUserRepository userRepository,
            ILogger<LoginController> logger, ITokenService tokenService)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _jwtSettings = jwtSettings.Value;
            _userRepository = userRepository;
            _logger = logger;
            _tokenService = tokenService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            try
            {
                if (model == null || string.IsNullOrEmpty(model.UserName) || string.IsNullOrEmpty(model.Password))
                {
                    return BadRequest("Invalid input data");
                }

                var user = await _context.Users.Include(u => u.Role)
                    .FirstOrDefaultAsync(u =>
                        u.Username == model.UserName &&
                        u.Password == model.Password);

                if (user == null)
                {
                    return BadRequest(new ApiResponse
                    {
                        Success = false,
                        Message = "Invalid login attempt"
                    });
                }

                var token = GenerateToken(user);

                return Ok(new ApiResponse
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
                        Token = token
                    }
                });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception occurred in Login method: {ex}");
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
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            catch (ArgumentNullException ex)
            {
                _logger.LogError($"ArgumentNullException occurred in GenerateToken method: {ex.Message}");
                throw;
            }
            catch (ArgumentException ex)
            {
                _logger.LogError($"ArgumentException occurred in GenerateToken method: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception occurred in GenerateToken method: {ex}");
                return null;
            }
        }
    }
}
