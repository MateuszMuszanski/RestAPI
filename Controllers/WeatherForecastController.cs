using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaAPI.Service;

namespace PizzaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _service;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var result = _service.Get();
            return result;
        }
        [HttpGet("{ile}")]
        public IEnumerable<WeatherForecast> Get([FromRoute] int ile, [FromQuery] int min, [FromQuery] int max)
        {
            var result = _service.Get(ile, min, max);
            return result;
        }
        [HttpPost("generate")]
        public ActionResult<IEnumerable<WeatherForecast>> Post([FromQuery] int ile, [FromBody] TemperatureRequest request )
        {
            if (ile < 0 || request.Min > request.Max)
            {
                return BadRequest();
            }
            return Ok(_service.Get(ile, request.Min, request.Max));
        }
    }
}
