using Microsoft.AspNetCore.Mvc;
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
                        ProductName = od.Product.Description,
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
        [Authorize(Roles = "Manager,Staff,Delivery,Member")]
        public async Task<ActionResult<OrderViewModel>> CreateOrder([FromBody] Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Thêm order vào cơ sở dữ liệu
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            // Tạo OrderViewModel từ order vừa thêm vào
            var orderViewModel = new OrderViewModel
            {
                OrderId = order.OrderId,
                UserName = order.User.FullName,
                TotalPrice = order.TotalPrice,
                Status = order.Status,
                OrderDate = order.OrderDate,
                CartItems = order.CartItems.Select(od => new CartItemModel
                {
                    ProductId = od.ProductId,
                    Price = od.UnitPrice,
                    Quantity = od.Quantity
                }).ToList()
            };

            return CreatedAtAction(nameof(GetOrderById), new { id = order.OrderId }, orderViewModel);
        }

        [HttpDelete("DoneStatusChange")]
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
        [Authorize(Roles = "Manager,Staff,Member")]
        public IActionResult CreatePaymentUrl(OrderCheckOutModel orderModel)
        {
            var order = _context.Orders.Include(o => o.CartItems)
				.Include(o => o.User)
                .FirstOrDefault(o => o.UserID == orderModel.UserId
                && o.OrderId == orderModel.OrderId);


            PaymentInformationModel model = new PaymentInformationModel 
            {
                Amount = (double)order.CartItems.Sum(c => c.UnitPrice * c.Quantity),
                Name = order.User.FullName,
                OrderDescription="AAA",
				ItemInOrder = $"{order.CartItems.ToString()}"
            };
			var url = _vnPayRepo.CreatePaymentUrl(model, HttpContext);

            return Ok(url);
        }

        [HttpGet("result")]
		[Authorize(Roles = "Manager,Staff,Member")]
        public IActionResult PaymentCallback()
        {
            var response = _vnPayRepo.PaymentExecute(Request.Query);
            return Ok(response);
        }
    }
}

