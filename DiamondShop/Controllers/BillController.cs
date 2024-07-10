using Microsoft.AspNetCore.Mvc;

namespace DiamondShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {

        public BillController()
        {
            
        }

        /*[HttpPost("CreateBill")]
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> CreateBill([FromBody] BillCreateDTO billCreateDTO)
        {
            
        }

        [HttpGet("GetBillById/{id}")]
        [Authorize(Roles = "Admin,Manager,Member")]
        public async Task<IActionResult> GetBillById(int id)
        {
            
        }

        [HttpGet("GetAllBills")]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> GetAllBills()
        {
            
        }

        [HttpPut("UpdateBillIsActive/{billId}")]
        
        public async Task<IActionResult> UpdateBillIsActive(int billId, [FromBody] bool isActive)
        {
            
        }*/
    }
}
