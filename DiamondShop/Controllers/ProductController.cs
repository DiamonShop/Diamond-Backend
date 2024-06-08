using DiamondShop.Data;
using FAMS.Entities.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DiamondShop.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : Controller
    {

        private readonly DiamondDbContext _context;

        public ProductController(DiamondDbContext context)
        {
            _context = context;
        }
        //lay all thong tin
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductDetail)
                .ToListAsync();
            return Ok(products);
        }
        //lay thong tin  theo IDproduct
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductDetail)
                .FirstOrDefaultAsync(p => p.ProductId == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
        //tao product moi
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetProductById), new { id = product.ProductId }, product);
            }
            return BadRequest(ModelState);
        }
        //update product 
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] Product product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Products.Any(p => p.ProductId == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        // xoa product 
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            product.IsActive = false;
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // tìm product theo category
        [HttpGet("category/{categoryName}")]
        public async Task<IActionResult> GetProductsByCategory(string categoryName)
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductDetail)
                .Where(p => p.Category.CategoryName == categoryName)
                .ToListAsync();
            if (products == null || products.Count == 0)
                    { 
                return NotFound();
            }
            return Ok(products);    
        }
        [HttpGet("search/{productName}")]
        public async Task<IActionResult> GetProductsByName(string productName)
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductDetail)
                .Where(p => p.ProductName.Contains(productName))
                .ToListAsync();

            if (products == null || products.Count == 0)
            {
                return NotFound();
            }

            return Ok(products);
        }
        [HttpGet("price/desc")]
        public async Task<IActionResult> GetProductsByPriceDesc()
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductDetail)
                .OrderByDescending(p => p.Price)
                .ToListAsync();

            if (products == null || products.Count == 0)
            {
                return NotFound();
            }

            return Ok(products);
        }

        // Lọc sản phẩm theo giá từ thấp tới cao
        [HttpGet("price/asc")]
        public async Task<IActionResult> GetProductsByPriceAsc()
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductDetail)
                .OrderBy(p => p.Price)
                .ToListAsync();

            if (products == null || products.Count == 0)
            {
                return NotFound();
            }

            return Ok(products);
        }
        // Tìm product theo chữ cái contains của ProductName
        [HttpGet("startswith/{letter}")]
        public async Task<IActionResult> GetProductsByFirstLetter(char letter)
        {
            var products = await _context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductDetail)
                .Where(p => p.ProductName.Contains(letter.ToString()))
                .ToListAsync();

            if (products == null || products.Count == 0)
            {
                return NotFound();
            }

            return Ok(products);
        }
    }
}

