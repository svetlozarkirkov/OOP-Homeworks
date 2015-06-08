using System;

namespace P2_DistanceCalculator
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            double deltaZ = z2 - z1;
            return (double)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }
    }
}
