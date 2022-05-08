using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Order
    {
        public int Id { get; set; }
        public int Price { get; set; }

        public Client Client { get; set; }
    }
}
