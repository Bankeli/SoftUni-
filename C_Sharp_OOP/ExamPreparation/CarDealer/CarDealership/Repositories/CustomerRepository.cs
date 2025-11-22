using CarDealership.Models.Contracts;
using CarDealership.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Repositories
{
    public class CustomerRepository : IRepository<ICustomer>
    {
        private readonly List<ICustomer> customers;

        public CustomerRepository()
        {
            customers = new List<ICustomer>();
        }
        public IReadOnlyCollection<ICustomer> Models => customers.AsReadOnly();

        public void Add(ICustomer model)
        {
            customers.Add(model);
        }

        public bool Exists(string text)
        {
            return this.customers.Any(x => x.Name == text);
        }

        public ICustomer Get(string text)
        {
            return FindCustomerBy(text);
        }

        public bool Remove(string text) =>
         customers.Remove(FindCustomerBy(text));


        private ICustomer FindCustomerBy(string text) => customers.FirstOrDefault(c => c.Name == text);
    }
}
