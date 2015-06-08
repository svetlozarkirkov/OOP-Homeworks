using System;

namespace P1_Point3D
{
    class Point3D
    {
        private double x, y, z = 0d;
        private static readonly Point3D StartingPoint = new Point3D(0, 0, 0);

        public static Point3D ViewStartingPoint 
        {
            get
            {
                return StartingPoint;
            }
        }

        //getters and setters for all three points below
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

        public Point3D()    //empty constructor, equals to {0,0,0}
        {
            
        }

        public Point3D(double x, double y, double z)    //constructor with all three points as parameters
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()   //printing the point3d in user friendly way
        {
            return string.Format("[ x={0}, y={1}, z={2} ]", this.x, this.y, this.z);
        }
    }
}
