namespace PizzaStoreModelLibrary;

public class Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public string? Type { get; set; }

    public void takePizzaDetailsFromConsole()
    {

        System.Console.WriteLine("Please enter pizza name: ");
        Name = Console.ReadLine()!;

        System.Console.WriteLine("Please enter pizza price: ");
        Price = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine("Please enter pizza quantity: ");
        Quantity = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Please enter pizza type - Type \"veg or non-veg\":");
        Type = Console.ReadLine()!;

    }

    public override string ToString()
    {
        return "Pizza Id: " + Id + "\n" +
        "Pizza Name: " + Name + "\n" +
        "Pizza Quantity: " + Quantity + "\n" +
        "Pizza Price: " + "Rs " + Price + "\n" +
        "Pizza Type: " + Type + "\n";
    }

    public override bool Equals(object? obj)
    {
        Pizza p1,p2;
        p1=this;
        p2= (Pizza)obj!;
        if(p1.Id==p2.Id){
            return true;
        }else{
            return false;
        }

    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }
}
