﻿namespace Diamond.Entities.Model
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
