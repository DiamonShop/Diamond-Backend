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

namespace DiamondShop.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IVnPayRepository _vnPayRepo;

        public OrderController(IOrderRepository context, IVnPayRepository vnPayRepo)
        {
            _orderRepository = context;
            _vnPayRepo = vnPayRepo;
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

        [HttpPut("UpdateTotalPrice")]
        /*[Authorize(Roles = "Manager,Staff,Member")]*/
        public async Task<IActionResult> UpdateTotalPrice(int orderId, int totalPrice)
        {
            bool result = await _orderRepository.UpdateOrder(orderId, totalPrice);
            if (result)
            {
                return Ok("Update Order successfully");
            }
            return Ok("Failed to Update Order");
        }

        [HttpPut("UpdateOrderDetail")]
        /*[Authorize(Roles = "Manager,Staff,Member")]*/
        public async Task<IActionResult> UpdateOrderDetail(int orderDetailId, int quantity)
        {
            bool result = await _orderRepository.UpdateOrderDetail(orderDetailId, quantity);
            if (result)
            {
                return Ok("Update Order successfully");
            }
            return Ok("Failed to Update Order");
        }

        [HttpDelete("UpdateStatus")]
        [Authorize(Roles = "Manager,Staff,Delivery")]
        public async Task<IActionResult> UpdateStatus(int orderId)
        {
            bool result = await _orderRepository.UpdateStatus(orderId);
            if (result)
            {
                return Ok("Update status Order successfully");
            }
            return Ok("Failed to Update status Order");
        }

        [HttpPost("Checkout")]
        //[Authorize(Roles = "Manager")]
        /*[Authorize(Roles = "Manager,Staff,Member")]*/
        public IActionResult CreatePaymentUrl(PaymentInformationModel model)
        {
            var url = _vnPayRepo.CreatePaymentUrl(model, HttpContext);

            return Ok(url);
        }

        [HttpGet("result")]
        //[Authorize(Roles = "Manager")]
        public IActionResult PaymentCallback()
        {
            var response = _vnPayRepo.PaymentExecute(Request.Query);
            var successUrl = "http://localhost:3000/?message=Payment%20Successful";
            var failureUrl = "http://localhost:3000/?message=Payment%20Failed";

            if (response.VnPayResponseCode.Equals("00"))
            {
                return Redirect(successUrl);
                //return Ok(response);
            }
            else
            {
                return Redirect(failureUrl);
            }
        }





        [HttpPut("UpdateStatusByUserId")]
        public async Task<IActionResult> UpdateStatusByUserId(int userId)
        {
			bool result = await _orderRepository.UpdateStatusByUserId(userId);
			if (result)
			{
				return Ok("Update status Order successfully");
			}
			return Ok("Failed to Update status Order");
		}
        //---------------bill-------------
    }
}

