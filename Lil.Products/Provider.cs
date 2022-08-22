using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lil.Products
{
    public class Provider: IProvider
    {
        private List<Product> products = new();

        public Provider()
        {
            for (int i = 0; i < 20; i++)
            {
                products.Add(new Product { Id = i, Name = $"Product {i}" });
            }
        }

        public Task<Product> GetAsync(int id)
        { 
            return Task.FromResult(products.FirstOrDefault( a => a.Id == id));
        }
    }
}
