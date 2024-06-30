using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Data
{
    public class User
    {
        [Key]
        [Required]
        public int UserId { get; set; }

        [ForeignKey("Role")]
        public int RoleId { get; set; }

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(20)] 
        public string NumberPhone { get; set; }
        [Required]
        [StringLength(30)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }



        public int LoyaltyPoints { get; set; }

        [Required]
        public bool IsActive { get; set; }

        // Quan hệ với Role 
        public virtual Role Role { get; set; }

        // Quan hệ với Orders
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

        // Quan hệ với Feedbacks
        public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

        
        
    }
}
