using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SpeedRacing
{
    public class Car
    {
        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double TravelledDistance { get; set; }

        public bool Drive(int distance)
        {
            double neededFuel = distance * FuelConsumption;
            if (neededFuel <= FuelAmount)
            {
                FuelAmount -= neededFuel;
                TravelledDistance += distance;
                return true;
            }
            else
                return false;


        }

    }
}
