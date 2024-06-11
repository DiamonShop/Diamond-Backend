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
using Microsoft.AspNetCore.Cors;

namespace DiamondShop.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoginController : ControllerBase
	{
		private readonly DiamondDbContext _context;
		private readonly JwtSettings _jwtSettings;

		public LoginController(DiamondDbContext context, SignInManager<IdentityUser> signInManager,
				IOptions<JwtSettings> jwtSettings)
		{
			_context = context;
			_jwtSettings = jwtSettings.Value;
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginModel model)
		{
			var user = _context.Users.FirstOrDefault(user =>
			user.Username == model.UserName &&
			user.Password == model.Password);
			if (user != null)
			{
				return Ok(new ApiResponse
				{
					Success = true,
					Message = "Login successful",
					Data = user
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

		/*[HttpPost("SignUp")]
		public Task<IActionResult> SignUp() 
		{

		}*/

		[HttpGet("GoogleLogin")]
		public IActionResult GoogleLogin()
		{
			var props = new AuthenticationProperties { RedirectUri = "Login/GoogleLogin" };
			return Challenge(props, GoogleDefaults.AuthenticationScheme);
		}

		[HttpGet("signin-google")]
		public async Task<IActionResult> GoogleLoginCallback()
		{
			var response = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			if (response.Principal == null) return BadRequest();

			var name = response.Principal.FindFirstValue(ClaimTypes.Name);
			var givenName = response.Principal.FindFirstValue(ClaimTypes.GivenName);
			var email = response.Principal.FindFirstValue(ClaimTypes.Email);
			//Do something with the claims
			// var user = await UserService.FindOrCreate(new { name, givenName, email});
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
