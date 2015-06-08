using System;
using System.IO;
using P1_Point3D;

namespace P3_Paths
{
    class Storage
    {
        public static void AddPathToFile(string file, Path3D path)
        {
            File.WriteAllText(file, path.ToString());
        }

        public static Path3D LoadPathFromFile(string file)
        {
            var collected = new Path3D();
            return collected;
        }
    }
}
