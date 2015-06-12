using System;
using P2_BankOfKurtovoKonare.Interfaces;

namespace P2_BankOfKurtovoKonare.Classes
{
    class Mortgage : Account
    {
        public Mortgage(Customer user, decimal balance) : base(user, balance)
        {
            
        }
        public override decimal CalculateInterest()
        {
            throw new NotImplementedException();
        }
    }
}
