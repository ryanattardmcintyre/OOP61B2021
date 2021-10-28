using System;
using System.Collections.Generic;
using System.Text;

namespace Week2_Worksheet3
{
    class Magazine : Publication
    {
        public int CurrIssue { get; set; }
        public int OrderQty { get; set; }


        /// <summary>
        /// This method should accept the amount of the new order quantity as a parameter.
        /// For functionality, this amount should replace the current orderQty.
        /// </summary>
        /// <param name="amount"></param>
        public void AdjustQty(int amount)
        {
            OrderQty = amount;
        }

        /// <summary>
        ///   This method should simply increase the currIssue attribute.
        /// </summary>
        public void RecNewIssue()
        {
            CurrIssue++;
        }





    }
}
