using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Entities.Model
{
    public class WarrantyModel
    {
        public int WarrantyId { get; set; }
        public string ProductId { get; set; }
        public DateOnly BuyDate { get; set; }
        public int WarrantyPeriod { get; set; }
        public string Username { get; set; }
        public bool IsAvailable { get; set; }
    }
}
