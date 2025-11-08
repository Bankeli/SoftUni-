

using Vehicle.Core.Interfaces;
using Vehicle.IO.Interfaces;
using Vehicle.Models;
using Vehicle.Models.Interfaces;

namespace Vehicle.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        
        public Engine(IReader reader, IO.Interfaces.IWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
           
        }
        public void Run()
        {
            string[] car = reader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] truck = reader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            List<IVehicle> vehicles = new();
            IVehicle myCar = new Car(double.Parse(car[1]), double.Parse(car[2]));
            vehicles.Add(myCar);
            IVehicle myTruck = new Truck(double.Parse(truck[1]), double.Parse(truck[2]));
            vehicles.Add(myTruck);

            int count = int.Parse(reader.ReadLine());

            for (int i = 0; i < count; i++)
            { 
                string[] command = reader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                string type = command[1];

                IVehicle vehicle = vehicles.FirstOrDefault(v => v.GetType().Name == type);

                if (action == "Drive")
                {
                    Console.WriteLine(vehicle.Drive(double.Parse(command[2])));
                }
                else if (action == "Refuel")
                {
                    vehicle.Refuel(double.Parse(command[2]));
                }
            }

            foreach (var vehicle in vehicles)
                Console.WriteLine(vehicle);
        }
    }
}

