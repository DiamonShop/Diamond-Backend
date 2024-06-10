﻿using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DiamondShop.Repositories.Interfaces;
using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories;

namespace DiamondShop.Controllers
{
	[Route("api/products")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductRepository _productRepository;

		public ProductController(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		// Lấy tất cả thông tin sản phẩm
		[HttpGet]
		public async Task<IActionResult> GetAllProducts()
		{
			var products = await _productRepository.GetAllProducts();
			if (products != null) { return Ok(products); }
			return NotFound();
		}


		// Lấy thông tin sản phẩm theo ID
		[HttpGet("GetProductById")]
		public async Task<IActionResult> GetProductById(int id)
		{
			var products = await _productRepository.GetProductById(id);
			if (products != null)
			{
				return Ok(await _productRepository.GetProductById(id));
			}

			return BadRequest("Product is not found");
		}

		// Tìm sản phẩm theo tên loại
		[HttpGet("GetProductsByCategoryName")]
		public async Task<IActionResult> GetProductsByCategoryName(string categoryName)
		{
			var products = await _productRepository.GetProductsByCategoryName(categoryName);

			if (products != null)
			{
				return Ok(products);
			}

			return NotFound("Product is not found");
		}

		// Tìm sản phẩm theo tên sản phẩm
		[HttpGet("GetProductsByName")]
		public async Task<IActionResult> GetProductsByName(string productName)
		{
			var products = await _productRepository.GetProductsByName(productName);

			if (products != null)
			{
				return Ok(products);
			}

			return NotFound();
		}

		// Lọc sản phẩm theo giá từ cao tới thấp
		[HttpGet("GetProductsByPriceDesc")]
		public async Task<IActionResult> GetProductsByPriceDesc()
		{
			var products = await _productRepository.GetProductsByPriceDesc();
			if (products != null)
			{
				return Ok(products);
			}
			return NotFound();
		}
		// Lọc sản phẩm theo giá từ thấp tới cao
		[HttpGet("GetProductsByPriceAsc")]
		public async Task<IActionResult> GetProductsByPriceAsc()
		{
			var products = await _productRepository.GetProductsByPriceAsc();
			if (products != null)
			{
				return Ok(products);
			}
			return NotFound();
		}

		// Tạo sản phẩm mới
		[HttpPost("CreateProduct")]
		public async Task<IActionResult> CreateProduct([FromBody] ProductViewModel productModel)
		{
			bool result = await _productRepository.CreateProduct(productModel);

			if (result)
			{
				return Ok("Create User Successfully");
			}
			return BadRequest("Failed To Create User");
		}

		// Cập nhật sản phẩm
		[HttpPut("UpdateProduct")]
		public async Task<IActionResult> UpdateProduct(int id, [FromBody] ProductViewModel productModel)
		{
			bool result = await _productRepository.UpdateProduct(id, productModel);

			if (result)
			{
				return Ok("Create User Successfully");
			}
			return BadRequest("Failed To Create User");
		}

		// Xóa sản phẩm
		[HttpDelete("DeleteProduct")]
		public async Task<IActionResult> DeleteProduct(int id)
		{
			bool result = await _productRepository.DeleteProduct(id);

			if (result)
			{
				return Ok("Create User Successfully");
			}
			return BadRequest("Failed To Create User");
		}
	}
}
