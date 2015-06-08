using System;
using P1_Point3D;

namespace P2_DistanceCalculator
{
    class MainClass
    {
        static void Main()
        {
            var distanceTestOne = DistanceCalculator.CalculateDistance(1.1, 2.2, 3.3, 4.4, 5.5, 6.6);
            Console.WriteLine(distanceTestOne);

            var firstPoint = new Point3D(12.4,14.7,16.2);
            var secondPoint = new Point3D(56.12, 78.2, 112.8257);
            var distanceTestTwo = DistanceCalculator.CalculateDistancePoint3D(firstPoint, secondPoint);
            Console.WriteLine(distanceTestTwo);
        }
    }
}
