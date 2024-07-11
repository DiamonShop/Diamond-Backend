using Diamond.DataAccess.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DiamondShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        IBillRepository _billRepository;
        public BillController(IBillRepository billRepository)
        {
            _billRepository = billRepository;
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

        }*/

        [HttpGet("GetAllBills")]
        /*[Authorize(Roles = "Admin,Manager")]*/
        public async Task<IActionResult> GetAllBills()
        {
            var bills = await _billRepository.GetAllBills();

            if (bills == null) { return Ok(null); }

            return Ok(bills);
        }

        /*[HttpPut("UpdateBillIsActive/{billId}")]

        public async Task<IActionResult> UpdateBillIsActive(int billId, [FromBody] bool isActive)
        {

        }*/
    }
}
