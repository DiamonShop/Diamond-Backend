using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Entities.Data
{
	public class Bill
	{
		public int BillId { get; set; }
		public int UserId { get; set; }
		public string Fullname { get; set; }
		public DateTime PayDate { get; set; }
		public string PaymentMethod { get; set; }
		public string ShipMethod { get; set; }

	}
}
