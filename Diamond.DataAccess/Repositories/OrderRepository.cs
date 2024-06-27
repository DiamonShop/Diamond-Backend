using Diamond.DataAccess.Repositories.Interfaces;
using DiamondShop.Controllers;
using DiamondShop.Data;
using DiamondShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Diamond.DataAccess.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DiamondDbContext _context;

        public OrderRepository(DiamondDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AddProductToOrderDetail(int orderId, string productId, int quantity)
        {
            bool result = false;
            var order = _context.Orders.Include(order => order.OrderDetails).FirstOrDefault(order => order.OrderId == orderId);
            if (order == null) { return result; }
            if (order.Status.Equals("Completed") || order.Status.Equals("Shipped")) { return result; }

            var product = _context.Products.SingleOrDefault(product => product.ProductId.Equals(productId));
            if (product == null) { return result; }
            //Kiểm tra xem orderDetail có productId chưa
            var orderDetails = order.OrderDetails.FirstOrDefault(od => od.ProductId.Equals(productId));
            if (orderDetails == null)
            {
                OrderDetail newOrderDetail = new OrderDetail()
                {
                    OrderId = orderId,
                    UnitPrice = product.BasePrice,
                    ProductName = product.ProductName,
                    Quantity = quantity,
                    ProductId = productId,
                };

                // Thêm order vào cơ sở dữ liệu
                _context.OrderDetails.Add(newOrderDetail);
                //Cập nhật lại total price của order
                order.TotalPrice += quantity * newOrderDetail.UnitPrice;
                _context.Orders.Update(order);
                result = await _context.SaveChangesAsync() > 0;
            }
            else
            {
                orderDetails.Quantity += quantity;
                _context.OrderDetails.Update(orderDetails);
                result = await _context.SaveChangesAsync() > 0;
            }

            return result;
        }

        public async Task<ApiResponse> CreateOrder(int userId)
        {
            bool result = false;
            var user = _context.Users.Include(u => u.Orders).FirstOrDefault(user => user.UserId == userId);

            if (user == null)
            {
                return new ApiResponse()
                {
                    Message = "User is not exist",
                    Success = false,
                    Data = null
                };
            }

            //Nếu có order với status là Ordering thì không tạo Order khác nữa
            var availableOrder = user.Orders.FirstOrDefault(od => od.Status.Equals("Ordering"));

            if (availableOrder != null)
            {
                return new ApiResponse()
                {
                    Message = "There is existed an order have not completed yet",
                    Success = false,
                    Data = null
                };
            }

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
                return new ApiResponse()
                {
                    Message = "Create Order Failed",
                    Success = false,
                    Data = null
                };
            }

            return new ApiResponse()
            {
                Message = "Create Order Successfully",
                Success = true,
                Data = order.OrderId
            };
        }

        public async Task<List<OrderViewModel>> GetAllOrders()
        {
            var orders = await _context.Orders.Include(o => o.User)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Product).ToListAsync();

            if (orders == null)
            {
                return null;
            }

            var orderModel = orders.Select(o => new OrderViewModel
            {
                OrderId = o.OrderId,
                UserName = o.User.FullName,
                TotalPrice = o.TotalPrice,
                Status = o.Status,
                OrderDate = o.OrderDate,
                OrderDetails = o.OrderDetails.Select(od => new CartItemModel
                {
                    ProductId = od.ProductId,
                    ProductName = od.ProductName,
                    UnitPrice = od.UnitPrice,
                    Quantity = od.Quantity
                }).ToList()
            }).ToList();

            if (orderModel == null)
            {
                return null;
            }
            else
            {
                return orderModel;
            }
        }

        public async Task<OrderViewModel> GetOrderById(int orderId)
        {
            var order = _context.Orders
                .Include(o => o.User)
                .Include(o => o.OrderDetails)
                    .ThenInclude(od => od.Product)
                    .SingleOrDefault(o => o.OrderId == orderId);

            if (order == null)
            {
                return null;
            }

            var orderModel = new OrderViewModel
            {
                OrderId = order.OrderId,
                UserName = order.User.FullName,
                TotalPrice = order.TotalPrice,
                Status = order.Status,
                OrderDate = order.OrderDate,
                OrderDetails = order.OrderDetails.Select(od => new CartItemModel
                {
                    ProductId = od.ProductId,
                    ProductName = od.ProductName,
                    UnitPrice = od.UnitPrice,
                    Quantity = od.Quantity
                }).ToList()
            };

            if (orderModel == null)
            {
                return null;
            }

            return orderModel;
        }

        public async Task<ApiResponse> GetOrderByUserId(int userId)
        {
            var userOrders = await _context.Orders
                                   .Include(o => o.OrderDetails)
                                   .Include(o => o.User) // Ensure User is included
                                   .Where(u => u.UserID == userId)
                                   .ToListAsync();

            if (!userOrders.Any()) // Check if the list is empty
            {
                return new ApiResponse()
                {
                    Message = "Get Order by user id failed",
                    Success = false,
                    Data = null
                };
            }

            var orderModel = userOrders.Select(o => new OrderViewModel
            {
                OrderId = o.OrderId, 
                UserName = o.User.FullName,
                TotalPrice = o.TotalPrice,
                Status = o.Status,
                OrderDate = o.OrderDate,
                OrderDetails = o.OrderDetails.Select(od => new CartItemModel
                {
                    ProductId = od.ProductId,
                    ProductName = od.ProductName,// Assuming ProductName is available in OrderDetails
                    UnitPrice = od.UnitPrice,
                    Quantity = od.Quantity
                }).ToList()
            }).ToList();

            if (orderModel == null)
            {
                return new ApiResponse()
                {
                    Message = "Get Order by user id failed",
                    Success = false,
                    Data = null
                };
            }

            return new ApiResponse()
            {
                Message = "Get Order by user id successfully",
                Success = true,
                Data = orderModel
            };
        }

        public async Task<bool> UpdateOrder(int orderId, int TotalPrice)
        {
            bool result = false;
            var order = _context.Orders.FirstOrDefault(orderDetail => orderDetail.OrderId == orderId);

            if (order == null)
            {
                return result;
            }

            order.TotalPrice = TotalPrice;
            order.OrderDate = order.OrderDate;
            order.Status = order.Status;
            order.UserID = order.UserID;
            order.OrderDetails = order.OrderDetails;

            // Thêm order vào cơ sở dữ liệu
            _context.Orders.Update(order);
            result = await _context.SaveChangesAsync() > 0;
            return result;
        }

        public async Task<bool> UpdateOrderDetail(int orderDetailId, int quantity)
        {
            bool result = false;
            var orderDetail = _context.OrderDetails.FirstOrDefault(orderDetail => orderDetail.OrderDetailId == orderDetailId);

            if (orderDetail == null) { return result; }

            orderDetail.Quantity = quantity;

            // Thêm order vào cơ sở dữ liệu
            _context.OrderDetails.Add(orderDetail);
            result = await _context.SaveChangesAsync() > 0;
            return result;
        }

        public async Task<bool> UpdateStatus(int orderId)
        {
            bool result = false;
            var order = await _context.Orders.FindAsync(orderId);

            if (order == null)
            {
                return result;
            }
            order.Status = "Completed";
            _context.Orders.Update(order);
            result = await _context.SaveChangesAsync() > 0;

            return result;
        }
    }
}
