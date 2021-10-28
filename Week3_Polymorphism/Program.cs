using System;
using Week3_Polymorphism.Shapes;

namespace Week3_Polymorphism
{
    class Program
    {

        /*
         * Polymorphism:
         * 
         * 1. Static Polymorphism : 
         * 
         *  - Method Overloading - when you have 2 or more methods bearing the same name but with different implementation
         * 
         * 
         * 2. Dynamic Polymorphism
         * 
         * - Method Overriding - when you first apply inheritance and then in the derived class change the implemenation of a base method
         * 
         */




        static void Main(string[] args)
        {
            Circle myCircle = new Circle();
            myCircle.X = 10;
            myCircle.Y = 20;

            Console.ReadKey();


        }
    }
}
