using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Entities.Model
{
	public class PaymentInformationModel
	{
		public string fullName { get; set; }
		public int phoneNumber { get; set; }
		public string birthday { get; set; }
		public string email { get; set; }
		public string streetAddress { get; set; }
		public string orderNote { get; set; }
		public double price { get; set; }
		
	}
}
