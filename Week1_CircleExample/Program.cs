using System;

namespace Week1_CircleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input radius");

            Circle myCircle = new Circle();  //creating an instance of Circle and calling it myCircle
            myCircle.Radius = Convert.ToDouble(Console.ReadLine()); //asking the user to input the radius and storing the value in the property

            Console.WriteLine(); //skips a line
            Console.WriteLine("Area: " + myCircle.FindArea() ); //making a call to the FindArea method and it returns a value and we display the value
            Console.WriteLine($"Perimeter: {myCircle.FindPermiter()}");


            Console.WriteLine("Press any key to stop...");
            Console.ReadKey(); //stops the execution of the console application because it waits for a key to be pressed



        }
    }
}
