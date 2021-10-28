using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_Polymorphism
{
    public class BankAccount
    {
        public string IBAN { get; set; }
        public double Balance { get; set; }
        public string ClientId { get; set; }
        public DateTime DateOpened { get; set; }
        public bool Active { get; set; }

        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        public virtual double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }

        public virtual double Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            { Balance -= amount; }
            return Balance;
        }
    }
}
