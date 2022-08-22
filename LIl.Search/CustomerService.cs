using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LIl.Search
{
    public class CustomerService : ICustomerService
    {
        public CustomerService(IHttpClientFactory factory)
        {
            Factory = factory;
        }

        public IHttpClientFactory Factory { get; }

        public async Task<Customer> GetAsync(int id)
        {
            var client = Factory.CreateClient("customerService");
            var response = await client.GetAsync($"customers/{id}");
            if (response.IsSuccessStatusCode)
            {
                string res = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Customer>(res);
            }

            return null;
        }
    }
}
