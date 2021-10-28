using System;

namespace Week1_IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book(); //i am creating an object/ instance
                                      //name of object: myBook

            myBook.Name = "Introduction to databases";
            myBook.Category = "Fiction";
            myBook.Isbn = "1231729128372";
            myBook.Price = 50;
            Console.WriteLine($"Book Name: {myBook.Name}");
            Console.WriteLine($"Book Isbn: {myBook.Isbn}");

            Console.WriteLine("Input tax rate (%): ");
            var rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Shelf Price: {myBook.GetShelfPrice(rate)}");

            Console.ReadKey();


        }
    }
}
