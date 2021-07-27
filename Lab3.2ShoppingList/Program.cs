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
                menu.Add("Apple", .99);
                menu.Add("Bread", 5.99);
                menu.Add("Cheese", 2.99);
                menu.Add("Eggs", 3.99);
                menu.Add("Milk", 4.99);

                Console.WriteLine("Welcome to Guenther's Market!");
                Console.WriteLine("\n Item  &   Price");
                Console.WriteLine("===================");

                foreach (KeyValuePair<string,double> kvp in menu)
                {
                    Console.WriteLine("key = {0}, Value = {1}", kvp.Key, kvp.Value);
                }
                
                Console.WriteLine("What item would you like to order?");
                string userInput = Console.ReadLine().ToLower();

                if (menu.ContainsKey(userInput))
                {
                    Console.WriteLine($"Adding {userInput} to cart at insert price");
                }
                
                else
                {
                    Console.WriteLine("Sorry we don't have those. Please try again.");
                }

                Console.WriteLine("Would you like to order anything else?");
                userCont = Console.ReadLine().ToLower();
            }

        }
    }
}
