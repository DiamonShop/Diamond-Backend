using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DiamondShop.Data;
using FAMS.Entities.Data;
using Microsoft.AspNetCore.Cors;
namespace DiamondShop.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : Controller
    {

        private readonly DiamondDbContext _context;

        public CategoryController(DiamondDbContext context)
        {
            _context = context;
        }

		[EnableCors("AllowSpecificOrigin")]
		[HttpGet("GetAllCategories")]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost("CreateACategory")]
        public async Task<IActionResult> CreateCategory([FromBody] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetCategoryById), new { id = category.CategoryId }, category);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] Category category)
        {
            if (id != category.CategoryId)
            {
                return BadRequest();
            }

            _context.Entry(category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Categories.Any(c => c.CategoryId == id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

