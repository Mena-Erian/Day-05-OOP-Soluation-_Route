using Assignment.First_Task;
using System;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            #region Project 1
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

            #region Task 5 [Implement IComparable<Point3D> interface]
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

            #region Task 6 [Implment ICloneable interface to make shallow copy and deep copy]
            /// Point3D[] points01 = new Point3D[10];
            /// Random random = new Random();
            /// int num = 0;
            /// for (int i = 0; i < points01.Length; i++)
            /// {
            ///     num = (int)Math.Floor(random.NextDouble() * 100); // Random Numbers between 0 and 100
            ///     points01[i] = new Point3D(num, ++num, num);
            /// }
            /// Console.WriteLine("\nBefore Copy");
            /// foreach (Point3D point in points01)
            /// {
            ///     Console.WriteLine(point);
            /// }

            #region Shallow Copy
            /// Point3D[] points02 = (Point3D[])points01.Clone();
            /// Console.WriteLine("\nAfter Copeing");
            /// 
            /// foreach (Point3D point in points02)
            /// {
            ///     Console.WriteLine(point);
            /// }
            /// 
            /// Console.WriteLine(ReferenceEquals(points01[0], points02[0]));// True // Maked Shallow Copy 
            /// points02[0].X = 0;
            /// points02[0].Y = 0;
            /// points02[0].Z = 0;
            /// // So any Change in arr1 it will be refelct in arr2 bacouse they have the 
            /// // same reference so they are change in the same object
            /// Console.WriteLine(points01[0]); // it will be changed
            #endregion

            #region Deep Copy
            /// Point3D[] points02 = new Point3D[points01.Length];
            /// for (int i = 0; i < points02.Length; i++)
            /// {
            ///     points02[i] = (Point3D)points01[i].Clone();
            /// }
            /// 
            /// Console.WriteLine("\nAfter Copeing");
            /// foreach (Point3D point in points01)
            /// {
            ///     Console.WriteLine(point);
            /// }
            /// 
            /// Console.WriteLine(ReferenceEquals(points01[0], points02[0]));//False // Maked Deep Copy 
            /// points02[0].X = 0;
            /// points02[0].Y = 0;
            /// points02[0].Z = 0;
            /// // So any Change in arr1 it will be not refelct in arr2 bacouse they don't have the 
            /// // same reference so, they are not changing in the same object
            /// Console.WriteLine(points01[0]); // it will be not changed
            #endregion

            #endregion
            #endregion

        }
    }
}
