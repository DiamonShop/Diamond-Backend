using DiamondShop.Data;
using DiamondShop.Model;

namespace DiamondShop.Repositories.Interfaces
{
	public interface ICategoryRepository
	{
		public Task<List<CategoryModel>> GetAllCategories();
		public Task<CategoryModel> GetCategoryById(int id);
		public Task<bool> CreateCategory(CategoryModel categoryModel);
		public Task<bool> UpdateCategory(int id, Category category);
		public Task<List<CategoryModel>> GetCategoryByName(string name);
	}
}
