using Demo.Abstraction;
using Demo.Static;

namespace Demo
{
    internal class Program
    {
        #region Abstract [Abstract Class, Abstract Method, Abstract Property]
        static void PrintShapeInfo(Shape shape)
        {
            Console.WriteLine($"shape.Dim01 {shape.Dim01}");
            Console.WriteLine($"shape.Dim02 {shape.Dim02}");
            Console.WriteLine($"shape.CalcArea = {shape.CalcArea()}");
            Console.WriteLine($"shape.Perimeter = {shape.Perimeter}");
        }
        static void Draw2D(IDraw2D shape)
        {
            shape.Draw();
        }
        #endregion
        static void Main()
        {
            #region Abstract [Abstract Class, Abstract Method, Abstract Property]
            /// Shape shape;
            /// /// shape.CalcArea();
            /// 
            /// shape = new Rectangle(10, 20);
            /// 
            /// decimal rectArea = shape.CalcArea();
            /// decimal rectPeri = shape.Perimeter;
            /// 
            /// Console.WriteLine($"rect.CalcArea() => {rectArea}");
            /// Console.WriteLine($"rectPeri.Perimeter => {rectPeri}");
            /// 
            /// shape = new Square(20);
            /// 
            /// decimal squarePeria = shape.Perimeter;
            /// decimal squareArea = shape.CalcArea();
            /// 
            /// Console.WriteLine($"{squarePeria}");
            /// Console.WriteLine($"{squareArea}");
            /// 
            /// Circle circle = new Circle(10);
            /// Console.WriteLine(circle.Perimeter);
            /// Console.WriteLine(circle.CalcArea());
            /// 
            /// PrintShapeInfo(shape); 
            #endregion

            #region Static [Class, Attribute, Property, Constructor, Method]

            //Utility U01 = new Utility(1, 2);
            //Utility U02 = new Utility(5, 10);

            // The Result of Calling this Method Will not be diferent By the Difference of the Object State[Data]
            //Console.WriteLine(U01.CmToInch(254));
            //Console.WriteLine(U02.CmToInch(254));

            //Console.WriteLine(Utility.CmToInch(254));
            //Console.WriteLine(Utility.CalcCircleArea(10));

            //Console.WriteLine(Utility.CalcCircleArea(10)); // first usage so will call in first the static constructor then call the method
            //Console.WriteLine(Utility.CalcCircleArea(10)); // here will call the method direct becouse the static Constructor just Called One per Class Lifetime 

            //Math
            //Convert
            //Console

            //Guid
            ///Console.WriteLine(  Guid.NewGuid()); 


            #endregion


        }
    }
}
