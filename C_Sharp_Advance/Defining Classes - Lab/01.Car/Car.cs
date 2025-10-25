using System;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make, string model, int year)
            :this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make,string model,int year,double fuelQuantity,double fuelConsumption)
            :this(make,model,year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            :this(make,model,year,fuelQuantity,fuelConsumption)
        {
          this.Engine = engine;  
            this.Tire = tires;
        }
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tire { get; set; }



        public void Drive(double distance)
        {
            var fuelNeeded = this.FuelConsumption * distance / 100;
            if (fuelNeeded <= this.FuelQuantity)
            {
                this.FuelQuantity -= fuelNeeded;
            }
            else Console.WriteLine($"Not enough fuel to perform this trip!");
        }

        public string WhoAmI()
        {
            return @$"Make: {this.Make}
Model: {this.Model}
Year: {this.Year}
Fuel: {this.FuelQuantity:f2}";


        }
    }
}
