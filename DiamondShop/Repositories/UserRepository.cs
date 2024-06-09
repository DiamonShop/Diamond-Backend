using AutoMapper;
using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DiamondShop.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly DiamondDbContext _context;
		private readonly IGenericRepository<User> _userGeneric;
		private readonly IMapper _mapper;

		public UserRepository(DiamondDbContext context, IGenericRepository<User> userGeneric)
		{
			_context = context;
			_userGeneric = userGeneric;
		}

		public async Task<User> GetByUserEmail(string email)
		{
			var user = await _context.Users.FirstOrDefaultAsync(user => user.Email.Equals(email));
			return user;
		}

		public async Task<User> GetByUserID(int userId)
		{
			var user = await _context.Users
						.Include(user => user.Role)
						.FirstOrDefaultAsync(user => user.UserId.Equals(userId));
			return user;
		}

		public async Task<User> GetByUserName(string userName)
		{
			var user = await _context.Users.FirstOrDefaultAsync(user => user.Username.Equals(userName));
			return user;
		}

		public async Task<List<User>> GetAllUsersAsync()
		{
			return await _context.Users.Include(user => user.Role).ToListAsync();
		}

		public async Task<bool> CreateAnNewUser(User user)
		{
			return await _userGeneric.Insert(user);
		}


	}
}
