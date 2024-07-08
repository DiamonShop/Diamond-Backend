using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Data
{
    public class Bill
    {
        [Key]
        [Required]
        public int BillId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [Required]
        [StringLength(200)]
        public string FullName { get; set; }

        [Required]
        [StringLength(50)]
        public string NumberPhone { get; set; } 

        [Required]
        [StringLength(200)]
        public string Email { get; set; }

        [Required]
        [StringLength(300)]
        public string Address { get; set; }

        [StringLength(500)]
        public string OrderNote { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public virtual User User { get; set; }
    }
}
