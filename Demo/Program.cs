using Demo.Abstraction;
using Demo.Partial;
using Demo.Sealed;
using Demo.Static;

namespace Demo
{
    internal class Program
    {
        static void CalcPayment(PaymentProcessor02 processor)
        {
            processor.ProccessPayment(100);
        }

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

            #region Sealed [Class, Property, Method]
            /// //MyPaymentProcessor processor = new MyPaymentProcessor();
            /// //CalcPayment(processor);
            /// 
            /// ImmutableString str = new ImmutableString("Ahmed");
            /// str = new ImmutableString("Mena");
            /// 
            /// 
            /// Parent parent = new GrandChild();
            /// 
            /// Console.WriteLine(parent.Salary); // will be call the salary in child not in grandchild
            #endregion

            #region Partial [Class, Method, interface, struct]
            // Why i Need to make class Partial
            /// 1. if the Class Conatain alot so for ORGANIZATION we will make it Partial
            /// 2. if more than one devolper work in this class, struct, interface or method so 
            ///         to avoid the conflict possible happens when marge(git) => maked it partial
            /// 3. if i have tool that generate class or another, and i need to add method or any in this class
            ///         so i will make the class generated => partial. Why?
            ///    imagen if i need to regnerete this class, so the code i wass add it will be emliments
            ///    so to avoid this we maked the class generated partial and write my code in another file (partial)

            /// Employee employee = new Employee()
            /// {
            ///     Id = 1,
            ///     Name = "Mena",
            ///     Age = 21,
            ///     Address = "Dokki, Giza." // in another file (partial)
            /// }; 
            #endregion


        }
    }
}
