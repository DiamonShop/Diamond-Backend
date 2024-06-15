using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Entities.Model
{
	public class PaymentInformationModel
	{
		public string ItemInOrder { get; set; }
		public double Amount { get; set; }
		public string OrderDescription { get; set; }
		public string Name { get; set; }
	}
}
