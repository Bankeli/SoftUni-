using System.Reflection.Metadata.Ecma335;

namespace NeedForSpeed
{
    internal class Program
    {
        class Car
        {
            public string Name { get; set; }
            public int Mileage { get; set; }
            public int Tank { get; set; }
            public Car(string name, int mileage, int fuel)
            {
                Name = name;
                Mileage = mileage;
                Tank = fuel;
            }

            public int Refill(int fuel)
            {
                int refilledTank = Math.Min(fuel, 75 - Tank);
                Tank += refilledTank;
                return refilledTank;
            }

            public override string ToString()
            {
                return $"{Name} -> Mileage: {Mileage} kms, Fuel in the tank: {Tank} lt.";
            }
        }
         static Dictionary<string,Car> Garage = new();
        static void Main(string[] args)
        {
            int carNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < carNumber; i++)
            {
                string[] commands = Console.ReadLine().Split("|");
                string carType = commands[0];
                int mileage = int.Parse(commands[1]); 
                int fuel = int.Parse(commands[2]);

                Car newCar = new Car(carType, mileage, fuel);
                Garage.Add(carType, newCar);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] arguements = input.Split(" : ",StringSplitOptions.RemoveEmptyEntries); 
                string action = arguements[0];
                string car = arguements[1];

                switch (action)
                {
                    case "Drive":
                        Drive(car, int.Parse(arguements[2]), int.Parse(arguements[3]));
                        break;
                    case "Refuel":
                        RefillTheTank(car, int.Parse(arguements[2]));
                        break;
                    case "Revert":
                        RevertCilometers(car, int.Parse(arguements[2]));
                        break;
                }
            }

            foreach (var car in Garage)
            {
                Console.WriteLine(car.Value);
            }
        }


        private static void Drive(string car, int distance, int fuel)
        {
            if (Garage[car].Tank < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
                return;
            }

            Garage[car].Mileage += distance;
            Garage[car].Tank -= fuel;

            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

            if (Garage[car].Mileage >= 100_000)
            {
                Console.WriteLine($"Time to sell the {car}!");
                Garage.Remove(car);
            }
        }
        private static void RefillTheTank(string car, int fuel)
        {
            int refill = Garage[car].Refill(fuel);

            Console.WriteLine($"{car} refueled with {refill} liters");
        }
        private static void RevertCilometers(string car, int kilometers)
        {
            Garage[car].Mileage -= kilometers;
            if (Garage[car].Mileage < 10_000)
            {
                Garage[car].Mileage = 10000;
                
            }
            else
                Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
        }
    }
}
