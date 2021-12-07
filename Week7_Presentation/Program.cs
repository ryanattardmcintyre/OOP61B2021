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
            CategoryRepository myCategoryRepository = new CategoryRepository();
            do
            {
                Console.Clear();
                Console.WriteLine("1.   List Items");
                Console.WriteLine("2.   Search Item");
                Console.WriteLine("3.   Sort");

                Console.WriteLine("5.   Adding an item");
                Console.WriteLine("6.   Deleting an item");
                Console.WriteLine("7.   Updating an item");
                Console.WriteLine("999. Quit");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input. Write only numbers listed in menu. Press a key to continue...");
                    Console.WriteLine("Error: " + ex.Message);
                    Console.ReadKey();

                }
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

                    case 3:

                        Console.Clear();
                        Console.WriteLine("Sort by...");
                        Console.WriteLine("1. Name");
                        Console.WriteLine("2. Price");

                        Console.Write("Input choice:");
                        int choiceForSorting = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Ascending? (y/n)");
                        bool ascending = true;
                        string choiceForAscending = Console.ReadLine();
                        if (choiceForAscending.ToLower() == "y") ascending = true;
                        else ascending = false;

                        if(choiceForSorting == 1)
                        {
                            DisplayItems(myItemsRepository.Sort(SortCriteria.Name, ascending));
                        }
                        else
                        {
                           var sortedList = myItemsRepository.Sort(SortCriteria.Price, ascending);
                            DisplayItems(sortedList);
                        }

                        Console.WriteLine("\nPress a key to go back to main menu...");
                        Console.ReadKey();

                        break;

                    case 5:

                        try
                        {
                            Item myNewItem = new Item();
                            Console.Write("Name: ");

                            myNewItem.Name = Console.ReadLine();
                            Console.Write("Price: ");
                            myNewItem.Price = Convert.ToDecimal(Console.ReadLine()); //this could be a line of code that may raise an exception

                            //we list categories to the user

                            var categories = myCategoryRepository.GetCategories();

                            foreach (var category in categories)
                            {
                                Console.WriteLine($"{category.Id}. {category.Name}");
                            }
                            Console.Write("Category: ");
                            myNewItem.CategoryId = Convert.ToInt32(Console.ReadLine()); //this may raise an exception

                            myItemsRepository.Add(myNewItem); //this can throw an exception if the user has input a category id out of range

                            Console.WriteLine("Item added successfully");
                        }
                        catch
                        {
                            Console.WriteLine("Invalid inputs. Check your inputs again next time.");
                        }
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
