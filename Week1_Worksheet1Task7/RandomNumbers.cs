using System;
using System.Collections.Generic;
using System.Text;

namespace Week1_Worksheet1Task7
{
    class RandomNumbers
    {
        int number1;
        int number2;
        public void GenerateNumbers()
        {
            Random r = new Random();
            number1 = r.Next(0, 11);
            number2 = r.Next(0, 11);
        }

        public int GetNumber1()
        {
            return number1;
        }

        public int GetNumber2()
        {
            return number2;
        }


        public int FindSum() {
            return number1 + number2;
        }

        public bool IsEqual(int num)
        {
            if (num == FindSum()) return true;
            else return false;
        }
    }
}
