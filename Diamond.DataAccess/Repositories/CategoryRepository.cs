using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace DiamondShop.Repositories
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly DiamondDbContext _context;

		public CategoryRepository(DiamondDbContext context)
		{
			_context = context;
		}

		public async Task<bool> CreateCategory(CategoryModel categoryModel)
		{
			if (categoryModel != null)
			{
				var category = new Category()
				{
					CategoryName = categoryModel.CategoryName,
				};

				_context.Categories.Add(category);
				await _context.SaveChangesAsync();
				return true;
			}
			return false;
		}

		public async Task<List<CategoryModel>> GetAllCategories()
		{
			var categories = await _context.Categories.ToListAsync();

			if (categories == null)
			{
				return null;
			}

			// Chuyển đổi danh sách người dùng sang UserViewModel để trả về
			var categoryModel = categories.Select(category => new CategoryModel
			{
				CategoryId = category.CategoryId,
				CategoryName = category.CategoryName
			}).ToList();

			return categoryModel;
		}

		public async Task<CategoryModel> GetCategoryById(int id)
		{
			var categories = await _context.Categories.FirstOrDefaultAsync(cate => cate.CategoryId.Equals(id));

			if (categories == null)
			{
				return null;
			}

			CategoryModel categoryModel = new CategoryModel()
			{
				CategoryId = categories.CategoryId,
				CategoryName = categories.CategoryName,
			};

			return categoryModel;
		}

		public async Task<List<CategoryModel>> GetCategoryByName(string name)
		{
			var category = await _context.Categories
				.Where(cate => cate.CategoryName!.Contains(name)) //Tìm gần đúng
				.ToListAsync();

			if (category == null)
			{
				return null!;
			}

			var categoryList = category.Select(cate => new CategoryModel
			{
				CategoryId = cate.CategoryId,
				CategoryName = cate.CategoryName,
			}).ToList();

			return categoryList;
		}

		public async Task<bool> UpdateCategory(int id, CategoryModel categoryModel)
		{
			var cate = await _context.Categories.FirstOrDefaultAsync(c => c.CategoryId.Equals(id));

			if (cate == null) // If category is null
			{
				return false;
			}

			try
			{
				cate.CategoryName = categoryModel.CategoryName;
				_context.Categories.Update(cate);
				// Save the changes to the database
				await _context.SaveChangesAsync();
			}
			catch (Exception ex)
			{
				return false;
			}
			return true; // Update succeeded
		}
	}
}
