using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_Polymorphism
{
    public class FixedAccount: BankAccount
    {
        //FixedAccount is the derived class
        //BankAccount is the base class

        public FixedAccount(double initialBalance):
            base(initialBalance)
        { }
        public double InterestRate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public void RunOnExpiry(BankAccount destinationAccount)
        {
            destinationAccount.Deposit(Balance);
            base.Withdraw(Balance);
            Active = false;
        }
        public override double Deposit(double amount)
        {
            throw new Exception("Deposit not allowed");
        }
        public override double Withdraw(double amount)
        {
            throw new Exception("Withdrawal not allowed");
        }
    }
}
