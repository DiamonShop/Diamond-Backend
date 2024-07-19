using Microsoft.AspNetCore.Mvc;
using DiamondShop.Repositories.Interfaces;
using DiamondShop.Model;
using Microsoft.AspNetCore.Authorization;
using DiamondShop.Data;

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
        [HttpGet("GetAllProduct")]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productRepository.GetAllProducts();

            if (products == null) { return NotFound("Product is empty"); }

            return Ok(products);
        }

        // Lấy tất cả thông tin sản phẩm


        // Lấy thông tin sản phẩm theo ID
        [HttpGet("GetProductById")]
        [Authorize(Roles = "Manager,Staff,Delivery")]
        public async Task<IActionResult> GetProductById(string id)
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

            return Ok(products);
        }

        // Lọc sản phẩm theo giá từ cao tới thấp
        [HttpGet("GetProductsByPriceDesc")]
        [Authorize(Roles = "Manager,Staff,Delivery,Member")]
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
        [Authorize(Roles = "Manager,Staff,Delivery,Member")]
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
        [Authorize(Roles = "Admin,Manager")]
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
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> UpdateProduct(string id, [FromBody] ProductViewModel productModel)
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
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            bool result = await _productRepository.DeleteProduct(id);


            return Ok("delete sucessfully");
        }

        // Cập nhật MarkupPrice của sản phẩm và cập nhật lại giá của Diamonds và Jewelry

        [HttpPut("UpdateAllMarkupRates")]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> UpdateAllMarkupRates([FromBody] UpdateMarkupRateDto dto)
        {
            var result = await _productRepository.UpdateAllMarkupRates(dto.NewMarkupRate);

            if (result)
            {
                return Ok("All MarkupRates updated successfully");
            }

            return BadRequest("Failed to update MarkupRates");
        }
        [HttpPut("UpdateMarkupRate")]
        public async Task<IActionResult> UpdateMarkupRate(string productId, [FromBody] int newMarkupRate)
        {
            var result = await _productRepository.UpdateMarkupRate(productId, newMarkupRate);

            if (result)
            {
                return Ok("MarkupRate updated successfully.");
            }
            else
            {
                return BadRequest("Failed to update MarkupRate.");
            }
        }
        [HttpGet("best-selling")]
        public async Task<ActionResult<List<ProductViewModel>>> GetBestSellingProducts(int topN = 10)
        {
            var products = await _productRepository.GetBestSellingProducts(topN);
            return Ok(products);
        }
    }
}

    

