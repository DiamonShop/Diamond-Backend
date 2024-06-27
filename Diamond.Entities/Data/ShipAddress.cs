using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiamondShop.Data
{
    public class ShipAddress
    {
        [Key]
        public int ShipAddressId { get; set; } // Định nghĩa khóa chính riêng

        [ForeignKey("User")]
        public int UserId { get; set; }  // UserId làm foreign key

        [StringLength(200)]
        public string PhoneNumber { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string ReceiverName { get; set; }

        public bool IsActive { get; set; }

        // Định nghĩa quan hệ với User
        public virtual User User { get; set; }
    }
}
