namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to the Vehicle Factory ===");
            Console.WriteLine();

            Console.Write("How many tires does your vehicle have? ");
            string input = Console.ReadLine() ?? "";

            // Convert the input to an integer
            int tireCount = int.Parse(input);

            // Ask the factory for a vehicle — we don't care which type!
            IVehicle vehicle = VehicleFactory.GetVehicle(tireCount);

            // Drive whatever we got back
            vehicle.Drive();
        }
    }
}