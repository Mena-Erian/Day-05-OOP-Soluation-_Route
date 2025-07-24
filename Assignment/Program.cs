using Assignment.First_Task;
using System;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            #region Task 2, 3 [Casting]
            /// Point3D p1 = new Point3D()
            /// {
            ///     X = Helper.GetIntFromUserUsingTryParse("Point 1 X"),
            ///     Y = Helper.GetIntFromUserUsingParse("Point 1 Y"),
            ///     Z = Helper.GetIntFromUserUsingConvert("Point 1 Z")
            /// };
            /// Console.WriteLine("----------------------------------------------");
            /// Point3D p2 = new Point3D()
            /// {
            ///     X = Helper.GetIntFromUserUsingTryParse("Point 2 X"),
            ///     Y = Helper.GetIntFromUserUsingParse("Point 2 Y"),
            ///     Z = Helper.GetIntFromUserUsingConvert("Point 2 Z")
            /// };
            /// Console.WriteLine(p1.ToString());
            /// Console.WriteLine(p2.ToString()); 
            #endregion

            #region Task 4 [Operators Overloading and override]
            /// Point3D p1 = new Point3D(1,2,3);
            /// Point3D p2 = new Point3D(1,2,3);
            /// Console.WriteLine(p1 == p2);
            /// Console.WriteLine(p1.Equals(p2));
            /// Console.WriteLine(p1.GetHashCode());
            /// Console.WriteLine(p2.GetHashCode());
            #endregion

            #region Task 5 [Implemente IComparable<Point3D> interface]
            /// Point3D[] points = new Point3D[10];
            /// Random random = new Random();
            /// int num = 0;
            /// for (int i = 0; i < points.Length; i++)
            /// {
            ///     num = (int)Math.Floor(random.NextDouble() * 100); // Random Numbers between 0 and 100
            ///     points[i] = new Point3D(num, ++num, num);
            /// }
            /// Console.WriteLine("\nBefore sorting");
            /// foreach (Point3D point in points)
            /// {
            ///     Console.WriteLine(point);
            /// }
            /// Console.WriteLine("\nAfter sorting");
            /// Array.Sort(points); // Implemente IComparable<Point3D> interface
            /// foreach (Point3D point in points)
            /// {
            ///     Console.WriteLine(point);
            /// } 
            #endregion

        }
    }
}
