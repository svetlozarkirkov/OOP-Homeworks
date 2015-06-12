using System;
using P2_BankOfKurtovoKonare.Classes;

namespace P2_BankOfKurtovoKonare
{
    class TestClass
    {
        static void Main()
        {
            var billGates = new Individual("Bill", "Gates");
            var microsoft = new Company("Microsoft");
            Console.WriteLine(billGates);
            Console.WriteLine(microsoft);
        }
    }
}
