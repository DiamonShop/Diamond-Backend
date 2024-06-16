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

    }
}
