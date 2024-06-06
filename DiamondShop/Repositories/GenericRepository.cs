using DiamondShop.Repositories.Interfaces;
using FAMS.Entities.Data;
using Microsoft.EntityFrameworkCore;

namespace DiamondShop.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private readonly DiamondDbContext _context;

		public GenericRepository(DiamondDbContext context)
		{
			_context = context;
		}

		public async Task<List<T>> GetAll()
		{
			try
			{
				return await _context.Set<T>().ToListAsync();
			}catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			return null;
		}

		public async Task<T> GetById(string id)
		{
			return await _context.FindAsync<T>(id);
		}

		public async Task<bool> Insert(T entity)
		{
			await _context.AddAsync<T>(entity);
			// If Inserted succesfully, return true, otherwise, false
			return await _context.SaveChangesAsync() > 0;
		}

		public async Task<bool> Update(T entity)
		{
			_context.Update<T>(entity);
			// If updated succesfully, return true, otherwise, false
			return await _context.SaveChangesAsync() > 0;
		}

	 	public async Task<bool> Delete(string id)
		{
			try
			{
				var entityID = await GetById(id);

				if(entityID != null)
				{
					_context.Remove<T>(entityID);
					return await _context.SaveChangesAsync() > 0;
				}else
				{
					Console.WriteLine("User not found for deletion");
					return false;
				}
			}catch (Exception ex)
			{
				Console.WriteLine("An error occurred while deleting user" + ex.Message);
				return false;
			}
		}

	}
}
