//mange Pizza model
using System;

namespace PizzaApp
{
    internal class ManagePizza
    {
        List<Pizza> pizzaList = new List<Pizza>();

        public void AddPizza(Pizza pizza)
        {
            int id = pizzaList.Count;
            pizza.Id = ++id;
            pizzaList.Add(pizza);
        }

        public Pizza takePizzaDetailsFromConsole()
        {
            Pizza pizza = new Pizza();

            System.Console.WriteLine("Please enter pizza name: ");
            pizza.Name = Console.ReadLine();

            System.Console.WriteLine("Please enter pizza price: ");
            pizza.Price = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Please enter pizza quantity: ");
            pizza.Quantity = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Please enter pizza type - Type \"veg or non-veg\":");
            pizza.Type = Console.ReadLine();

            return pizza;
        }

        public List<Pizza> GetPizzasList()
        {
            return pizzaList;
        }

        public void PrintPizzaDetails(Pizza pizza)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Pizza Id: " + pizza.Id);
            System.Console.WriteLine("Pizza Name: " + pizza.Name);
            System.Console.WriteLine("Pizza Price: $" + pizza.Price);
            System.Console.WriteLine("Pizza Quantity: " + pizza.Quantity);
            System.Console.WriteLine("Pizza Type: " + pizza.Type);
        }
    }
}