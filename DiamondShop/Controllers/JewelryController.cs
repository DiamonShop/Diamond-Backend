using Diamond.DataAccess.Repositories.Interfaces;
using Diamond.Entities.Model;
using DiamondShop.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiamondShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JewelryController : ControllerBase
    {
        private readonly IJewelryRepository _jewelryRepository;

        public JewelryController(IJewelryRepository jewelryRepository)
        {
            _jewelryRepository = jewelryRepository;
        }

        // Lấy tất cả thông tin sản phẩm
        [HttpGet("GetAllJewelry")]
        public async Task<IActionResult> GetAllJewelry()
        {
            var products = await _jewelryRepository.GetAllJewelry();

            if (products == null) { return NotFound(null); }

            return Ok(products);
        }

        // Lấy thông tin sản phẩm theo ID
        [HttpGet("GetJewelryById")]
        /*[Authorize(Roles = "Manager,Staff,Delivery")]*/
        public async Task<IActionResult> GetJewelryById(int id)
        {
            var products = await _jewelryRepository.GetJewelryById(id);
            if (products != null)
            {
                return Ok(products);
            }

            return BadRequest("Product is not found");
        }

        [HttpGet("GetJewelryByProductId")]
        /*[Authorize(Roles = "Manager,Staff,Delivery")]*/
        public async Task<IActionResult> GetJewelryByProductId(string productId)
        {
            var products = await _jewelryRepository.GetJewelryByProductId(productId);
            if (products != null)
            {
                return Ok(products);
            }

            return Ok(null);
        }

        // Tìm sản phẩm theo tên loại
        [HttpGet("GetJewelryByCategoryName")]
        public async Task<IActionResult> GetJewelryByCategoryName(string categoryName)
        {
            var products = await _jewelryRepository.GetJewelryByCategoryName(categoryName);

            if (products != null)
            {
                return Ok(products);
            }

            return NotFound("Product is not found");
        }

        // Tìm sản phẩm theo tên sản phẩm
        [HttpGet("GetJewelryByName")]
        public async Task<IActionResult> GetJewelryByName(string productName)
        {
            var products = await _jewelryRepository.GetJewelryByName(productName);

            return Ok(products);
        }

        // Lọc sản phẩm theo giá từ cao tới thấp
        [HttpGet("GetJewelryByPriceDesc")]
        [Authorize(Roles = "Manager,Staff,Delivery,Member")]
        public async Task<IActionResult> GetJewelryByPriceDesc()
        {
            var products = await _jewelryRepository.GetJewelryByPriceDesc();
            if (products != null)
            {
                return Ok(products);
            }
            return NotFound();
        }

        // Lọc sản phẩm theo giá từ thấp tới cao
        [HttpGet("GetJewelryByPriceAsc")]
        [Authorize(Roles = "Manager,Staff,Delivery,Member")]
        public async Task<IActionResult> GetJewelryByPriceAsc()
        {
            var products = await _jewelryRepository.GetJewelryByPriceAsc();
            if (products != null)
            {
                return Ok(products);
            }
            return NotFound();
        }

        // Tạo sản phẩm mới
        [HttpPost("CreateJewelry")]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> CreateJewelry([FromBody] JewelryModel jewelryModel)
        {
            bool result = await _jewelryRepository.CreateJewelry(jewelryModel);

            if (result)
            {
                return Ok("Create Jewelry Successfully");
            }
            return BadRequest("Failed To Create Jewelry");
        }

        // Cập nhật sản phẩm
        [HttpPut("UpdateJewelry")]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> UpdateJewelry(int id, [FromBody] JewelryModel jewelryModel)
        {
            bool result = await _jewelryRepository.UpdateJewelry(id, jewelryModel);

            if (result)
            {
                return Ok("Create Jewelry Successfully");
            }
            return BadRequest("Failed To Create Jewelry");
        }

        // Xóa sản phẩm
        [HttpDelete("DeleteJewelry")]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> DeleteJewelry(int id)
        {
            bool result = await _jewelryRepository.DeleteJewelry(id);


            return Ok("Delete Jewelry sucessfully");
        }
    }
}
