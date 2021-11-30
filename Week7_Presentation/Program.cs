using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7_BusinessLogic.Context;
using Week7_BusinessLogic.Repositories;

namespace Week7_Presentation
{
    //Configuring one time settings
    //1. copy the connectionstring from App.Config of the BusinessLogic project to the 
    //    App.config of the presentation project

    //2. right-click the Presentation project, Manage NuGet Packages, Search for 
    //   EntityFramework, select the matching version (with the other project's EntityFramework)
    //   and Install


    class Program
    {
        static void Main(string[] args)
        {

            int choice = 0;
            ItemsRepository myItemsRepository = new ItemsRepository();
            do
            {
                Console.WriteLine("1.   List Items");
                Console.WriteLine("2.   Search Item");
                Console.WriteLine("999. Quit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        var myList = myItemsRepository.GetItems();

                        DisplayItems(myList);

                        Console.WriteLine("\nPress a key to go back to main menu...");
                        Console.ReadKey();
                        break;

                    case 2:

                        Console.Write("Type a name of a product: ");
                        string keyword = Console.ReadLine();

                        var fetchedItems =myItemsRepository.GetItems(keyword);

                        DisplayItems(fetchedItems);

                        Console.WriteLine("\nPress a key to go back to main menu...");
                        Console.ReadKey();
                        break;

                }

            } while (choice != 999);
        }

        static void DisplayItems(List<Item> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine($"Name: {item.Name}\tPrice: Eur{item.Price}");
            }
        }
    }
}
