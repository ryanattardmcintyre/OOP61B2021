using System;
using System.Collections.Generic;
using System.Text;

namespace Week6_Abstraction
{
    public class ShortTermContract: Contract
    {
        public double TotalRentalFee { get; set; }

        public ShortTermContract(double totalFee)
        {
            TotalRentalFee = totalFee;
        }

        public override double CalculateNetBalance()
        {
            return TotalRentalFee - CalculateTaxFromRent() - 50;
        }

        public override double CalculateTaxFromRent()
        {
            return TotalRentalFee * 0.15;
        }
    }
}
