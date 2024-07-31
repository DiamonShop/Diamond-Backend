using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DiamondShop.Data;
using DiamondShop.Model;
using Diamond.Entities.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using System.Threading.Tasks;
using System;
using Microsoft.Data.SqlClient;
using DiamondShop.Repositories;
using Diamond.DataAccess.Repositories.Interfaces;
using Microsoft.CodeAnalysis;
using Diamond.Entities.DTO;
using DiamondShop.API.Services;

namespace DiamondShop.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IVnPayRepository _vnPayRepo;
        private readonly BillService _billService;

        public OrderController(IOrderRepository context, IVnPayRepository vnPayRepo, BillService billService)
        {
            _orderRepository = context;
            _vnPayRepo = vnPayRepo;
            _billService = billService;
        }

        [HttpGet("GetAllOrders")]
        /*[Authorize(Roles = "Manager,Staff,Delivery")]*/
        public async Task<IActionResult> GetAllOrders()
        {
            return Ok(await _orderRepository.GetAllOrders());
        }

        [HttpGet("GetOrderById")]
        [Authorize(Roles = "Manager,Staff,Delivery")]
        public async Task<ActionResult<OrderViewModel>> GetOrderById(int orderId)
        {
            if (await _orderRepository.GetOrderById(orderId) == null)
            {
                return Ok("User is not found");
            }
            return Ok(await _orderRepository.GetOrderById(orderId));
        }

        [HttpGet("GetOrderByUserId")]
        /*[Authorize(Roles = "Manager,Staff,Delivery")]*/
        public async Task<IActionResult> GetOrderByUserId(int userId)
        {
            var apiResponse = await _orderRepository.GetOrderByUserId(userId);
            return Ok(apiResponse);
        }

        [HttpGet("GetHistoryOrderByUserId")]
        public async Task<IActionResult> GetHistoryOrderByUserId(int userId)
        {
            var apiResponse = await _orderRepository.GetHistoryOrderByUserId(userId);
            return Ok(apiResponse);
        }

        [HttpPost("CreatOrder")]
        /*[Authorize(Roles = "Manager,Staff,Member")]*/
        public async Task<IActionResult> CreateOrder(int userId)
        {
            var apiResponse = await _orderRepository.CreateOrder(userId);
            return Ok(apiResponse);
        }

        [HttpPost("AddProductToOrderDetail")]
        /*[Authorize(Roles = "Manager,Staff,Member")]*/
        public async Task<IActionResult> AddProductToOrderDetail(int orderId, string productId, int quantity)
        {
            bool result = await _orderRepository.AddProductToOrderDetail(orderId, productId, quantity);
            if (result)
            {
                return Ok("Add product to order detail successfully");
            }
            return Ok("Failed to add product to order detail");
        }

        [HttpGet("GetAllOrderDetail")]
        /*[Authorize(Roles = "Manager,Staff,Member")]*/
        public async Task<IActionResult> GetAllOrderDetail()
        {
            return Ok(await _orderRepository.GetAllOrderDetail());
        }

        [HttpPut("UpdateTotalPrice")]
        /*[Authorize(Roles = "Manager,Staff,Member")]*/
        public async Task<IActionResult> UpdateTotalPrice(int orderId, int totalPrice)
        {
            bool result = await _orderRepository.UpdateOrder(orderId, totalPrice);
            return Ok(result);
        }

        [HttpPut("UpdateOrderDetail")]
        /*[Authorize(Roles = "Manager,Staff,Member")]*/
        public async Task<IActionResult> UpdateOrderDetail(string orderDetailId, int quantity)
        {
            bool result = await _orderRepository.UpdateOrderDetail(orderDetailId, quantity);
            if (result)
            {
                return Ok("Update Order successfully");
            }
            return Ok("Failed to Update Order");
        }

        [HttpDelete("DeleteOrderDetail")]
        /*[Authorize(Roles = "Manager,Staff,Member")]*/
        public async Task<IActionResult> DeleteOrderDetail(string orderDetailId)
        {
            bool result = await _orderRepository.DeleteOrderDetail(orderDetailId);
            if (result)
            {
                return Ok("Delete Order Detail successfully");
            }
            return Ok("Failed to Delete Order Detail");
        }

        [HttpPut("UpdateStatusCompleted")]
        /*[Authorize(Roles = "Manager,Staff,Delivery")]*/
        public async Task<IActionResult> UpdateStatusCompleted(int orderId)
        {
            bool result = await _orderRepository.UpdateStatusCompleted(orderId);
            if (result)
            {
                return Ok("Update status Order successfully");
            }
            return Ok("Failed to Update status Order");
        }

        [HttpPut("UpdateStatusCancel")]
        /*[Authorize(Roles = "Manager,Staff,Delivery")]*/
        public async Task<IActionResult> UpdateStatusCancel(int orderId, string cancelReason)
        {
            bool result = await _orderRepository.UpdateStatusCancel(orderId, cancelReason);
            if (result)
            {
                return Ok("Update status Order successfully");
            }
            return Ok("Failed to Update status Order");
        }
        /*
		[HttpPost("Checkout")]
		public IActionResult CreatePaymentUrl(PaymentInformationModel model)
		{
			var billCreateDTO = new BillCreateDTO
			{
				UserId = model.userId,
				FullName = model.fullName,
				NumberPhone = model.phoneNumber.ToString(),
				Email = model.email,
				Address = model.streetAddress,
				OrderNote = model.orderNote,
				IsActive = true,
				Price = model.price
			};

			_billService.SaveBill(billCreateDTO);

			var url = _vnPayRepo.CreatePaymentUrl(model, HttpContext);
			return Ok(url);
		}*/
        [HttpPost("Checkout")]
        public IActionResult CreatePaymentUrl(PaymentInformationModel model)
        {
            var url = _vnPayRepo.CreatePaymentUrl(model, HttpContext);
            return Ok(url);
        }


        [HttpGet("result")]
        public async Task<IActionResult> PaymentCallback()
        {
            var response = _vnPayRepo.PaymentExecute(Request.Query);
            var successUrl = "http://localhost:3000/Thanhtoanthanhcong";
            var failureUrl = "http://localhost:3000/?message=Payment%20Failed";

            if (response.VnPayResponseCode.Equals("00"))
            {
                return Redirect(successUrl);
            }
            else
            {
                return Redirect(failureUrl);
            }
        }

        [HttpPut("UpdateStatusToPending")]
        public async Task<IActionResult> UpdateStatusToPending(int userId)
        {
            bool result = await _orderRepository.UpdateStatusToPending(userId);
            if (result)
            {
                return Ok("Update status to pending successfully");
            }
            return Ok("Failed to Update status Order");
        }

        [HttpPut("UpdateStatusToShipping")]
        public async Task<IActionResult> UpdateStatusToShipping(int orderId)
        {
            bool result = await _orderRepository.UpdateStatusToShipping(orderId);
            if (result)
            {
                return Ok("Update status to shipping successfully");
            }
            return Ok("Failed to Update status Order");
        }

        [HttpGet("GetOrderByUserIdOrderId")]
		public async Task<IActionResult> GetOrderByUserIdOrderId(int userId, int orderId)
		{
			var apiResponse = await _orderRepository.GetOrderByUserIdOrderId(userId, orderId);
			return Ok(apiResponse);
		}

		[HttpGet("GetLatestOrderByUserId")]
		public async Task<IActionResult> GetLatestOrderByUserId(int userId)
		{
			var apiResponse = await _orderRepository.GetLatestOrderByUserId(userId);
			return Ok(apiResponse);
		}
        [HttpGet("orders/count")]
        public async Task<IActionResult> GetOrderCountByMonth([FromQuery] int month, [FromQuery] int year)
        {
            var orderCount = await _orderRepository.GetOrderCountByMonth(month, year);
            return Ok(orderCount);
        }

        [HttpGet("orders/revenue")]
        public async Task<IActionResult> GetRevenueByMonth([FromQuery] int month, [FromQuery] int year)
        {
            var revenue = await _orderRepository.GetRevenueByMonth(month, year);
            return Ok(revenue);
        }

        [HttpGet("orders/sales-by-category")]
        public async Task<IActionResult> GetProductSalesByCategory([FromQuery] int month, [FromQuery] int year)
        {
            var salesByCategory = await _orderRepository.GetProductSalesByCategory(month, year);
            return Ok(salesByCategory);
        }

		[HttpPut("UpdateOrderNoteByUserId")]
		public async Task<IActionResult> UpdateOrderNote(int userId, string note)
		{
			bool result = await _orderRepository.UpdateOrderNote(userId, note);
			if (result)
			{
				return Ok("Update note successfully.");
			}
			return BadRequest("Update note failed.");
		}
	}

}
