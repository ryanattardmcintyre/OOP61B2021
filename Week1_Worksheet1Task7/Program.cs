using System;

namespace Week1_Worksheet1Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press a key to generate the numbers");
            Console.ReadKey();

            RandomNumbers myRandomNumbers = new RandomNumbers();
            myRandomNumbers.GenerateNumbers();
        


            Console.WriteLine("Guess the total of the two numbers which were randomly generated: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You guessed the number: " + myRandomNumbers.IsEqual(guess));
            Console.WriteLine($"The numbers generated were: " +
                $"{myRandomNumbers.GetNumber1()}, {myRandomNumbers.GetNumber2()}, Total: {myRandomNumbers.FindSum()}");

            Console.WriteLine("Hit a key to terminate application...");
            Console.ReadKey();

        }
    }
}
