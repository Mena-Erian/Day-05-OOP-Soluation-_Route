using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Static
{
    // Static Class :
    // is a Just Container For Class Member : [Attribute, Property, Constructor, Method]
    // and Constants
    // You Can't Create Object From This Class (Helper Class)
    // No Inheritance for this Class
    internal static class Utility
    {
        //public int X { get; set; }
        //public int Y { get; set; }

        // Who Give the Default to Attr (attri = default)
        /// Object Member (Non-Static) => 'new' Keyword given with its Datatype default Value
        /// Class Member (Static)      => 
        ///                            Who: CLR 
        ///                            What do: will Initilize Each and Every Static Attribute with its Datatype default value
        ///                            When: Before the First Usage of the Class

        // what the usage of the Class
        /// 1. Creat Object from this Class, Or From Object inheret from this class
        /// 2. Call static Property
        /// 3. Call static Method

        // 1. Class Member Attribute: Static Attribute
        ///private static readonly double pi = 3.14 /*default*/;
        /// Readonly => just Can assign =>
        ///                             - At its declaration
        ///                             - In a constructor =>
        ///                                     (instance constructor for instance fields, static constructor for static fields)

        // 2. Constant
        private const double pi = 3.14; // Can't assign in any where wehter there constructor or another

        // Const VS Readonly
        /// 1. const : Can't assign in any wehter constructor or another just in there declartion (Const act static so i can't write static kayword in there decaltion) 
        ///                                                         
        /// 2. readonly: Can just assign  - At its declaration
        ///                               - In a constructor =>
        ///                                 (instance constructor for instance fields, static constructor for static fields)

        // Class Member Property: Static Property : [Must Deal with One of the Following]:
        /// 1. Static Attribute
        /// 2. Constant
        public static double PI
        {
            get { return pi; }
            //set { pi = value; } // now can't do this with readonly or const
        }


        // public readonly double test = default;
        // Object Member Constructor : Non-Static Constructor
        /// public Utility(int x, int y)
        /// {
        ///     X = x;
        ///     Y = y;
        ///     pi = default; // can't here becouse is const ,, but i can in  readonly
        ///     //test = pi; // here i can even there is readonly but when was const i was can't do this
        ///     //this.pi = 3.14;
        ///     //Utility.pi = 3.14; is not the right placee for initializing the static attribute
        /// }

        // Class have just One Static Constructor not more like the Object member Constructor(can do many)

        // What is the something will Called Once per Class Lifetime:
        ///                          Static Constructor [Max Only One Per Class]
        // what the count of static constructor in the class :
        ///                                                    Max ONE per Class
        // Why they Called Special Constructor:
        ///          U Can't Specify Access Modifier OR Parameters for the Static Constructor
        // Who they Call : (CLR)Will be Called ONCE per Class Lifetime
        // When they Excute : Before the First Usage of the Class

        static Utility()
        {
            //pi = 3.14;
        }

        // Class Member Method: Static Method
        public static double CmToInch(double Cm)
        {
            return Cm / 2.54;
        }
        // Object Member Method: Non-Static Method

        // Class Member Method: Static Method
        public static double CalcCircleArea(double Radius)
        {
            return Utility.PI * Radius * Radius;
        }


    }
}
