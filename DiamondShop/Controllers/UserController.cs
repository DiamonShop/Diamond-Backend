using Microsoft.AspNetCore.Mvc;
using DiamondShop.Data;
using DiamondShop.Repositories.Interfaces;
using DiamondShop.Model;

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
		public async Task<IActionResult> GetAllUsers()
		{
			return Ok(await _userRepository.GetAllUsersAsync());
		}

		[HttpGet("GetUserByName")]
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
		public async Task<IActionResult> GetUserByEmail(string email)
		{
			if (await _userRepository.GetByUserEmail(email) != null)
			{
				return Ok(_userRepository.GetByUserEmail(email));
			}
			return BadRequest("User is not found");
		}

		[HttpGet("GetUserById")]
		public async Task<IActionResult> GetUserById(int id)
		{
			if (await _userRepository.GetByUserID(id) == null)
			{
				return BadRequest("User is not found");
			}
			return Ok(await _userRepository.GetByUserID(id));
		}

		[HttpPost("CreateUser")]
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



