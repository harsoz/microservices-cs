using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lil.Products.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        public ProductsController(IProvider provider)
        {
            Provider = provider;
        }

        public IProvider Provider { get; }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await Provider.GetAsync(id);

            if (response is not null)
                return Ok(response);

            return NotFound();
        }
    }
}
