using Diamond.Entities.Model;
using DiamondShop.API.Libraries;
using DiamondShop.Data;
using DiamondShop.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Security.Policy;
using DiamondShop.Repositories.Interfaces;

namespace DiamondShop.Controllers
{
	public class VnPayRepository : IVnPayRepository
	{
		private readonly IConfiguration _configuration;

		public VnPayRepository(IConfiguration configuration)
		{
			_configuration = configuration;
		}
		public string CreatePaymentUrl(PaymentInformationModel model, HttpContext context)
		{
			var timeZoneById = TimeZoneInfo.FindSystemTimeZoneById(_configuration["TimeZoneId"]);
			var timeNow = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZoneById);
			var tick = DateTime.Now.Ticks.ToString();
			var pay = new VnPayLibrary();
			var urlCallBack = _configuration["PaymentCallBack:ReturnUrl"];

			pay.AddRequestData("vnp_Version", _configuration["Vnpay:Version"]);
			pay.AddRequestData("vnp_Command", _configuration["Vnpay:Command"]);
			pay.AddRequestData("vnp_TmnCode", _configuration["Vnpay:TmnCode"]);
			pay.AddRequestData("vnp_Amount", ((int)model.Amount * 100).ToString());
			pay.AddRequestData("vnp_CreateDate", timeNow.ToString("yyyyMMddHHmmss"));
			pay.AddRequestData("vnp_CurrCode", _configuration["Vnpay:CurrCode"]);
			pay.AddRequestData("vnp_IpAddr", pay.GetIpAddress(context));
			pay.AddRequestData("vnp_Locale", _configuration["Vnpay:Locale"]);
			pay.AddRequestData("vnp_OrderInfo", $"{model.Name} {model.OrderDescription} {model.Amount}");
			pay.AddRequestData("vnp_OrderType", model.ItemInOrder);
			pay.AddRequestData("vnp_ReturnUrl", urlCallBack);
			pay.AddRequestData("vnp_TxnRef", tick);

			var paymentUrl =
				pay.CreateRequestUrl(_configuration["Vnpay:BaseUrl"], _configuration["Vnpay:HashSecret"]);

			return paymentUrl;
		}

		public PaymentResponseModel PaymentExecute(IQueryCollection collections)
		{
			var pay = new VnPayLibrary();
			var response = pay.GetFullResponseData(collections, _configuration["Vnpay:HashSecret"]);

			return response;
		}
	}
}
