using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double SportCarFuelConsumption = 10;
        public SportCar(int horesPower, double fuel) : base(horesPower, fuel)
        {
        }

        public override double FuelConsumption { get { return SportCarFuelConsumption; } }
    }
}
