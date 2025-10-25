using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private const double CarFuelConsumption = 3;
        public Car(int horesPower, double fuel) : base(horesPower, fuel)
        {

        }

        public override double FuelConsumption { get { return CarFuelConsumption; } }
    }
}
