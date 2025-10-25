namespace _07.VehicleCatalogue
{
    internal class Program
    {

        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }
        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }

        public class Catalogue
        {
            public Catalogue()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }
        }

        static void Main(string[] args)
        {
            string input = string.Empty;
            Catalogue catalog = new Catalogue();

            while ((input = Console.ReadLine()) != "end")
            {

                string[] inputArguments = input.Split("/");

                if (inputArguments[0] == "Car")
                {
                    Car newCar = new Car();
                    newCar.Brand = inputArguments[1];
                    newCar.Model = inputArguments[2];
                    newCar.HorsePower = int.Parse(inputArguments[3]);

                    catalog.Cars.Add(newCar);
                }
                else if (inputArguments[0] == "Truck")
                {
                    Truck newTruck = new Truck();

                    newTruck.Brand = inputArguments[1];
                    newTruck.Model = inputArguments[2];
                    newTruck.Weight = int.Parse(inputArguments[3]);

                    catalog.Trucks.Add(newTruck);
                }
            }

            catalog.Cars = catalog.Cars.OrderBy(c => c.Brand).ToList();
            catalog.Trucks = catalog.Trucks.OrderBy(t => t.Brand).ToList();

            PrintFinalResult(catalog.Cars, catalog.Trucks);
        }

        static void PrintFinalResult(List<Car> cars, List<Truck> trucks)
        {
            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }

            }
            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }

            }

        }
    }
}
