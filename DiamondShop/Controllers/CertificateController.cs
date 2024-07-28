using Diamond.DataAccess.Repositories.Interfaces;
using DiamondShop.Repositories;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DiamondShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CertificateController : ControllerBase
    {
        private readonly ICertificateRepository _certificateRepository;

        public CertificateController(ICertificateRepository certificateRepository)
        {
            _certificateRepository = certificateRepository;
        }

        [HttpGet("GetCertificateByUserId")]
        public async Task<IActionResult> GetCertificateByUserId(int userId)
        {
            var products = await _certificateRepository.GetCertificateByUserId(userId);

            if (products == null) { return Ok(null); }

            return Ok(products);
        }
    }
}
