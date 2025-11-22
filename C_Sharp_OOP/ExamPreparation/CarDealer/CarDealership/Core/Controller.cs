using CarDealership.Core.Contracts;
using CarDealership.Models;
using CarDealership.Models.Contracts;
using CarDealership.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Core
{
    public class Controller : IController
    {
        private IDealership dealership;
        public Controller()
        {
            dealership = new Dealership();
        }
        public string AddCustomer(string customerTypeName, string customerName)
        {
            if (customerTypeName != nameof(IndividualClient) && customerTypeName != nameof(LegalEntityCustomer))
                return string.Format(OutputMessages.InvalidType, customerTypeName);

            if (dealership.Customers.Exists(customerName))
                return string.Format(OutputMessages.CustomerAlreadyAdded, customerName);

            ICustomer customer;
            if (customerTypeName == nameof(IndividualClient))
            {
                customer = new IndividualClient(customerName);
            }
            else
            {
                customer = new LegalEntityCustomer(customerName);
            }

            dealership.Customers.Add(customer);
            return string.Format(OutputMessages.CustomerAddedSuccessfully, customerName);

        }

        public string AddVehicle(string vehicleTypeName, string model, double price)
        {
            if (vehicleTypeName != nameof(SaloonCar) && vehicleTypeName != nameof(SUV) && vehicleTypeName != nameof(Truck))
                return string.Format(OutputMessages.InvalidType, vehicleTypeName);
            if (dealership.Vehicles.Exists(model))
                return string.Format(OutputMessages.VehicleAlreadyAdded, model);

            IVehicle vehicle;

            if (vehicleTypeName == nameof(SaloonCar))
                vehicle = new SaloonCar(model, price);

            else if (vehicleTypeName == nameof(SUV))
                vehicle = new SUV(model, price);

            else
                vehicle = new Truck(model, price);
            var priceToString = vehicle.Price.ToString("f2");
            dealership.Vehicles.Add(vehicle);

            return string.Format(OutputMessages.VehicleAddedSuccessfully, vehicleTypeName, model, priceToString);


        }

        public string CustomerReport()
        {
            var orderedCustomer = dealership.Customers.Models.OrderBy(x => x.Name).ToList();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Customer Report:");

            foreach (var customer in orderedCustomer)
            {
                sb.AppendLine(customer.ToString());
                sb.AppendLine("-Models:");

                if (customer.Purchases.Count == 0)
                {
                    sb.AppendLine("--none");
                }
                else
                {
                    foreach (var purchasedModel in customer.Purchases.OrderBy(x => x))
                    {
                        sb.AppendLine($"--{purchasedModel}");
                    }
                }

            }
                return sb.ToString().TrimEnd();
        }

        public string PurchaseVehicle(string vehicleTypeName, string customerName, double budget)
        {
            if (!dealership.Customers.Exists(customerName))
            {
                return string.Format(OutputMessages.CustomerNotFound, customerName);
            }
            if (!dealership.Vehicles.Models.Any(v => v.GetType().Name == vehicleTypeName))
            {
                return string.Format(OutputMessages.VehicleTypeNotFound, vehicleTypeName);
            }

            ICustomer customer = dealership.Customers.Get(customerName);

            if (customer.GetType().Name == nameof(IndividualClient) && vehicleTypeName == nameof(Truck) ||
                customer.GetType().Name == nameof(LegalEntityCustomer) && vehicleTypeName == nameof(SaloonCar))
                return string.Format(OutputMessages.CustomerNotEligibleToPurchaseVehicle,customerName, vehicleTypeName);

            var filteredCars = dealership.Vehicles.Models.Where(x => x.GetType().Name == vehicleTypeName && x.Price <= budget).OrderByDescending(x => x.Price).ToList();
            if (filteredCars.Count == 0)
                return string.Format(OutputMessages.BudgetIsNotEnough, customerName, vehicleTypeName);

            IVehicle vehicle = filteredCars.First();

            customer.BuyVehicle(vehicle.Model);
            vehicle.SellVehicle(customer.Name);

            return string.Format(OutputMessages.VehiclePurchasedSuccessfully, customerName, vehicle.Model);
        }


        public string SalesReport(string vehicleTypeName)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{vehicleTypeName} Sales Report:");

            var vehiclesToReport = dealership.Vehicles.Models.Where(x => x.GetType().Name == vehicleTypeName).ToList();

            foreach (var saloonCar in vehiclesToReport.OrderBy(c => c.Model))
            {
                sb.AppendLine($"--{saloonCar?.ToString().TrimEnd()}");
            }

            sb.AppendLine($"-Total Purchases: {vehiclesToReport.Select(v => v.SalesCount).Sum()}");

            return sb.ToString().TrimEnd();
        }
    }
}
