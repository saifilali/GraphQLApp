using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GraphQLAppPlus.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GraphQLAppPlusController : ControllerBase
    {
        private readonly OwnerConsumer _consumer;

        public GraphQLAppPlusController(OwnerConsumer consumer)
        {
            _consumer = consumer;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var owners = await _consumer.GetAllOwners();
            return Ok(owners);
        }


        //… other actions
    }
}
