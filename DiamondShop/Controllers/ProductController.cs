using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DiamondShop.Repositories.Interfaces;
using DiamondShop.Data;
using DiamondShop.Model;

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
            var productViewModels = products.Select(static p => new ProductViewModel
            {
                ProductId = p.ProductId,
                Price = p.Price,
                ProductName = p.ProductName
            }).ToList();
            return Ok(productViewModels);
        }


        // Lấy thông tin sản phẩm theo ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _productRepository.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            var productViewModel = new ProductViewModel
            {
                ProductId = product.ProductId,
                Price = product.Price,
                ProductName = product.ProductName
            };

            return Ok(productViewModel);
        }


        // Tạo sản phẩm mới
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] Product product)
        {
            if (ModelState.IsValid)
            {
                await _productRepository.CreateProduct(product);
                return CreatedAtAction(nameof(GetProductById), new { id = product.ProductId }, product);
            }
            return BadRequest(ModelState);
        }

        // Cập nhật sản phẩm
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] Product product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }

            await _productRepository.UpdateProduct(product);

            return NoContent();
        }

        // Xóa sản phẩm
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var existingProduct = await _productRepository.GetProductById(id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            await _productRepository.DeleteProduct(id);

            return NoContent();
        }

        // Tìm sản phẩm theo tên loại
        [HttpGet("category/{categoryName}")]
        public async Task<IActionResult> GetProductsByCategoryName(string categoryName)
        {
            var products = await _productRepository.GetProductsByCategoryName(categoryName);

            if (products == null || !products.Any())
            {
                return NotFound();
            }

            return Ok(products);
        }

        // Tìm sản phẩm theo tên sản phẩm
        [HttpGet("search/{productName}")]
        public async Task<IActionResult> GetProductsByName(string productName)
        {
            var products = await _productRepository.GetProductsByName(productName);

            if (products == null || !products.Any())
            {
                return NotFound();
            }

            return Ok(products);
        }

        // Tìm sản phẩm theo chữ cái đầu tiên của tên sản phẩm
        [HttpGet("startswith/{letter}")]
        public async Task<IActionResult> GetProductsByFirstLetter(char letter)
        {
            var products = await _productRepository.GetProductsByFirstLetter(letter);

            if (products == null || !products.Any())
            {
                return NotFound();
            }

            return Ok(products);
        }

        // Lọc sản phẩm theo giá từ cao tới thấp
        [HttpGet("price/desc")]
        public async Task<IActionResult> GetProductsByPriceDesc()
        {
            var products = await _productRepository.GetProductsByPriceDesc();
            var productViewModels = products.Select(static p => new ProductViewModel
            {
                ProductId = p.ProductId,
                Price = p.Price,
                ProductName = p.ProductName
            }).ToList();
            return products != null && products.Any() ? Ok(productViewModels) : NotFound("No products found");
        }

        [HttpGet("price/asc")]
        public async Task<IActionResult> GetProductsByPriceAsc()
        {
            var products = await _productRepository.GetProductsByPriceAsc();
            var productViewModels = products.Select(static p => new ProductViewModel
            {
                ProductId = p.ProductId,
                Price = p.Price,
                ProductName = p.ProductName
            }).ToList();
            return products != null && products.Any() ? Ok(productViewModels) : NotFound("No products found");
        }

        // Tìm sản phẩm theo từ khóa tương tự với tên sản phẩm
        [HttpGet("similar/{keyword}")]
        public async Task<IActionResult> GetProductsBySimilarName(string keyword)
        {
            var products = await _productRepository.GetProductsBySimilarName(keyword);

            if (products == null || !products.Any())
            {
                return NotFound();
            }

            return Ok(products);
        }
    }
}
