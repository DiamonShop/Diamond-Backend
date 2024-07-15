using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Entities.Model
{
    public class DiamondModel
    {
        public int DiamondID { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Carat { get; set; }
        public string Clarity { get; set; }
        public string Cut { get; set; }
        public decimal DiameterMM { get; set; }
        public string Color { get; set; }
        public decimal MarkupRate { get; set; }
        public int MarkupPrice { get; set; }
        public string Description { get; set; }
        public int BasePrice { get; set; }
        public bool IsActive { get; set; }
    }
}
