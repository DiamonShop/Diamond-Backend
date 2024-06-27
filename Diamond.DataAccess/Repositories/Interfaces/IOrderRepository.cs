using DiamondShop.Controllers;
using DiamondShop.Model;

namespace Diamond.DataAccess.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        public Task<List<OrderViewModel>> GetAllOrders();
        public Task<OrderViewModel> GetOrderById(int id);
        public Task<ApiResponse> GetOrderByUserId(int userId);
        public Task<ApiResponse> CreateOrder(int userId);
        public Task<bool> AddProductToOrderDetail(int orderId, string productId, int quantity);
        public Task<bool> UpdateOrder(int orderId, int totalPrice);
        public Task<bool> UpdateStatus(int orderId);
        public Task<bool> UpdateOrderDetail(int orderDetailId, int quantity);
    }
}
