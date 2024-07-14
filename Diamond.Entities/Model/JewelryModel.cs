﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Diamond.Entities.Model
{
    public class JewelryModel
    {
        public int JewelryID { get; set; }
        public int JewelrySettingID { get; set; }
        public string Material { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int MainDiamondID { get; set; }
        public string MainDiamondName { get; set; }
        public int MainDiamondQuantity { get; set; }
        public int SideDiamondID { get; set; }
        public string SideDiamondName { get; set; }
        public int SideDiamondQuantity { get; set; }
        public int BasePrice { get; set; }
        public int MarkupRate { get; set; }
        public int MarkupPrice { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public List<JewelrySizeModel> JewelrySizes { get; set; } = new List<JewelrySizeModel>();
    }
}
