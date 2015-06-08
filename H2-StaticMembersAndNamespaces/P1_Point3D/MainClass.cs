using System;

namespace P1_Point3D
{
    class MainClass
    {
        static void Main()
        {
            Point3D initialPoint = new Point3D();
            Point3D constructedPoint = new Point3D(2,4,5);

            initialPoint.X = 4.5;   //changing individual points in the instances
            constructedPoint.Z = 12;

            var start = Point3D.ViewStartingPoint;  //invoking starting point static property

            Console.WriteLine(initialPoint);    // printing the objects to the console
            Console.WriteLine(constructedPoint);
        }
    }
}
