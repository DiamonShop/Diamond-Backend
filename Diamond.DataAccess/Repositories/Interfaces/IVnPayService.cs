using DiamondShop.Model;
using Microsoft.AspNetCore.Http;

namespace DiamondShop.Controllers
{
	public interface IVnPayService
	{
		string CreatePaymentUrl(HttpContext context, VnPaymentRequestModel model);
		VnPaymentResponseModel PaymentExecute(IQueryCollection collections);
	}
}
