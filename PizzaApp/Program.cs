// See https://aka.ms/new-console-template for more information

using System;
using System.Globalization;
using System.Reflection.Metadata;

namespace PizzaApp
{
    internal class Program
    {
        ManagePizza managePizza = new ManagePizza();
        void InitializePizzaStore()
        {
            int choice = 0;
            do
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Welcome to the Pizza store!!");
                System.Console.WriteLine("1. Enter the Pizza stock.");
                System.Console.WriteLine("2. List the Pizza stock.");
                System.Console.WriteLine("3. Exit Pizza store.");
                System.Console.WriteLine("\nPlease enter your choce:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: { InitializePizzaStock(); break; }
                    case 2: { ListPizzaStock(); break; }
                    case 3: { System.Console.WriteLine("\nGoodbye!!"); break; }
                    default: { System.Console.WriteLine("Invalid choice"); break; }
                }
            } while (choice != 3);
        }

        void ListPizzaStock()
        {
            List<Pizza> pizzaList = managePizza.GetPizzasList();
            foreach (Pizza p in pizzaList)
            {
                managePizza.PrintPizzaDetails(p);
            }

        }

        void InitializePizzaStock()
        {
            do
            {
                System.Console.WriteLine("Please enter the Pizza details:\n");
                Pizza pizza = managePizza.takePizzaDetailsFromConsole();
                managePizza.AddPizza(pizza);

                System.Console.WriteLine("Do you want another Pizza? Type \"yes\" or \"no\":");
                string choice = Console.ReadLine()!.ToLower();
                if (choice != "yes")
                {
                    break;
                }
            } while (true);
        }

        static void Main(string[] args)
        {
            Program prog=new Program();
            prog.InitializePizzaStore();
        }
    }
}
