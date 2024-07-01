using Diamond.Entities.Data;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiamondShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiamondsController : ControllerBase
    {
        private readonly IDiamondsRepository _diamondsRepository;

        public DiamondsController(IDiamondsRepository diamondsRepository)
        {
            _diamondsRepository = diamondsRepository;
        }

        [HttpGet("GetAllDiamonds")]
        [Authorize(Roles = "Admin,Manager,Member")]
        public async Task<IActionResult> GetAllDiamonds()
        {
            var diamonds = await _diamondsRepository.GetAllDiamonds();
            return Ok(diamonds);
        }

        [HttpPost("CreateDiamond")]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> CreateDiamond([FromBody] Diamonds diamond)
        {
            if (diamond == null)
            {
                return BadRequest("Invalid diamond data.");
            }

            var createdDiamond = await _diamondsRepository.CreateDiamond(diamond);
            return Ok(createdDiamond);
        }

        [HttpPut("UpdateDiamond")]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> UpdateDiamond([FromBody] Diamonds diamond)
        {
            if (diamond == null)
            {
                return BadRequest("Invalid diamond data.");
            }

            var updatedDiamond = await _diamondsRepository.UpdateDiamond(diamond);
            if (updatedDiamond == null)
            {
                return NotFound("Diamond not found.");
            }
            return Ok(updatedDiamond);
        }
    }
}
