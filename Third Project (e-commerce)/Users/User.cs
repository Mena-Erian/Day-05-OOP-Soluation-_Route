using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Third_Project__e_commerce_.Discounts;

namespace Third_Project__e_commerce_.Users
{
    abstract class User
    {
        public string? Name { get; set; }
        public abstract Discount GetDiscount();
    }
}
