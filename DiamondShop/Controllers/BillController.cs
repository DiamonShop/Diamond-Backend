using Diamond.Entities.DTO;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DiamondShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IBillRepository _billRepository;

        public BillController(IBillRepository billRepository)
        {
            _billRepository = billRepository;
        }

        [HttpPost("CreateBill")]
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> CreateBill([FromBody] BillCreateDTO billCreateDTO)
        {
            if (billCreateDTO == null)
            {
                return BadRequest("Invalid bill data.");
            }

            var createdBill = await _billRepository.CreateBill(billCreateDTO);
            return Ok(createdBill);
        }

        [HttpGet("GetBillById/{id}")]
        [Authorize(Roles = "Admin,Manager,Member")]
        public async Task<IActionResult> GetBillById(int id)
        {
            var bill = await _billRepository.GetBillById(id);
            if (bill == null)
            {
                return NotFound("Bill not found.");
            }
            return Ok(bill);
        }

        [HttpGet("GetAllBills")]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> GetAllBills()
        {
            var bills = await _billRepository.GetAllBills();
            return Ok(bills);
        }

        [HttpPut("UpdateBillIsActive/{billId}")]
        
        public async Task<IActionResult> UpdateBillIsActive(int billId, [FromBody] bool isActive)
        {
            var result = await _billRepository.UpdateBillIsActive(billId, isActive);

            if (result)
            {
                return Ok("Bill IsActive status updated successfully.");
            }
            else
            {
                return BadRequest("Failed to update Bill IsActive status.");
            }
        }
    }
}
