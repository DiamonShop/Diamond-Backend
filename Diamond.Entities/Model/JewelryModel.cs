﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Diamond.Entities.Model
{
    public class JewelryModel
    {
        public int JewelryID { get; set; }
        public int JewelrySettingID { get; set; }
        public string ProductID { get; set; }
        public int CategoryId { get; set; }
        public int MainDiamondID { get; set; }
        public int MainDiamondQuantity { get; set; }
        public int SideDiamondID { get; set; }
        public int SideDiamondQuantity { get; set; }
        public int BasePrice { get; set; }
        public List<JewelrySizeModel> JewelrySizes { get; set; } = new List<JewelrySizeModel>();
    }
}
