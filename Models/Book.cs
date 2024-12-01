using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPI_OOP.Models
{
    internal class Book
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string genre { get; set; }
        public AvailabilityStatus availabilityStatus { get; set; }
        public enum AvailabilityStatus
        {
            Available,
            CheckedOut
        }
    }
}
