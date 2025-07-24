using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Sealed
{
    class Parent
    {
        public virtual int Salary { get; set; }
        public virtual void Print ()
        {
            Console.WriteLine("I am Based");
        }
    }
    class Child : Parent
    {
        // Sealed Property
        public sealed override int Salary
        {
            get
            {

                Console.WriteLine("Child salary");
                return base.Salary;
            }
            set { base.Salary = value < 5000 ? 5000 : value; }
        }
        // Sealed Method so now can't any child override this method
        public sealed override void Print()
        {
            Console.WriteLine("I am Derived");
        }
    }
    sealed /* after sealed can't any class inheret from grandchild class */ class GrandChild : Child
    {
        // After make the property Salary sealed in Child Class, so now you can't override in this
        // property just you can make another one (by Using 'new' keyword on not)
        public new int Salary
        {
            get
            {
                Console.WriteLine("GrandChild salary");

                return base.Salary;
            }
            set { base.Salary = value < 6000 ? 6000 : value; }
        }
        /// After make the Print Method sealed in Child Class, so now you can't override in this
        /// Method just you can make another one (by Using 'new' keyword on not)
        //public override void Print()
        //{
        //    Console.WriteLine("I am GrandChild");
        //}
    }
    class Test : Child
    {

    }
}
