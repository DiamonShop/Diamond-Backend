using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using DiamondShop.Model;
using DiamondShop.Data;
using FAMS.Entities.Data;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Google;
using DiamondShop.Repositories.Interfaces;

namespace DiamondShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly DiamondDbContext _context;
        private readonly JwtSettings _jwtSettings;
        private readonly IUserRepository _userRepository;

        public UserController(DiamondDbContext context, SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager, 
            IOptions<JwtSettings> jwtSettings, 
            IUserRepository userRepository)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _jwtSettings = jwtSettings.Value;
            _userRepository = userRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userRepository.GetAllUsersAsync();

            // Chuyển đổi danh sách người dùng sang UserViewModel để trả về
            var userViewModels = users.Select(user => new UserViewModel
            {
                UserId = user.UserId,
                FullName = user.FullName,
                Email = user.Email,
                RoleName = user.Role?.RoleName // Lấy tên vai trò của người dùng nếu có
            }).ToList();

            return Ok(userViewModels);
        }



		[HttpGet("{id}")]
		public async Task<IActionResult> GetUserById(int id)
		{
			var user = await _context.Users.FindAsync(id);
			if (user == null)
			{
				return NotFound("User not found");
			}
			return Ok(user);
		}

		[HttpPost]
        [Route("Registration")]
        public async Task<IActionResult> CreateUser(UserDTO userDTO)
        {
            if (!ModelState.IsValid)
            {
				return BadRequest(ModelState);
			}
            _context.Users.Add(new User
            {
                UserId = userDTO.UserId,
                FullName = userDTO.Fullname,
                Username = userDTO.Username,
                Password = userDTO.Password,
                Email = userDTO.Email,
                Status = userDTO.Status,
                RoleId = userDTO.RoleId
            });
            _context.SaveChanges();
            return Ok("User registered");
            
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] User user)
        {
            if (id != user.UserId)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Users.Any(u => u.UserId == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            user.IsActive = true;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        [HttpPost("login")]
        /*public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
               var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password,
                    lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return Ok(new ApiResponse
                    {
                        Success = true,
                        Message = "Login successful"
                    });
                }
                else
                {
                    return Ok(new ApiResponse
                    {
                        Success = false,
                        Message = "Invalid login attempt"
                    });
                }
            }

            return BadRequest("Invalid login request");
        }*/

        [HttpGet("google-login")]
        public IActionResult GoogleLogin()
        {
            var properties = new AuthenticationProperties { RedirectUri = Url.Action("GoogleLoginCallback") };
            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }

        [HttpGet("google-login-callback")]
        public async Task<IActionResult> GoogleLoginCallback()
        {
            var authenticateResult = await HttpContext.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);

            if (!authenticateResult.Succeeded)
                return BadRequest("Google login failed");

            var emailClaim = authenticateResult.Principal.FindFirst(ClaimTypes.Email);
            if (emailClaim == null || string.IsNullOrEmpty(emailClaim.Value))
                return BadRequest("Google login failed: Email claim not found");

            var user = await _userManager.FindByEmailAsync(emailClaim.Value);

            if (user == null)
            {
                // Tạo một người dùng mới nếu chưa tồn tại
                user = new IdentityUser
                {
                    UserName = emailClaim.Value,
                    Email = emailClaim.Value
                };
                var result = await _userManager.CreateAsync(user);
                if (!result.Succeeded)
                    return BadRequest("Failed to create user account");
            }

            // Đăng nhập người dùng
            await _signInManager.SignInAsync(user, isPersistent: false);

            // Chuyển hướng hoặc trả về thông báo thành công
            return Ok(new ApiResponse
            {
                Success = true,
                Message = "Google login successful"
            });
        }
        private string GenerateToken(User user)
        {
            var secretKeyBytes = Encoding.UTF8.GetBytes(_jwtSettings.SecretKey);

            var claims = new List<Claim>
            {
                new Claim("UserID", user.UserId.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Email, user.Email)
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddMinutes(_jwtSettings.ExpirationMinutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes), SecurityAlgorithms.HmacSha512Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }




    
}


   
