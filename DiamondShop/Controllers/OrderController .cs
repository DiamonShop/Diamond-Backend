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
        /*[Authorize(Roles = "Manager,Staff,Delivery")]*/
        public async Task<IActionResult> GetAllOrders()
        {
            var orders = await _context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Product)
                .Select(o => new OrderViewModel
                {
                    OrderId = o.OrderId,
                    UserName = o.User.FullName,
                    TotalPrice = o.TotalPrice,
                    Status = o.Status,
                    OrderDate = o.OrderDate,
                    OrderDetails = o.OrderDetails.Select(od => new CartItemModel
                    {
                        ProductId = od.ProductId,
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
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Product)
                .Where(o => o.OrderId == id)
                .Select(o => new OrderViewModel
                {
                    OrderId = o.OrderId,
                    UserName = o.User.FullName,
                    TotalPrice = o.TotalPrice,
                    Status = o.Status,
                    OrderDate = o.OrderDate,
                    OrderDetails = o.OrderDetails.Select(od => new CartItemModel
                    {
                        ProductId = od.ProductId,
                        ProductName = od.Product.ProductName,
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

        [HttpGet("GetOrderByUserId")]
        /*[Authorize(Roles = "Manager,Staff,Delivery")]*/
        public async Task<IActionResult> GetOrderByUserId(int userId)
        {
            var userOrders = await _context.Orders
                .Where(u => u.UserID == userId)
                .Select(o => new OrderViewModel
                {
                    OrderId = o.OrderId,
                    UserName = o.User.FullName,  // Assumes Order entity has a User navigation property
                    TotalPrice = o.TotalPrice,
                    Status = o.Status,
                    OrderDate = o.OrderDate,
                    OrderDetails = o.OrderDetails.Select(od => new CartItemModel
                    {
                        ProductId = od.ProductId,
                        Quantity = od.Quantity
                    }).ToList()
                }).ToListAsync();

            if(!userOrders.Any())
            {
                return Ok(new ApiResponse()
                {
                    Message = "Get Order by user id failed",
                    Success = false,
                    Data = null
                });
            }

            return Ok(new ApiResponse()
            {
                Message = "Get Order by user id successfully",
                Success = true,
                Data = userOrders
            }); 
        }

        [HttpPost("CreatOrder")]
        /*[Authorize(Roles = "Manager,Staff,Member")]*/
        public async Task<IActionResult> CreateOrder(int userId)
        {
            bool result = false;
            var user = _context.Users.Include(u => u.Orders).FirstOrDefault(user => user.UserId == userId);
            
            if (user == null) { return NotFound("User is not found"); }

            //Nếu có order với status là Ordering thì không tạo Order khác nữa
            var availableOrder = user.Orders.FirstOrDefault(od => od.Status.Equals("Ordering"));

            if(availableOrder != null) { return Ok(availableOrder.OrderId); }

            Order order = new Order()
            {
                UserID = userId,
                OrderDate = DateTime.Now,
                OrderDetails = null!,
                Status = "Ordering",
                TotalPrice = 0
            };

            // Thêm order vào cơ sở dữ liệu
            _context.Orders.Add(order);
            result = await _context.SaveChangesAsync() > 0;

            if (result == false)
            {
                return BadRequest(new ApiResponse()
                {
                    Message = "Create Order Failed",
                    Success = false,
                    Data = null
                });
            }
            return Ok(new ApiResponse()
            {
                Message = "Create Order Successfully",
                Success = true,
                Data = order.OrderId
            });
        }

        [HttpPost("AddProductToOrderDetail")]
        /*[Authorize(Roles = "Manager,Staff,Member")]*/
        public async Task<IActionResult> AddProductToOrderDetail(int orderId, string productId, int quantity)
        {
            bool result = false;
            var order = _context.Orders.Include(order => order.OrderDetails).FirstOrDefault(order => order.OrderId == orderId);
            if (order == null) { return NotFound("Order is not found"); }
            if (order.Status.Equals("Completed") || order.Status.Equals("Shipped")) { return BadRequest("Order is completed"); }

            var product = _context.Products.SingleOrDefault(product => product.ProductId.Equals(productId));
            if (product == null) { return BadRequest("Product is not existed"); }
            //Kiểm tra xem orderDetail có productId chưa
            var orderDetails = order.OrderDetails.FirstOrDefault(od => od.ProductId.Equals(productId));
            if (orderDetails == null)
            {
                OrderDetail newOrderDetail = new OrderDetail()
                {
                    OrderId = orderId,
                    UnitPrice = product.BasePrice,
                    Quantity = quantity,
                    ProductId = productId,
                };

                // Thêm order vào cơ sở dữ liệu
                _context.OrderDetails.Add(newOrderDetail);
                result = await _context.SaveChangesAsync() > 0;
            } else {
                orderDetails.Quantity += quantity;
                _context.OrderDetails.Update(orderDetails);
                result = await _context.SaveChangesAsync() > 0;
            }
            
            if (result == false)
            {
                return BadRequest("Add product to OrderDatail failed");
            }
            return Ok("Add product to OrderDetail succesfully");
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
			var failureUrl = "http://localhost:3000/Giohang?message=Payment%20Failed";

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
    }
}

