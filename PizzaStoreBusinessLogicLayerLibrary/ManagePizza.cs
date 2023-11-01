using PizzaStoreDataAccessLayerLibrary;
using PizzaStoreModelLibrary;

namespace PizzaStoreBusinessLogicLayerLibrary;

public class ManagePizza
{
    Irepository<int, Pizza> repos = new PizzaRepository();
    public ICollection<Pizza> GetPizzas()
    {
        return repos.GetAll();
    }

    /// <summary>
    /// This method will get the pizza list on the basis of type - veg or non-veg
    /// </summary>
    /// <param name="type">veg or non-veg</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>

    public ICollection<Pizza> GetPizzasByType(string type)
    {
        var pizzas = GetPizzas();
        if (type == "veg" || type == "non-veg")
        {
            var filteredByTypePizzas = pizzas.Where(p => p.Type == type).ToList();
            if (filteredByTypePizzas.Count == 0)
            {
                throw new Exception("No such pizza type found");
            }
            else
            {
                return filteredByTypePizzas;
            }
        }
        else
        {
            throw new Exception("Inavalid pizza type");
        }
    }

    /// <summary>
    ///  This methods will get pizza list on the basis of min and max price range
    /// </summary>
    /// <param name="minPrice">0</param>
    /// <param name="maxPrice">>0</param>
    /// <returns></returns>
    /// <exception cref="Exception"></exception>

    public ICollection<Pizza> GetPizzasByPriceRange(double minPrice,double maxPrice)
    {
        var pizzas = GetPizzas();
        if (minPrice>=0 && maxPrice>0)
        {
            var filteredByPricePizzas = pizzas.Where(p => p.Price >=minPrice && p.Price<=maxPrice).ToList();
            if (filteredByPricePizzas.Count == 0)
            {
                throw new Exception("No such pizza within given price range found");
            }
            else
            {
                return filteredByPricePizzas;
            }
        }
        else
        {
            throw new Exception("Inavalid pizza price range");
        }
    }

    public Pizza AddANewPizza(Pizza pizza){
        repos.Add(pizza);
        return pizza;
    }

}
