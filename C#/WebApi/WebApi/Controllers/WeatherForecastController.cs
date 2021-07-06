using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IDateTimeService _dateTimeService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IDateTimeService dateTimeService)
        {
            _logger = logger;
            _dateTimeService = dateTimeService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = _dateTimeService.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55)
            })
            .ToArray();
        }
    }
}
