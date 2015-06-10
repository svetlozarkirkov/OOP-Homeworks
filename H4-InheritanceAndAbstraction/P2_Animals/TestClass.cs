using System;
using System.Linq;

namespace P2_Animals
{
    class TestClass
    {
        static void Main()
        {
            var penka = new Kitten("Penka", 10);
                       
            var gosho = new Tomcat("Goshko", 12);
                        
            var haralampi = new Frog("Haralampi", 4, "male");

            var maria = new Dog("Mariika", 2, "female");

            var animalList = new Animal[]
            {
                penka,
                gosho,
                haralampi,
                maria,
                new Dog("Atanaska", 6, "female"),
                new Kitten("Kircho", 2),
                new Frog("Jack", 4, "male"), 
            };

            foreach (var animal in animalList)
            {
                Console.WriteLine(animal);
                animal.ProduceSound();
                Console.WriteLine();
            }

            Console.WriteLine("Average age of animals in the array is: {0:F2}",
                animalList.Average(x => x.Age));
        }
    }
}
