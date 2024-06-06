using DiamondShop.Data;
using DiamondShop.Repositories.Interfaces;
using FAMS.Entities.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace DiamondShop.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly DiamondDbContext _context;
		private readonly GenericRepository<User> _userGeneric;
		
		public UserRepository(DiamondDbContext context, GenericRepository<User> userGeneric)
		{
			_context = context;
			_userGeneric = userGeneric;
		}

		public async Task<User> GetByUserEmail(string email)
		{
			var user = await _context.Users.FirstOrDefaultAsync(user => user.Email.Equals(email));
			return user;
		}

		public async Task<User> GetByUserID(string userId)
		{
			var user = await _context.Users.FirstOrDefaultAsync(user => user.UserId.Equals(userId));
			return user;
		}

		public async Task<User> GetByUserName(string userName)
		{
			var user = await _context.Users.FirstOrDefaultAsync(user => user.Username.Equals(userName));
			return user;
		}

		public async Task<List<User>> GetAllUsersAsync()
		{
			return await _context.Users.ToListAsync();
		}

		public async Task<bool> CreateAnNewUser(User user)
		{
			return await _userGeneric.Insert(user);
		}

	}
}
