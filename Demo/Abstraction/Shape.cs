using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    // Abstract Class
    // is a Partial Impementation for Other Classes
    // is a Container for Common Code[Fully Implemented Members, Abstract Members] among many Classes
    // You Can't Create an Object from Abstract Class [it is not fully implmented].
    abstract class Shape
    {
        //protected Shape() { }
        protected Shape(decimal dim01, decimal dim02)
        {
            Dim01 = dim01;
            Dim02 = dim02;
        }

        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }
        // Abstract Property = Virtual Property Without Implmentation
        public abstract decimal Perimeter { get; }

        // Abstract Method = Virtual Method Without Implmentation
        public abstract decimal CalcArea();
    }

    abstract class RectBase : Shape
    {
        protected RectBase(decimal dim01, decimal dim02) : base(dim01, dim02)
        {

        }
        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }

    }

    // Concrete class => class fully implmented
    //                   is a
    class Rectangle : RectBase
    {
        public Rectangle(decimal dim01, decimal dim02) : base(dim01, dim02)
        {

        }
        public override decimal Perimeter
        {
            get { return (Dim01 + Dim02) * 2; }
        }

    }
    class Square : RectBase
    {
        public Square(decimal dim01) : base(dim01, dim01)
        {

        }
        public override decimal Perimeter
        {
            get { return Dim01 * 4; }
        }
    }

    // Concrete Class
    class Circle : Shape, IDraw2D, IDraw3D
    {
        public Circle(decimal Raduis) : base(Raduis, Raduis)
        {
        }
        public override decimal Perimeter
        {
            get { return 2 * 3.14M * Dim01; }
        }
        public override decimal CalcArea()
        {
            return 3.14M * Dim01 * Dim01;
        }

        void IDraw2D.Draw()
        {
            throw new NotImplementedException();
        }

        void IDraw3D.Draw()
        {
            throw new NotImplementedException();
        }
    }
    class Triangle : Shape
    {
        public Triangle(decimal dim03, decimal dim02, decimal dim01) : base(dim01, dim02)
        {
            Dim03 = dim03;
        }

        public decimal Dim03 { get; set; }
        public override decimal Perimeter => throw new NotImplementedException();

        public override decimal CalcArea()
        {
            throw new NotImplementedException();
        }
    }


    public interface IDraw2D
    {
        //static IDraw2D() { }
        void Draw();
    }
    public interface IDraw3D
    {
        void Draw();
    }
}
