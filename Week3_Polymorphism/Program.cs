using System;
using System.Collections.Generic;
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
            List<BankAccount> bank = new List<BankAccount>();
            int choice = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine();
                Console.WriteLine("1. Open an account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. List all accounts");
                Console.WriteLine("5. Quit");

                Console.WriteLine("Input menu choice");
                choice = Convert.ToInt32(Console.ReadLine());


                switch(choice)
                {
                    case 1:
                        
                        Console.WriteLine("Input Client Id");
                        string id = Console.ReadLine();

                        Console.WriteLine("Initial Balance:");
                        double balance = Convert.ToDouble(Console.ReadLine());

                        BankAccount myBankAccount = new BankAccount(balance);
                        myBankAccount.ClientId = id;
                        myBankAccount.IBAN = Guid.NewGuid().ToString();
                        myBankAccount.Active = true;
                        myBankAccount.DateOpened = DateTime.Now;

                        bank.Add(myBankAccount);

                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4: 

                        foreach(BankAccount b in bank)
                        {
                            Console.WriteLine($"Client Id: {b.ClientId}\nIban: {b.IBAN}\nDate Opened: {b.DateOpened.ToString("dd.MM.yyyy")}\nBalance: {b.Balance}");
                        }
                        Console.WriteLine("Click any key to continue...");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("You pressed the wrong input. Click to continue...");
                        Console.ReadKey();
                        break;
                }


            } while (choice != 5);

            Console.WriteLine("You're about to close the application. Hit Enter to terminate...");
            Console.ReadKey();


        }
    }
}
