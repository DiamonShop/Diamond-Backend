using System;
using System.Collections.Generic;
namespace Diamond.Entities.Model
{
    public class DiamondModel
    {
        public int DiamondID { get; set; }
        public int ProductID { get; set; }
        public string Origin { get; set; }
        public decimal Carat { get; set; }
        public string Clarity { get; set; }
        public string Cut { get; set; }
        public string Color { get; set; }
        public decimal BasePrice { get; set; }
    }
}
