namespace SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,Car> carMap = new Dictionary<string,Car>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                double fuelAmount = double.Parse(data[1]);
                double consumptionPerKm = double.Parse(data[2]);

                var car = new Car {Model = model,FuelAmount = fuelAmount, FuelConsumption = consumptionPerKm };
                if(!carMap.ContainsKey(model))
                    carMap.Add(model,car);
            }
           string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = data[1];
                int distance = int.Parse(data[2]);

                Car car = carMap[model];
               if(!car.Drive(distance))
                    Console.WriteLine("Insufficient fuel for the drive");
            }

            foreach (var car in carMap.Values)
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
        }
    }
}
