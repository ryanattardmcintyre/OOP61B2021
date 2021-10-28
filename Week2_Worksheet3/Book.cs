using System;
using System.Collections.Generic;
using System.Text;

namespace Week2_Worksheet3
{
    class Book: Publication
    {
        public string Author { get; set; }

        /// <summary>
        /// This method should accept the amount of new copies as a parameter. 
        /// For functionality, this amount should be added to the copies attribute 
        /// and return the new amount of copies with a message – “There are x amount of copies left”.
        /// </summary>
        /// <param name="amount">The amount you want to buy</param>
        /// <returns></returns>
        /// 
        public string OrderCopies(int amount)
        {
            Copies += amount;

            return $"There are {Copies} amount of copies left";
        
        }

    }
}
