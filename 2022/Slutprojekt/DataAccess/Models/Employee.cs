using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Employee : User
    {
        public string Department { get; set; }
        public DateTime EmployedDate { get; set; }
        public DateTime TerminatedDate { get; set; }
        public bool IsEmployed { get; set; }
    }
}
