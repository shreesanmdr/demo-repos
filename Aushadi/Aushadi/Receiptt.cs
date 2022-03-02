using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aushadi
{
    class Receiptt
    {
        public int ID { get; set; }
        public string productName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Selection { get; set; }
        public string Total { get { return string.Format("(0)$", Price * Quantity); } }
    }
}
