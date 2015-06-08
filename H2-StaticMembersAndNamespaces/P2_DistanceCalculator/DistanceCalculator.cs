using System;
using P1_Point3D;

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

        public static double CalculateDistancePoint3D(Point3D a, Point3D b)
        {
            double deltaX = b.X - a.X;
            double deltaY = b.Y - a.Y;
            double deltaZ = b.Z - a.Z;
            return (double)Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
        }
    }
}
