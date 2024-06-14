using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DiamondShop.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly DiamondDbContext _context;

		public UserRepository(DiamondDbContext context)
		{
			_context = context;
		}

		public async Task<UserViewModel> GetByUserID(int userId)
		{
			var user = await _context.Users
						.Include(user => user.Role)
						.FirstOrDefaultAsync(user => user.UserId.Equals(userId));

			if (user == null)
			{
				return null!;
			}

			UserViewModel userModel = new UserViewModel()
			{
				UserId = user.UserId,
				Username = user.Username,
				FullName = user.FullName!,
				Email = user.Email!,
				RoleName = user.Role.RoleName
			};

			return userModel;
		}

		public async Task<List<UserViewModel>> GetByUserEmail(string email)
		{
			var users = await _context.Users
				.Include(user => user.Role)
				.Where(user => user.Email.Contains(email)) //Tìm gần đúng
				.ToListAsync();

			if (users == null)
			{
				return null!;
			}

			var userList = users.Select(user => new UserViewModel
			{
				UserId = user.UserId,
				Username = user.Username,
				FullName = user.FullName,
				Email = user.Email,
				RoleName = user.Role.RoleName
			}).ToList();

			return userList;
		}

		public async Task<List<UserViewModel>> GetByUserName(string userName)
		{
			var users = await _context.Users
				.Include(user => user.Role)
				.Where(user => user.Username.Contains(userName)) //Tìm gần đúng
				.ToListAsync();

			if (users == null)
			{
				return null!;
			}

			var userList = users.Select(user => new UserViewModel
			{
				UserId = user.UserId,
				Username = user.Username,
				FullName = user.FullName!,
				Email = user.Email!,
				RoleName = user.Role.RoleName
			}).ToList();

			return userList;

		}

		public async Task<List<UserViewModel>> GetAllUsersAsync()
		{
			var users = await _context.Users.Include(user => user.Role).ToListAsync();

			if (users == null)
			{
				return null!;
			}

			// Chuyển đổi danh sách người dùng sang UserViewModel để trả về
			var userList = users.Select(user => new UserViewModel
			{
				UserId = user.UserId,
				Username = user.Username,
				FullName = user.FullName!,
				Email = user.Email!,
				RoleName = user.Role.RoleName // Lấy tên role của người dùng nếu có
			}).ToList();

			return userList;
		}

		public async Task<bool> CreateAnNewUser(UserDTO userDTO)
		{
			if (userDTO == null)
			{
				return false;
			}

			try
			{
				var user = new User()
				{
					FullName = userDTO.Fullname,
					Username = userDTO.Username,
					Password = userDTO.Password,
					Email = userDTO.Email,
					IsActive = userDTO.IsActive,
					RoleId = userDTO.RoleId
				};
				await _context.Users.AddAsync(user);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}

		public async Task<bool> DeleteUserAsync(int userId)
		{
			var user = await _context.Users.FirstOrDefaultAsync(u => u.UserId == userId);

			if (user == null)
			{
				return false;
			}

			if (user.UserId == userId)
			{
				user.IsActive = false;
				_context.Users.Update(user);
				await _context.SaveChangesAsync();
			}

			return true;
		}

		public async Task<bool> UpdateUserProfile(int userId, UpdateUserModel userModel)
		{
			var user = await _context.Users
				.Include(u => u.Role)
				.FirstOrDefaultAsync(u => u.UserId == userId);

			if (user == null)
			{
				return false;
			}

			try
			{
				user.Username = userModel.Username;
				user.Password = userModel.Password;
				user.FullName = userModel.FullName;
				user.Email = userModel.Email;

				_context.Users.Update(user);
				await _context.SaveChangesAsync();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}
		public async Task<bool> SignUpUser(UserSignUpModel userSignUpModel)
		{
			bool result = false;
			if (userSignUpModel == null)
			{
				return false;
			}

			try
			{
				var user = new User()
				{
					Username = userSignUpModel.Username,
					Email = userSignUpModel.Email,
					Password = userSignUpModel.Password,
					FullName = "",
					IsActive = true,
					RoleId = 3
				};

				await _context.AddAsync(user);
				result = _context.SaveChanges() > 0;
			}
			catch (Exception)
			{
				return false;
			}
			return result;
		}
	}
}
