using System;
using System.Collections.Generic;
using System.Text;

namespace Week6_Abstraction
{
    public class LongTermContract: Contract
    {
        public LongTermContract(double monthlyFee)
        {
            MonthlyRentalFee = monthlyFee;
        }
        public double MonthlyRentalFee { get; set; }
        public override double CalculateTaxFromRent()
        {
            return MonthlyRentalFee * 0.15;
        }

        public override double CalculateNetBalance()
        {
            return MonthlyRentalFee - CalculateTaxFromRent();
        }
    }
}
