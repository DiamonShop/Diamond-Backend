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
using Diamond.Entities.Helpers;

namespace DiamondShop.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DiamondDbContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly JwtSettings _jwtSettings;
        private readonly IUserRepository _userRepository;

        public LoginController(DiamondDbContext context, SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager, IOptions<JwtSettings> jwtSettings, IUserRepository userRepository)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
            _jwtSettings = jwtSettings.Value;
            _userRepository = userRepository;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var user = _context.Users.Include(u => u.Role).FirstOrDefault(u =>
                u.Username == model.UserName &&
                u.Password == model.Password);

            if (user == null)
            {
                return Ok(new ApiResponse
                {
                    Success = false,
                    Message = "Invalid login attempt"
                });
            }

            UserViewModel userModel = new UserViewModel()
            {
                UserId = user.UserId,
                Email = user.Email,
                FullName = user.FullName,
                RoleName = user.Role.RoleName,
                Username = model.UserName
            };

            return Ok(new ApiResponse
            {
                Success = true,
                Message = "Login successful",
                Data = userModel
            });
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
            var secretKeyBytes = Encoding.UTF8.GetBytes(_jwtSettings.SecretKey);

            var claims = new List<Claim>
            {
                new Claim(MySettings.CLAIM_USERID, user.UserId.ToString()),
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
