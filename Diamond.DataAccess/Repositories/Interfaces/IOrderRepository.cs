using Diamond.Entities.Model;
using DiamondShop.Controllers;
using DiamondShop.Data;
using DiamondShop.Model;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        public Task<List<OrderViewModel>> GetAllOrders();
        public Task<OrderViewModel> GetOrderById(int id);
        public Task<ApiResponse> GetOrderByUserId(int userId);
        public Task<ApiResponse> GetHistoryOrderByUserId(int userId);
        public Task<ApiResponse> CreateOrder(int userId);
        public Task<bool> AddProductToOrderDetail(int orderId, string productId, int quantity);
        public Task<bool> UpdateOrder(int orderId, int totalPrice);
        public Task<bool> UpdateStatusCompleted(int orderId);
        public Task<bool> UpdateStatusCancel(int orderId, string cancelReason);
        public Task<bool> UpdateOrderDetail(string orderDetailId, int quantity);
        public Task<bool> DeleteOrderDetail(string orderDetailId);
        public Task<List<OrderDetailModel>> GetAllOrderDetail();
        public Task<bool> UpdateStatusByUserId(int userId);
        public Task<ApiResponse> GetOrderByUserIdOrderId(int userId, int orderId);

	}
}
