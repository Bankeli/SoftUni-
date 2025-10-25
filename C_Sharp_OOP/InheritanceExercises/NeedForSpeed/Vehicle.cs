

namespace NeedForSpeed
{
    public abstract class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        protected Vehicle(int horesPower, double fuel)
        {
            HorsePower = horesPower;
            Fuel = fuel;
        }

        public virtual double FuelConsumption { get { return DefaultFuelConsumption; } }
        public int HorsePower { get; set; }
        public double Fuel { get; set; }

        public virtual void Drive (double kilometers)
        {
            Fuel -=kilometers * FuelConsumption;
        }
    }
}
