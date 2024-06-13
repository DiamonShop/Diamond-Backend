using Diamond.Entities.Model;
using DiamondShop.Model;
using Microsoft.AspNetCore.Http;

namespace DiamondShop.Controllers
{
	public interface IVnPayService
	{
		string CreatePaymentUrl(PaymentInformationModel model, HttpContext context);
		PaymentResponseModel PaymentExecute(IQueryCollection collections);
	}
}
