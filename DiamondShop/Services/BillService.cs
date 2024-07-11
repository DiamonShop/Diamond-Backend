using Diamond.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiamondShop.API.Services
{
	public class BillService
	{
		private readonly List<BillCreateDTO> _bills = new List<BillCreateDTO>();
		public void SaveBill(BillCreateDTO bill)
		{
			//Random random = new Random();
			//bill.Id = random.Next(0000,99999);
			//bill.CreatedDate = DateTime.UtcNow;
			_bills.Add(bill);
		}

		public BillCreateDTO GetLatestBill()
		{
			return _bills.OrderByDescending(b => b.CreatedDate).FirstOrDefault();
		}

	}
}
