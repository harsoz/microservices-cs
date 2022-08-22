using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lil.Customers
{
    public interface IProvider
    {
        public Task<Customer> GetCustomerAsync(int id);
    }
}
