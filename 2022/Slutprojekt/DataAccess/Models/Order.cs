using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsTakeAway { get; set; }
        public bool IsReady { get; set; }
        public bool IsDeleted { get; set; }

        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
    }
}
