using System;
using PizzaStoreModelLibrary;

namespace PizzaStoreDataAccessLayerLibrary;

public class PizzaRepository : Irepository<int, Pizza>
{
    List<Pizza> pizzas = new List<Pizza>();
    public Pizza Add(Pizza item)
    {
        if (item == null)
        {
            throw new ArgumentNullException("No Pizza object present");
        }
        else
        {
            item.Id = GenerateId();
            pizzas.Add(item);
            return item;
        }
    }

    private int GenerateId()
    {
        return pizzas.Count + 1;
    }

    public Pizza Delete(int key)
    {
        Pizza pizza = GetById(key);
        pizzas.Remove(pizza);
        return pizza;
    }

    public ICollection<Pizza> GetAll()
    {
        if (pizzas.Count == 0)
        {
            throw new PizzaStackEmptyException();
        }
        return pizzas;

    }

    public Pizza GetById(int key)
    {
        Pizza? pizza = pizzas.FirstOrDefault(p => p.Id == key);
        if (pizza == null)
        {
            throw new Exception("Invalid! No pizza found for the given Id");
        }
        else
        {
            return pizza;
        }


    }

    public Pizza Update(Pizza item)
    {
        if (item == null)
        {
            throw new Exception("Invalid! Cannot update pizza");
        }
        else
        {
            Pizza pizza = GetById(item.Id);
            pizza.Name = item.Name;
            pizza.Price = item.Price;
            pizza.Quantity = item.Quantity;
            pizza.Type = item.Type;
            return pizza;
        }
    }
}