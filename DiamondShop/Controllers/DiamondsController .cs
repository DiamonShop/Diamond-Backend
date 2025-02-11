﻿using Microsoft.AspNetCore.Mvc;
using DiamondShop.Data;
using Microsoft.AspNetCore.Cors;
using DiamondShop.Repositories.Interfaces;
using DiamondShop.Model;
using Microsoft.AspNetCore.Authorization;
using Diamond.Entities.Model;
using Diamond.Entities.Data;
using DiamondShop.Repositories;
namespace DiamondShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiamondsController : Controller
    {
        private readonly IDiamondsRepository _diamondRepository;

        public DiamondsController(IDiamondsRepository diamondRepository)
        {
            _diamondRepository = diamondRepository;
        }

        // Lấy tất cả thông tin sản phẩm
        [HttpGet("GetAllDiamond")]
        public async Task<IActionResult> GetAllDiamond()
        {
            var products = await _diamondRepository.GetAllDiamonds();

            if (products == null) { return Ok("null"); }

            return Ok(products);
        }

        // Lấy thông tin sản phẩm theo ID
        [HttpGet("GetDiamondById")]
        /*[Authorize(Roles = "Manager,Staff,Delivery")]*/
        public async Task<IActionResult> GetDiamondById(int id)
        {
            var products = await _diamondRepository.GetDiamondById(id);
            if (products != null)
            {
                return Ok(products);
            }

            return Ok(null);
        }

        [HttpGet("GetDiamondByProductId")]
        /*[Authorize(Roles = "Manager,Staff,Delivery")]*/
        public async Task<IActionResult> GetDiamondByProductId(string productId)
        {
            var products = await _diamondRepository.GetDiamondByProductId(productId);
            if (products != null)
            {
                return Ok(products);
            }

            return Ok(null);
        }

        // Tìm sản phẩm theo tên sản phẩm
        [HttpGet("GetDiamondByName")]
        public async Task<IActionResult> GetDiamondByName(string productName)
        {
            var products = await _diamondRepository.GetDiamondByName(productName);

            return Ok(products);
        }

        // Lọc sản phẩm theo giá từ cao tới thấp
        [HttpGet("GetDiamondByPriceDesc")]
        [Authorize(Roles = "Manager,Staff,Delivery,Member")]
        public async Task<IActionResult> GetDiamondByPriceDesc()
        {
            var products = await _diamondRepository.GetDiamondByPriceDesc();
            if (products != null)
            {
                return Ok(products);
            }
            return NotFound();
        }

        // Lọc sản phẩm theo giá từ thấp tới cao
        [HttpGet("GetDiamondByPriceAsc")]
        [Authorize(Roles = "Manager,Staff,Delivery,Member")]
        public async Task<IActionResult> GetDiamondByPriceAsc()
        {
            var products = await _diamondRepository.GetDiamondByPriceAsc();
            if (products != null)
            {
                return Ok(products);
            }
            return NotFound();
        }

        // Tạo sản phẩm mới
        [HttpPost("CreateDiamond")]
        /*[Authorize(Roles = "Admin,Manager")]*/
        public async Task<IActionResult> CreateDiamond(DiamondModel diamondModel)
        {
            bool result = await _diamondRepository.CreateDiamond(diamondModel);

            if (result)
            {
                return Ok("Create Jewelry Successfully");
            }
            return BadRequest("Failed To Create Jewelry");
        }

        // Cập nhật sản phẩm
        [HttpPut("UpdateDiamond")]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> UpdateDiamond([FromBody] DiamondModel diamondModel)
        {
            bool result = await _diamondRepository.UpdateDiamond(diamondModel);

            if (result)
            {
                return Ok("Update Jewelry Successfully");
            }
            return Ok("Failed To Update Jewelry");
        }

        // Xóa sản phẩm
        [HttpDelete("DeleteDiamond")]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> DeleteDiamond(int id)
        {
            bool result = await _diamondRepository.DeleteDiamond(id);


            return Ok("Delete Jewelry sucessfully");
        }

        [HttpGet("GetDiamondCountByDiameter")]
        public async Task<IActionResult> GetDiamondCountByDiameter(decimal diameterMM)
        {
            var count = await _diamondRepository.GetDiamondCountByDiameter(diameterMM);
            return Ok(count);
        }

        [HttpGet("getallMaindiamond")]
        public ActionResult<IEnumerable<MainDiamond>> GetAllMainDiamonds()
        {
            var mainDiamonds = _diamondRepository.GetAllMainDiamonds();
            return Ok(mainDiamonds);
        }

        [HttpGet("getallsidediamonds")]
        public ActionResult<IEnumerable<SideDiamond>> GetAllSideDiamonds()
        {
            var sideDiamonds = _diamondRepository.GetAllSideDiamonds();
            return Ok(sideDiamonds);

        }

        [HttpPut("UpdateDiamondQuantity")]
        public async Task<IActionResult> UpdateDiamondQuantity(int userId)
        {
            bool result = await _diamondRepository.UpdateDiamondQuantity(userId);
			if (result)
			{
				return Ok("Update quantity successfully.");
			}
			return BadRequest("Failed to update quantity");
		}
        [HttpGet("GetDiamondsBySize")]
        public async Task<IActionResult> GetDiamondsBySize(decimal size)
        {
            var diamonds = await _diamondRepository.GetDiamondsBySize(size);

            if (diamonds == null || diamonds.Count == 0)
            {
                return NotFound(new { message = "Diamonds not found for the specified size." });
            }

            return Ok(diamonds);
        }
        [HttpPost("CreateDiamondWithPrice")]
        public async Task<IActionResult> CreateDiamondWithPrice([FromBody] DiamondModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var result = await _diamondRepository.CreateDiamondWithPrice(model);
                    if (result)
                    {
                        return Ok("Diamond created successfully");
                    }
                    return BadRequest("Error creating diamond");
                }
                catch (Exception ex)
                {
                    return BadRequest($"Error creating diamond: {ex.Message}");
                }
            }
            var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage).ToList();
            return BadRequest(errors);
        }



    }
}

