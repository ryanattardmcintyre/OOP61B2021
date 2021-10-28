using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_Polymorphism
{
    public class SavingsAccount
    {

        //Constructor overloading

         public SavingsAccount() //default constructor
         { }

         public SavingsAccount(double initialBalance)
        {
            Balance = initialBalance;
        }







        //Method Overloading can be achieved by either varying the number of parameters or the varying the data types of the parameters

        public double Balance { get; set; }

        public void Deposit (int amount)
        {
            Balance += amount;
        }

        public void Deposit (int amount , double charge)
        {
            Balance += amount;
            Balance -= charge;
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }

        public void Deposit (double amount, double charge)
        {
            Balance += amount;
            Balance -= charge;
        }

    }
}
