using System;

namespace P1_Persons
{
    class MainClass
    {
        static void Main()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            //Console.WriteLine("name = {0}", name);
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("age = {0}", age);
            Console.Write("Enter email (optional): ");
            string email = Console.ReadLine();
            //Console.WriteLine("email = {0}", email);
            var personOne = new Person(name, age);  // object created by the constructor which does not take the email
            var personTwo = new Person(name, age, email);   //object created by the constructor which takes the email if it exists
            Console.WriteLine(personOne);   // printing the objects at the console
            Console.WriteLine(personTwo);
        }
    }
}
