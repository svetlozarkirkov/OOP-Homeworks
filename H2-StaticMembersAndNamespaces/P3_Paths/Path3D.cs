using System;
using System.Collections.Generic;
using System.Text;
using P1_Point3D;


namespace P3_Paths
{
    public class Path3D
    {
        private List<Point3D> pointCollection = new List<Point3D>();

        public Path3D()
        {
            
        }

        public void AddPoint3DToPath(Point3D point)
        {
            this.pointCollection.Add(point);
        }

        public override string ToString()
        {
            var pointCollectionString = new StringBuilder();
            pointCollectionString.Append("[");
            foreach (var point in this.pointCollection)
            {
                pointCollectionString.Append(point);
            }
            pointCollectionString.Append("]");
            return pointCollectionString.ToString();
        }
    }
}
