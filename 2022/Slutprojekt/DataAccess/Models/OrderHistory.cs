﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class OrderHistory
    {
        public int Id { get; set; }
        public Order Order { get; set; }
    }
}
