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
using NuGet.Protocol.Core.Types;
using AutoMapper;

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

		[HttpGet("GetAllUsers")]
		public async Task<IActionResult> GetAllUsers()
		{
			var users = await _userRepository.GetAllUsersAsync();

			// Chuyển đổi danh sách người dùng sang UserViewModel để trả về
			var userViewModels = users.Select(user => new UserViewModel
			{
				UserId = user.UserId,
				Username = user.Username,
				FullName = user.FullName,
				Email = user.Email,
				RoleName = user.Role?.RoleName // Lấy tên vai trò của người dùng nếu có
			}).ToList();

			return Ok(userViewModels);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetUserById(int id)
		{
			var user = await _userRepository.GetByUserID(id);
			UserViewModel userViewModel;

			try
			{
				if (user == null)
				{
					return NotFound("User not found");
				}
				else
				{
					userViewModel = new UserViewModel()
					{
						UserId = user.UserId,
						Username = user.Username,
						FullName = user.FullName,
						Email = user.Email,
						RoleName = user.Role?.RoleName
					};
				}
			}
			catch (Exception ex)
			{
				return StatusCode(500, "Internal server error");
			}
			return Ok(userViewModel);
		}

		[HttpPost("Registration")]
		public async Task<IActionResult> CreateUser(UserDTO userDTO)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			var objUser = _context.Users
							.FirstOrDefault(x => x.Email == userDTO.Email && x.Username == userDTO.Username);

			if (objUser == null)
			{
				_context.Users.Add(new User
				{
					FullName = userDTO.Fullname,
					Username = userDTO.Username,
					Password = userDTO.Password,
					Email = userDTO.Email,
					IsActive = userDTO.IsActive,
					RoleId = userDTO.RoleId
				});
				_context.SaveChanges();
				return Ok("User registered");
			}
			else
			{
				return BadRequest("User already existed.");
			}
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateUser(int id, [FromBody] UserModel userModel)
		{
			var user = await _userRepository.GetByUserID(id);

			if (id != user.UserId)
			{
				return BadRequest();
			}

			try
			{
				user.Username = userModel.Username;
				user.FullName = userModel.FullName;
				user.Email = userModel.Email;

				_context.Users.Update(user);
				_context.SaveChanges();
				return Ok("Update Successfully!");
			}
			catch (DbUpdateConcurrencyException)
			{
				throw;
			}
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteUser(int id)
		{
			var user = await _context.Users.FindAsync(id);
			if (user == null)
			{
				return NotFound();
			}
			user.IsActive = false;

			_context.Users.Remove(user);
			await _context.SaveChangesAsync();

			return NoContent();
		}

	}





}



