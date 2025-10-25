using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            RaceMotorcycle car = new (150, 50);

            car.Drive(20);

            Console.WriteLine(car.FuelConsumption);

            
        }
    }
}
