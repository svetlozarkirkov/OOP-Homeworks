using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using P1_Point3D;

namespace P3_Paths
{
    class Storage
    {
        private const string PointMatcher = 
            @"x=([0-9]*\.?[0-9]+), y=([0-9]*\.?[0-9]+), z=([0-9]*\.?[0-9]+)";

        private const string PathMatcher = @"(x=([0-9]*\.?[0-9]+)), (y=([0-9]*\.?[0-9]+)), (z=([0-9]*\.?[0-9]+))";
        public static void AddPathToFile(string file, Path3D path)
        {
            File.WriteAllText(file, path.ToString());
        }

        public static Path3D LoadPathFromFile(string file)
        {
            var collected = new Path3D();
            var inputStr = File.ReadAllText(file);
            if (!Regex.IsMatch(inputStr, PathMatcher))
            {
                throw new ArgumentNullException("inputStr", "File does not contain Path3D data.");
            }
            
            MatchCollection matches = Regex.Matches(inputStr, PointMatcher);
            foreach (Match match in matches)
            {
                double x = double.Parse(match.Groups[1].Value);
                double y = double.Parse(match.Groups[2].Value);
                double z = double.Parse(match.Groups[3].Value);
                var tempPoint = new Point3D(x,y,z);
                collected.AddPoint3DToPath(tempPoint);
            }
            return collected;
        }
    }
}
