using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace P3_StringDisperser
{
    class TestClass
    {
        static void Main()
        {
            StringDisperser people = new StringDisperser("Pesho", "Maria", "Gosho");
            StringDisperser peopleClone = people.Clone();
            
            StringDisperser cities = new StringDisperser("Varna","Sofia","Berlin","New York");
            StringDisperser animals = new StringDisperser("Cat","Dog","Rabbit","Goat");
            
            var strDspList = new List<StringDisperser>
            {
                animals,
                cities,
                people
            };

            foreach (var strdsp in strDspList)
            {
                Console.WriteLine(strdsp);
                Console.WriteLine(new string('-',50));
            }

            strDspList.Sort();  // by total char sum

            foreach (var element in strDspList)
            {
                foreach (var ch in element)
                {
                    Console.Write(ch + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
