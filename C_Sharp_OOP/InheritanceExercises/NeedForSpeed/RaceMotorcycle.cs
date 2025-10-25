using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double RaceMotorFuelConsumption = 8;
        public RaceMotorcycle(int horesPower, double fuel) : base(horesPower, fuel)
        {
        }

        public override double FuelConsumption
        { get { return RaceMotorFuelConsumption; } }
    }
}
