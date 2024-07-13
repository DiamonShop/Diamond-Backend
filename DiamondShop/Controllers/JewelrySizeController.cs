using Diamond.DataAccess.Repositories.Interfaces;
using Diamond.Entities.Model;
using DiamondShop.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiamondShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JewelrySizeController : ControllerBase
    {
        private readonly IJewelrySizeRepository _jewelrySizeRepository;

        public JewelrySizeController(IJewelrySizeRepository jewelrySizeRepository)
        {
            _jewelrySizeRepository = jewelrySizeRepository;
        }
        // GET: api/<JewelrySizeController>
        // Tạo sản phẩm mới

        [HttpGet("GetAllJewelrySize")]
        public async Task<IActionResult> GetAllJewelrySize()
        {
            var products = await _jewelrySizeRepository.GetAllJewelrySize();

            if (products == null) { return Ok(null); }

            return Ok(products);
        }

        [HttpPost("CreateJewelrySize")]
        /*[Authorize(Roles = "Admin,Manager")]*/
        public async Task<IActionResult> CreateJewelrySize([FromBody] JewelrySizeModel jewelrySizeModel)
        {
            bool result = await _jewelrySizeRepository.CreateJewelrySize(jewelrySizeModel);

            if (result)
            {
                return Ok("Create Jewelry Size Successfully");
            }
            return BadRequest("Failed To Create Jewelry Size");
        }
    }
}
