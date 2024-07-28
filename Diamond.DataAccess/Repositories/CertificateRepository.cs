using Diamond.DataAccess.Repositories.Interfaces;
using Diamond.Entities.Model;
using Microsoft.EntityFrameworkCore;

namespace Diamond.DataAccess.Repositories
{
    public class CertificateRepository : ICertificateRepository
    {
        private readonly DiamondDbContext _context;

        public CertificateRepository(DiamondDbContext context)
        {
            _context = context;
        }

        public async Task<List<CertificateModel>> GetCertificateByUserId(int userId)
        {
            // Lấy danh sách đơn hàng của người dùng có trạng thái "Completed"
            var orders = await _context.Orders
                .Include(o => o.OrderDetails)
                .Where(o => o.UserID == userId && o.Status == "Completed")
                .ToListAsync();

            var certificates = new List<CertificateModel>();

            // Duyệt qua từng Orders
            foreach (var order in orders)
            {
                // Duyệt qua từng OrderDetails
                foreach (var orderDetail in order.OrderDetails)
                {
                    // Lấy thông tin sản phẩm từ bảng Products
                    var product = await _context.Products
                        .Where(p => p.ProductId == orderDetail.ProductId && p.ProductType.Equals("Diamond"))
                        .FirstOrDefaultAsync();

                    if (product != null)
                    {
                        var certificate = new CertificateModel
                        {
                            ProductId = product.ProductId,
                            ProductName = product.ProductName
                        };
                        certificates.Add(certificate);
                    }
                }
            }

            return certificates;
        }
    }
}
