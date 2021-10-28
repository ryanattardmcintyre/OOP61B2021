using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_Polymorphism
{
    public class BankAccount
    {
        public string IBAN { get; set; }

        protected double balance;
        public double Balance { get { return balance; } }
        public string ClientId { get; set; }
        public DateTime DateOpened { get; set; }
        public bool Active { get; set; }

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public virtual double Deposit(double amount)
        {
            balance += amount;
            return Balance;
        }

        public virtual double Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            { balance -= amount; }
            return Balance;
        }
    }
}
