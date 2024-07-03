using DiamondShop.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiamondShop.Repositories.Interfaces
{
    public interface IBillRepository
    {
        Task<Bill> CreateBill(Bill bill);
        Task<Bill> GetBillById(int billId);
        Task<List<Bill>> GetAllBills();
    }
}
