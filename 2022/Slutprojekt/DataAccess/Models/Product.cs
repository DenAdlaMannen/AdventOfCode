using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public double Alcohol { get; set; }
        public bool Lactose { get; set; }
        public bool Gluten { get; set; }
        public bool Vegan { get; set; }
        public bool IsDeleted { get; set; }
    }
}
