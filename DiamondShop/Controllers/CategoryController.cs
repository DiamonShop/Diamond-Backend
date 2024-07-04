using Diamond.Entities.Data;
using Diamond.Entities.Model;
using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiamondShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        // Lấy tất cả thông tin sản phẩm
        [HttpGet("GetAllCategory")]
        public async Task<IActionResult> GetAllCategory()
        {
            var products = await _categoryRepository.GetAllCategories();

            if (products == null) { return Ok(null); }

            return Ok(products);
        }

        // Lấy thông tin sản phẩm theo ID
        [HttpGet("GetCategoryById")]
        /*[Authorize(Roles = "Manager,Staff,Delivery")]*/
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var products = await _categoryRepository.GetCategoryById(id);
            if (products != null)
            {
                return Ok(products);
            }

            return BadRequest("Product is not found");
        }

        // Tìm sản phẩm theo tên sản phẩm
        [HttpGet("GetCategoryByName")]
        public async Task<IActionResult> GetCategoryByName(string productName)
        {
            var products = await _categoryRepository.GetCategoryByName(productName);

            return Ok(products);
        }

        // Tạo sản phẩm mới
        [HttpPost("CreateCategory")]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> CreateCategory([FromBody] CategoryModel categoryModel)
        {
            bool result = await _categoryRepository.CreateCategory(categoryModel);

            if (result)
            {
                return Ok("Create Jewelry Successfully");
            }
            return BadRequest("Failed To Create Jewelry");
        }

        // Cập nhật sản phẩm
        [HttpPut("UpdateCategory")]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] CategoryModel categoryModel)
        {
            bool result = await _categoryRepository.UpdateCategory(id, categoryModel);

            if (result)
            {
                return Ok("Create Jewelry Successfully");
            }
            return BadRequest("Failed To Create Jewelry");
        }
    }
}
