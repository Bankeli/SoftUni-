using CarDealership.Models.Contracts;
using CarDealership.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Repositories
{
    public class VehicleRepository : IRepository<IVehicle>
    {

        private readonly List<IVehicle> vehicles;

        public VehicleRepository()
        {
            vehicles = new List<IVehicle>();
        }
        public IReadOnlyCollection<IVehicle> Models => vehicles.AsReadOnly();

        public void Add(IVehicle model)
        {
            vehicles.Add(model);
        }

        public bool Exists(string text) => vehicles.Any(v => v.Model == text);


        public IVehicle Get(string text)
        {
            return FindBy(text);
        }

        public bool Remove(string text)
        {
            var existing = FindBy(text);
            if (existing != null)
            {
                vehicles.Remove(existing);
                return true;
            }
            return false;
        }

        private IVehicle FindBy(string text) => vehicles.FirstOrDefault(v => v.Model == text);
    }
}
