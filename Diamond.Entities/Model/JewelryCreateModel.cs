using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Entities.Model
{
    public class JewelryCreateModel
    {
        public int JewelryID { get; set; }
        public int JewelrySettingID { get; set; }
        public decimal MarkupRate { get; set; }
        public int MarkupPrice { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        //Main and side diamond
        public int MainDiamondID { get; set; }
        public int MainDiamondQuantity { get; set; }
        public int SideDiamondID { get; set; }
        public int SideDiamondQuantity { get; set; }
        public int BasePrice { get; set; }
        //Size
        public int Size { get; set; }
        public int Quantity { get; set; }
    }
}
