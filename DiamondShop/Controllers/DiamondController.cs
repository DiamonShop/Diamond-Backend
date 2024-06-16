using Diamond.DataAccess.Repositories.Interfaces;
using Diamond.Entities.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiamondShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiamondController : ControllerBase
    {
        private readonly IDiamondRepository _repository;

        public DiamondController() { }

        // GET api/<DiamondController>/5
        [HttpGet("GetAllDiamonds")]
        public async Task<IActionResult> GetAllDiamonds()
        {
            var diamonds = await _repository.GetAllDiamonds();

            if(diamonds == null)
            {
                return BadRequest("Diamond is empty");
            }

            return Ok(diamonds);
        }

        [HttpGet("GetDiamondById")]
        public Task<IActionResult> GetDiamondById()
        {
            var diamonds = await _repository.GetDiamondById();



            return;
        }

        [HttpGet("GetDiamondByName")]
        public Task<IActionResult> GetDiamondByName()
        {
            var diamonds = await _repository.GetDiamondByName();



            return;
        }

        // POST api/<DiamondController>
        [HttpPost("CreateDiamond")]
        public Task<IActionResult> CreateDiamond([FromBody] DiamondModel diamondModel)
        {

        }

        // PUT api/<DiamondController>/5
        [HttpPut("UpdateDiamond")]
        public Task<IActionResult> UpdateDiamond(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DiamondController>/5
        [HttpDelete("DeleteDiamond")]
        public Task<IActionResult> DeleteDiamond(int id)
        {
        }
    }
}
