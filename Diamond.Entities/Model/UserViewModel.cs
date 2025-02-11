﻿using Diamond.Entities.Data;
using Diamond.Entities.Model;

namespace DiamondShop.Model
{
    public class UserViewModel
	{
        public int UserId { get; set; }
		public string Username { get; set; }
        public string password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string RoleName { get; set; }
        public int roleId { get; set; }
        
        public int LoyaltyPoints { get; set; }
        public bool IsActive { get; set; }
        public string NumberPhone { get; set; }
        public string Address { get; set; }
    }
}
