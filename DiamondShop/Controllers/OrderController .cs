using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DiamondShop.Data;

using DiamondShop.Model;
using Diamond.Entities.Model;
using Diamond.Entities.Helpers;
using Diamond.Entities.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace DiamondShop.Controllers
{
	[Route("api/orders")]
	[ApiController]
	public class OrderController : ControllerBase
	{
		private readonly DiamondDbContext _context;
		private readonly IVnPayService _vnPayService;

		public OrderController(DiamondDbContext context, IVnPayService vnPayService)
		{
			_context = context;
			_vnPayService = vnPayService;
		}

        [HttpGet("get-all-order")]
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
                        Price = od.Price,
                        Quantity = od.Quantity
                    }).ToList()
                })
                .ToListAsync();

            return Ok(orders);
        }

        [HttpGet("get/{id}")]
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
                        Price = od.Price,
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


        [HttpPost]
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
                    Price = od.Price,
                    Quantity = od.Quantity
                }).ToList()
            };

            return CreatedAtAction(nameof(GetOrderById), new { id = order.OrderId }, orderViewModel);
        }


        [HttpDelete("{id}")]
		public async Task<IActionResult> DeleteOrder(int id)
		{
			var order = await _context.Orders.FindAsync(id);
			if (order == null)
			{
				return NotFound();
			}

			_context.Orders.Remove(order);
			await _context.SaveChangesAsync();

			return NoContent();
		}

		[HttpPost("checkout")]
		public async Task<IActionResult> Checkout(OrderCheckOutModel od)
        {
			var order = _context.Orders.Include(o => o.CartItems).Include(o => o.User)
		.FirstOrDefault(o => o.UserId == od.UserId && o.OrderId == od.OrderId);

			if (ModelState.IsValid)
			{
				var vnPayModel = new VnPaymentRequestModel
				{
					Amount = (double)order.CartItems.Sum(c => c.Price * c.Quantity),
					CreatedDate = DateTime.Now,
					Fullname = order.User.FullName,
					OrderId = new Random().Next(100, 1000)
				};
				//return Ok(vnPayModel);
				return Redirect(_vnPayService.CreatePaymentUrl(HttpContext, vnPayModel));
			}else { return NoContent(); }

			var uId = HttpContext.User.Claims.SingleOrDefault(p => p.Type == MySettings.CLAIM_USERID).Value;
            var user = new User();
            if (od.CheckUser)
            {
				user = _context.Users.SingleOrDefault(u => u.UserId == int.Parse(uId));
            }

            var bill = new Bill
            {
                BillId = int.Parse(uId),
                Fullname = od.Name ?? user.FullName,
                PayDate = DateTime.Now,
				PaymentMethod = "VnPay",
				ShipMethod = "Grab"
			};

			_context.Database.BeginTransaction();
            try
            {
                _context.Add(bill);
                _context.SaveChanges();

                var detailList = new List<BillDetail>();
                foreach(var item in order.CartItems)
                {
                    detailList.Add(new BillDetail
                    {
                        BillId = bill.BillId,
                        Quantity = item.Quantity,
                        Price = item.Price,
                        CartItemId = item.CartItemId
                    });

                }
                
                _context.AddRange(detailList);
                _context.SaveChanges();
                _context.Database.CommitTransaction();

               // HttpContext.Session.Set<List<CartItem>>("MYCART", new List<CartItem>());

				return Ok("Success");
            }
            catch 
            {
                _context.Database.RollbackTransaction();
            }
		}

		public IActionResult PaymentSuccess()
		{
			return Ok("Success");
		}

		public IActionResult PaymentCallBack()
		{
			var response = _vnPayService.PaymentExecute(Request.Query);

			if (response == null || response.VnPayResponseCode != "00")
			{
				//TempData["Message"] = $"Lỗi thanh toán VN Pay: {response.VnPayResponseCode}";
				return RedirectToAction("PaymentFail");
			}


			// Lưu đơn hàng vô database

			//TempData["Message"] = $"Thanh toán VNPay thành công";
			return RedirectToAction("PaymentSuccess");
		}
	}
}

