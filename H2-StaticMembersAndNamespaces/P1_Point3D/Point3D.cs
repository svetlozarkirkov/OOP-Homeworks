using System;
using System.Security.Cryptography.X509Certificates;

namespace P1_Point3D
{
    class Point3D
    {
        private double x, y, z = 0d;
        private static readonly Point3D StartingPoint = new Point3D(0, 0, 0);

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public Point3D()    //empty constructor, equal to StartingPoint
        {
            
        }

        public Point3D(double x, double y, double z)    //constructor with all three points as parameters
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return string.Format("[ x={0}, y={1}, z={2} ]", this.x, this.y, this.z);
        }
    }
}
