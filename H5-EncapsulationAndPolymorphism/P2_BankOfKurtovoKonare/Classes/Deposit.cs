using System;
using P2_BankOfKurtovoKonare.Interfaces;

namespace P2_BankOfKurtovoKonare.Classes
{
    class Deposit : Account, IWithdrawable
    {
        public Deposit(Customer user, decimal balance) : base(user,balance)
        {
            
        }
        public override decimal CalculateInterest()
        {
            throw new NotImplementedException();
        }

        public void WithdrawMoney(decimal moneyAmount)
        {
            this.Balance -= moneyAmount;
        }
    }
}
