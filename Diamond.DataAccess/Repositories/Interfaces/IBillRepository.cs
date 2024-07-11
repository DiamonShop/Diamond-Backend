using Diamond.Entities.DTO;
using DiamondShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Repositories.Interfaces
{
    public interface IBillRepository
    {
        public Task<List<BillDTO>> GetAllBills();
        public Task<BillDTO> GetBillById(int id);
        public Task<bool> CreateBill(BillDTO billDTO);
        public Task<bool> UpdateBill(int id, BillDTO billDTO);
        public Task<List<BillDTO>> GetBillByName(string name);

    }
}
