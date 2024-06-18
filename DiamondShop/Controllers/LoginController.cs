using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace DiamondShop.Controllers
{
    [Route("api/Register")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly IUserRepository _userRepository;


        public LoginController(IUserRepository userRepository) // Thêm ILogger vào đây
        {
            _userRepository = userRepository;
        }


        [HttpPost("Login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (model == null || string.IsNullOrEmpty(model.UserName) || string.IsNullOrEmpty(model.Password))
            {
                return BadRequest(new ApiResponse
                {
                    Message = "Username and password cannot be empty",
                    Success = false
                });
            }

            var response = await _userRepository.Login(model);

            if (response == null)
            {
                return StatusCode(500, new ApiResponse
                {
                    Message = "Internal server error",
                    Success = false
                });
            }

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }


        [HttpPost("Logout")]
        [Authorize]
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

        [HttpGet("GoogleLogin")]
        [AllowAnonymous]
        public IActionResult GoogleLogin()
        {
            var properties = new AuthenticationProperties
            {
                RedirectUri = Url.Action(nameof(GoogleLoginCallback))
            };
            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }

        [HttpGet("GoogleLoginCallback")]
        [AllowAnonymous]
        public async Task<IActionResult> GoogleLoginCallback()
        {
            var result = await HttpContext.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);
            if (!result.Succeeded)
            {
                return BadRequest("Failed to authenticate with Google.");
            }

            var claims = result.Principal.Identities.FirstOrDefault()?.Claims;
            var email = claims?.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
            var name = claims?.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;

            if (string.IsNullOrEmpty(email))
            {
                return BadRequest("Google authentication did not return an email.");
            }

            var user = await _userRepository.FindByEmailAsync(email);
            if (user == null)
            {
                // If user doesn't exist, create a new user or handle as needed
            }

            var token = await _userRepository.GenerateJwtToken(user);

            return Ok(new
            {
                Token = token,
                User = new
                {
                    user.Username,
                    user.FullName,
                    user.Email
                }
            });
        }

    }
}

