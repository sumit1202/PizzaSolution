// See https://aka.ms/new-console-template for more information

using PizzaStoreBusinessLogicLayerLibrary;
using PizzaStoreModelLibrary;

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
                System.Console.WriteLine("3. List the Pizza by type (veg/non-veg).");
                System.Console.WriteLine("4. List the Pizza by price range(min price - max price).");
                System.Console.WriteLine("5. Exit Pizza store.");
                System.Console.WriteLine("\nPlease enter your choce:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: { InitializePizzaStock(); break; }
                    case 2: { ListPizzaStock(); break; }
                    case 3: { ListPizzaStockByType(); break; }
                    case 4: { ListPizzaStockbyPriceRange(); break; }
                    case 5: { System.Console.WriteLine("\nGoodbye!!"); break; }
                    default: { System.Console.WriteLine("Invalid choice"); break; }
                }
            } while (choice != 5);
        }

        private void printPizzas(ICollection<Pizza> pizzas)
        {
            foreach (Pizza p in pizzas)
            {
                System.Console.WriteLine(p);
            }
        }

        private void ListPizzaStockbyPriceRange()
        {
            
            try
            {
                System.Console.WriteLine("Please enter MIN price range:");
                Double min = Convert.ToDouble(System.Console.ReadLine());
                System.Console.WriteLine("Please enter MAX price range:");
                Double max = Convert.ToDouble(System.Console.ReadLine());
                ICollection<Pizza> pizzaList = managePizza.GetPizzasByPriceRange(min,max);
                printPizzas(pizzaList);
            }
            catch (System.Exception e)
            {

                System.Console.WriteLine(e.Message);
            }
        }

        private void ListPizzaStockByType()
        {
            System.Console.WriteLine("Please enter type of pizza - veg or non-veg:");
            try
            {
                string type = System.Console.ReadLine()!;
                ICollection<Pizza> pizzaList = managePizza.GetPizzasByType(type);
                printPizzas(pizzaList);
            }
            catch (System.Exception e)
            {

                System.Console.WriteLine(e.Message);
            }
        }

        void ListPizzaStock()
        {
            ICollection<Pizza> pizzaList = managePizza.GetPizzas();
            printPizzas(pizzaList);

        }

        void InitializePizzaStock()
        {
            do
            {
                System.Console.WriteLine("Please enter the Pizza details:\n");
                Pizza pizza = new Pizza();
                pizza.takePizzaDetailsFromConsole();
                managePizza.AddANewPizza(pizza);

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
            Program prog = new Program();
            prog.InitializePizzaStore();
        }
    }
}
