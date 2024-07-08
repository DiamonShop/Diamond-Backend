using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Entities.DTO
{
    public class BillDTO
    {
        public int BillId { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string OrderNote { get; set; }
        public bool IsActive { get; set; }
    }
}
