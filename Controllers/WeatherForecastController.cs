using System;
using System.Collections.Generic;
using System.Linq;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static DependencyInjection.Models.IOperation;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController>_logger;
        private readonly IMyDependency _myDependency;
        private readonly IOperation _TransientOperation, _ScopedOperation, _SingletonOperation;



        public WeatherForecastController(ILogger<WeatherForecastController> logger, MyDependency dependency, Operation TransientOperation,
            Operation ScopedOperation, Operation SingletonOperation)
        {
            _logger = logger;
            _myDependency = dependency;
            _TransientOperation = TransientOperation;
            _ScopedOperation = ScopedOperation;
            _SingletonOperation = SingletonOperation;

        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            _myDependency.WriteMessage("inside the weather controller get");

            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
