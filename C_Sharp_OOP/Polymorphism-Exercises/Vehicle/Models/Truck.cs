
namespace Vehicle.Models
{
    internal class Truck : Vehicle
    {
        private const double TruckFuelConsumptionIncrease = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
        }
        public override double FuelConsumption => base.FuelConsumption + TruckFuelConsumptionIncrease;

        public override string Drive(double distance)
        {
            if (FuelQuantity >= distance * FuelConsumption)
            {
                FuelQuantity -= distance * FuelConsumption;
                return $"{this.GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }

        public override void Refuel(double liters)
        {
            FuelQuantity += liters * 0.95;
        }
    }
}
