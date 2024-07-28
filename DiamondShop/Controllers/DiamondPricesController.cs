using Diamond.DataAccess.Repositories.Interfaces;
using Diamond.Entities.Data;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiamondShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiamondPricesController : Controller
    {
        private readonly IDiamondPriceRepository _diamondPriceRepository;
        private readonly IDiamondUpdateService _diamondUpdateService;
        private readonly IDiamondsRepository _diamondsRepository;

        public DiamondPricesController(IDiamondPriceRepository diamondPriceRepository, IDiamondUpdateService diamondUpdateService, IDiamondsRepository diamondsRepository)
        {
            _diamondPriceRepository = diamondPriceRepository;
            _diamondUpdateService = diamondUpdateService;
            _diamondsRepository = diamondsRepository;
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

        [HttpPost("update-diamond-prices")]
        public async Task<IActionResult> UpdateDiamondPrices()
        {
            try
            {
                await _diamondUpdateService.UpdateAllDiamondPrices();
                return Ok(new { message = "Giá kim cương đã được cập nhật thành công." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Đã xảy ra lỗi khi cập nhật giá kim cương.", error = ex.Message });
            }
        }
        [HttpPut("update-price-by-properties")]
        public async Task<IActionResult> UpdateDiamondPriceByProperties(DiamondPrice updatedDiamondPrice)
        {
            if (updatedDiamondPrice == null)
            {
                return BadRequest("Invalid data.");
            }

            var existingDiamondPrice = await _diamondPriceRepository.GetDiamondPrice(
                updatedDiamondPrice.Carat, updatedDiamondPrice.Clarity, updatedDiamondPrice.Color, updatedDiamondPrice.Cut);

            if (existingDiamondPrice == null)
            {
                return NotFound("Diamond price not found.");
            }

            // Cập nhật giá kim cương
            existingDiamondPrice.Price = updatedDiamondPrice.Price;

            var result = await _diamondPriceRepository.UpdateDiamondPrice(existingDiamondPrice);
            if (!result)
            {
                return BadRequest("Failed to update diamond price.");
            }

            // Cập nhật giá sản phẩm liên quan
            var relatedDiamonds = await _diamondsRepository.GetDiamondProductsByProperties(
                updatedDiamondPrice.Carat, updatedDiamondPrice.Clarity, updatedDiamondPrice.Color, updatedDiamondPrice.Cut);

            foreach (var diamond in relatedDiamonds)
            {
                diamond.BasePrice = updatedDiamondPrice.Price;
                diamond.Product.MarkupPrice = (int)(updatedDiamondPrice.Price * diamond.Product.MarkupRate);
            }

            var updateResult = await _diamondsRepository.UpdateDiamonds(relatedDiamonds);
            if (!updateResult)
            {
                return BadRequest("Failed to update related product prices.");
            }

            return Ok("Diamond price and related product prices updated successfully.");
        }



    }
}
