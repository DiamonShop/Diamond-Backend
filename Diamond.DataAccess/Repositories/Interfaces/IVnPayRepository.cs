using Diamond.Entities.Model;
using DiamondShop.Model;
using Microsoft.AspNetCore.Http;

namespace DiamondShop.Repositories.Interfaces
{
	public interface IVnPayRepository
	{
		string CreatePaymentUrl(PaymentInformationModel model, HttpContext context);
		PaymentResponseModel PaymentExecute(IQueryCollection collections);
	}
}
