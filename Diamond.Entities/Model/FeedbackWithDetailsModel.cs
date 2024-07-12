using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.Entities.Model
{
    public class FeedbackWithDetailsModel
    {
        public int UserId { get; set; }
        public string ProductId { get; set; }
        public string Description { get; set; }
        public DateTime? DateTime { get; set; }
        public string UserName { get; set; }
        public string ProductName { get; set; }
    }
}
