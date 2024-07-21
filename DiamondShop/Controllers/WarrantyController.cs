using Diamond.DataAccess.Repositories.Interfaces;
using Diamond.Entities.Model;
using DiamondShop.Data;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiamondShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarrantyController : ControllerBase
    {
        private readonly IWarrantyRepository _warrantyRepository;

        public WarrantyController(IWarrantyRepository warrantyRepository)
        {
            _warrantyRepository = warrantyRepository;
        }

        // Lấy tất cả thông tin sản phẩm
        [HttpGet("GetAllWarranties")]
        [Authorize(Roles = "Member,Manager")]
        public async Task<IActionResult> GetAllWarranties()
        {
            var warranty = await _warrantyRepository.GetAllWarranties();

            if (warranty == null) { return Ok(null); }

            return Ok(warranty);
        }

        // Lấy thông tin sản phẩm theo ID
        [HttpGet("GetWarrantyById")]
        /*[Authorize(Roles = "Manager,Staff,Delivery")]*/
        public async Task<IActionResult> GetWarrantyById(int warrantyId)
        {
            var warranty = await _warrantyRepository.GetWarrantyById(warrantyId);
            if (warranty != null)
            {
                return Ok(warranty);
            }

            return Ok(null);
        }

        // Tìm sản phẩm theo tên sản phẩm
        [HttpGet("GetWarrantyByUserId")]
        public async Task<IActionResult> GetWarrantyByUserId(int userId)
        {
            var warranty = await _warrantyRepository.GetWarrantyByUserId(userId);
            if (warranty != null)
            {
                return Ok(warranty);
            }
            return Ok(null);
        }

        // Tạo sản phẩm mới
        [HttpPost("CreateWarranty")]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> CreateCategory(int orderId, WarrantyCreateModel warrantyModel)
        {
            bool result = await _warrantyRepository.CreateWarranty(orderId, warrantyModel);

            if (result)
            {
                return Ok("Create Jewelry Successfully");
            }
            return Ok("Failed To Create Jewelry");
        }

        [HttpPut("UpdateCategory")]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> UpdateCategory(int warrantyId, [FromBody] WarrantyModel warrantyModel)
        {
            bool result = await _warrantyRepository.UpdateWarranty(warrantyId, warrantyModel);

            if (result)
            {
                return Ok("Create Jewelry Successfully");
            }
            return Ok("Failed To Create Jewelry");
        }
    }
}
