using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DiamondShop.Data;
using Google;

namespace DiamondShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly DiamondDbContext _context;

        public BillController(DiamondDbContext context)
        {
            _context = context;
        }

        [HttpPost("CreateBill")]
        public async Task<IActionResult> CreateBill([FromBody] Bill bill)
        {
            if (ModelState.IsValid)
            {
                _context.Bills.Add(bill);
                await _context.SaveChangesAsync();
                return Ok(new { Message = "Bill created successfully", BillId = bill.BillId });
            }
            return BadRequest(ModelState);
        }
    }
}
