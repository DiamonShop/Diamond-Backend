using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Diamond.Entities.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace DiamondShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly Jwt _jwtSettings;

        public TokenController(IOptions<Jwt> jwtSettings)
        {
            _jwtSettings = jwtSettings.Value;
        }

        [HttpGet("protected-resource")]
		[Authorize(Roles = "Admin")]
		public IActionResult GetProtectedResource()
        {
            // Đây là một ví dụ về một endpoint bảo vệ
            return Ok("This is a protected resource");
        }

        private ClaimsPrincipal ValidateToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_jwtSettings.SecretKey);
            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };

            try
            {
                // Thực hiện xác thực token
                var principal = tokenHandler.ValidateToken(token, validationParameters, out var validatedToken);
                return principal;
            }
            catch (SecurityTokenException)
            {
                // Token không hợp lệ
                return null;
            }
        }

        [HttpPost("protected-action")]
		[Authorize(Roles = "Admin")]
		public IActionResult ProtectedAction()
        {
            // Lấy token từ header Authorization
            var authHeader = HttpContext.Request.Headers["Authorization"];
            var token = authHeader.FirstOrDefault()?.Split(" ").Last();

            if (string.IsNullOrEmpty(token))
            {
                return Unauthorized("Missing token");
            }

            // Thực hiện xác thực token
            var principal = ValidateToken(token);

            if (principal == null)
            {
                return Unauthorized("Invalid token");
            }

            // Token hợp lệ, tiếp tục xử lý yêu cầu
            return Ok("Protected action completed");
        }
    }
}
