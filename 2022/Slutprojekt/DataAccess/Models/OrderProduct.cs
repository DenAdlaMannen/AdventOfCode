using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class OrderProduct
    {
        public int Quantity { get; set; }


        public Order OrderId { get; set; }
        public Product ProductId { get; set; }
    }
}
