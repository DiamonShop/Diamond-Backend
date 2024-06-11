using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Entities.Data
{
	public class BillDetail
	{
		public int DetailId { get; set; }
		public int BillId { get; set;}
		public int CartItemId { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
	}
}
