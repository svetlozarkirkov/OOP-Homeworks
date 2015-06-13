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
            
            var billGatesAccount = new Deposit(billGates, 99999, 0.05m);
            Console.WriteLine(billGatesAccount);
            
            Console.WriteLine(new string('-',20));
            
            var microsoftAccount = new Mortgage(microsoft, 92247624, 0.04m);
            Console.WriteLine(microsoftAccount);
            Console.WriteLine(new string('-', 20));
            
            billGatesAccount.WithdrawMoney(200.44m);
            microsoftAccount.DepositMoney(56.12m);
            
            Console.WriteLine("Interest for {0}: {1:C2}",
                billGatesAccount.User.GetName(), billGatesAccount.CalculateInterest(234, 10));
            Console.WriteLine("Interest for {0}: {1:C2}",
                microsoftAccount.User.GetName(), microsoftAccount.CalculateInterest(73567, 24));
        }
    }
}