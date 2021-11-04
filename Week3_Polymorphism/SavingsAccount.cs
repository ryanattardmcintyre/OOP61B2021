using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_Polymorphism
{
    //static polymorphism : overloading - we add a new method with different parameters
    //dynamic polymorphism: overriding - we change the implementation

    //access modifiers:
    //public - property/class is accessible from everywhere
    //private - field is accessible only from the class where it is declared
    //protected - field/property is accessible from the class or from the inherited classes
    //internal - class is accessible from within the same project

    public class SavingsAccount: BankAccount
    {
        // Static Polymorphism
         public SavingsAccount(double initialBalance): base(initialBalance)
         {
            Fee = 1;
            ChargeLevelFee = 30;
         }

         public SavingsAccount(double fee, double chargeLevel, double initialBalance):base(initialBalance)
        {
            Fee = fee;
            ChargeLevelFee = chargeLevel;
        }

         public double Fee { get; set; }
         public double ChargeLevelFee { get; set; }

        // Dynamic Polymorphism
        public override double Withdraw(double amount)
        {
            base.Withdraw(amount);

            if (Balance > ChargeLevelFee)
                base.Withdraw(Fee);

            return Balance;
        }




    }
}
