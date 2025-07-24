using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project__e_commerce_.Discount
{
    abstract class Discount
    {
        public string? Name { get; set; }
        public abstract decimal CalculateDiscount(decimal price, int quantity);
    }
}
