using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaAPI.Entities;

namespace PizzaAPI.Controllers
{
    [Route("api/pizza")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly PizzaDbContext dbContext;

        public PizzaController(PizzaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public ActionResult<IEnumerable<Pizza>> GetAll()
        {
            var pizza = dbContext.
                Pizzas.
                ToList();

            return Ok(pizza);
        }
    }
}
