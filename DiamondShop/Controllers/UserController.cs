using Microsoft.AspNetCore.Mvc;
using DiamondShop.Repositories.Interfaces;
using DiamondShop.Model;
using Microsoft.AspNetCore.Authorization;
using Diamond.Entities.DTO;
using DiamondShop.Data;
using Microsoft.EntityFrameworkCore;
using Diamond.Entities.Model;

namespace DiamondShop.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserRepository _userRepository;
		

		public UserController(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		[HttpGet("GetAllUsers")]
		/*[Authorize(Roles = "Admin,Manager")]*/
		public async Task<IActionResult> GetAllUsers()
		{
			return Ok(await _userRepository.GetAllUsersAsync());
		}

		[HttpGet("GetUserByName")]
		[Authorize(Roles = "Admin,Manager")]
		public async Task<IActionResult> GetUserByName(string name)
		{
			var userList = await _userRepository.GetByUserName(name);

			if (userList != null)
			{
				return Ok(userList);
			}
			return BadRequest("User is not found");
		}

		[HttpGet("GetUserByEmail")]
		[Authorize(Roles = "Admin,Manager")]
		public async Task<IActionResult> GetUserByEmail(string email)
		{
			if (await _userRepository.GetByUserEmail(email) != null)
			{
				return Ok(_userRepository.GetByUserEmail(email));
			}
			return BadRequest("User is not found");
		}

        [HttpGet("GetUserProfile")]
        [Authorize(Roles = "Admin,Manager,Staff,Delivery,Member")]
        public async Task<IActionResult> GetUserProfile(int id)
        {
            var userProfile = await _userRepository.GetUserProfile(id);
            if (userProfile == null)
            {
                return BadRequest("User profile not found");
            }
            return Ok(userProfile);
        }

        [HttpGet("GetUserById")]
		[Authorize(Roles = "Admin,Manager")]
		public async Task<IActionResult> GetUserById(int id)
		{
			if (await _userRepository.GetByUserID(id) == null)
			{
				return BadRequest("User is not found");
			}
			return Ok(await _userRepository.GetByUserID(id));
		}

		[HttpPost("CreateUser")]
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> CreateUser(UserDTO userDTO)
		{
			bool result = await _userRepository.CreateAnNewUser(userDTO);
			if (result)
			{
				return Ok("Create User Successfully");
			}
			return BadRequest("Failed To Create User");
		}

		[HttpPut("UpdateUserProfile")]
		[Authorize(Roles = "Admin,Manager,Staff,Delivery,Member")]
		public async Task<IActionResult> UpdateUserProfile(int id, [FromBody] UpdateUserModel userModel)
		{
			bool result = await _userRepository.UpdateUserProfile(id, userModel);
			if (result)
			{
				return Ok("Update User Successfully");
			}
			return BadRequest("Failed To Create User");
		}

		[HttpDelete("DeleteUser")]
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> DeleteUser(int id)
		{
			bool result = await _userRepository.DeleteUserAsync(id);
			if (result)
			{
				return Ok("Delete User Successfully");
			}
			return BadRequest("Failed To Delete User");
		}

       


    }
}



