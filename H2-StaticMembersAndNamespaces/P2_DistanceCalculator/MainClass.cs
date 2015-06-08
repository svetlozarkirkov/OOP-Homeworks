using System;

namespace P2_DistanceCalculator
{
    class MainClass
    {
        static void Main()
        {
            var distanceTest = DistanceCalculator.CalculateDistance(1.1, 2.2, 3.3, 4.4, 5.5, 6.6);
            Console.WriteLine(distanceTest);
        }
    }
}
