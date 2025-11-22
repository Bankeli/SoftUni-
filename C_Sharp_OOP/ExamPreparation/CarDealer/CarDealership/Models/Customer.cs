using CarDealership.Models.Contracts;
using CarDealership.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public abstract class Customer : ICustomer
    {
        private string name;
        private readonly List<string> purchases = new List<string>();

        public Customer(string name)
        {
            this.Name = name;
            this.Purchases = purchases.AsReadOnly();

        }
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(ExceptionMessages.NameIsRequired);
                this.name = value;
            }
        }

        public IReadOnlyCollection<string> Purchases { get; }

        public override string ToString() => $"{Name} - Purchases: {Purchases.Count}";



        public void BuyVehicle(string vehicleModel)
        {
            purchases.Add(vehicleModel);
        }

        
    }
}
