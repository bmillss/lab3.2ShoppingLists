using System;
using System.Collections.Generic;

namespace Lab3._2ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string userCont = "y";
            while (userCont == "y" || userCont == "yes")
            {
                Dictionary<string, double> menu = new Dictionary<string, double>();
                menu.Add("Cold cut", 11.99);
                menu.Add("steak&cheese ", 12.99);
                menu.Add("subadub", 7.99);
                menu.Add("egg&cheese", 6.99);

                Console.WriteLine("Welcome to Guenther's Market!");
                Console.WriteLine("\n Item  &   Price");
                Console.WriteLine("===================");

                foreach (KeyValuePair<string,double> pair in menu)
                {
                    Console.WriteLine("{0}   \t{1}", pair.Key, pair.Value);
                }

                
                Console.WriteLine("\nWould you like to add/remove/change an item? (A)(R)(C) or press (Q) to quit");
                string userChoice = Console.ReadLine().ToLower();

                switch(userChoice)
                {
                    case "a":
                        Console.WriteLine("\nWhat would you like to add?");
                        string userInput = Console.ReadLine().ToLower();
                        Console.WriteLine("At what price?");
                        double userPrice = Convert.ToDouble(Console.ReadLine());
                        menu[userInput] = userPrice;

                        foreach (var pair in menu)
                        {
                            Console.WriteLine($"{pair.Key} is priced at {pair.Value}");
                        }

                        break;
                    case "r":
                        Console.WriteLine("\nWhat would you like to remove?");
                        string userInputRem = Console.ReadLine().ToLower();
                        
                        if (menu.ContainsKey(userInputRem))
                        {
                            menu.Remove(userInputRem);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("This item was not found please try again");
                            continue;
                        }
                    case "c":
                        Console.WriteLine("\nWhich item would you like to change?");
                        foreach (var pair in menu)
                        {
                            Console.WriteLine($"{pair.Key} is priced at {pair.Value}");
                        }
                        string userChangeItem = Console.ReadLine();

                        Console.WriteLine("\nWhat price would you like it to be?");
                        double userInputChange = Convert.ToDouble(Console.ReadLine());

                        menu[userChangeItem] = userInputChange;

                        break;
                    default:
                        break;

                }
                foreach (var pair in menu)
                {
                    Console.WriteLine($"{pair.Key} is priced at {pair.Value}");
                }
                Console.WriteLine("\nWould you like to order anything else?");
                userCont = Console.ReadLine().ToLower();
            }

        }
    }
}
