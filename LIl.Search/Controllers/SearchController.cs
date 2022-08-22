using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIl.Search.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        public SearchController(ICustomerService customerService)
        {
            CustomerService = customerService;
        }

        public ICustomerService CustomerService { get; }

       [HttpGet("customers/{customerId}")]
       public async Task<IActionResult> SearchAsync(int customerId)
        {
            var response = await CustomerService.GetAsync(customerId);

            if (response is null)
                return NotFound();

            return Ok(response);
        }
    }
}
