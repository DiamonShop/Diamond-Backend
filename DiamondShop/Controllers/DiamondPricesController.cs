using Diamond.DataAccess.Repositories.Interfaces;
using Diamond.Entities.Data;
using Microsoft.AspNetCore.Mvc;

namespace DiamondShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiamondPricesController : Controller
    {
        private readonly IDiamondPriceRepository _diamondPriceRepository;

        public DiamondPricesController(IDiamondPriceRepository diamondPriceRepository)
        {
            _diamondPriceRepository = diamondPriceRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DiamondPrice>>> GetAllDiamondPrices()
        {
            var diamondPrices = await _diamondPriceRepository.GetAllDiamondPrices();
            return Ok(diamondPrices);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DiamondPrice>> GetDiamondPriceById(int id)
        {
            var diamondPrice = await _diamondPriceRepository.GetDiamondPriceById(id);
            if (diamondPrice == null)
            {
                return NotFound();
            }
            return Ok(diamondPrice);
        }

        [HttpPost]
        public async Task<ActionResult> CreateDiamondPrice(DiamondPrice diamondPrice)
        {
            var result = await _diamondPriceRepository.CreateDiamondPrice(diamondPrice);
            if (result)
            {
                return Ok("Diamond price created successfully");
            }
            return BadRequest("Failed to create diamond price");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDiamondPrice(int id, DiamondPrice diamondPrice)
        {
            if (id != diamondPrice.Id)
            {
                return BadRequest();
            }

            var result = await _diamondPriceRepository.UpdateDiamondPrice(diamondPrice);
            if (result)
            {
                return Ok("Diamond price updated successfully");
            }
            return BadRequest("Failed to update diamond price");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiamondPrice(int id)
        {
            var result = await _diamondPriceRepository.DeleteDiamondPrice(id);
            if (result)
            {
                return Ok("Diamond price deleted successfully");
            }
            return BadRequest("Failed to delete diamond price");
        }
  
        [HttpGet("Pricesdiamonds")]
        public async Task<ActionResult<IEnumerable<object>>> GetDiamondsWithPrices()
        {
            var diamondsGrouped = await _diamondPriceRepository.GetDiamondsGroupedByDiameter();

            var result = diamondsGrouped.Select(group => new
            {
                DiameterMM = group.Key,
                Diamonds = group.Select(d => new
                {
                    d.Clarity,
                    d.Cut,
                    d.Color,
                    d.Price,
                    d.Carat 
                })
            });

            return Ok(result);
        }


    }
}
