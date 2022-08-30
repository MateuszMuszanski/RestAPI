using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaAPI.Controllers
{
    [Route("api/del")]
    [ApiController]
    public class Delivery : ControllerBase
    {
        private readonly PizzaDbContext dbContext;

        public ActionResult<Delivery> GetIt()
        {
            var delivery = dbContext.Deliveries.ToList();
            return Ok(delivery);
        }
    }
}
