using System;
using P1_Point3D;

namespace P3_Paths
{
    class MainClass
    {
        static void Main()
        {
            Path3D path = new Path3D();
            var pointOne = new Point3D(1.1, 2.4, 13.2323);
            var pointTwo = new Point3D(45.344, 87.42, 156.22);
            path.AddPoint3DToPath(pointOne);
            path.AddPoint3DToPath(pointTwo);
            Console.WriteLine(path);
            Storage.AddPathToFile("pathcollection.txt",path);
            
            var pathTwo = Storage.LoadPathFromFile("paths.txt");
            Console.WriteLine(pathTwo);
        }
    }
}
