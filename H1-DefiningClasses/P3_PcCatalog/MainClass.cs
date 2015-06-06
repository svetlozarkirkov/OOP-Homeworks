using System;
using System.Runtime.CompilerServices;

namespace P3_PcCatalog
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Computer testComputer = new Computer();
            testComputer.Name = "Test PC";
            Component intelProc = new Component("i5-3230", 450.20m);
            Component kingstonRam = new Component("Kingston 8GB DDR4", 102.48m);
            Console.WriteLine(intelProc);
            Console.WriteLine(kingstonRam);
            testComputer.AddComponent(intelProc);
            testComputer.AddComponent(kingstonRam);
            testComputer.PrintData();
        }
    }
}
