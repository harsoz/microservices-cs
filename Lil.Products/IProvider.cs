using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lil.Products
{
    public interface IProvider
    {
        Task<Product> GetAsync(int id);
    }
}
