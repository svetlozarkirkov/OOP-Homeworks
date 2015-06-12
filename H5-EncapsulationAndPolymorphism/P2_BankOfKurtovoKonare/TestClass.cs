using System;
using P2_BankOfKurtovoKonare.Classes;

namespace P2_BankOfKurtovoKonare
{
    class TestClass
    {
        static void Main()
        {
            Customer billGates = new Individual("Bill", "Gates");
            Customer microsoft = new Company("Microsoft");
            var billGatesAccount = new Deposit(billGates, 1000);
            Console.WriteLine(billGatesAccount);
            var microsoftAccount = new Mortgage(microsoft, 9875);
            Console.WriteLine(microsoftAccount);
        }
    }
}