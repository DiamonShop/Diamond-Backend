﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DiamondShop.Data;
using DiamondShop.Model;
using Diamond.Entities.Model;
using DiamondShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace DiamondShop.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly DiamondDbContext _context;
        private readonly IVnPayRepository _vnPayRepo;

        public OrderController(DiamondDbContext context, IVnPayRepository vnPayRepo)
        {
            _context = context;
            _vnPayRepo = vnPayRepo;
        }

        [HttpGet("GetAllOrders")]
        [Authorize(Roles = "Manager,Staff,Delivery")]
        public async Task<ActionResult<List<OrderViewModel>>> GetAllOrders()
        {
            var orders = await _context.Orders
                .Include(o => o.User)
                .Include(o => o.CartItems)
                    .ThenInclude(od => od.Product)
                .Select(o => new OrderViewModel
                {
                    OrderId = o.OrderId,
                    UserName = o.User.FullName,
                    TotalPrice = o.TotalPrice,
                    Status = o.Status,
                    OrderDate = o.OrderDate,
                    CartItems = o.CartItems.Select(od => new CartItemModel
                    {
                        ProductId = od.ProductId,
                        Price = od.UnitPrice,
                        Quantity = od.Quantity
                    }).ToList()
                })
                .ToListAsync();

            return Ok(orders);
        }

        [HttpGet("GetOrderById")]
        [Authorize(Roles = "Manager,Staff,Delivery")]
        public async Task<ActionResult<OrderViewModel>> GetOrderById(int id)
        {
            var order = await _context.Orders
                .Include(o => o.User)
                .Include(o => o.CartItems)
                    .ThenInclude(od => od.Product)
                .Where(o => o.OrderId == id)
                .Select(o => new OrderViewModel
                {
                    OrderId = o.OrderId,
                    UserName = o.User.FullName,
                    TotalPrice = o.TotalPrice,
                    Status = o.Status,
                    OrderDate = o.OrderDate,
                    CartItems = o.CartItems.Select(od => new CartItemModel
                    {
                        ProductId = od.ProductId,
                        ProductName = od.Product.ProductName,
                        Price = od.UnitPrice,
                        Quantity = od.Quantity
                    }).ToList()
                })
                .FirstOrDefaultAsync();

            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        [HttpPost("CreatOrder")]
        /*[Authorize(Roles = "Manager,Staff,Member")]*/
        public async Task<IActionResult> CreateOrder(int userId)
        {
            bool result = false;
            var user = _context.Users.FirstOrDefault(user => user.UserId == userId);

            if (user == null) { return NotFound("User is not found"); }

            Order order = new Order()
            {
                UserID = userId,
                OrderDate = DateTime.Now,
                CartItems = null!,
                Status = "Ordering",
                TotalPrice = 0
            };

            // Thêm order vào cơ sở dữ liệu
            _context.Orders.Add(order);
            result = await _context.SaveChangesAsync() > 0;

            if (result == false)
            {
                return BadRequest("Create Order Failed");
            }
            return Ok("Create Order Succesfully");
        }

        [HttpPost("CreateOrderDetail")]
        /*[Authorize(Roles = "Manager,Staff,Member")]*/
        public async Task<IActionResult> CreateOrderDetail(int orderId, int productId)
        {
            bool result = false;
            var order = _context.Orders.FirstOrDefault(order => order.OrderId == orderId);

            if (order == null) { return NotFound("Order is not found"); }

            if (order.Status.Equals("Completed")) { return BadRequest("Create OrderDatail Failed"); }
            
            OrderDetail orderDetail = new OrderDetail()
            {
                OrderId = order.OrderId,
                UnitPrice = 0,
                Quantity = 0,
                ProductId = productId
            };

            // Thêm order vào cơ sở dữ liệu
            _context.OrderDetails.Add(orderDetail);
            result = await _context.SaveChangesAsync() > 0;

            if (result == false)
            {
                return BadRequest("Create OrderDatail Failed");
            }
            return Ok("Create OrderDetail Succesfully");
        }

        [HttpPut("UpdateOrderDetail")]
        /*[Authorize(Roles = "Manager,Staff,Member")]*/
        public async Task<IActionResult> UpdateOrderDetail(int orderDetailId, int quantity)
        {
            bool result = false;
            var orderDetail = _context.OrderDetails.FirstOrDefault(orderDetail => orderDetail.OrderDetailId == orderDetailId);

            if (orderDetail == null) { return NotFound("Order is not found"); }

            orderDetail.Quantity = quantity;
            

            // Thêm order vào cơ sở dữ liệu
            _context.OrderDetails.Add(orderDetail);
            result = await _context.SaveChangesAsync() > 0;

            if (result == false)
            {
                return BadRequest("Create OrderDatail Failed");
            }
            return Ok("Create OrderDetail Succesfully");
        }

        [HttpDelete("ChangeToDoneStatus")]
        [Authorize(Roles = "Manager,Staff,Delivery")]
        public async Task<IActionResult> ChangeToDoneStatus(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            order.Status = "Done";
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost("Checkout")]
        //[Authorize(Roles = "Manager")]
        [Authorize(Roles = "Manager,Staff,Member")]
        public IActionResult CreatePaymentUrl(PaymentInformationModel model)
        {
            var url = _vnPayRepo.CreatePaymentUrl(model, HttpContext);

            return Ok(url);
        }

        [HttpGet("result")]
        //[Authorize(Roles = "Manager")]
        [Authorize(Roles = "Manager,Staff,Member")]
        public IActionResult PaymentCallback()
        {
            var response = _vnPayRepo.PaymentExecute(Request.Query);
            return Ok(response);
        }
    }
}

