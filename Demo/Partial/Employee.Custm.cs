using Demo.Sealed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Partial
{
    // can't make here inheret from another (multible inheretins)
   internal partial class Employee : Parent
    {
        public string? Address { get; set; }

        //public partial int DoSomeCode()
        //{
        //    int X = 10;
        //    X++;
        //    return X;
        //}

        
    }
}
