using Diamond.Entities.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DiamondShop.Repositories.Interfaces
{
    public interface IBillRepository
    {
        Task<BillDTO> GetBillById(int billId);
        Task<List<BillDTO>> GetAllBills();
        Task<BillDTO> CreateBill(BillCreateDTO billCreateDTO);
        Task<bool> UpdateBillIsActive(int billId, bool isActive);
    }
}
