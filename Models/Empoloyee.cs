using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_OOP.Models
{
    internal class Empoloyee : Person
    {
        public decimal Salary { get; set; }
        public int workingHoures { get; set; }
    }
}
