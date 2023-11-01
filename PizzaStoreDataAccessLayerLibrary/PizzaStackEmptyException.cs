using System;

namespace PizzaStoreDataAccessLayerLibrary;

class PizzaStackEmptyException: Exception
{
    string msg;
    public PizzaStackEmptyException()
    {
        msg="Sorry! No pizzas available at this moment.";
    }

    public override string Message => msg;
}