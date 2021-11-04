using System;
using System.Collections.Generic;
using Week3_Polymorphism.Shapes;
using System.Linq;

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

                        Console.WriteLine("1. Fixed");
                        Console.WriteLine("2. Savings");
                        int accountChoice = Convert.ToInt32(Console.ReadLine());

                        BankAccount myBankAccount; //note: just the declaration
                        if (accountChoice == 1)
                        {
                            myBankAccount = new FixedAccount(balance); //initialization of Fixed
                        }
                        else if(accountChoice==2)
                        {
                            myBankAccount = new SavingsAccount(balance); //initialization of Savings
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                            break; //stops this iteration so it doesnt execute the following code
                        }


                        myBankAccount.ClientId = id;
                        myBankAccount.IBAN = Guid.NewGuid().ToString();
                        myBankAccount.Active = true;
                        myBankAccount.DateOpened = DateTime.Now;

                        bank.Add(myBankAccount);

                        break;

                    case 2:

                        Console.WriteLine("Input amount to deposit");
                        double amount = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Input bank account");
                        string accountId = Console.ReadLine();

                        BankAccount retrievedBankAccount = bank.SingleOrDefault(a => a.IBAN == accountId);

                        //foreach (BankAccount a in bank)
                        //{
                        //    if (a.IBAN == accountId)
                        //    {
                        //        retrievedBankAccount = a;
                        //        break;
                        //    }
                        //}

                        if(retrievedBankAccount != null)
                        {
                            try
                            {
                                double newBalance = retrievedBankAccount.Deposit(amount);
                                Console.WriteLine($"New Balance of account with IBAN {retrievedBankAccount.IBAN} is {newBalance}");
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Bank account does not exist");
                        }
                        Console.WriteLine("Press a key to continue...");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Input amount to withdraw");
                        amount = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Input bank account");
                        accountId = Console.ReadLine();

                        retrievedBankAccount = bank.SingleOrDefault(a => a.IBAN == accountId);

                        //foreach (BankAccount a in bank)
                        //{
                        //    if (a.IBAN == accountId)
                        //    {
                        //        retrievedBankAccount = a;
                        //        break;
                        //    }
                        //}

                        if (retrievedBankAccount != null)
                        {
                            double newBalance = retrievedBankAccount.Withdraw(amount);
                            Console.WriteLine($"New Balance of account with IBAN {retrievedBankAccount.IBAN} is {newBalance}");
                        }
                        else
                        {
                            Console.WriteLine("Bank account does not exist");
                        }
                        Console.WriteLine("Press a key to continue...");
                        Console.ReadKey();

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
