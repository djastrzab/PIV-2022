using System;
using System.Collections.Generic;

namespace lab4.NorthwindContext
{
    public partial class OrderSubtotal
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
