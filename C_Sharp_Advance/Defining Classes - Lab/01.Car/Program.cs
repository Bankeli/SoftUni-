using System;
namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            var tiresList = new List<Tire[]>();
            var enginesList = new List<Engine>();
            var carList = new List<Car>();

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] data = input.Split();

                var firstYear = int.Parse(data[0]);
                var firstPressure = double.Parse(data[1]);
                var secondYear = int.Parse(data[2]);
                var secondPressure = double.Parse(data[3]);
                var thirdYear = int.Parse(data[4]);
                var thirdPressure = double.Parse(data[5]);
                var fourthYear = int.Parse(data[6]);
                var fourthPressure = double.Parse(data[7]);


                var tires = new Tire[]
                    {
                        new Tire(firstYear,firstPressure),
                        new Tire(secondYear,secondPressure),
                        new Tire(thirdYear,thirdPressure),
                        new Tire(fourthYear,fourthPressure),
                    };

                tiresList.Add(tires);

            }

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] data = input.Split();

                var horsePower = int.Parse(data[0]);
                var cubicCapacity = double.Parse(data[1]);

                var engine = new Engine(horsePower, cubicCapacity);
                enginesList.Add(engine);
            }

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] dataCar = input.Split();
                var make = dataCar[0];
                var model = dataCar[1];
                var year = int.Parse(dataCar[2]);
                var fuelQuantity = double.Parse(dataCar[3]);
                var fuelConsumption = double.Parse(dataCar[4]);
                int engineIndex = int.Parse(dataCar[5]);
                int tireIndex = int.Parse(dataCar[6]);

                Car newCar = new Car(make, model, year, fuelQuantity, fuelConsumption, enginesList[engineIndex], tiresList[tireIndex]);

                carList.Add(newCar);
            }

            ShowSpecialCars(carList);

        }

        public static void ShowSpecialCars(List<Car> cars)
        {
           
            
            var result = cars
                .Where(cars => cars.Year >= 2017)
            .Where(cars => cars.Engine.HorsePower > 330)
            .Where(cars =>
            {
                var tirePressure = cars.Tire.Select(t => t.Pressure).Sum();
                return tirePressure > 9 && tirePressure < 10;
            })
            .ToList();

            foreach (var car in result)
            {
                car.Drive(20);
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
            
        }
    }
}
