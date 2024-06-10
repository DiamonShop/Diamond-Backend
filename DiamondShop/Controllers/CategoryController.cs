using Microsoft.AspNetCore.Mvc;
using DiamondShop.Data;
using Microsoft.AspNetCore.Cors;
using DiamondShop.Repositories.Interfaces;
using DiamondShop.Model;
namespace DiamondShop.Controllers
{
	[Route("api/categories")]
	[ApiController]
	public class CategoryController : Controller
	{
		private readonly ICategoryRepository _cateRepository;

		public CategoryController(ICategoryRepository cateRepository)
		{
			_cateRepository = cateRepository;
		}

		/*[EnableCors("AllowSpecificOrigin")]*/
		[HttpGet("GetAllCategories")]
		public async Task<IActionResult> GetAllCategories()
		{
			return Ok(await _cateRepository.GetAllCategories());
		}

		[HttpGet("GetCategoryById")]
		public async Task<IActionResult> GetCategoryById(int id)
		{
			var category = await _cateRepository.GetCategoryById(id);
			if (category != null)
			{
				return Ok(category);
			}
			return BadRequest("Category is not found");
		}

		[HttpGet("GetCategoryByName")]
		public async Task<IActionResult> GetCategoryByName(string name)
		{
			var category = await _cateRepository.GetCategoryByName(name);
			if (category != null)
			{
				return Ok(category);
			}
			return BadRequest("Category is not found");
		}

		[HttpPost("CreateACategory")]
		public async Task<IActionResult> CreateCategory([FromBody] CategoryModel categoryModel)
		{
			bool result = await _cateRepository.CreateCategory(categoryModel);
			if (result)
			{
				return Ok("Category created successfully");
			}
			return BadRequest("Category cannot be null");
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateCategory(int id, [FromBody] Category category)
		{
			bool result = await _cateRepository.UpdateCategory(id, category);
			if (result)
			{
				return Ok("Category updated successfully");
			}
			return BadRequest("Category cannot be null");
		}
	}
}

