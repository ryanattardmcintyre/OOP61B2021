using System;
using System.Collections.Generic;
using System.Text;

namespace Week2_Worksheet3
{
    class Publication
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public int Copies { get; set; }
        public string SellCopy(int amount)
        {
            Copies -= amount;

            return "There are "+ Copies +" amount of copies left";
        }



    }
}
