using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lil.Customers
{
    public class Provider : IProvider
    {
        private List<Customer> repository = new();

        public Provider()
        {
            for (int i = 0; i < 20; i++)
            {
                repository.Add(new Customer { Id = i, Name = $"Name {i}"});
            }
        }
        public Task<Customer> GetCustomerAsync(int id)
        {
            return Task.FromResult(repository.FirstOrDefault(a => a.Id == id));
        }
    }
}
