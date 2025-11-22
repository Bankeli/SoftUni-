using CarDealership.Models.Contracts;
using CarDealership.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public abstract class Vehicle : IVehicle
    {
        private string model;
        private double price;
        private readonly List<string> buyers = new List<string>();
        protected Vehicle(string model, double price)
        {
            this.Model = model;
            this.Price = price;

            Buyers = buyers.AsReadOnly();
        }
        public string Model
        {
            get => model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(ExceptionMessages.ModelIsRequired);
                model = value;
            }
        }


        public double Price
        {
            get => price;
            private set
            {
                if (value<= 0)
                {
                    throw new ArgumentException(ExceptionMessages.PriceMustBePositive);
                }
                price = value;
            }
        }


        public IReadOnlyCollection<string> Buyers { get; }

        public int SalesCount => Buyers.Count;

        public override string ToString() => $"{Model} - Price: {Price:F2}, Total Model Sales: {SalesCount}";



        public void SellVehicle(string buyerName)
        {
            buyers.Add(buyerName);
        }
    }
}
