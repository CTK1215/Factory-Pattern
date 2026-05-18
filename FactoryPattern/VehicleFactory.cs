namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle GetVehicle(int numberOfTires)
    {
        if (numberOfTires == 2)
        {
            return new Motorcycle();
        }
        else if (numberOfTires == 4)
        {
            return new Car();
        }
        else if (numberOfTires == 18)
        {
            return new BigRig();
        }
        else if (numberOfTires == 3)
        {
            return new Tricycle();
        }
        else
        {
            Console.WriteLine($"❌ No vehicle has {numberOfTires} tires. Defaulting to a Car.");
            return new Car();
        }
    }
}