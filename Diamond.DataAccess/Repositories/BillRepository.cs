using Diamond.DataAccess.Repositories.Interfaces;
using Diamond.Entities.DTO;
using DiamondShop.Data;
using DiamondShop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Repositories
{
    public class BillRepository: IBillRepository
    {
        private readonly DiamondDbContext _context;
        public BillRepository(DiamondDbContext context) 
        {
            _context = context;
        }

        public Task<bool> CreateBill(BillDTO billDTO)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BillDTO>> GetAllBills()
        {
            List<BillDTO> billList = new List<BillDTO>();
            var orders = await _context.Orders.ToListAsync();

            if (orders == null)
            {
                return null;
            }

            foreach (var item in orders)
            {
                var user = await _context.Users.FindAsync(item.UserID);
                if (user != null)
                {
                    BillDTO billDTO = new BillDTO
                    {
                        UserId = user.UserId,
                        OrderId = item.OrderId,
                        FullName = user.FullName,
                        NumberPhone = user.NumberPhone,
                        Email = user.Email,
                        Address = user.Address,
                        OrderNote = item.OrderNote,
                        OrderStatus = item.Status
                    };

                    billList.Add(billDTO);
                }
            }

            return billList;
        }

        public Task<BillDTO> GetBillById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BillDTO>> GetBillByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateBill(int id, BillDTO billDTO)
        {
            throw new NotImplementedException();
        }
    }
}
