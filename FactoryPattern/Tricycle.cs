namespace FactoryPattern;

public class Tricycle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Building a new Tricycle!");
    }
}