using System.Drawing;
using static _06.VehicleCatalogue.Program;

namespace _06.VehicleCatalogue
{
    internal class Program
    {
        public class Vehicle
        {
            public Vehicle(string type, string model, string color, int hp)
            {
                Type = type.ToLower(); 
                Model = model;
                Color = color;
                HorsePower = hp;
            }
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }

            public void PrintVehicleInfo()
            {
                Console.WriteLine($"Type: {(Type == "car" ? "Car" : "Truck")}");
                Console.WriteLine($"Model: {Model}");
                Console.WriteLine($"Color: {Color}");
                Console.WriteLine($"Horsepower: {HorsePower}");
            }
        }
        

        static void Main(string[] args)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] vehiclesData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries
                    );
                string type = vehiclesData[0];
                string model = vehiclesData[1];
                string color = vehiclesData[2];
                int hp = int.Parse(vehiclesData[3]);

                Vehicle vehicle = new Vehicle(type, model, color, hp);

                vehicleList.Add(vehicle);
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle foundVehicle = vehicleList.FirstOrDefault(v => v.Model == input);
                if (foundVehicle != null)
                {
                    foundVehicle.PrintVehicleInfo();
                }
            }

            var cars = vehicleList.Where(v => v.Type == "car").ToList();
            var trucks = vehicleList.Where(v => v.Type == "truck").ToList();

            double avgCarsHp = cars.Count > 0 ? cars.Average(c => c.HorsePower) : 0.0;
            double avgTrucksHp = trucks.Count > 0 ? trucks.Average(t => t.HorsePower) : 0.0;

            Console.WriteLine($"Cars have average horsepower of: {avgCarsHp:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgTrucksHp:F2}.");
        }
    }
}
