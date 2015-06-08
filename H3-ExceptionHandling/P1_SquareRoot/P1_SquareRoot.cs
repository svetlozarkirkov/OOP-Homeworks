using System;

namespace P1_SquareRoot
{
    class P1_SquareRoot
    {
        static void Main()
        {
            Console.Write("This program calculates Square Root!\n" +
                          "Enter number: ");
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("Invalid number");
                }
                else
                {
                    Console.WriteLine("Square root: {0}", Math.Sqrt(num));
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not a number!?");
            }
            finally
            {
                Console.WriteLine("Good bye :P");
            }
        }
    }
}
