using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIl.Search
{
    public interface ICustomerService
    {
        Task<Customer> GetAsync(int id);
    }

    public record Customer(int Id, string Name);
}
