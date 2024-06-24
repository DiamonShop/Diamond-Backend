using Diamond.Entities.Data;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiamondShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JewelrySettingController : ControllerBase
    {
        private readonly IJewelrySettingRepository _jewelrySettingRepository;

        public JewelrySettingController(IJewelrySettingRepository jewelrySettingRepository)
        {
            _jewelrySettingRepository = jewelrySettingRepository;
        }

        [HttpGet("All")]
        public async Task<ActionResult<IEnumerable<JewelrySettings>>> GetAllJewelrySettings()
        {
            var jewelrySettings = await _jewelrySettingRepository.GetAllJewelrySettings();
            return Ok(jewelrySettings);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<JewelrySettings>> GetJewelrySettingById(int id)
        {
            var jewelrySetting = await _jewelrySettingRepository.GetJewelrySettingById(id);
            if (jewelrySetting == null)
            {
                return NotFound();
            }
            return Ok(jewelrySetting);
        }

        [HttpGet("search/{name}")]
        public async Task<ActionResult<IEnumerable<JewelrySettings>>> GetJewelrySettingsByName(string name)
        {
            var jewelrySettings = await _jewelrySettingRepository.GetJewelrySettingsByName(name);
            return Ok(jewelrySettings);
        }

        [HttpPost]
        public async Task<ActionResult> CreateJewelrySetting([FromBody] JewelrySettings jewelrySetting)
        {
            if (jewelrySetting == null)
            {
                return BadRequest();
            }

            var created = await _jewelrySettingRepository.CreateJewelrySetting(jewelrySetting);
            if (created)
            {
                return CreatedAtAction(nameof(GetJewelrySettingById), new { id = jewelrySetting.JewelrySettingID }, jewelrySetting);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateJewelrySetting(int id, [FromBody] JewelrySettings jewelrySetting)
        {
            if (jewelrySetting == null || id != jewelrySetting.JewelrySettingID)
            {
                return BadRequest();
            }

            var updated = await _jewelrySettingRepository.UpdateJewelrySetting(id, jewelrySetting);
            if (updated)
            {
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteJewelrySetting(int id)
        {
            var deleted = await _jewelrySettingRepository.DeleteJewelrySetting(id);
            if (deleted)
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
