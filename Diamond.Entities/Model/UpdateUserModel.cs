using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DiamondShop.Model
{
    public class UpdateUserModel
	{
        public int UserId { get; set; }

        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string NumberPhone { get; set; }
        public string Address { get; set; }

    }
}
