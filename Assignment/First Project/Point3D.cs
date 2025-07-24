using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.First_Task
{
    internal class Point3D : IComparable<Point3D>, ICloneable
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        #endregion

        #region Constructors
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D(int x, int y) : this(x, y, 0)
        {
        }
        public Point3D(int x) : this(x, 0, 0)
        {
        }
        public Point3D()
        {
        }
        #endregion


        #region Methods
        public int CompareTo(Point3D? other)
        {
            if (other is null) return 1;
            return this.X.CompareTo(other?.X) + this.Y.CompareTo(other?.Y);
        }
        public object Clone()
        {
            return new Point3D() // deep copy
            {
                X =  this.X,
                Y = this.Y,
                Z = this.Z
            };
        }

        #region Operators overloading
        public static bool operator ==(Point3D left, Point3D right)
        {
            if (left.X == right.X && left.Y == right.Y && left.Z == right.Z)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            if (left.X != right.X && left.Y != right.Y && left.Z != right.Z)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Overriding [ToString, Equals, GetHashCode]
        public override bool Equals(object? obj)
        {
            if (obj is null) return false;

            Point3D other = (Point3D)obj;

            return this.X == other.X && this.Y == other.Y && this.Z == other.Z;
        }
        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return HashCode.Combine(X, Y, Z);
        }
        public override string ToString()
        {
            return $"Point Coordiantes: ({X},{Y},{Z})";
        }
        #endregion

        #endregion

    }
}
